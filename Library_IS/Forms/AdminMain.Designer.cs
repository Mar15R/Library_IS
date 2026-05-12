namespace Library_IS.Forms
{
    partial class AdminMain
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
            this.gv_Books = new System.Windows.Forms.DataGridView();
            this.gv_Users = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_RegisterBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Books
            // 
            this.gv_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Books.Location = new System.Drawing.Point(150, 34);
            this.gv_Books.Name = "gv_Books";
            this.gv_Books.Size = new System.Drawing.Size(1183, 246);
            this.gv_Books.TabIndex = 0;
            this.gv_Books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Books_CellClick);
            // 
            // gv_Users
            // 
            this.gv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Users.Location = new System.Drawing.Point(150, 300);
            this.gv_Users.Name = "gv_Users";
            this.gv_Users.Size = new System.Drawing.Size(1183, 268);
            this.gv_Users.TabIndex = 1;
            this.gv_Users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Users_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Users";
            // 
            // btn_RegisterBook
            // 
            this.btn_RegisterBook.Location = new System.Drawing.Point(12, 64);
            this.btn_RegisterBook.Name = "btn_RegisterBook";
            this.btn_RegisterBook.Size = new System.Drawing.Size(108, 23);
            this.btn_RegisterBook.TabIndex = 4;
            this.btn_RegisterBook.Text = "Register Book";
            this.btn_RegisterBook.UseVisualStyleBackColor = true;
            this.btn_RegisterBook.Click += new System.EventHandler(this.btn_RegisterBook_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 598);
            this.Controls.Add(this.btn_RegisterBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gv_Users);
            this.Controls.Add(this.gv_Books);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.Load += new System.EventHandler(this.AdminMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Books;
        private System.Windows.Forms.DataGridView gv_Users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_RegisterBook;
    }
}