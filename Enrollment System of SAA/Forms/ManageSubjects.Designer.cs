namespace Enrollment_System_of_SAA.Forms
{
    partial class ManageSubjects
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSubjects));
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvSubjectList = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupSubject = new System.Windows.Forms.GroupBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbGradeLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnCancel = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDeleteSubject = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEditSubject = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnNewSubject = new Bunifu.Framework.UI.BunifuTileButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList)).BeginInit();
            this.groupSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.label22.Location = new System.Drawing.Point(293, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(375, 24);
            this.label22.TabIndex = 27;
            this.label22.Text = "Saint Augustine\'s Academy, Patnongon";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(402, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(157, 24);
            this.label21.TabIndex = 26;
            this.label21.Text = "Manage Subject";
            // 
            // dgvSubjectList
            // 
            this.dgvSubjectList.AllowUserToAddRows = false;
            this.dgvSubjectList.AllowUserToDeleteRows = false;
            this.dgvSubjectList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubjectList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjectList.Location = new System.Drawing.Point(109, 323);
            this.dgvSubjectList.Name = "dgvSubjectList";
            this.dgvSubjectList.ReadOnly = true;
            this.dgvSubjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjectList.Size = new System.Drawing.Size(847, 343);
            this.dgvSubjectList.TabIndex = 30;
            this.dgvSubjectList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjectList_CellClick);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.Location = new System.Drawing.Point(938, 683);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 29;
            this.lblCount.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(835, 683);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Record(s) Count: ";
            // 
            // groupSubject
            // 
            this.groupSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSubject.Controls.Add(this.btnSave);
            this.groupSubject.Controls.Add(this.txtDescription);
            this.groupSubject.Controls.Add(this.cbGradeLevel);
            this.groupSubject.Controls.Add(this.label7);
            this.groupSubject.Controls.Add(this.label6);
            this.groupSubject.Controls.Add(this.txtTitle);
            this.groupSubject.Controls.Add(this.label5);
            this.groupSubject.Controls.Add(this.txtCode);
            this.groupSubject.Controls.Add(this.label4);
            this.groupSubject.Controls.Add(this.txtID);
            this.groupSubject.Controls.Add(this.label2);
            this.groupSubject.Enabled = false;
            this.groupSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSubject.Location = new System.Drawing.Point(7, 90);
            this.groupSubject.Name = "groupSubject";
            this.groupSubject.Size = new System.Drawing.Size(949, 163);
            this.groupSubject.TabIndex = 44;
            this.groupSubject.TabStop = false;
            this.groupSubject.Text = "Details";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageActive = null;
            this.btnSave.Location = new System.Drawing.Point(869, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 71);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 12;
            this.btnSave.TabStop = false;
            this.btnSave.Zoom = 8;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(115, 92);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(715, 65);
            this.txtDescription.TabIndex = 11;
            // 
            // cbGradeLevel
            // 
            this.cbGradeLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGradeLevel.FormattingEnabled = true;
            this.cbGradeLevel.Location = new System.Drawing.Point(551, 60);
            this.cbGradeLevel.Name = "cbGradeLevel";
            this.cbGradeLevel.Size = new System.Drawing.Size(279, 28);
            this.cbGradeLevel.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Grade Level";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(551, 29);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(279, 26);
            this.txtTitle.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Title";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(115, 60);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(137, 26);
            this.txtCode.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Code";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(115, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(137, 26);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBox.BackColor = System.Drawing.Color.White;
            this.txtSearchBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchBox.BackgroundImage")));
            this.txtSearchBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.txtSearchBox.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearchBox.Icon")));
            this.txtSearchBox.Location = new System.Drawing.Point(558, 275);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(398, 42);
            this.txtSearchBox.TabIndex = 45;
            this.txtSearchBox.text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.btnCancel.color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.btnCancel.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImagePosition = 14;
            this.btnCancel.ImageZoom = 50;
            this.btnCancel.LabelPosition = 29;
            this.btnCancel.LabelText = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(11, 602);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 85);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.btnDeleteSubject.color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.btnDeleteSubject.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.btnDeleteSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSubject.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSubject.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSubject.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSubject.Image")));
            this.btnDeleteSubject.ImagePosition = 14;
            this.btnDeleteSubject.ImageZoom = 50;
            this.btnDeleteSubject.LabelPosition = 29;
            this.btnDeleteSubject.LabelText = "Delete";
            this.btnDeleteSubject.Location = new System.Drawing.Point(11, 509);
            this.btnDeleteSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(85, 85);
            this.btnDeleteSubject.TabIndex = 48;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnEditSubject
            // 
            this.btnEditSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.btnEditSubject.color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.btnEditSubject.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.btnEditSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSubject.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSubject.ForeColor = System.Drawing.Color.White;
            this.btnEditSubject.Image = ((System.Drawing.Image)(resources.GetObject("btnEditSubject.Image")));
            this.btnEditSubject.ImagePosition = 14;
            this.btnEditSubject.ImageZoom = 50;
            this.btnEditSubject.LabelPosition = 29;
            this.btnEditSubject.LabelText = "Edit";
            this.btnEditSubject.Location = new System.Drawing.Point(11, 416);
            this.btnEditSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditSubject.Name = "btnEditSubject";
            this.btnEditSubject.Size = new System.Drawing.Size(85, 85);
            this.btnEditSubject.TabIndex = 47;
            this.btnEditSubject.Click += new System.EventHandler(this.btnEditSubject_Click);
            // 
            // btnNewSubject
            // 
            this.btnNewSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.btnNewSubject.color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.btnNewSubject.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.btnNewSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSubject.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSubject.ForeColor = System.Drawing.Color.White;
            this.btnNewSubject.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSubject.Image")));
            this.btnNewSubject.ImagePosition = 14;
            this.btnNewSubject.ImageZoom = 50;
            this.btnNewSubject.LabelPosition = 29;
            this.btnNewSubject.LabelText = "New";
            this.btnNewSubject.Location = new System.Drawing.Point(11, 323);
            this.btnNewSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewSubject.Name = "btnNewSubject";
            this.btnNewSubject.Size = new System.Drawing.Size(85, 85);
            this.btnNewSubject.TabIndex = 46;
            this.btnNewSubject.Click += new System.EventHandler(this.btnNewSubject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(105, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "List of Available Subjects";
            // 
            // ManageSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnEditSubject);
            this.Controls.Add(this.btnNewSubject);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.groupSubject);
            this.Controls.Add(this.dgvSubjectList);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Name = "ManageSubjects";
            this.Size = new System.Drawing.Size(971, 710);
            this.Load += new System.EventHandler(this.ManageSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList)).EndInit();
            this.groupSubject.ResumeLayout(false);
            this.groupSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvSubjectList;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTextbox txtSearchBox;
        private Bunifu.Framework.UI.BunifuTileButton btnCancel;
        private Bunifu.Framework.UI.BunifuTileButton btnDeleteSubject;
        private Bunifu.Framework.UI.BunifuTileButton btnEditSubject;
        private Bunifu.Framework.UI.BunifuTileButton btnNewSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGradeLevel;
        private System.Windows.Forms.TextBox txtDescription;
        private Bunifu.Framework.UI.BunifuImageButton btnSave;
    }
}
