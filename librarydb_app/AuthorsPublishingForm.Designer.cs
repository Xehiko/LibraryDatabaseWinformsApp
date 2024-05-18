namespace librarydb_app
{
    partial class AuthorsPublishingForm
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
            this.dataGridViewAP = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddBA = new System.Windows.Forms.Button();
            this.comboBoxHouses = new System.Windows.Forms.ComboBox();
            this.labelHouse = new System.Windows.Forms.Label();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonCreateXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAP
            // 
            this.dataGridViewAP.AllowUserToAddRows = false;
            this.dataGridViewAP.AllowUserToDeleteRows = false;
            this.dataGridViewAP.AllowUserToResizeColumns = false;
            this.dataGridViewAP.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAP.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewAP.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAP.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewAP.Name = "dataGridViewAP";
            this.dataGridViewAP.ReadOnly = true;
            this.dataGridViewAP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewAP.Size = new System.Drawing.Size(787, 721);
            this.dataGridViewAP.TabIndex = 7;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonDelete.Location = new System.Drawing.Point(795, 433);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(199, 52);
            this.buttonDelete.TabIndex = 56;
            this.buttonDelete.Text = "Удалить выделенную строку";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddBA
            // 
            this.buttonAddBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonAddBA.Location = new System.Drawing.Point(798, 302);
            this.buttonAddBA.Name = "buttonAddBA";
            this.buttonAddBA.Size = new System.Drawing.Size(202, 41);
            this.buttonAddBA.TabIndex = 55;
            this.buttonAddBA.Text = "Добавить";
            this.buttonAddBA.UseVisualStyleBackColor = true;
            this.buttonAddBA.Click += new System.EventHandler(this.buttonAddBA_Click);
            // 
            // comboBoxHouses
            // 
            this.comboBoxHouses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHouses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxHouses.FormattingEnabled = true;
            this.comboBoxHouses.Items.AddRange(new object[] {
            "admin",
            "reader"});
            this.comboBoxHouses.Location = new System.Drawing.Point(798, 240);
            this.comboBoxHouses.Name = "comboBoxHouses";
            this.comboBoxHouses.Size = new System.Drawing.Size(202, 26);
            this.comboBoxHouses.TabIndex = 54;
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelHouse.Location = new System.Drawing.Point(798, 219);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(175, 18);
            this.labelHouse.TabIndex = 53;
            this.labelHouse.Text = "Название издательства";
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Items.AddRange(new object[] {
            "admin",
            "reader"});
            this.comboBoxAuthors.Location = new System.Drawing.Point(798, 181);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(202, 26);
            this.comboBoxAuthors.TabIndex = 52;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelAuthor.Location = new System.Drawing.Point(798, 160);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(49, 18);
            this.labelAuthor.TabIndex = 51;
            this.labelAuthor.Text = "Автор";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelSearch.Location = new System.Drawing.Point(798, 20);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(52, 18);
            this.labelSearch.TabIndex = 58;
            this.labelSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxSearch.Location = new System.Drawing.Point(798, 41);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(177, 24);
            this.textBoxSearch.TabIndex = 57;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonCreateXML
            // 
            this.buttonCreateXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonCreateXML.Location = new System.Drawing.Point(795, 507);
            this.buttonCreateXML.Name = "buttonCreateXML";
            this.buttonCreateXML.Size = new System.Drawing.Size(199, 41);
            this.buttonCreateXML.TabIndex = 59;
            this.buttonCreateXML.Text = "Сохранить в XML";
            this.buttonCreateXML.UseVisualStyleBackColor = true;
            this.buttonCreateXML.Click += new System.EventHandler(this.buttonCreateXML_Click);
            // 
            // AuthorsPublishingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 721);
            this.Controls.Add(this.buttonCreateXML);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddBA);
            this.Controls.Add(this.comboBoxHouses);
            this.Controls.Add(this.labelHouse);
            this.Controls.Add(this.comboBoxAuthors);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.dataGridViewAP);
            this.Name = "AuthorsPublishingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorsPublishingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAP;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddBA;
        private System.Windows.Forms.ComboBox comboBoxHouses;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonCreateXML;
    }
}