namespace librarydb_app
{
    partial class RegularForm
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.buttonMyBooks = new System.Windows.Forms.Button();
            this.buttonLoanBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelLogin.Location = new System.Drawing.Point(12, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(53, 20);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "label1";
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(653, 12);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(119, 35);
            this.buttonSignOut.TabIndex = 1;
            this.buttonSignOut.Text = "Выход из аккаунта";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // buttonMyBooks
            // 
            this.buttonMyBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonMyBooks.Location = new System.Drawing.Point(275, 173);
            this.buttonMyBooks.Name = "buttonMyBooks";
            this.buttonMyBooks.Size = new System.Drawing.Size(250, 50);
            this.buttonMyBooks.TabIndex = 2;
            this.buttonMyBooks.Text = "Мои книги";
            this.buttonMyBooks.UseVisualStyleBackColor = true;
            this.buttonMyBooks.Click += new System.EventHandler(this.buttonMyBooks_Click);
            // 
            // buttonLoanBook
            // 
            this.buttonLoanBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonLoanBook.Location = new System.Drawing.Point(275, 261);
            this.buttonLoanBook.Name = "buttonLoanBook";
            this.buttonLoanBook.Size = new System.Drawing.Size(250, 50);
            this.buttonLoanBook.TabIndex = 3;
            this.buttonLoanBook.Text = "Взять книгу";
            this.buttonLoanBook.UseVisualStyleBackColor = true;
            this.buttonLoanBook.Click += new System.EventHandler(this.buttonLoanBook_Click);
            // 
            // RegularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonLoanBook);
            this.Controls.Add(this.buttonMyBooks);
            this.Controls.Add(this.buttonSignOut);
            this.Controls.Add(this.labelLogin);
            this.Name = "RegularForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegularForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSignOut;
        internal System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonMyBooks;
        private System.Windows.Forms.Button buttonLoanBook;
    }
}