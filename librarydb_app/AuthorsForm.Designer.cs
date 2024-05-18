namespace librarydb_app
{
    partial class AuthorsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelDeathDate = new System.Windows.Forms.Label();
            this.richTextBoxBiography = new System.Windows.Forms.RichTextBox();
            this.labelBiography = new System.Windows.Forms.Label();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxDeathDate = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonCreateXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.AllowUserToAddRows = false;
            this.dataGridViewAuthors.AllowUserToDeleteRows = false;
            this.dataGridViewAuthors.AllowUserToResizeColumns = false;
            this.dataGridViewAuthors.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAuthors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAuthors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAuthors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAuthors.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAuthors.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAuthors.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.ReadOnly = true;
            this.dataGridViewAuthors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(816, 721);
            this.dataGridViewAuthors.TabIndex = 0;
            this.dataGridViewAuthors.SelectionChanged += new System.EventHandler(this.dataGridViewAuthors_SelectionChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxLastName.Location = new System.Drawing.Point(824, 88);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(177, 24);
            this.textBoxLastName.TabIndex = 1;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelLastName.Location = new System.Drawing.Point(824, 67);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(87, 18);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last name *";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelFirstName.Location = new System.Drawing.Point(824, 121);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(88, 18);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "First name *";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxFirstName.Location = new System.Drawing.Point(824, 142);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(177, 24);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelMiddleName.Location = new System.Drawing.Point(824, 175);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(102, 18);
            this.labelMiddleName.TabIndex = 6;
            this.labelMiddleName.Text = "Middle name *";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxMiddleName.Location = new System.Drawing.Point(824, 196);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(177, 24);
            this.textBoxMiddleName.TabIndex = 5;
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelBirth.Location = new System.Drawing.Point(824, 233);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(159, 18);
            this.labelBirth.TabIndex = 8;
            this.labelBirth.Text = "Birth Date (дд.мм.гггг)";
            // 
            // labelDeathDate
            // 
            this.labelDeathDate.AutoSize = true;
            this.labelDeathDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelDeathDate.Location = new System.Drawing.Point(824, 290);
            this.labelDeathDate.Name = "labelDeathDate";
            this.labelDeathDate.Size = new System.Drawing.Size(168, 18);
            this.labelDeathDate.TabIndex = 10;
            this.labelDeathDate.Text = "Death Date (дд.мм.гггг)";
            // 
            // richTextBoxBiography
            // 
            this.richTextBoxBiography.Location = new System.Drawing.Point(824, 366);
            this.richTextBoxBiography.Name = "richTextBoxBiography";
            this.richTextBoxBiography.Size = new System.Drawing.Size(177, 106);
            this.richTextBoxBiography.TabIndex = 13;
            this.richTextBoxBiography.Text = "";
            // 
            // labelBiography
            // 
            this.labelBiography.AutoSize = true;
            this.labelBiography.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelBiography.Location = new System.Drawing.Point(824, 345);
            this.labelBiography.Name = "labelBiography";
            this.labelBiography.Size = new System.Drawing.Size(108, 18);
            this.labelBiography.TabIndex = 14;
            this.labelBiography.Text = "Brief Biography";
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonAddAuthor.Location = new System.Drawing.Point(824, 492);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(177, 41);
            this.buttonAddAuthor.TabIndex = 15;
            this.buttonAddAuthor.Text = "Добавить автора";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonDelete.Location = new System.Drawing.Point(824, 607);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(177, 52);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить автора по выделенной строке";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxBirthDate.Location = new System.Drawing.Point(824, 254);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.Size = new System.Drawing.Size(177, 24);
            this.textBoxBirthDate.TabIndex = 17;
            // 
            // textBoxDeathDate
            // 
            this.textBoxDeathDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxDeathDate.Location = new System.Drawing.Point(824, 311);
            this.textBoxDeathDate.Name = "textBoxDeathDate";
            this.textBoxDeathDate.Size = new System.Drawing.Size(177, 24);
            this.textBoxDeathDate.TabIndex = 18;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonEdit.Location = new System.Drawing.Point(824, 549);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(177, 52);
            this.buttonEdit.TabIndex = 35;
            this.buttonEdit.Text = "Изменить автора по выделенной строке";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxSearch.Location = new System.Drawing.Point(824, 30);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(177, 24);
            this.textBoxSearch.TabIndex = 36;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelSearch.Location = new System.Drawing.Point(824, 9);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(52, 18);
            this.labelSearch.TabIndex = 37;
            this.labelSearch.Text = "Поиск";
            // 
            // buttonCreateXML
            // 
            this.buttonCreateXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonCreateXML.Location = new System.Drawing.Point(824, 668);
            this.buttonCreateXML.Name = "buttonCreateXML";
            this.buttonCreateXML.Size = new System.Drawing.Size(177, 41);
            this.buttonCreateXML.TabIndex = 38;
            this.buttonCreateXML.Text = "Сохранить в XML";
            this.buttonCreateXML.UseVisualStyleBackColor = true;
            this.buttonCreateXML.Click += new System.EventHandler(this.buttonCreateXML_Click);
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 721);
            this.Controls.Add(this.buttonCreateXML);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxDeathDate);
            this.Controls.Add(this.textBoxBirthDate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.labelBiography);
            this.Controls.Add(this.richTextBoxBiography);
            this.Controls.Add(this.labelDeathDate);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.dataGridViewAuthors);
            this.Name = "AuthorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelDeathDate;
        private System.Windows.Forms.RichTextBox richTextBoxBiography;
        private System.Windows.Forms.Label labelBiography;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.TextBox textBoxDeathDate;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonCreateXML;
    }
}