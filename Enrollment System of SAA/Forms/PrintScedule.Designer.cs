namespace Enrollment_System_of_SAA.Forms
{
    partial class PrintScedule
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
            this.ClassScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptScheduleModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClassScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptScheduleModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassScheduleBindingSource
            // 
            this.ClassScheduleBindingSource.DataSource = typeof(Enrollment_System_of_SAA.Models.ClassSchedule);
            // 
            // rptScheduleModelBindingSource
            // 
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Enrollment_System_of_SAA.Reports.rptSchedule.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(651, 382);
            this.reportViewer1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PrintScedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 409);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintScedule";
            this.Text = "PrintScedule";
            this.Load += new System.EventHandler(this.PrintScedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptScheduleModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClassScheduleBindingSource;
        private System.Windows.Forms.BindingSource rptScheduleModelBindingSource;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}