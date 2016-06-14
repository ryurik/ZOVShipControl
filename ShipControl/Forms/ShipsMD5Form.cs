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
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ZOV.Tools;

namespace ShipControl.Forms
{
    public partial class ShipsMD5Form : Form
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

        }

        private void LoadData()
        {

            dbContext = new DAL.ShipsMD5EntityFrameWork();

            dbContext.ShipsMD5.Load();
            dbContext.ShipsMD5Detail.Load();

            var ds = dbContext.ShipsMD5.Where(x => x.Actual == true).OrderByDescending(x=>x.ShipsMD5ID).ToList();
            shipsMD5BindingSource.DataSource = ds;

            ApplySecurity();
        }

        private void ApplySecurity()
        {
            foreach (var a in Security.ValuesAndDescriptions.Where(a => a.Value != ""))
            {
                if ((Security.ShipControl & a.Key) != a.Key)
                {
                    gridViewMaster.Columns.Remove(gridViewMaster.Columns[a.Value]);
                }
            }
        }

        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            ShipsMD5 s = (ShipsMD5)gridViewMaster.GetRow(e.RowHandle);
            e.IsEmpty = s.ShipsMD5Detail.Count == 0;
        }

        private void gridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView1_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "ShipsMD5Detail";
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
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

        private void gridView1_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
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
                if ((Security.ShipControl & a.Key) != a.Key)
                {
                    view.Columns.Remove(view.Columns[a.Value]);
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
//            cvi.Appearance.BackColor = System.Drawing.Color.LightCoral;
//            cvi.OverridedState = DevExpress.Utils.Drawing.ObjectState.Disabled;
            cvi.PaintAppearance.BackColor = cvi.CheckState != CheckState.Checked ? System.Drawing.Color.NavajoWhite : System.Drawing.Color.PaleGreen;
            cvi.CalcViewInfo(e.Graphics);}
    }
}
