namespace ShipControl.Forms
{
    partial class ShipsMD5Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipsMD5Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnApply = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shipsMD5EntityFrameWorkGridControl = new DevExpress.XtraGrid.GridControl();
            this.shipsMD5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewMaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colShipsMD5ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdvancePaynemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinalPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiced = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShiped = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipsMD5EntityFrameWorkGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipsMD5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.layoutControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 51);
            this.panel1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnApply);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(581, 285, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(780, 51);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnApply
            // 
            this.btnApply.Image = ((System.Drawing.Image)(resources.GetObject("btnApply.Image")));
            this.btnApply.Location = new System.Drawing.Point(663, 12);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(105, 22);
            this.btnApply.StyleController = this.layoutControl1;
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Применить";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(780, 51);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnApply;
            this.layoutControlItem1.Location = new System.Drawing.Point(651, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(109, 31);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(651, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.shipsMD5EntityFrameWorkGridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 442);
            this.panel2.TabIndex = 1;
            // 
            // shipsMD5EntityFrameWorkGridControl
            // 
            this.shipsMD5EntityFrameWorkGridControl.DataSource = this.shipsMD5BindingSource;
            this.shipsMD5EntityFrameWorkGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipsMD5EntityFrameWorkGridControl.Location = new System.Drawing.Point(0, 0);
            this.shipsMD5EntityFrameWorkGridControl.MainView = this.gridViewMaster;
            this.shipsMD5EntityFrameWorkGridControl.Name = "shipsMD5EntityFrameWorkGridControl";
            this.shipsMD5EntityFrameWorkGridControl.Size = new System.Drawing.Size(780, 442);
            this.shipsMD5EntityFrameWorkGridControl.TabIndex = 0;
            this.shipsMD5EntityFrameWorkGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMaster});
            // 
            // shipsMD5BindingSource
            // 
            this.shipsMD5BindingSource.DataSource = typeof(DAL.ShipsMD5);
            // 
            // gridViewMaster
            // 
            this.gridViewMaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShipsMD5ID,
            this.colShipNumber,
            this.colShipName,
            this.colAdvancePaynemt,
            this.colCompleted,
            this.colFinalPayment,
            this.colInvoiced,
            this.colPaid,
            this.colShiped});
            this.gridViewMaster.GridControl = this.shipsMD5EntityFrameWorkGridControl;
            this.gridViewMaster.Name = "gridViewMaster";
            this.gridViewMaster.OptionsDetail.ShowDetailTabs = false;
            this.gridViewMaster.OptionsView.ShowGroupPanel = false;
            this.gridViewMaster.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewMaster_CustomDrawCell);
            this.gridViewMaster.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridView1_MasterRowEmpty);
            this.gridViewMaster.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridView1_MasterRowExpanded);
            this.gridViewMaster.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridView1_MasterRowGetChildList);
            this.gridViewMaster.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridView1_MasterRowGetRelationName);
            this.gridViewMaster.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridView1_MasterRowGetRelationCount);
            // 
            // colShipsMD5ID
            // 
            this.colShipsMD5ID.FieldName = "ShipsMD5ID";
            this.colShipsMD5ID.Name = "colShipsMD5ID";
            // 
            // colShipNumber
            // 
            this.colShipNumber.Caption = "№ Отгрузки";
            this.colShipNumber.FieldName = "ShipNumber";
            this.colShipNumber.Name = "colShipNumber";
            this.colShipNumber.Visible = true;
            this.colShipNumber.VisibleIndex = 0;
            // 
            // colShipName
            // 
            this.colShipName.Caption = "Отгрузка";
            this.colShipName.FieldName = "ShipName";
            this.colShipName.Name = "colShipName";
            this.colShipName.Visible = true;
            this.colShipName.VisibleIndex = 1;
            // 
            // colAdvancePaynemt
            // 
            this.colAdvancePaynemt.Caption = "Предварительный расчет";
            this.colAdvancePaynemt.FieldName = "AdvancePaynemt";
            this.colAdvancePaynemt.Name = "colAdvancePaynemt";
            this.colAdvancePaynemt.Visible = true;
            this.colAdvancePaynemt.VisibleIndex = 2;
            // 
            // colCompleted
            // 
            this.colCompleted.Caption = "Комплектация";
            this.colCompleted.FieldName = "Completed";
            this.colCompleted.Name = "colCompleted";
            this.colCompleted.Visible = true;
            this.colCompleted.VisibleIndex = 3;
            // 
            // colFinalPayment
            // 
            this.colFinalPayment.Caption = "Окончательный расчет";
            this.colFinalPayment.FieldName = "FinalPayment";
            this.colFinalPayment.Name = "colFinalPayment";
            this.colFinalPayment.Visible = true;
            this.colFinalPayment.VisibleIndex = 4;
            // 
            // colInvoiced
            // 
            this.colInvoiced.Caption = "Выставлен счет-фактура";
            this.colInvoiced.FieldName = "Invoiced";
            this.colInvoiced.Name = "colInvoiced";
            this.colInvoiced.Visible = true;
            this.colInvoiced.VisibleIndex = 5;
            // 
            // colPaid
            // 
            this.colPaid.Caption = "Оплачено";
            this.colPaid.FieldName = "Paid";
            this.colPaid.Name = "colPaid";
            this.colPaid.Visible = true;
            this.colPaid.VisibleIndex = 6;
            // 
            // colShiped
            // 
            this.colShiped.Caption = "Товар отгружен";
            this.colShiped.FieldName = "Shiped";
            this.colShiped.Name = "colShiped";
            this.colShiped.Visible = true;
            this.colShiped.VisibleIndex = 7;
            // 
            // ShipsMD5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 493);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ShipsMD5Form";
            this.Text = "Контроль отгрузок";
            this.Load += new System.EventHandler(this.ShipsMD5Form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shipsMD5EntityFrameWorkGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipsMD5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl shipsMD5EntityFrameWorkGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMaster;
        private System.Windows.Forms.BindingSource shipsMD5BindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colShipsMD5ID;
        private DevExpress.XtraGrid.Columns.GridColumn colShipNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colShipName;
        private DevExpress.XtraGrid.Columns.GridColumn colAdvancePaynemt;
        private DevExpress.XtraGrid.Columns.GridColumn colCompleted;
        private DevExpress.XtraGrid.Columns.GridColumn colFinalPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiced;
        private DevExpress.XtraGrid.Columns.GridColumn colPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colShiped;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnApply;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}