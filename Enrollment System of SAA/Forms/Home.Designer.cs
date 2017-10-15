namespace Enrollment_System_of_SAA.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.AppName = new System.Windows.Forms.Label();
            this.sidemenu = new System.Windows.Forms.Panel();
            this.tab10UserSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab9SiteMap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab8SubjectModule = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab7ClassList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab1EnrollmentModule = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab6TeacherMasterList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab5StudentRecord = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab4RequirementCheckList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab3StudentMasterList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab2EnrollmentHistory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.sidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.header.Controls.Add(this.picMinimize);
            this.header.Controls.Add(this.picClose);
            this.header.Controls.Add(this.AppName);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1200, 40);
            this.header.TabIndex = 0;
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picMinimize.Image")));
            this.picMinimize.Location = new System.Drawing.Point(1137, 7);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(25, 25);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimize.TabIndex = 2;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(1165, 7);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(25, 25);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // AppName
            // 
            this.AppName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.Color.White;
            this.AppName.Location = new System.Drawing.Point(12, 9);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(267, 16);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "St. Augustine Academy - Enrollment System";
            // 
            // sidemenu
            // 
            this.sidemenu.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.sidemenu.Controls.Add(this.tab10UserSettings);
            this.sidemenu.Controls.Add(this.tab9SiteMap);
            this.sidemenu.Controls.Add(this.tab8SubjectModule);
            this.sidemenu.Controls.Add(this.tab7ClassList);
            this.sidemenu.Controls.Add(this.tab1EnrollmentModule);
            this.sidemenu.Controls.Add(this.tab6TeacherMasterList);
            this.sidemenu.Controls.Add(this.tab5StudentRecord);
            this.sidemenu.Controls.Add(this.tab4RequirementCheckList);
            this.sidemenu.Controls.Add(this.tab3StudentMasterList);
            this.sidemenu.Controls.Add(this.tab2EnrollmentHistory);
            this.sidemenu.Controls.Add(this.pictureBox1);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 40);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(229, 710);
            this.sidemenu.TabIndex = 1;
            // 
            // tab10UserSettings
            // 
            this.tab10UserSettings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab10UserSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab10UserSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab10UserSettings.BorderRadius = 0;
            this.tab10UserSettings.ButtonText = "     User Settings";
            this.tab10UserSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab10UserSettings.DisabledColor = System.Drawing.Color.Gray;
            this.tab10UserSettings.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab10UserSettings.ForeColor = System.Drawing.SystemColors.Window;
            this.tab10UserSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.tab10UserSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab10UserSettings.Iconimage")));
            this.tab10UserSettings.Iconimage_right = null;
            this.tab10UserSettings.Iconimage_right_Selected = null;
            this.tab10UserSettings.Iconimage_Selected = null;
            this.tab10UserSettings.IconMarginLeft = 0;
            this.tab10UserSettings.IconMarginRight = 0;
            this.tab10UserSettings.IconRightVisible = true;
            this.tab10UserSettings.IconRightZoom = 0D;
            this.tab10UserSettings.IconVisible = true;
            this.tab10UserSettings.IconZoom = 100D;
            this.tab10UserSettings.IsTab = true;
            this.tab10UserSettings.Location = new System.Drawing.Point(0, 623);
            this.tab10UserSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab10UserSettings.Name = "tab10UserSettings";
            this.tab10UserSettings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab10UserSettings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab10UserSettings.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tab10UserSettings.selected = false;
            this.tab10UserSettings.Size = new System.Drawing.Size(229, 48);
            this.tab10UserSettings.TabIndex = 12;
            this.tab10UserSettings.Text = "     User Settings";
            this.tab10UserSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab10UserSettings.Textcolor = System.Drawing.Color.White;
            this.tab10UserSettings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tab9SiteMap
            // 
            this.tab9SiteMap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab9SiteMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab9SiteMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab9SiteMap.BorderRadius = 0;
            this.tab9SiteMap.ButtonText = "     Site Map";
            this.tab9SiteMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab9SiteMap.DisabledColor = System.Drawing.Color.Gray;
            this.tab9SiteMap.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab9SiteMap.ForeColor = System.Drawing.SystemColors.Window;
            this.tab9SiteMap.Iconcolor = System.Drawing.Color.Transparent;
            this.tab9SiteMap.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab9SiteMap.Iconimage")));
            this.tab9SiteMap.Iconimage_right = null;
            this.tab9SiteMap.Iconimage_right_Selected = null;
            this.tab9SiteMap.Iconimage_Selected = null;
            this.tab9SiteMap.IconMarginLeft = 0;
            this.tab9SiteMap.IconMarginRight = 0;
            this.tab9SiteMap.IconRightVisible = true;
            this.tab9SiteMap.IconRightZoom = 0D;
            this.tab9SiteMap.IconVisible = true;
            this.tab9SiteMap.IconZoom = 100D;
            this.tab9SiteMap.IsTab = true;
            this.tab9SiteMap.Location = new System.Drawing.Point(0, 569);
            this.tab9SiteMap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab9SiteMap.Name = "tab9SiteMap";
            this.tab9SiteMap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab9SiteMap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab9SiteMap.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tab9SiteMap.selected = false;
            this.tab9SiteMap.Size = new System.Drawing.Size(229, 48);
            this.tab9SiteMap.TabIndex = 11;
            this.tab9SiteMap.Text = "     Site Map";
            this.tab9SiteMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab9SiteMap.Textcolor = System.Drawing.Color.White;
            this.tab9SiteMap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tab8SubjectModule
            // 
            this.tab8SubjectModule.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab8SubjectModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab8SubjectModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab8SubjectModule.BorderRadius = 0;
            this.tab8SubjectModule.ButtonText = "     Subject Module";
            this.tab8SubjectModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab8SubjectModule.DisabledColor = System.Drawing.Color.Gray;
            this.tab8SubjectModule.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab8SubjectModule.ForeColor = System.Drawing.SystemColors.Window;
            this.tab8SubjectModule.Iconcolor = System.Drawing.Color.Transparent;
            this.tab8SubjectModule.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab8SubjectModule.Iconimage")));
            this.tab8SubjectModule.Iconimage_right = null;
            this.tab8SubjectModule.Iconimage_right_Selected = null;
            this.tab8SubjectModule.Iconimage_Selected = null;
            this.tab8SubjectModule.IconMarginLeft = 0;
            this.tab8SubjectModule.IconMarginRight = 0;
            this.tab8SubjectModule.IconRightVisible = true;
            this.tab8SubjectModule.IconRightZoom = 0D;
            this.tab8SubjectModule.IconVisible = true;
            this.tab8SubjectModule.IconZoom = 100D;
            this.tab8SubjectModule.IsTab = true;
            this.tab8SubjectModule.Location = new System.Drawing.Point(0, 515);
            this.tab8SubjectModule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab8SubjectModule.Name = "tab8SubjectModule";
            this.tab8SubjectModule.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab8SubjectModule.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab8SubjectModule.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tab8SubjectModule.selected = false;
            this.tab8SubjectModule.Size = new System.Drawing.Size(229, 48);
            this.tab8SubjectModule.TabIndex = 10;
            this.tab8SubjectModule.Text = "     Subject Module";
            this.tab8SubjectModule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab8SubjectModule.Textcolor = System.Drawing.Color.White;
            this.tab8SubjectModule.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab8SubjectModule.Click += new System.EventHandler(this.tab8SubjectModule_Click);
            // 
            // tab7ClassList
            // 
            this.tab7ClassList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab7ClassList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab7ClassList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab7ClassList.BorderRadius = 0;
            this.tab7ClassList.ButtonText = "     Scheduling";
            this.tab7ClassList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab7ClassList.DisabledColor = System.Drawing.Color.Gray;
            this.tab7ClassList.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab7ClassList.ForeColor = System.Drawing.SystemColors.Window;
            this.tab7ClassList.Iconcolor = System.Drawing.Color.Transparent;
            this.tab7ClassList.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab7ClassList.Iconimage")));
            this.tab7ClassList.Iconimage_right = null;
            this.tab7ClassList.Iconimage_right_Selected = null;
            this.tab7ClassList.Iconimage_Selected = null;
            this.tab7ClassList.IconMarginLeft = 0;
            this.tab7ClassList.IconMarginRight = 0;
            this.tab7ClassList.IconRightVisible = true;
            this.tab7ClassList.IconRightZoom = 0D;
            this.tab7ClassList.IconVisible = true;
            this.tab7ClassList.IconZoom = 100D;
            this.tab7ClassList.IsTab = true;
            this.tab7ClassList.Location = new System.Drawing.Point(0, 461);
            this.tab7ClassList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab7ClassList.Name = "tab7ClassList";
            this.tab7ClassList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab7ClassList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab7ClassList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tab7ClassList.selected = false;
            this.tab7ClassList.Size = new System.Drawing.Size(229, 48);
            this.tab7ClassList.TabIndex = 9;
            this.tab7ClassList.Text = "     Scheduling";
            this.tab7ClassList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab7ClassList.Textcolor = System.Drawing.Color.White;
            this.tab7ClassList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab7ClassList.Click += new System.EventHandler(this.tab7ClassList_Click);
            // 
            // tab1EnrollmentModule
            // 
            this.tab1EnrollmentModule.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab1EnrollmentModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab1EnrollmentModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab1EnrollmentModule.BorderRadius = 0;
            this.tab1EnrollmentModule.ButtonText = "     Enrollment Module";
            this.tab1EnrollmentModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab1EnrollmentModule.DisabledColor = System.Drawing.Color.Gray;
            this.tab1EnrollmentModule.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1EnrollmentModule.ForeColor = System.Drawing.SystemColors.Window;
            this.tab1EnrollmentModule.Iconcolor = System.Drawing.Color.Transparent;
            this.tab1EnrollmentModule.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab1EnrollmentModule.Iconimage")));
            this.tab1EnrollmentModule.Iconimage_right = null;
            this.tab1EnrollmentModule.Iconimage_right_Selected = null;
            this.tab1EnrollmentModule.Iconimage_Selected = null;
            this.tab1EnrollmentModule.IconMarginLeft = 0;
            this.tab1EnrollmentModule.IconMarginRight = 0;
            this.tab1EnrollmentModule.IconRightVisible = true;
            this.tab1EnrollmentModule.IconRightZoom = 0D;
            this.tab1EnrollmentModule.IconVisible = true;
            this.tab1EnrollmentModule.IconZoom = 100D;
            this.tab1EnrollmentModule.IsTab = true;
            this.tab1EnrollmentModule.Location = new System.Drawing.Point(3, 139);
            this.tab1EnrollmentModule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab1EnrollmentModule.Name = "tab1EnrollmentModule";
            this.tab1EnrollmentModule.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab1EnrollmentModule.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab1EnrollmentModule.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tab1EnrollmentModule.selected = false;
            this.tab1EnrollmentModule.Size = new System.Drawing.Size(229, 48);
            this.tab1EnrollmentModule.TabIndex = 8;
            this.tab1EnrollmentModule.Text = "     Enrollment Module";
            this.tab1EnrollmentModule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab1EnrollmentModule.Textcolor = System.Drawing.Color.White;
            this.tab1EnrollmentModule.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1EnrollmentModule.Click += new System.EventHandler(this.tab1EnrollmentModule_Click);
            // 
            // tab6TeacherMasterList
            // 
            this.tab6TeacherMasterList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab6TeacherMasterList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab6TeacherMasterList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab6TeacherMasterList.BorderRadius = 0;
            this.tab6TeacherMasterList.ButtonText = "     Teacher Masterlist";
            this.tab6TeacherMasterList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab6TeacherMasterList.DisabledColor = System.Drawing.Color.Gray;
            this.tab6TeacherMasterList.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab6TeacherMasterList.ForeColor = System.Drawing.SystemColors.Window;
            this.tab6TeacherMasterList.Iconcolor = System.Drawing.Color.Transparent;
            this.tab6TeacherMasterList.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab6TeacherMasterList.Iconimage")));
            this.tab6TeacherMasterList.Iconimage_right = null;
            this.tab6TeacherMasterList.Iconimage_right_Selected = null;
            this.tab6TeacherMasterList.Iconimage_Selected = null;
            this.tab6TeacherMasterList.IconMarginLeft = 0;
            this.tab6TeacherMasterList.IconMarginRight = 0;
            this.tab6TeacherMasterList.IconRightVisible = true;
            this.tab6TeacherMasterList.IconRightZoom = 0D;
            this.tab6TeacherMasterList.IconVisible = true;
            this.tab6TeacherMasterList.IconZoom = 100D;
            this.tab6TeacherMasterList.IsTab = true;
            this.tab6TeacherMasterList.Location = new System.Drawing.Point(0, 407);
            this.tab6TeacherMasterList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab6TeacherMasterList.Name = "tab6TeacherMasterList";
            this.tab6TeacherMasterList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab6TeacherMasterList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab6TeacherMasterList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tab6TeacherMasterList.selected = false;
            this.tab6TeacherMasterList.Size = new System.Drawing.Size(229, 48);
            this.tab6TeacherMasterList.TabIndex = 7;
            this.tab6TeacherMasterList.Text = "     Teacher Masterlist";
            this.tab6TeacherMasterList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab6TeacherMasterList.Textcolor = System.Drawing.Color.White;
            this.tab6TeacherMasterList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tab5StudentRecord
            // 
            this.tab5StudentRecord.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab5StudentRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab5StudentRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab5StudentRecord.BorderRadius = 0;
            this.tab5StudentRecord.ButtonText = "     Student Record";
            this.tab5StudentRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab5StudentRecord.DisabledColor = System.Drawing.Color.Gray;
            this.tab5StudentRecord.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab5StudentRecord.ForeColor = System.Drawing.SystemColors.Window;
            this.tab5StudentRecord.Iconcolor = System.Drawing.Color.Transparent;
            this.tab5StudentRecord.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab5StudentRecord.Iconimage")));
            this.tab5StudentRecord.Iconimage_right = null;
            this.tab5StudentRecord.Iconimage_right_Selected = null;
            this.tab5StudentRecord.Iconimage_Selected = null;
            this.tab5StudentRecord.IconMarginLeft = 0;
            this.tab5StudentRecord.IconMarginRight = 0;
            this.tab5StudentRecord.IconRightVisible = true;
            this.tab5StudentRecord.IconRightZoom = 0D;
            this.tab5StudentRecord.IconVisible = true;
            this.tab5StudentRecord.IconZoom = 100D;
            this.tab5StudentRecord.IsTab = true;
            this.tab5StudentRecord.Location = new System.Drawing.Point(0, 353);
            this.tab5StudentRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab5StudentRecord.Name = "tab5StudentRecord";
            this.tab5StudentRecord.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab5StudentRecord.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab5StudentRecord.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tab5StudentRecord.selected = false;
            this.tab5StudentRecord.Size = new System.Drawing.Size(229, 48);
            this.tab5StudentRecord.TabIndex = 6;
            this.tab5StudentRecord.Text = "     Student Record";
            this.tab5StudentRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab5StudentRecord.Textcolor = System.Drawing.Color.White;
            this.tab5StudentRecord.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab5StudentRecord.Click += new System.EventHandler(this.tab5StudentRecord_Click);
            // 
            // tab4RequirementCheckList
            // 
            this.tab4RequirementCheckList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab4RequirementCheckList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab4RequirementCheckList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab4RequirementCheckList.BorderRadius = 0;
            this.tab4RequirementCheckList.ButtonText = "     Requirement Checklist";
            this.tab4RequirementCheckList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab4RequirementCheckList.DisabledColor = System.Drawing.Color.Gray;
            this.tab4RequirementCheckList.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab4RequirementCheckList.ForeColor = System.Drawing.SystemColors.Window;
            this.tab4RequirementCheckList.Iconcolor = System.Drawing.Color.Transparent;
            this.tab4RequirementCheckList.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab4RequirementCheckList.Iconimage")));
            this.tab4RequirementCheckList.Iconimage_right = null;
            this.tab4RequirementCheckList.Iconimage_right_Selected = null;
            this.tab4RequirementCheckList.Iconimage_Selected = null;
            this.tab4RequirementCheckList.IconMarginLeft = 0;
            this.tab4RequirementCheckList.IconMarginRight = 0;
            this.tab4RequirementCheckList.IconRightVisible = true;
            this.tab4RequirementCheckList.IconRightZoom = 0D;
            this.tab4RequirementCheckList.IconVisible = true;
            this.tab4RequirementCheckList.IconZoom = 100D;
            this.tab4RequirementCheckList.IsTab = true;
            this.tab4RequirementCheckList.Location = new System.Drawing.Point(0, 299);
            this.tab4RequirementCheckList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab4RequirementCheckList.Name = "tab4RequirementCheckList";
            this.tab4RequirementCheckList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab4RequirementCheckList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab4RequirementCheckList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tab4RequirementCheckList.selected = false;
            this.tab4RequirementCheckList.Size = new System.Drawing.Size(229, 48);
            this.tab4RequirementCheckList.TabIndex = 5;
            this.tab4RequirementCheckList.Text = "     Requirement Checklist";
            this.tab4RequirementCheckList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab4RequirementCheckList.Textcolor = System.Drawing.Color.White;
            this.tab4RequirementCheckList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab4RequirementCheckList.Click += new System.EventHandler(this.tab4RequirementCheckList_Click);
            // 
            // tab3StudentMasterList
            // 
            this.tab3StudentMasterList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab3StudentMasterList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab3StudentMasterList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab3StudentMasterList.BorderRadius = 0;
            this.tab3StudentMasterList.ButtonText = "     Student Masterlist";
            this.tab3StudentMasterList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab3StudentMasterList.DisabledColor = System.Drawing.Color.Gray;
            this.tab3StudentMasterList.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab3StudentMasterList.ForeColor = System.Drawing.SystemColors.Window;
            this.tab3StudentMasterList.Iconcolor = System.Drawing.Color.Transparent;
            this.tab3StudentMasterList.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab3StudentMasterList.Iconimage")));
            this.tab3StudentMasterList.Iconimage_right = null;
            this.tab3StudentMasterList.Iconimage_right_Selected = null;
            this.tab3StudentMasterList.Iconimage_Selected = null;
            this.tab3StudentMasterList.IconMarginLeft = 0;
            this.tab3StudentMasterList.IconMarginRight = 0;
            this.tab3StudentMasterList.IconRightVisible = true;
            this.tab3StudentMasterList.IconRightZoom = 0D;
            this.tab3StudentMasterList.IconVisible = true;
            this.tab3StudentMasterList.IconZoom = 100D;
            this.tab3StudentMasterList.IsTab = true;
            this.tab3StudentMasterList.Location = new System.Drawing.Point(0, 245);
            this.tab3StudentMasterList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab3StudentMasterList.Name = "tab3StudentMasterList";
            this.tab3StudentMasterList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab3StudentMasterList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab3StudentMasterList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tab3StudentMasterList.selected = false;
            this.tab3StudentMasterList.Size = new System.Drawing.Size(229, 48);
            this.tab3StudentMasterList.TabIndex = 4;
            this.tab3StudentMasterList.Text = "     Student Masterlist";
            this.tab3StudentMasterList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab3StudentMasterList.Textcolor = System.Drawing.Color.White;
            this.tab3StudentMasterList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab3StudentMasterList.Click += new System.EventHandler(this.tab3StudentMasterList_Click);
            // 
            // tab2EnrollmentHistory
            // 
            this.tab2EnrollmentHistory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab2EnrollmentHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab2EnrollmentHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab2EnrollmentHistory.BorderRadius = 0;
            this.tab2EnrollmentHistory.ButtonText = "     Enrollment History";
            this.tab2EnrollmentHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab2EnrollmentHistory.DisabledColor = System.Drawing.Color.Gray;
            this.tab2EnrollmentHistory.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2EnrollmentHistory.ForeColor = System.Drawing.SystemColors.Window;
            this.tab2EnrollmentHistory.Iconcolor = System.Drawing.Color.Transparent;
            this.tab2EnrollmentHistory.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab2EnrollmentHistory.Iconimage")));
            this.tab2EnrollmentHistory.Iconimage_right = null;
            this.tab2EnrollmentHistory.Iconimage_right_Selected = null;
            this.tab2EnrollmentHistory.Iconimage_Selected = null;
            this.tab2EnrollmentHistory.IconMarginLeft = 0;
            this.tab2EnrollmentHistory.IconMarginRight = 0;
            this.tab2EnrollmentHistory.IconRightVisible = true;
            this.tab2EnrollmentHistory.IconRightZoom = 0D;
            this.tab2EnrollmentHistory.IconVisible = true;
            this.tab2EnrollmentHistory.IconZoom = 100D;
            this.tab2EnrollmentHistory.IsTab = true;
            this.tab2EnrollmentHistory.Location = new System.Drawing.Point(0, 191);
            this.tab2EnrollmentHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab2EnrollmentHistory.Name = "tab2EnrollmentHistory";
            this.tab2EnrollmentHistory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.tab2EnrollmentHistory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(213)))));
            this.tab2EnrollmentHistory.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tab2EnrollmentHistory.selected = false;
            this.tab2EnrollmentHistory.Size = new System.Drawing.Size(229, 48);
            this.tab2EnrollmentHistory.TabIndex = 3;
            this.tab2EnrollmentHistory.Text = "     Enrollment History";
            this.tab2EnrollmentHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab2EnrollmentHistory.Textcolor = System.Drawing.Color.White;
            this.tab2EnrollmentHistory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2EnrollmentHistory.Click += new System.EventHandler(this.tab2EnrollmentHistory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(229, 40);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(971, 710);
            this.MainPanel.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.sidemenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel sidemenu;
        private Bunifu.Framework.UI.BunifuFlatButton tab1EnrollmentModule;
        private Bunifu.Framework.UI.BunifuFlatButton tab6TeacherMasterList;
        private Bunifu.Framework.UI.BunifuFlatButton tab5StudentRecord;
        private Bunifu.Framework.UI.BunifuFlatButton tab4RequirementCheckList;
        private Bunifu.Framework.UI.BunifuFlatButton tab3StudentMasterList;
        private Bunifu.Framework.UI.BunifuFlatButton tab2EnrollmentHistory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton tab10UserSettings;
        private Bunifu.Framework.UI.BunifuFlatButton tab9SiteMap;
        private Bunifu.Framework.UI.BunifuFlatButton tab8SubjectModule;
        private Bunifu.Framework.UI.BunifuFlatButton tab7ClassList;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel MainPanel;
    }
}