
namespace TeamManager
{
    partial class TeamsListFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamsListFrm));
            this.teamsListBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.teamsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.homeRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Home = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.createNewTeamBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.teamsListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // teamsListBoxControl
            // 
            this.teamsListBoxControl.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsListBoxControl.Appearance.Options.UseFont = true;
            this.teamsListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamsListBoxControl.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Standard;
            this.teamsListBoxControl.Location = new System.Drawing.Point(0, 193);
            this.teamsListBoxControl.Name = "teamsListBoxControl";
            this.teamsListBoxControl.Size = new System.Drawing.Size(1314, 400);
            this.teamsListBoxControl.TabIndex = 4;
            this.teamsListBoxControl.TabStop = false;
            this.teamsListBoxControl.DoubleClick += new System.EventHandler(this.teamsListBoxControl_DoubleClick);
            // 
            // teamsRibbonPageGroup
            // 
            this.teamsRibbonPageGroup.Name = "teamsRibbonPageGroup";
            this.teamsRibbonPageGroup.Text = "Teams";
            // 
            // homeRibbonPage
            // 
            this.homeRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.teamsRibbonPageGroup});
            this.homeRibbonPage.Name = "homeRibbonPage";
            this.homeRibbonPage.Text = "Home";
            // 
            // Home
            // 
            this.Home.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.Home.Name = "Home";
            this.Home.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.createNewTeamBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Teams";
            // 
            // createNewTeamBarButtonItem
            // 
            this.createNewTeamBarButtonItem.Caption = "Create Team";
            this.createNewTeamBarButtonItem.Id = 1;
            this.createNewTeamBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("createNewTeamBarButtonItem.ImageOptions.SvgImage")));
            this.createNewTeamBarButtonItem.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTeamBarButtonItem.ItemAppearance.Disabled.Options.UseFont = true;
            this.createNewTeamBarButtonItem.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.createNewTeamBarButtonItem.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.createNewTeamBarButtonItem.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTeamBarButtonItem.ItemAppearance.Hovered.Options.UseFont = true;
            this.createNewTeamBarButtonItem.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.createNewTeamBarButtonItem.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.createNewTeamBarButtonItem.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTeamBarButtonItem.ItemAppearance.Normal.Options.UseFont = true;
            this.createNewTeamBarButtonItem.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.createNewTeamBarButtonItem.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.createNewTeamBarButtonItem.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTeamBarButtonItem.ItemAppearance.Pressed.Options.UseFont = true;
            this.createNewTeamBarButtonItem.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.createNewTeamBarButtonItem.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.createNewTeamBarButtonItem.Name = "createNewTeamBarButtonItem";
            this.createNewTeamBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.createNewTeamBarButtonItem_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete Team";
            this.btnDelete.Id = 4;
            this.btnDelete.ImageOptions.DisabledSvgImageSize = new System.Drawing.Size(50, 50);
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.btnDelete.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDelete.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnDelete.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDelete.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnDelete.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDelete.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnDelete.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.btnDelete.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnEmployee);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Employees";
            // 
            // btnEmployee
            // 
            this.btnEmployee.Caption = "Add Employee";
            this.btnEmployee.Id = 3;
            this.btnEmployee.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEmployee.ImageOptions.SvgImage")));
            this.btnEmployee.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnEmployee.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.btnEmployee.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnEmployee.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnEmployee.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnEmployee.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnEmployee.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ItemAppearance.Normal.Options.UseFont = true;
            this.btnEmployee.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnEmployee.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnEmployee.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnEmployee.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.btnEmployee.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmployee_ItemClick);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.skinPaletteDropDownButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = " Appearance";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 7;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 6;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.createNewTeamBarButtonItem,
            this.btnEmployee,
            this.btnDelete,
            this.skinPaletteDropDownButtonItem1,
            this.skinRibbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Home});
            this.ribbonControl1.Size = new System.Drawing.Size(1314, 193);
            // 
            // TeamsListFrm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 593);
            this.Controls.Add(this.teamsListBoxControl);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "TeamsListFrm";
            this.Ribbon = this.ribbonControl1;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.VisibleChanged += new System.EventHandler(this.TeamsListFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.teamsListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.ListBoxControl teamsListBoxControl;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup teamsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage homeRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPage Home;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem createNewTeamBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnEmployee;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
    }
}