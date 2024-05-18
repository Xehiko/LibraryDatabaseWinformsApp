namespace librarydb_app
{
    partial class ReportsForm
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
            this.comboBoxReaders = new System.Windows.Forms.ComboBox();
            this.labelReader = new System.Windows.Forms.Label();
            this.comboBoxReports = new System.Windows.Forms.ComboBox();
            this.labelReportType = new System.Windows.Forms.Label();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxReaders
            // 
            this.comboBoxReaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxReaders.FormattingEnabled = true;
            this.comboBoxReaders.Items.AddRange(new object[] {
            "admin",
            "reader"});
            this.comboBoxReaders.Location = new System.Drawing.Point(258, 139);
            this.comboBoxReaders.Name = "comboBoxReaders";
            this.comboBoxReaders.Size = new System.Drawing.Size(284, 28);
            this.comboBoxReaders.TabIndex = 50;
            // 
            // labelReader
            // 
            this.labelReader.AutoSize = true;
            this.labelReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelReader.Location = new System.Drawing.Point(255, 118);
            this.labelReader.Name = "labelReader";
            this.labelReader.Size = new System.Drawing.Size(103, 20);
            this.labelReader.TabIndex = 49;
            this.labelReader.Text = "Читатель *";
            // 
            // comboBoxReports
            // 
            this.comboBoxReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxReports.FormattingEnabled = true;
            this.comboBoxReports.Location = new System.Drawing.Point(258, 218);
            this.comboBoxReports.Name = "comboBoxReports";
            this.comboBoxReports.Size = new System.Drawing.Size(284, 28);
            this.comboBoxReports.TabIndex = 52;
            // 
            // labelReportType
            // 
            this.labelReportType.AutoSize = true;
            this.labelReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelReportType.Location = new System.Drawing.Point(255, 197);
            this.labelReportType.Name = "labelReportType";
            this.labelReportType.Size = new System.Drawing.Size(104, 20);
            this.labelReportType.TabIndex = 51;
            this.labelReportType.Text = "Тип отчёта";
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonCreateReport.Location = new System.Drawing.Point(258, 312);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(284, 59);
            this.buttonCreateReport.TabIndex = 53;
            this.buttonCreateReport.Text = "Сформировать XML отчёт";
            this.buttonCreateReport.UseVisualStyleBackColor = true;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.comboBoxReports);
            this.Controls.Add(this.labelReportType);
            this.Controls.Add(this.comboBoxReaders);
            this.Controls.Add(this.labelReader);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxReaders;
        private System.Windows.Forms.Label labelReader;
        private System.Windows.Forms.ComboBox comboBoxReports;
        private System.Windows.Forms.Label labelReportType;
        private System.Windows.Forms.Button buttonCreateReport;
    }
}