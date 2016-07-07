using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ZOV.Tools;

namespace ShipControl.Forms
{
    public partial class ShipsMD5Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DAL.ShipsMD5EntityFrameWork dbContext;
        private List<string> fieldsList = new List<string> { "AdvancePayment", "Completed", "FinalPayment", "Invoiced", "Paid", "Shiped" };
        private bool isDataChanged { get { return ((dbContext != null) & (dbContext.ChangeTracker.HasChanges() & !Security.ReadOnlyForShips)); } }


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
            splashScreenManagerMain.ShowWaitForm();
            try
            {
                splashScreenManagerMain.SetWaitFormDescription(String.Format("Создается конкекст"));
                dbContext = new DAL.ShipsMD5EntityFrameWork();

                splashScreenManagerMain.SetWaitFormDescription(String.Format("Загружаются пользователи"));
                dbContext.ZOVReminderUsers.Load();

                splashScreenManagerMain.SetWaitFormDescription(String.Format("Загружаются отгрузки"));
                dbContext.ShipsMD5.Load();

                splashScreenManagerMain.SetWaitFormDescription(String.Format("Загружаются клиенты"));
                dbContext.ShipsMD5Detail.Load();

                splashScreenManagerMain.SetWaitFormDescription(String.Format("Фильтрация"));
                var ds = dbContext.ShipsMD5.Where(x => x.Actual &
                                                (!(x.ShipNumber.Contains("доп") | x.ShipNumber.Contains("доз") |
                                                    x.ShipNumber.StartsWith("д") | x.ShipNumber.StartsWith(".")) |
                                                barCheckItemShowAdditional.Checked) &
                                                (!(x.ShipNumber.Contains("сб")) | barCheckItemAssembly.Checked))
                                        .OrderByDescending(x => x.ShipsMD5ID)
                                        .ToList();
                shipsMD5BindingSource.DataSource = ds;

                splashScreenManagerMain.SetWaitFormDescription(String.Format("Создание лукапных полей"));
                CreateLookUpFields();

                splashScreenManagerMain.SetWaitFormDescription(String.Format("Применение секьюрити"));
                ApplySecurity();

                splashScreenManagerMain.SetWaitFormDescription(String.Format("Отрисовка"));
            }
            catch (Exception E)
            {
                MessageBox.Show(String.Format("{0}\n\n{1}",E.Message, E.InnerException.Message), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            splashScreenManagerMain.CloseWaitForm();
            SomeSub();
        }

        private void CreateLookUpFields()
        {
            FillLookUpEdit(AdvancePaymentUserIDTextEdit);
            FillLookUpEdit(CompletedUserIDTextEdit);
            FillLookUpEdit(FinalPaymentUserIDTextEdit);
            FillLookUpEdit(InvoicedUserIDTextEdit);
            FillLookUpEdit(PaidUserIDTextEdit);
            FillLookUpEdit(ShipedUserIDTextEdit);
        }

        private void FillLookUpEdit(DevExpress.XtraEditors.LookUpEdit lookUpEdit)
        {
            var currentUsers = dbContext.ZOVReminderUsers.ToList();

            lookUpEdit.Properties.DataSource = currentUsers;
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lookUpEdit.Properties.ValueMember = "ZOVReminderUsersID";
            lookUpEdit.Properties.DisplayMember = "UserName";
            if (currentUsers.Count > 0)
                lookUpEdit.Properties.DropDownRows = currentUsers.Count;
            lookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ZOVReminderUsersID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "Пользователь")});
        }

        private void ApplySecurity()
        {
            foreach (var a in Security.ValuesAndDescriptions.Where(a => a.Value[1] != "DontShowField"))
            {
                var column = gridViewMaster.Columns.ColumnByFieldName(a.Value[0]);
                if (column != null)
                    gridViewMaster.Columns[a.Value[0]].OptionsColumn.AllowEdit = (((Security.ShipControl & a.Key) == a.Key) & (!Security.ReadOnlyForShips));

                if ((Security.ShipControl & a.Key) != a.Key)
                {
                    //XtraGrid.Columns.Remove(XtraGrid.Columns[a.Value]);
                }
            }
            panelBottom.Visible = !Security.ReadOnlyForShips;
        }


        private void ApplySecurityDetails(DevExpress.XtraGrid.Views.Base.ColumnView view)
        {
            foreach (var a in Security.ValuesAndDescriptionsDetail.Where(a => a.Value[1] == "DontShowField"))
            {
                var column = view.Columns.ColumnByFieldName(a.Key.ToString());
                if (column != null)
                    column.Visible = false;
                //XtraGrid.Columns[a.Value[0]].Visible = false;
            }
            foreach (var a in Security.ValuesAndDescriptionsDetail.Where(a => a.Value[0] != "Editable"))
            {
                var column = view.Columns.ColumnByFieldName(a.Key.ToString());
                if (column != null)
                    column.OptionsColumn.AllowEdit = false;
                    //XtraGrid.Columns[a.Key.ToString()].OptionsColumn.AllowEdit = false;
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
            gridView.CustomDrawCell -= detailView_CustomDrawCell;
            gridView.CustomDrawCell += detailView_CustomDrawCell;


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


            view.Columns["AdvancePayment"].Caption = "Предв расчет";
            view.Columns["Completed"].Caption = "Комплектация";
            view.Columns["FinalPayment"].Caption = "Окон. расчет";
            view.Columns["Invoiced"].Caption = "Выст. счет-фактура";
            view.Columns["Paid"].Caption = "Оплачено";
            view.Columns["Shiped"].Caption = "Отгружено";

            foreach (var a in Security.ValuesAndDescriptions.Where(a => a.Value[1] != "DontShowField"))
            {
                view.Columns[a.Value[0]].OptionsColumn.AllowEdit = ((Security.ShipControl & a.Key) == a.Key);
                if ((Security.ShipControl & a.Key) != a.Key)
                {
                    //view.Columns.Remove(view.Columns[a.Value]);
                }
            }
            ApplySecurityDetails(view);
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


        private void detailView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            Trace.WriteLine("detailView_CustomDrawCell");

            GridView view = sender as GridView;

            if (e.RowHandle == view.FocusedRowHandle) return;
            Trace.WriteLine(String.Format("detailView_CustomDrawCell: {0}", e.Column.FieldName));
            if (!fieldsList.Contains(e.Column.FieldName)) return;

            GridCellInfo ci = e.Cell as GridCellInfo;
            CheckEditViewInfo cvi = ci.ViewInfo as CheckEditViewInfo;


            cvi.AllowOverridedState = true;
            if (!ci.Column.OptionsColumn.AllowEdit)
            {
                //                cvi.Appearance.BackColor = System.Drawing.Color.LightCoral;
                cvi.OverridedState = DevExpress.Utils.Drawing.ObjectState.Disabled;
            }
            cvi.PaintAppearance.BackColor = cvi.CheckState != CheckState.Checked ? Color.NavajoWhite : Color.PaleGreen;
            cvi.CalcViewInfo(e.Graphics);
        }


        private void RefreshData()
        {
            if (isDataChanged)
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
            if (isDataChanged)
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
            //splitContainerControlMain.Collapsed = !barCheckItemShow.Checked;
            //splitContainerControlMain.IsSplitterFixed = !barCheckItemShow.Checked;
            xtraTabPageExcel.PageVisible = barCheckItemShow.Checked;
            if (!barCheckItemShow.Checked) return;
            ShowDocInExcel();
        }

        private void shipsMD5BindingSource_PositionChanged(object sender, EventArgs e)
        {
            ShowDocInExcel();
        }

        private string curDoc = String.Empty;
        private void ShowDocInExcel()
        {
            if ((shipsMD5BindingSource.Current == null) | 
                (!barCheckItemShow.Checked) | 
                (xtraTabControlMain.SelectedTabPage != xtraTabPageExcel) |
                (!xtraTabPageExcel.PageVisible)) return;

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

        private void barCheckItemSearchRecord_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowHideSearchPanel();
        }

        private void ShowHideSearchPanel()
        {
            gridViewMaster.OptionsView.ShowAutoFilterRow = barCheckItemSearchRecord.Checked;
        }

        private void xtraTabControlMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            ShowDocInExcel();
        }

        private ShipsMD5 GetCurrentMasterShip()
        {
            if (gridViewMaster.FocusedRowHandle < 0)
                return null;

            return (ShipsMD5)gridViewMaster.GetRow(gridViewMaster.FocusedRowHandle);
        }

        private void AdvancePaymentCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var shipsMD5 = GetCurrentMasterShip();
            if (shipsMD5 == null)
                return;

            shipsMD5.AdvancePaymentDate = AdvancePaymentCheckEdit.Checked ? DateTime.Now : (DateTime?)null;
            shipsMD5.AdvancePaymentUserID = AdvancePaymentCheckEdit.Checked ? ZOV.Tools.Security.ZOVReminderUsersID : (int?)null;
        }

        private void SomeSub()
        {

            if (gridViewMaster.GroupCount == 0)
            {
                gridViewMaster.SelectAll();
                return;
            }

            gridViewMaster.BeginSelection();
            gridViewMaster.ClearSelection();

            bool isExpanded = false;

            for (int rowVisibleIndex = 0; rowVisibleIndex < gridViewMaster.RowCount; rowVisibleIndex++)
            {
                int rowHandle = gridViewMaster.GetVisibleRowHandle(rowVisibleIndex);

                if (gridViewMaster.IsNewItemRow(rowHandle))
                {
                    continue;
                }

                int level = gridViewMaster.GetRowLevel(rowHandle);

                if (level == 0)
                {
                    if (!isExpanded)
                    {

                        isExpanded = gridViewMaster.GetRowExpanded(rowHandle);

                        if (isExpanded)
                            gridViewMaster.ClearSelection();
                        else
                            gridViewMaster.SelectRow(rowHandle);
                    }
                }
                else
                {
                    gridViewMaster.SelectRow(rowHandle);

                    //Update: select hidden rows
                    if (gridViewMaster.IsGroupRow(rowHandle) & !gridViewMaster.GetRowExpanded(rowHandle))
                    {
                        SelectRowHierarchy(rowHandle);
                    }
                }
            }
            gridViewMaster.EndSelection();

        }

        private void SelectRowHierarchy(int rowHandle)
        {

            int childCount = gridViewMaster.GetChildRowCount(rowHandle);

            for (int childIndex = 0; childIndex < childCount; childIndex++)
            {

                int childRowHandle = gridViewMaster.GetChildRowHandle(rowHandle, childIndex);

                gridViewMaster.SelectRow(childRowHandle);

                if (gridViewMaster.IsGroupRow(childRowHandle))
                {
                    SelectRowHierarchy(childRowHandle);
                }
            }

        }

    }
}
