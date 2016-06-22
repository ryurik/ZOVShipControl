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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipsMD5Form));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnApply = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.shipsMD5BindingSource = new System.Windows.Forms.BindingSource();
            this.ribbonControlMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barCheckItemShowAdditional = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemAssembly = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barCheckItemShow = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupData = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainerControlMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControlMain = new DevExpress.XtraLayout.LayoutControl();
            this.shipsMD5EntityFrameWorkGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewMaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colShipsMD5ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdvancePaynemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinalPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiced = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShiped = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroupFill = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemFill = new DevExpress.XtraLayout.LayoutControlItem();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.splashScreenManagerShipsLoad = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ShipControl.Forms.ShipsSplashWaitForm), true, true);
            this.splashScreenManagerMain = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ShipControl.Forms.ShipsSplashWaitForm), true, true);
            this.ribbonPageGroupView = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipsMD5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlMain)).BeginInit();
            this.splitContainerControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            this.layoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipsMD5EntityFrameWorkGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFill)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.layoutControl1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 463);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(967, 30);
            this.panelBottom.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnApply);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(581, 285, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(967, 30);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnApply
            // 
            this.btnApply.Image = ((System.Drawing.Image)(resources.GetObject("btnApply.Image")));
            this.btnApply.Location = new System.Drawing.Point(834, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(131, 22);
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
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(967, 30);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnApply;
            this.layoutControlItem1.Location = new System.Drawing.Point(832, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(135, 30);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 2, 0);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(832, 30);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // shipsMD5BindingSource
            // 
            this.shipsMD5BindingSource.DataSource = typeof(DAL.ShipsMD5);
            this.shipsMD5BindingSource.PositionChanged += new System.EventHandler(this.shipsMD5BindingSource_PositionChanged);
            // 
            // ribbonControlMain
            // 
            this.ribbonControlMain.AllowMdiChildButtons = false;
            this.ribbonControlMain.AutoHideEmptyItems = true;
            this.ribbonControlMain.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControlMain.ExpandCollapseItem.Id = 0;
            this.ribbonControlMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlMain.ExpandCollapseItem,
            this.barCheckItemShowAdditional,
            this.barCheckItemAssembly,
            this.ribbonGalleryBarItem1,
            this.barCheckItemShow,
            this.barButtonItemRefresh});
            this.ribbonControlMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlMain.MaxItemId = 5;
            this.ribbonControlMain.Name = "ribbonControlMain";
            this.ribbonControlMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageMain});
            this.ribbonControlMain.ShowToolbarCustomizeItem = false;
            this.ribbonControlMain.Size = new System.Drawing.Size(967, 125);
            this.ribbonControlMain.Toolbar.ShowCustomizeItem = false;
            // 
            // barCheckItemShowAdditional
            // 
            this.barCheckItemShowAdditional.Caption = "Допы / Дозы";
            this.barCheckItemShowAdditional.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.barCheckItemShowAdditional.Id = 1;
            this.barCheckItemShowAdditional.Name = "barCheckItemShowAdditional";
            this.barCheckItemShowAdditional.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemShowAdditional_CheckedChanged);
            // 
            // barCheckItemAssembly
            // 
            this.barCheckItemAssembly.BindableChecked = true;
            this.barCheckItemAssembly.Caption = "Сборки";
            this.barCheckItemAssembly.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.barCheckItemAssembly.Checked = true;
            this.barCheckItemAssembly.Id = 1;
            this.barCheckItemAssembly.Name = "barCheckItemAssembly";
            this.barCheckItemAssembly.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemAssembly_CheckedChanged);
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            // 
            // 
            // 
            galleryItemGroup1.Caption = "Excel";
            galleryItem1.Caption = "Excel";
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1});
            this.ribbonGalleryBarItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.ribbonGalleryBarItem1.Gallery.ShowItemText = true;
            this.ribbonGalleryBarItem1.Id = 2;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // barCheckItemShow
            // 
            this.barCheckItemShow.Caption = "Excel";
            this.barCheckItemShow.Id = 3;
            this.barCheckItemShow.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barCheckItemShow.LargeGlyph")));
            this.barCheckItemShow.Name = "barCheckItemShow";
            this.barCheckItemShow.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemShow_CheckedChanged);
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Обновить данные";
            this.barButtonItemRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemRefresh.Glyph")));
            this.barButtonItemRefresh.Id = 4;
            this.barButtonItemRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemRefresh.LargeGlyph")));
            this.barButtonItemRefresh.Name = "barButtonItemRefresh";
            this.barButtonItemRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRefresh_ItemClick);
            // 
            // ribbonPageMain
            // 
            this.ribbonPageMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup,
            this.ribbonPageGroup1,
            this.ribbonPageGroupData,
            this.ribbonPageGroupView});
            this.ribbonPageMain.Name = "ribbonPageMain";
            this.ribbonPageMain.Text = "Главная";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.AllowMinimize = false;
            this.ribbonPageGroup.ItemLinks.Add(this.barCheckItemShowAdditional);
            this.ribbonPageGroup.ItemLinks.Add(this.barCheckItemAssembly);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.ShowCaptionButton = false;
            this.ribbonPageGroup.Text = "главная";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barCheckItemShow);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroupData
            // 
            this.ribbonPageGroupData.ItemLinks.Add(this.barButtonItemRefresh);
            this.ribbonPageGroupData.Name = "ribbonPageGroupData";
            this.ribbonPageGroupData.Text = "Данные";
            // 
            // splitContainerControlMain
            // 
            this.splitContainerControlMain.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2;
            this.splitContainerControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlMain.IsSplitterFixed = true;
            this.splitContainerControlMain.Location = new System.Drawing.Point(0, 125);
            this.splitContainerControlMain.Name = "splitContainerControlMain";
            this.splitContainerControlMain.Panel1.Controls.Add(this.layoutControlMain);
            this.splitContainerControlMain.Panel2.Controls.Add(this.spreadsheetControl1);
            this.splitContainerControlMain.Panel2.Text = "Excel";
            this.splitContainerControlMain.Size = new System.Drawing.Size(967, 338);
            this.splitContainerControlMain.SplitterPosition = 768;
            this.splitContainerControlMain.TabIndex = 6;
            this.splitContainerControlMain.Text = "splitContainerControl1";
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Controls.Add(this.shipsMD5EntityFrameWorkGridControl);
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlMain.Name = "layoutControlMain";
            this.layoutControlMain.Root = this.layoutControlGroupFill;
            this.layoutControlMain.Size = new System.Drawing.Size(768, 338);
            this.layoutControlMain.TabIndex = 4;
            this.layoutControlMain.Text = "layoutControl2";
            // 
            // shipsMD5EntityFrameWorkGridControl
            // 
            this.shipsMD5EntityFrameWorkGridControl.DataSource = this.shipsMD5BindingSource;
            this.shipsMD5EntityFrameWorkGridControl.Location = new System.Drawing.Point(0, 0);
            this.shipsMD5EntityFrameWorkGridControl.MainView = this.gridViewMaster;
            this.shipsMD5EntityFrameWorkGridControl.Margin = new System.Windows.Forms.Padding(0);
            this.shipsMD5EntityFrameWorkGridControl.Name = "shipsMD5EntityFrameWorkGridControl";
            this.shipsMD5EntityFrameWorkGridControl.Size = new System.Drawing.Size(768, 338);
            this.shipsMD5EntityFrameWorkGridControl.TabIndex = 0;
            this.shipsMD5EntityFrameWorkGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMaster});
            // 
            // gridViewMaster
            // 
            this.gridViewMaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShipsMD5ID,
            this.colShipDate,
            this.colShipNumber,
            this.colShipName,
            this.colAdvancePaynemt,
            this.colCompleted,
            this.colFinalPayment,
            this.colInvoiced,
            this.colPaid,
            this.colShiped});
            this.gridViewMaster.GridControl = this.shipsMD5EntityFrameWorkGridControl;
            this.gridViewMaster.GroupCount = 1;
            this.gridViewMaster.Name = "gridViewMaster";
            this.gridViewMaster.OptionsDetail.ShowDetailTabs = false;
            this.gridViewMaster.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMaster.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colShipDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewMaster.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewMaster_CustomDrawCell);
            this.gridViewMaster.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridViewMaster_MasterRowEmpty);
            this.gridViewMaster.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridViewMaster_MasterRowExpanded);
            this.gridViewMaster.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridViewMaster_MasterRowGetChildList);
            this.gridViewMaster.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridViewMaster_MasterRowGetRelationName);
            this.gridViewMaster.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridViewMaster_MasterRowGetRelationCount);
            // 
            // colShipsMD5ID
            // 
            this.colShipsMD5ID.FieldName = "ShipsMD5ID";
            this.colShipsMD5ID.Name = "colShipsMD5ID";
            this.colShipsMD5ID.OptionsColumn.AllowEdit = false;
            this.colShipsMD5ID.OptionsColumn.ReadOnly = true;
            // 
            // colShipDate
            // 
            this.colShipDate.Caption = "Дата отгрузки";
            this.colShipDate.FieldName = "ShipDate";
            this.colShipDate.Name = "colShipDate";
            this.colShipDate.OptionsColumn.AllowEdit = false;
            this.colShipDate.OptionsColumn.ReadOnly = true;
            this.colShipDate.Visible = true;
            this.colShipDate.VisibleIndex = 0;
            // 
            // colShipNumber
            // 
            this.colShipNumber.Caption = "№ Отгрузки";
            this.colShipNumber.FieldName = "ShipNumber";
            this.colShipNumber.Name = "colShipNumber";
            this.colShipNumber.OptionsColumn.AllowEdit = false;
            this.colShipNumber.OptionsColumn.ReadOnly = true;
            this.colShipNumber.Visible = true;
            this.colShipNumber.VisibleIndex = 0;
            // 
            // colShipName
            // 
            this.colShipName.Caption = "Отгрузка";
            this.colShipName.FieldName = "ShipName";
            this.colShipName.Name = "colShipName";
            this.colShipName.OptionsColumn.AllowEdit = false;
            this.colShipName.OptionsColumn.ReadOnly = true;
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
            // layoutControlGroupFill
            // 
            this.layoutControlGroupFill.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupFill.GroupBordersVisible = false;
            this.layoutControlGroupFill.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemFill});
            this.layoutControlGroupFill.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupFill.Name = "layoutControlGroupFill";
            this.layoutControlGroupFill.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupFill.Size = new System.Drawing.Size(768, 338);
            this.layoutControlGroupFill.TextVisible = false;
            // 
            // layoutControlItemFill
            // 
            this.layoutControlItemFill.Control = this.shipsMD5EntityFrameWorkGridControl;
            this.layoutControlItemFill.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemFill.Name = "layoutControlItemFill";
            this.layoutControlItemFill.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItemFill.Size = new System.Drawing.Size(768, 338);
            this.layoutControlItemFill.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemFill.TextVisible = false;
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetControl1.MenuManager = this.ribbonControlMain;
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Size = new System.Drawing.Size(194, 338);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // splashScreenManagerShipsLoad
            // 
            this.splashScreenManagerShipsLoad.ClosingDelay = 500;
            // 
            // ribbonPageGroupView
            // 
            this.ribbonPageGroupView.Name = "ribbonPageGroupView";
            this.ribbonPageGroupView.Text = "Настройка вида";
            // 
            // ShipsMD5Form
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 493);
            this.Controls.Add(this.splitContainerControlMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.ribbonControlMain);
            this.Name = "ShipsMD5Form";
            this.Ribbon = this.ribbonControlMain;
            this.Text = "Контроль отгрузок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShipsMD5Form_FormClosing);
            this.Load += new System.EventHandler(this.ShipsMD5Form_Load);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipsMD5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlMain)).EndInit();
            this.splitContainerControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            this.layoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shipsMD5EntityFrameWorkGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.BindingSource shipsMD5BindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnApply;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.BarCheckItem barCheckItemShowAdditional;
        private DevExpress.XtraBars.BarCheckItem barCheckItemAssembly;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItemShow;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlMain;
        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraGrid.GridControl shipsMD5EntityFrameWorkGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMaster;
        private DevExpress.XtraGrid.Columns.GridColumn colShipsMD5ID;
        private DevExpress.XtraGrid.Columns.GridColumn colShipNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colShipName;
        private DevExpress.XtraGrid.Columns.GridColumn colAdvancePaynemt;
        private DevExpress.XtraGrid.Columns.GridColumn colCompleted;
        private DevExpress.XtraGrid.Columns.GridColumn colFinalPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiced;
        private DevExpress.XtraGrid.Columns.GridColumn colPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colShiped;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupFill;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemFill;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupData;
        private DevExpress.XtraGrid.Columns.GridColumn colShipDate;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManagerMain;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManagerShipsLoad;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupView;
    }
}