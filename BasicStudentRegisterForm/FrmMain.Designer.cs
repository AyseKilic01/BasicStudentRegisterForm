namespace BasicStudentRegisterForm
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMain = new DevExpress.XtraBars.BarButtonItem();
            this.btnStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnHelp = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AutoSizeItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnMain,
            this.btnStudent,
            this.btnAdd,
            this.btnDelete,
            this.btnUpdate,
            this.btnHelp,
            this.barButtonItem7});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1212, 145);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnMain
            // 
            this.btnMain.Caption = "AnaSayfa";
            this.btnMain.Id = 1;
            this.btnMain.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.ImageOptions.Image")));
            this.btnMain.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMain.ImageOptions.LargeImage")));
            this.btnMain.Name = "btnMain";
            // 
            // btnStudent
            // 
            this.btnStudent.Caption = "Öğrenciler";
            this.btnStudent.Id = 2;
            this.btnStudent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.ImageOptions.Image")));
            this.btnStudent.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStudent.ImageOptions.LargeImage")));
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStudent_ItemClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Ekle";
            this.btnAdd.Id = 3;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Sil";
            this.btnDelete.Id = 4;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Güncelle";
            this.btnUpdate.Id = 5;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            // 
            // btnHelp
            // 
            this.btnHelp.Caption = "Yardım";
            this.btnHelp.Id = 6;
            this.btnHelp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.Image")));
            this.btnHelp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.LargeImage")));
            this.btnHelp.Name = "btnHelp";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Öğrenci Kayıt Sistemi";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMain);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnStudent);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.btnHelp);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            // 
            // btnExit
            // 
            this.btnExit.AllowFocus = false;
            this.btnExit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.AppearanceDisabled.Options.UseBackColor = true;
            this.btnExit.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.AppearanceHovered.Options.UseBackColor = true;
            this.btnExit.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.AppearancePressed.Options.UseBackColor = true;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(1178, 31);
            this.btnExit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnExit.Size = new System.Drawing.Size(22, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 511);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnMain;
        private DevExpress.XtraBars.BarButtonItem btnStudent;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnHelp;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}

