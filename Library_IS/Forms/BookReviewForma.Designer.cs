namespace Library_IS.Forms
{
    partial class BookReviewForma
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
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_DateTime = new System.Windows.Forms.Label();
            this.lb_BookName = new System.Windows.Forms.Label();
            this.txt_Review = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Location = new System.Drawing.Point(29, 32);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(35, 13);
            this.lb_User.TabIndex = 0;
            this.lb_User.Text = "label1";
            // 
            // lb_DateTime
            // 
            this.lb_DateTime.AutoSize = true;
            this.lb_DateTime.Location = new System.Drawing.Point(29, 83);
            this.lb_DateTime.Name = "lb_DateTime";
            this.lb_DateTime.Size = new System.Drawing.Size(35, 13);
            this.lb_DateTime.TabIndex = 1;
            this.lb_DateTime.Text = "label2";
            // 
            // lb_BookName
            // 
            this.lb_BookName.AutoSize = true;
            this.lb_BookName.Location = new System.Drawing.Point(29, 138);
            this.lb_BookName.Name = "lb_BookName";
            this.lb_BookName.Size = new System.Drawing.Size(35, 13);
            this.lb_BookName.TabIndex = 2;
            this.lb_BookName.Text = "label3";
            // 
            // txt_Review
            // 
            this.txt_Review.Location = new System.Drawing.Point(32, 194);
            this.txt_Review.Name = "txt_Review";
            this.txt_Review.Size = new System.Drawing.Size(600, 20);
            this.txt_Review.TabIndex = 3;
            // 
            // BookReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Review);
            this.Controls.Add(this.lb_BookName);
            this.Controls.Add(this.lb_DateTime);
            this.Controls.Add(this.lb_User);
            this.Name = "BookReview";
            this.Text = "BookReview";
            this.Load += new System.EventHandler(this.BookReview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Label lb_DateTime;
        private System.Windows.Forms.Label lb_BookName;
        private System.Windows.Forms.TextBox txt_Review;
    }
}