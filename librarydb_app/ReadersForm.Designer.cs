namespace librarydb_app
{
    partial class ReadersForm
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
            this.dataGridViewReaders = new System.Windows.Forms.DataGridView();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddReader = new System.Windows.Forms.Button();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelHomeAddress = new System.Windows.Forms.Label();
            this.textBoxHomeAddress = new System.Windows.Forms.TextBox();
            this.comboBoxLogin = new System.Windows.Forms.ComboBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonCreateXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReaders
            // 
            this.dataGridViewReaders.AllowUserToAddRows = false;
            this.dataGridViewReaders.AllowUserToDeleteRows = false;
            this.dataGridViewReaders.AllowUserToResizeColumns = false;
            this.dataGridViewReaders.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReaders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewReaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReaders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewReaders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReaders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReaders.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewReaders.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewReaders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReaders.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewReaders.Name = "dataGridViewReaders";
            this.dataGridViewReaders.ReadOnly = true;
            this.dataGridViewReaders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewReaders.Size = new System.Drawing.Size(816, 721);
            this.dataGridViewReaders.TabIndex = 3;
            this.dataGridViewReaders.SelectionChanged += new System.EventHandler(this.dataGridViewReaders_SelectionChanged);
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxBirthDate.Location = new System.Drawing.Point(824, 261);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.Size = new System.Drawing.Size(177, 24);
            this.textBoxBirthDate.TabIndex = 25;
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelBirth.Location = new System.Drawing.Point(824, 240);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(159, 18);
            this.labelBirth.TabIndex = 24;
            this.labelBirth.Text = "Birth Date (дд.мм.гггг)";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelMiddleName.Location = new System.Drawing.Point(824, 192);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(102, 18);
            this.labelMiddleName.TabIndex = 23;
            this.labelMiddleName.Text = "Middle name *";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxMiddleName.Location = new System.Drawing.Point(824, 213);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(177, 24);
            this.textBoxMiddleName.TabIndex = 22;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelFirstName.Location = new System.Drawing.Point(824, 138);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(88, 18);
            this.labelFirstName.TabIndex = 21;
            this.labelFirstName.Text = "First name *";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxFirstName.Location = new System.Drawing.Point(824, 159);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(177, 24);
            this.textBoxFirstName.TabIndex = 20;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelLastName.Location = new System.Drawing.Point(824, 84);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(87, 18);
            this.labelLastName.TabIndex = 19;
            this.labelLastName.Text = "Last name *";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxLastName.Location = new System.Drawing.Point(824, 105);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(177, 24);
            this.textBoxLastName.TabIndex = 18;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonDelete.Location = new System.Drawing.Point(824, 594);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(177, 52);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "Удалить читателя по выделенной строке";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddReader
            // 
            this.buttonAddReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonAddReader.Location = new System.Drawing.Point(824, 469);
            this.buttonAddReader.Name = "buttonAddReader";
            this.buttonAddReader.Size = new System.Drawing.Size(177, 41);
            this.buttonAddReader.TabIndex = 26;
            this.buttonAddReader.Text = "Добавить читателя";
            this.buttonAddReader.UseVisualStyleBackColor = true;
            this.buttonAddReader.Click += new System.EventHandler(this.buttonAddReader_Click);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelPhoneNumber.Location = new System.Drawing.Point(824, 346);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(115, 18);
            this.labelPhoneNumber.TabIndex = 31;
            this.labelPhoneNumber.Text = "Phone number *";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(824, 367);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(177, 24);
            this.textBoxPhoneNumber.TabIndex = 30;
            // 
            // labelHomeAddress
            // 
            this.labelHomeAddress.AutoSize = true;
            this.labelHomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelHomeAddress.Location = new System.Drawing.Point(824, 292);
            this.labelHomeAddress.Name = "labelHomeAddress";
            this.labelHomeAddress.Size = new System.Drawing.Size(116, 18);
            this.labelHomeAddress.TabIndex = 29;
            this.labelHomeAddress.Text = "Home address *";
            // 
            // textBoxHomeAddress
            // 
            this.textBoxHomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxHomeAddress.Location = new System.Drawing.Point(824, 313);
            this.textBoxHomeAddress.Name = "textBoxHomeAddress";
            this.textBoxHomeAddress.Size = new System.Drawing.Size(177, 24);
            this.textBoxHomeAddress.TabIndex = 28;
            // 
            // comboBoxLogin
            // 
            this.comboBoxLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxLogin.FormattingEnabled = true;
            this.comboBoxLogin.Items.AddRange(new object[] {
            "admin",
            "reader"});
            this.comboBoxLogin.Location = new System.Drawing.Point(824, 423);
            this.comboBoxLogin.Name = "comboBoxLogin";
            this.comboBoxLogin.Size = new System.Drawing.Size(177, 26);
            this.comboBoxLogin.TabIndex = 33;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelLogin.Location = new System.Drawing.Point(824, 402);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(106, 18);
            this.labelLogin.TabIndex = 32;
            this.labelLogin.Text = "Reader Login *";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonEdit.Location = new System.Drawing.Point(824, 536);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(177, 52);
            this.buttonEdit.TabIndex = 34;
            this.buttonEdit.Text = "Изменить читателя по выделенной строке";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelSearch.Location = new System.Drawing.Point(824, 13);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(52, 18);
            this.labelSearch.TabIndex = 41;
            this.labelSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxSearch.Location = new System.Drawing.Point(824, 34);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(177, 24);
            this.textBoxSearch.TabIndex = 40;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonCreateXML
            // 
            this.buttonCreateXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonCreateXML.Location = new System.Drawing.Point(824, 652);
            this.buttonCreateXML.Name = "buttonCreateXML";
            this.buttonCreateXML.Size = new System.Drawing.Size(177, 41);
            this.buttonCreateXML.TabIndex = 42;
            this.buttonCreateXML.Text = "Сохранить в XML";
            this.buttonCreateXML.UseVisualStyleBackColor = true;
            this.buttonCreateXML.Click += new System.EventHandler(this.buttonCreateXML_Click);
            // 
            // ReadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 721);
            this.Controls.Add(this.buttonCreateXML);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.comboBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelHomeAddress);
            this.Controls.Add(this.textBoxHomeAddress);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddReader);
            this.Controls.Add(this.textBoxBirthDate);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.dataGridViewReaders);
            this.Name = "ReadersForm";
            this.Text = "ReadersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReaders;
        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddReader;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelHomeAddress;
        private System.Windows.Forms.TextBox textBoxHomeAddress;
        private System.Windows.Forms.ComboBox comboBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonCreateXML;
    }
}