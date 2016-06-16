using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ZOV.Tools;

namespace ShipControl.Forms
{
    public partial class ShipsMD5Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DAL.ShipsMD5EntityFrameWork dbContext;
        private List<string> fieldsList = new List<string> { "AdvancePaynemt", "Completed", "FinalPayment", "Invoiced", "Paid", "Shiped" };

        public ShipsMD5Form()
        {
            // https://www.devexpress.com/Support/Center/Example/Details/E417  -- Master-Detail

            InitializeComponent();

            LoadData();

        }

        private void ShipsMD5Form_Load(object sender, EventArgs e)
        {
            ShowHideExcelPanel();
        }

        private void LoadData()
        {

            dbContext = new DAL.ShipsMD5EntityFrameWork();

            dbContext.ShipsMD5.Load();
            dbContext.ShipsMD5Detail.Load();

            var ds = dbContext.ShipsMD5.Where(x => x.Actual & 
                                                   (!(x.ShipNumber.Contains("доп") | x.ShipNumber.Contains("доз") | x.ShipNumber.StartsWith("д") | x.ShipNumber.StartsWith(".")) | barCheckItemShowAdditional.Checked) &
                                                   (!(x.ShipNumber.Contains("сб")) | barCheckItemAssembly.Checked)).OrderByDescending(x => x.ShipsMD5ID).ToList();
            shipsMD5BindingSource.DataSource = ds;

            ApplySecurity();
        }

        private void ApplySecurity()
        {
            foreach (var a in Security.ValuesAndDescriptions.Where(a => a.Value != ""))
            {
                gridViewMaster.Columns[a.Value].OptionsColumn.AllowEdit = ((Security.ShipControl & a.Key) == a.Key);

                if ((Security.ShipControl & a.Key) != a.Key)
                {
                    //gridViewMaster.Columns.Remove(gridViewMaster.Columns[a.Value]);
                }
            }
        }

        private void gridViewMaster_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            ShipsMD5 s = (ShipsMD5)gridViewMaster.GetRow(e.RowHandle);
            e.IsEmpty = s.ShipsMD5Detail.Count == 0;
        }

        private void gridViewMaster_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridViewMaster_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "ShipsMD5Detail";
        }

        private void gridViewMaster_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            ShipsMD5 s = (ShipsMD5)gridViewMaster.GetRow(e.RowHandle);
            e.ChildList = new BindingSource(s, "ShipsMD5Detail");
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            dbContext.SaveChanges();
        }

        private void gridViewMaster_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Base.ColumnView view = gridViewMaster.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            GridView gridView = gridViewMaster.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            gridView.CustomDrawCell -= gridViewMaster_CustomDrawCell;
            gridView.CustomDrawCell += gridViewMaster_CustomDrawCell;


            //view.ViewCaption = "Text " + e.RowHandle.ToString();
            CheckSequrityDetail(view);
        }

        private void CheckSequrityDetail(DevExpress.XtraGrid.Views.Base.ColumnView view)
        {
            view.Columns["ShipsMD5"].Visible = false;
            view.Columns["ShipsMD5DetailID"].Visible = false;
            view.Columns["ShipsMD5ID"].Visible = false;
            view.Columns["AddTime"].Visible = false;

            view.Columns["ShipNumber"].Caption = "№ отгрузки";
            view.Columns["Customer"].Caption = "Клиент";
            view.Columns["LegalName"].Caption = "Юр. лицо";
            view.Columns["ShipDate"].Caption = "Дата отгр";
            view.Columns["FilePath"].Visible = false;


            view.Columns["AdvancePaynemt"].Caption = "Предв расчет";
            view.Columns["Completed"].Caption = "Комплектация";
            view.Columns["FinalPayment"].Caption = "Окон. расчет";
            view.Columns["Invoiced"].Caption = "Выст. счет-фактура";
            view.Columns["Paid"].Caption = "Оплачено";
            view.Columns["Shiped"].Caption = "Отгружено";

            foreach (var a in Security.ValuesAndDescriptions.Where(a => a.Value != ""))
            {
                view.Columns[a.Value].OptionsColumn.AllowEdit = ((Security.ShipControl & a.Key) == a.Key);
                if ((Security.ShipControl & a.Key) != a.Key)
                {
                    //view.Columns.Remove(view.Columns[a.Value]);
                }
            }
        }

        private void gridViewMaster_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.RowHandle == view.FocusedRowHandle) return;
            if (!fieldsList.Contains(e.Column.FieldName)) return;

            GridCellInfo ci = e.Cell as GridCellInfo;
            CheckEditViewInfo cvi = ci.ViewInfo as CheckEditViewInfo;


            cvi.AllowOverridedState = true;
            if (!ci.Column.OptionsColumn.AllowEdit)
            {
//                cvi.Appearance.BackColor = System.Drawing.Color.LightCoral;
                cvi.OverridedState = DevExpress.Utils.Drawing.ObjectState.Disabled;
            }
            cvi.PaintAppearance.BackColor = cvi.CheckState != CheckState.Checked ? System.Drawing.Color.NavajoWhite : System.Drawing.Color.PaleGreen;
            cvi.CalcViewInfo(e.Graphics);
        }

        private void RefreshData()
        {
            if (dbContext.ChangeTracker.HasChanges())
            {
                switch (MessageBox.Show("Сохранить изменения и обновить?", "Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        SaveData();
                        break;

                    case DialogResult.Cancel:
                        return;
                }
            };
            LoadData();
        }

        private void ShipsMD5Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dbContext.ChangeTracker.HasChanges())
            {
                switch (MessageBox.Show("Сохранить изменения и закрыть?", "Нюанс", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        SaveData();
                        break;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            };
        }

        private void checkBoxAdditioanal_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void barCheckItemShowAdditional_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData();
        }

        private void barCheckItemAssembly_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData();
        }

        private void barCheckItemShow_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowHideExcelPanel();
        }

        private void ShowHideExcelPanel()
        {
            splitContainerControlMain.Collapsed = !barCheckItemShow.Checked;
            splitContainerControlMain.IsSplitterFixed = !barCheckItemShow.Checked;
            ShowDocInExcel();
        }

        private void shipsMD5BindingSource_PositionChanged(object sender, EventArgs e)
        {
            ShowDocInExcel();
        }

        private string curDoc = String.Empty;
        private void ShowDocInExcel()
        {
            if ((shipsMD5BindingSource.Current == null) | (!barCheckItemShow.Checked)) return;

            if (curDoc != ((ShipsMD5)shipsMD5BindingSource.Current).FilePath)
            {
                spreadsheetControl1.CreateNewDocument();
                curDoc = spreadsheetControl1.LoadDocument(((ShipsMD5)shipsMD5BindingSource.Current).FilePath) ? ((ShipsMD5)shipsMD5BindingSource.Current).FilePath : String.Empty;
            }
            int curRow = 1;
            //try
            //{
            //    curRow = (int)(((DataRowView)shipsMD5BindingSource.Current)["KitchenRow"]);
            //}
            //catch (Exception)
            //{
            //}
            (spreadsheetControl1.Document.Worksheets[0].Rows[curRow - 1]).Select();
            spreadsheetControl1.Document.Worksheets[0].ScrollToRow(curRow - 1);
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData();
        }

    }
}
