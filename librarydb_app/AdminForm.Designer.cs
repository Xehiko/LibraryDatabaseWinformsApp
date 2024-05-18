namespace librarydb_app
{
    partial class AdminForm
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
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.buttonAuthors = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonHouse = new System.Windows.Forms.Button();
            this.buttonDeps = new System.Windows.Forms.Button();
            this.buttonReaders = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonBookHasAuthor = new System.Windows.Forms.Button();
            this.buttonAuthorPublishing = new System.Windows.Forms.Button();
            this.buttonBookings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(653, 12);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(119, 35);
            this.buttonSignOut.TabIndex = 0;
            this.buttonSignOut.Text = "Выход из аккаунта";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // buttonAuthors
            // 
            this.buttonAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonAuthors.Location = new System.Drawing.Point(196, 50);
            this.buttonAuthors.Name = "buttonAuthors";
            this.buttonAuthors.Size = new System.Drawing.Size(198, 50);
            this.buttonAuthors.TabIndex = 1;
            this.buttonAuthors.Text = "Таблица Авторы";
            this.buttonAuthors.UseVisualStyleBackColor = true;
            this.buttonAuthors.Click += new System.EventHandler(this.buttonAuthors_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonBooks.Location = new System.Drawing.Point(196, 121);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(198, 50);
            this.buttonBooks.TabIndex = 2;
            this.buttonBooks.Text = "Таблица Книги";
            this.buttonBooks.UseVisualStyleBackColor = true;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonHouse
            // 
            this.buttonHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonHouse.Location = new System.Drawing.Point(196, 190);
            this.buttonHouse.Name = "buttonHouse";
            this.buttonHouse.Size = new System.Drawing.Size(198, 50);
            this.buttonHouse.TabIndex = 3;
            this.buttonHouse.Text = "Таблица Издательства";
            this.buttonHouse.UseVisualStyleBackColor = true;
            this.buttonHouse.Click += new System.EventHandler(this.buttonHouse_Click);
            // 
            // buttonDeps
            // 
            this.buttonDeps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonDeps.Location = new System.Drawing.Point(196, 261);
            this.buttonDeps.Name = "buttonDeps";
            this.buttonDeps.Size = new System.Drawing.Size(198, 50);
            this.buttonDeps.TabIndex = 4;
            this.buttonDeps.Text = "Таблица Отделы";
            this.buttonDeps.UseVisualStyleBackColor = true;
            this.buttonDeps.Click += new System.EventHandler(this.buttonDeps_Click);
            // 
            // buttonReaders
            // 
            this.buttonReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonReaders.Location = new System.Drawing.Point(196, 335);
            this.buttonReaders.Name = "buttonReaders";
            this.buttonReaders.Size = new System.Drawing.Size(198, 50);
            this.buttonReaders.TabIndex = 5;
            this.buttonReaders.Text = "Таблица Читатели";
            this.buttonReaders.UseVisualStyleBackColor = true;
            this.buttonReaders.Click += new System.EventHandler(this.buttonReaders_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonUsers.Location = new System.Drawing.Point(196, 406);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(198, 50);
            this.buttonUsers.TabIndex = 6;
            this.buttonUsers.Text = "Таблица Пользователи";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonBookHasAuthor
            // 
            this.buttonBookHasAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonBookHasAuthor.Location = new System.Drawing.Point(411, 50);
            this.buttonBookHasAuthor.Name = "buttonBookHasAuthor";
            this.buttonBookHasAuthor.Size = new System.Drawing.Size(198, 50);
            this.buttonBookHasAuthor.TabIndex = 7;
            this.buttonBookHasAuthor.Text = "Таблица Авторы и книги";
            this.buttonBookHasAuthor.UseVisualStyleBackColor = true;
            this.buttonBookHasAuthor.Click += new System.EventHandler(this.buttonBookHasAuthor_Click);
            // 
            // buttonAuthorPublishing
            // 
            this.buttonAuthorPublishing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonAuthorPublishing.Location = new System.Drawing.Point(411, 121);
            this.buttonAuthorPublishing.Name = "buttonAuthorPublishing";
            this.buttonAuthorPublishing.Size = new System.Drawing.Size(198, 50);
            this.buttonAuthorPublishing.TabIndex = 8;
            this.buttonAuthorPublishing.Text = "Таблица Авторы и издательства";
            this.buttonAuthorPublishing.UseVisualStyleBackColor = true;
            this.buttonAuthorPublishing.Click += new System.EventHandler(this.buttonAuthorPublishing_Click);
            // 
            // buttonBookings
            // 
            this.buttonBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonBookings.Location = new System.Drawing.Point(196, 478);
            this.buttonBookings.Name = "buttonBookings";
            this.buttonBookings.Size = new System.Drawing.Size(198, 50);
            this.buttonBookings.TabIndex = 9;
            this.buttonBookings.Text = "Таблица Брони";
            this.buttonBookings.UseVisualStyleBackColor = true;
            this.buttonBookings.Click += new System.EventHandler(this.buttonBookings_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonBookings);
            this.Controls.Add(this.buttonAuthorPublishing);
            this.Controls.Add(this.buttonBookHasAuthor);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonReaders);
            this.Controls.Add(this.buttonDeps);
            this.Controls.Add(this.buttonHouse);
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.buttonAuthors);
            this.Controls.Add(this.buttonSignOut);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Button buttonAuthors;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Button buttonHouse;
        private System.Windows.Forms.Button buttonDeps;
        private System.Windows.Forms.Button buttonReaders;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonBookHasAuthor;
        private System.Windows.Forms.Button buttonAuthorPublishing;
        private System.Windows.Forms.Button buttonBookings;
    }
}

