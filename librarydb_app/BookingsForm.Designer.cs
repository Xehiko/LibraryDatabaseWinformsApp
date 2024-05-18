namespace librarydb_app
{
    partial class BookingsForm
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
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddBooking = new System.Windows.Forms.Button();
            this.comboBoxReader = new System.Windows.Forms.ComboBox();
            this.labelReader = new System.Windows.Forms.Label();
            this.comboBoxDepName = new System.Windows.Forms.ComboBox();
            this.labelDepName = new System.Windows.Forms.Label();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.labelBook = new System.Windows.Forms.Label();
            this.textBoxLoanDate = new System.Windows.Forms.TextBox();
            this.labelLoanDate = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonCreateXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.AllowUserToAddRows = false;
            this.dataGridViewBookings.AllowUserToDeleteRows = false;
            this.dataGridViewBookings.AllowUserToResizeColumns = false;
            this.dataGridViewBookings.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBookings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookings.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBookings.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewBookings.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBookings.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.ReadOnly = true;
            this.dataGridViewBookings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewBookings.Size = new System.Drawing.Size(816, 721);
            this.dataGridViewBookings.TabIndex = 6;
            this.dataGridViewBookings.SelectionChanged += new System.EventHandler(this.dataGridViewBookings_SelectionChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonEdit.Location = new System.Drawing.Point(824, 452);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(177, 52);
            this.buttonEdit.TabIndex = 43;
            this.buttonEdit.Text = "Изменить выделенную строку";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonDelete.Location = new System.Drawing.Point(824, 510);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(177, 52);
            this.buttonDelete.TabIndex = 42;
            this.buttonDelete.Text = "Удалить выделенную строку";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddBooking
            // 
            this.buttonAddBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonAddBooking.Location = new System.Drawing.Point(824, 376);
            this.buttonAddBooking.Name = "buttonAddBooking";
            this.buttonAddBooking.Size = new System.Drawing.Size(177, 41);
            this.buttonAddBooking.TabIndex = 41;
            this.buttonAddBooking.Text = "Добавить";
            this.buttonAddBooking.UseVisualStyleBackColor = true;
            this.buttonAddBooking.Click += new System.EventHandler(this.buttonAddBooking_Click);
            // 
            // comboBoxReader
            // 
            this.comboBoxReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxReader.FormattingEnabled = true;
            this.comboBoxReader.Items.AddRange(new object[] {
            "admin",
            "reader"});
            this.comboBoxReader.Location = new System.Drawing.Point(824, 210);
            this.comboBoxReader.Name = "comboBoxReader";
            this.comboBoxReader.Size = new System.Drawing.Size(177, 26);
            this.comboBoxReader.TabIndex = 48;
            // 
            // labelReader
            // 
            this.labelReader.AutoSize = true;
            this.labelReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelReader.Location = new System.Drawing.Point(824, 189);
            this.labelReader.Name = "labelReader";
            this.labelReader.Size = new System.Drawing.Size(83, 18);
            this.labelReader.TabIndex = 47;
            this.labelReader.Text = "Читатель *";
            // 
            // comboBoxDepName
            // 
            this.comboBoxDepName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxDepName.FormattingEnabled = true;
            this.comboBoxDepName.Items.AddRange(new object[] {
            "admin",
            "reader"});
            this.comboBoxDepName.Location = new System.Drawing.Point(824, 151);
            this.comboBoxDepName.Name = "comboBoxDepName";
            this.comboBoxDepName.Size = new System.Drawing.Size(177, 26);
            this.comboBoxDepName.TabIndex = 46;
            this.comboBoxDepName.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepName_SelectedIndexChanged);
            // 
            // labelDepName
            // 
            this.labelDepName.AutoSize = true;
            this.labelDepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelDepName.Location = new System.Drawing.Point(824, 130);
            this.labelDepName.Name = "labelDepName";
            this.labelDepName.Size = new System.Drawing.Size(139, 18);
            this.labelDepName.TabIndex = 45;
            this.labelDepName.Text = "Название отдела *";
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Items.AddRange(new object[] {
            "admin",
            "reader"});
            this.comboBoxBook.Location = new System.Drawing.Point(824, 272);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(177, 26);
            this.comboBoxBook.TabIndex = 50;
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelBook.Location = new System.Drawing.Point(824, 251);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(127, 18);
            this.labelBook.TabIndex = 49;
            this.labelBook.Text = "Название книги *";
            // 
            // textBoxLoanDate
            // 
            this.textBoxLoanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxLoanDate.Location = new System.Drawing.Point(824, 333);
            this.textBoxLoanDate.Name = "textBoxLoanDate";
            this.textBoxLoanDate.Size = new System.Drawing.Size(177, 24);
            this.textBoxLoanDate.TabIndex = 52;
            // 
            // labelLoanDate
            // 
            this.labelLoanDate.AutoSize = true;
            this.labelLoanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelLoanDate.Location = new System.Drawing.Point(824, 312);
            this.labelLoanDate.Name = "labelLoanDate";
            this.labelLoanDate.Size = new System.Drawing.Size(162, 18);
            this.labelLoanDate.TabIndex = 51;
            this.labelLoanDate.Text = "Loan Date (дд.мм.гггг)";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelSearch.Location = new System.Drawing.Point(824, 23);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(52, 18);
            this.labelSearch.TabIndex = 54;
            this.labelSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxSearch.Location = new System.Drawing.Point(824, 44);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(177, 24);
            this.textBoxSearch.TabIndex = 53;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonCreateXML
            // 
            this.buttonCreateXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonCreateXML.Location = new System.Drawing.Point(824, 603);
            this.buttonCreateXML.Name = "buttonCreateXML";
            this.buttonCreateXML.Size = new System.Drawing.Size(177, 41);
            this.buttonCreateXML.TabIndex = 55;
            this.buttonCreateXML.Text = "Отчёт в XML";
            this.buttonCreateXML.UseVisualStyleBackColor = true;
            this.buttonCreateXML.Click += new System.EventHandler(this.buttonCreateXML_Click);
            // 
            // BookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 721);
            this.Controls.Add(this.buttonCreateXML);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxLoanDate);
            this.Controls.Add(this.labelLoanDate);
            this.Controls.Add(this.comboBoxBook);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.comboBoxReader);
            this.Controls.Add(this.labelReader);
            this.Controls.Add(this.comboBoxDepName);
            this.Controls.Add(this.labelDepName);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddBooking);
            this.Controls.Add(this.dataGridViewBookings);
            this.Name = "BookingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddBooking;
        private System.Windows.Forms.ComboBox comboBoxReader;
        private System.Windows.Forms.Label labelReader;
        private System.Windows.Forms.ComboBox comboBoxDepName;
        private System.Windows.Forms.Label labelDepName;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.TextBox textBoxLoanDate;
        private System.Windows.Forms.Label labelLoanDate;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonCreateXML;
    }
}