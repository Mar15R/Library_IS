namespace Library_IS.Forms
{
    partial class UserMain
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
            this.gv_Available = new System.Windows.Forms.DataGridView();
            this.gv_UserBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Available)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Available
            // 
            this.gv_Available.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Available.Location = new System.Drawing.Point(68, 12);
            this.gv_Available.Name = "gv_Available";
            this.gv_Available.Size = new System.Drawing.Size(1101, 306);
            this.gv_Available.TabIndex = 0;
            this.gv_Available.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Available_CellClick);
            // 
            // gv_UserBooks
            // 
            this.gv_UserBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_UserBooks.Location = new System.Drawing.Point(70, 343);
            this.gv_UserBooks.Name = "gv_UserBooks";
            this.gv_UserBooks.Size = new System.Drawing.Size(1099, 231);
            this.gv_UserBooks.TabIndex = 1;
            this.gv_UserBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_UserBooks_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taken";
            // 
            // btn_AddReview
            // 
            this.btn_AddReview.Location = new System.Drawing.Point(24, 586);
            this.btn_AddReview.Name = "btn_AddReview";
            this.btn_AddReview.Size = new System.Drawing.Size(75, 23);
            this.btn_AddReview.TabIndex = 4;
            this.btn_AddReview.Text = "Add Review";
            this.btn_AddReview.UseVisualStyleBackColor = true;
            this.btn_AddReview.Click += new System.EventHandler(this.btn_AddReview_Click);
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 677);
            this.Controls.Add(this.btn_AddReview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gv_UserBooks);
            this.Controls.Add(this.gv_Available);
            this.Name = "UserMain";
            this.Text = "UserMain";
            this.Load += new System.EventHandler(this.UserMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Available)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Available;
        private System.Windows.Forms.DataGridView gv_UserBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddReview;
    }
}