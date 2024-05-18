namespace librarydb_app
{
    partial class DepsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDeps = new System.Windows.Forms.DataGridView();
            this.labelDepPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelDepName = new System.Windows.Forms.Label();
            this.textBoxDepName = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddDep = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonCreateXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeps)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDeps
            // 
            this.dataGridViewDeps.AllowUserToAddRows = false;
            this.dataGridViewDeps.AllowUserToDeleteRows = false;
            this.dataGridViewDeps.AllowUserToResizeColumns = false;
            this.dataGridViewDeps.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDeps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDeps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeps.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDeps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDeps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDeps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDeps.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDeps.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewDeps.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDeps.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewDeps.Name = "dataGridViewDeps";
            this.dataGridViewDeps.ReadOnly = true;
            this.dataGridViewDeps.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewDeps.Size = new System.Drawing.Size(816, 721);
            this.dataGridViewDeps.TabIndex = 4;
            this.dataGridViewDeps.SelectionChanged += new System.EventHandler(this.dataGridViewDeps_SelectionChanged);
            // 
            // labelDepPhoneNumber
            // 
            this.labelDepPhoneNumber.AutoSize = true;
            this.labelDepPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelDepPhoneNumber.Location = new System.Drawing.Point(824, 232);
            this.labelDepPhoneNumber.Name = "labelDepPhoneNumber";
            this.labelDepPhoneNumber.Size = new System.Drawing.Size(144, 18);
            this.labelDepPhoneNumber.TabIndex = 25;
            this.labelDepPhoneNumber.Text = "Dep phone number *";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(824, 253);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(177, 24);
            this.textBoxPhoneNumber.TabIndex = 24;
            // 
            // labelDepName
            // 
            this.labelDepName.AutoSize = true;
            this.labelDepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelDepName.Location = new System.Drawing.Point(824, 178);
            this.labelDepName.Name = "labelDepName";
            this.labelDepName.Size = new System.Drawing.Size(136, 18);
            this.labelDepName.TabIndex = 23;
            this.labelDepName.Text = "Department name *";
            // 
            // textBoxDepName
            // 
            this.textBoxDepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxDepName.Location = new System.Drawing.Point(824, 199);
            this.textBoxDepName.Name = "textBoxDepName";
            this.textBoxDepName.Size = new System.Drawing.Size(177, 24);
            this.textBoxDepName.TabIndex = 22;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonEdit.Location = new System.Drawing.Point(824, 391);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(177, 52);
            this.buttonEdit.TabIndex = 37;
            this.buttonEdit.Text = "Изменить отдел по выделенной строке";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonDelete.Location = new System.Drawing.Point(824, 449);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(177, 52);
            this.buttonDelete.TabIndex = 36;
            this.buttonDelete.Text = "Удалить отдел по выделенной строке";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddDep
            // 
            this.buttonAddDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonAddDep.Location = new System.Drawing.Point(824, 305);
            this.buttonAddDep.Name = "buttonAddDep";
            this.buttonAddDep.Size = new System.Drawing.Size(177, 41);
            this.buttonAddDep.TabIndex = 35;
            this.buttonAddDep.Text = "Добавить отдел";
            this.buttonAddDep.UseVisualStyleBackColor = true;
            this.buttonAddDep.Click += new System.EventHandler(this.buttonAddDep_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelSearch.Location = new System.Drawing.Point(824, 29);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(52, 18);
            this.labelSearch.TabIndex = 39;
            this.labelSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxSearch.Location = new System.Drawing.Point(824, 50);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(177, 24);
            this.textBoxSearch.TabIndex = 38;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonCreateXML
            // 
            this.buttonCreateXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonCreateXML.Location = new System.Drawing.Point(824, 545);
            this.buttonCreateXML.Name = "buttonCreateXML";
            this.buttonCreateXML.Size = new System.Drawing.Size(177, 41);
            this.buttonCreateXML.TabIndex = 40;
            this.buttonCreateXML.Text = "Сохранить в XML";
            this.buttonCreateXML.UseVisualStyleBackColor = true;
            this.buttonCreateXML.Click += new System.EventHandler(this.buttonCreateXML_Click);
            // 
            // DepsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 721);
            this.Controls.Add(this.buttonCreateXML);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddDep);
            this.Controls.Add(this.labelDepPhoneNumber);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelDepName);
            this.Controls.Add(this.textBoxDepName);
            this.Controls.Add(this.dataGridViewDeps);
            this.Name = "DepsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDeps;
        private System.Windows.Forms.Label labelDepPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelDepName;
        private System.Windows.Forms.TextBox textBoxDepName;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddDep;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonCreateXML;
    }
}