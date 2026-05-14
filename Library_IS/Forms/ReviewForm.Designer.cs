namespace Library_IS.Forms
{
    partial class ReviewForm
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
            this.cb_Books = new System.Windows.Forms.ComboBox();
            this.rt_Review = new System.Windows.Forms.RichTextBox();
            this.btn_SaveReview = new System.Windows.Forms.Button();
            this.lb_Books = new System.Windows.Forms.Label();
            this.lb_Review = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Books
            // 
            this.cb_Books.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Books.FormattingEnabled = true;
            this.cb_Books.Location = new System.Drawing.Point(84, 25);
            this.cb_Books.Name = "cb_Books";
            this.cb_Books.Size = new System.Drawing.Size(332, 21);
            this.cb_Books.TabIndex = 0;
            // 
            // rt_Review
            // 
            this.rt_Review.Location = new System.Drawing.Point(84, 66);
            this.rt_Review.Name = "rt_Review";
            this.rt_Review.Size = new System.Drawing.Size(332, 96);
            this.rt_Review.TabIndex = 1;
            this.rt_Review.Text = "";
            // 
            // btn_SaveReview
            // 
            this.btn_SaveReview.Location = new System.Drawing.Point(84, 182);
            this.btn_SaveReview.Name = "btn_SaveReview";
            this.btn_SaveReview.Size = new System.Drawing.Size(158, 23);
            this.btn_SaveReview.TabIndex = 2;
            this.btn_SaveReview.Text = "Save";
            this.btn_SaveReview.UseVisualStyleBackColor = true;
            this.btn_SaveReview.Click += new System.EventHandler(this.btn_SaveReview_Click);
            // 
            // lb_Books
            // 
            this.lb_Books.AutoSize = true;
            this.lb_Books.Location = new System.Drawing.Point(12, 25);
            this.lb_Books.Name = "lb_Books";
            this.lb_Books.Size = new System.Drawing.Size(37, 13);
            this.lb_Books.TabIndex = 3;
            this.lb_Books.Text = "Books";
            // 
            // lb_Review
            // 
            this.lb_Review.AutoSize = true;
            this.lb_Review.Location = new System.Drawing.Point(12, 69);
            this.lb_Review.Name = "lb_Review";
            this.lb_Review.Size = new System.Drawing.Size(43, 13);
            this.lb_Review.TabIndex = 4;
            this.lb_Review.Text = "Review";
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 267);
            this.Controls.Add(this.lb_Review);
            this.Controls.Add(this.lb_Books);
            this.Controls.Add(this.btn_SaveReview);
            this.Controls.Add(this.rt_Review);
            this.Controls.Add(this.cb_Books);
            this.Name = "ReviewForm";
            this.Text = "ReviewForm";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Books;
        private System.Windows.Forms.RichTextBox rt_Review;
        private System.Windows.Forms.Button btn_SaveReview;
        private System.Windows.Forms.Label lb_Books;
        private System.Windows.Forms.Label lb_Review;
    }
}