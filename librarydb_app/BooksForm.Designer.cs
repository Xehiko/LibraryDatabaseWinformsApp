namespace librarydb_app
{
    partial class BooksForm
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
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.comboBoxDepName = new System.Windows.Forms.ComboBox();
            this.labelDepName = new System.Windows.Forms.Label();
            this.comboBoxHouseName = new System.Windows.Forms.ComboBox();
            this.labelHouseName = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.labelBookPrice = new System.Windows.Forms.Label();
            this.textBoxBookPrice = new System.Windows.Forms.TextBox();
            this.textBoxReceiptDate = new System.Windows.Forms.TextBox();
            this.labelReceiptDate = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonCreateXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AllowUserToResizeColumns = false;
            this.dataGridViewBooks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewBooks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewBooks.Size = new System.Drawing.Size(816, 721);
            this.dataGridViewBooks.TabIndex = 5;
            this.dataGridViewBooks.SelectionChanged += new System.EventHandler(this.dataGridViewBooks_SelectionChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonEdit.Location = new System.Drawing.Point(824, 487);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(177, 52);
            this.buttonEdit.TabIndex = 40;
            this.buttonEdit.Text = "Изменить книгу по выделенной строке";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonDelete.Location = new System.Drawing.Point(824, 545);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(177, 52);
            this.buttonDelete.TabIndex = 39;
            this.buttonDelete.Text = "Удалить книгу по выделенной строке";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonAddBook.Location = new System.Drawing.Point(824, 413);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(177, 41);
            this.buttonAddBook.TabIndex = 38;
            this.buttonAddBook.Text = "Добавить книгу";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // comboBoxDepName
            // 
            this.comboBoxDepName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxDepName.FormattingEnabled = true;
            this.comboBoxDepName.Items.AddRange(new object[] {
            "admin",
            "reader"});
            this.comboBoxDepName.Location = new System.Drawing.Point(824, 143);
            this.comboBoxDepName.Name = "comboBoxDepName";
            this.comboBoxDepName.Size = new System.Drawing.Size(177, 26);
            this.comboBoxDepName.TabIndex = 42;
            // 
            // labelDepName
            // 
            this.labelDepName.AutoSize = true;
            this.labelDepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelDepName.Location = new System.Drawing.Point(824, 122);
            this.labelDepName.Name = "labelDepName";
            this.labelDepName.Size = new System.Drawing.Size(139, 18);
            this.labelDepName.TabIndex = 41;
            this.labelDepName.Text = "Название отдела *";
            // 
            // comboBoxHouseName
            // 
            this.comboBoxHouseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxHouseName.FormattingEnabled = true;
            this.comboBoxHouseName.Items.AddRange(new object[] {
            "admin",
            "reader"});
            this.comboBoxHouseName.Location = new System.Drawing.Point(824, 202);
            this.comboBoxHouseName.Name = "comboBoxHouseName";
            this.comboBoxHouseName.Size = new System.Drawing.Size(177, 26);
            this.comboBoxHouseName.TabIndex = 44;
            // 
            // labelHouseName
            // 
            this.labelHouseName.AutoSize = true;
            this.labelHouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelHouseName.Location = new System.Drawing.Point(824, 181);
            this.labelHouseName.Name = "labelHouseName";
            this.labelHouseName.Size = new System.Drawing.Size(185, 18);
            this.labelHouseName.TabIndex = 43;
            this.labelHouseName.Text = "Название издательства *";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelBookName.Location = new System.Drawing.Point(824, 238);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(85, 18);
            this.labelBookName.TabIndex = 46;
            this.labelBookName.Text = "Book Title *";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxBookName.Location = new System.Drawing.Point(824, 259);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(177, 24);
            this.textBoxBookName.TabIndex = 45;
            // 
            // labelBookPrice
            // 
            this.labelBookPrice.AutoSize = true;
            this.labelBookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelBookPrice.Location = new System.Drawing.Point(824, 293);
            this.labelBookPrice.Name = "labelBookPrice";
            this.labelBookPrice.Size = new System.Drawing.Size(92, 18);
            this.labelBookPrice.TabIndex = 48;
            this.labelBookPrice.Text = "Book Price *";
            // 
            // textBoxBookPrice
            // 
            this.textBoxBookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxBookPrice.Location = new System.Drawing.Point(824, 314);
            this.textBoxBookPrice.Name = "textBoxBookPrice";
            this.textBoxBookPrice.Size = new System.Drawing.Size(177, 24);
            this.textBoxBookPrice.TabIndex = 47;
            // 
            // textBoxReceiptDate
            // 
            this.textBoxReceiptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxReceiptDate.Location = new System.Drawing.Point(824, 372);
            this.textBoxReceiptDate.Name = "textBoxReceiptDate";
            this.textBoxReceiptDate.Size = new System.Drawing.Size(177, 24);
            this.textBoxReceiptDate.TabIndex = 50;
            // 
            // labelReceiptDate
            // 
            this.labelReceiptDate.AutoSize = true;
            this.labelReceiptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelReceiptDate.Location = new System.Drawing.Point(824, 351);
            this.labelReceiptDate.Name = "labelReceiptDate";
            this.labelReceiptDate.Size = new System.Drawing.Size(179, 18);
            this.labelReceiptDate.TabIndex = 49;
            this.labelReceiptDate.Text = "Receipt Date (дд.мм.гггг)";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelSearch.Location = new System.Drawing.Point(824, 14);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(52, 18);
            this.labelSearch.TabIndex = 52;
            this.labelSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxSearch.Location = new System.Drawing.Point(824, 35);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(177, 24);
            this.textBoxSearch.TabIndex = 51;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonCreateXML
            // 
            this.buttonCreateXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonCreateXML.Location = new System.Drawing.Point(824, 629);
            this.buttonCreateXML.Name = "buttonCreateXML";
            this.buttonCreateXML.Size = new System.Drawing.Size(177, 41);
            this.buttonCreateXML.TabIndex = 53;
            this.buttonCreateXML.Text = "Сохранить в XML";
            this.buttonCreateXML.UseVisualStyleBackColor = true;
            this.buttonCreateXML.Click += new System.EventHandler(this.buttonCreateXML_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 721);
            this.Controls.Add(this.buttonCreateXML);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxReceiptDate);
            this.Controls.Add(this.labelReceiptDate);
            this.Controls.Add(this.labelBookPrice);
            this.Controls.Add(this.textBoxBookPrice);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.comboBoxHouseName);
            this.Controls.Add(this.labelHouseName);
            this.Controls.Add(this.comboBoxDepName);
            this.Controls.Add(this.labelDepName);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.dataGridViewBooks);
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.ComboBox comboBoxDepName;
        private System.Windows.Forms.Label labelDepName;
        private System.Windows.Forms.ComboBox comboBoxHouseName;
        private System.Windows.Forms.Label labelHouseName;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label labelBookPrice;
        private System.Windows.Forms.TextBox textBoxBookPrice;
        private System.Windows.Forms.TextBox textBoxReceiptDate;
        private System.Windows.Forms.Label labelReceiptDate;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonCreateXML;
    }
}