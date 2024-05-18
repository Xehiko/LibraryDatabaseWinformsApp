namespace librarydb_app
{
    partial class BooksAuthorsForm
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
            this.dataGridViewBA = new System.Windows.Forms.DataGridView();
            this.comboBoxBooks = new System.Windows.Forms.ComboBox();
            this.labelBook = new System.Windows.Forms.Label();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddBA = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonCreateXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBA
            // 
            this.dataGridViewBA.AllowUserToAddRows = false;
            this.dataGridViewBA.AllowUserToDeleteRows = false;
            this.dataGridViewBA.AllowUserToResizeColumns = false;
            this.dataGridViewBA.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBA.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBA.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewBA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBA.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewBA.Name = "dataGridViewBA";
            this.dataGridViewBA.ReadOnly = true;
            this.dataGridViewBA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewBA.Size = new System.Drawing.Size(787, 721);
            this.dataGridViewBA.TabIndex = 6;
            // 
            // comboBoxBooks
            // 
            this.comboBoxBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxBooks.FormattingEnabled = true;
            this.comboBoxBooks.Items.AddRange(new object[] {
            "admin",
            "reader"});
            this.comboBoxBooks.Location = new System.Drawing.Point(795, 225);
            this.comboBoxBooks.Name = "comboBoxBooks";
            this.comboBoxBooks.Size = new System.Drawing.Size(202, 26);
            this.comboBoxBooks.TabIndex = 48;
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelBook.Location = new System.Drawing.Point(795, 204);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(117, 18);
            this.labelBook.TabIndex = 47;
            this.labelBook.Text = "Название книги";
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Items.AddRange(new object[] {
            "admin",
            "reader"});
            this.comboBoxAuthors.Location = new System.Drawing.Point(795, 166);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(202, 26);
            this.comboBoxAuthors.TabIndex = 46;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelAuthor.Location = new System.Drawing.Point(795, 145);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(49, 18);
            this.labelAuthor.TabIndex = 45;
            this.labelAuthor.Text = "Автор";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonDelete.Location = new System.Drawing.Point(795, 380);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(202, 52);
            this.buttonDelete.TabIndex = 50;
            this.buttonDelete.Text = "Удалить выделенную строку";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddBA
            // 
            this.buttonAddBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonAddBA.Location = new System.Drawing.Point(794, 277);
            this.buttonAddBA.Name = "buttonAddBA";
            this.buttonAddBA.Size = new System.Drawing.Size(203, 41);
            this.buttonAddBA.TabIndex = 49;
            this.buttonAddBA.Text = "Добавить";
            this.buttonAddBA.UseVisualStyleBackColor = true;
            this.buttonAddBA.Click += new System.EventHandler(this.buttonAddBA_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelSearch.Location = new System.Drawing.Point(795, 24);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(52, 18);
            this.labelSearch.TabIndex = 52;
            this.labelSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxSearch.Location = new System.Drawing.Point(795, 45);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(202, 24);
            this.textBoxSearch.TabIndex = 51;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonCreateXML
            // 
            this.buttonCreateXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonCreateXML.Location = new System.Drawing.Point(795, 491);
            this.buttonCreateXML.Name = "buttonCreateXML";
            this.buttonCreateXML.Size = new System.Drawing.Size(202, 41);
            this.buttonCreateXML.TabIndex = 53;
            this.buttonCreateXML.Text = "Сохранить в XML";
            this.buttonCreateXML.UseVisualStyleBackColor = true;
            this.buttonCreateXML.Click += new System.EventHandler(this.buttonCreateXML_Click);
            // 
            // BooksAuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 721);
            this.Controls.Add(this.buttonCreateXML);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddBA);
            this.Controls.Add(this.comboBoxBooks);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.comboBoxAuthors);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.dataGridViewBA);
            this.Name = "BooksAuthorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksAuthorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBA;
        private System.Windows.Forms.ComboBox comboBoxBooks;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddBA;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonCreateXML;
    }
}