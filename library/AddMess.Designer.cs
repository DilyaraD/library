namespace library
{
    partial class AddMess
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
            this.button_auth = new System.Windows.Forms.Button();
            this.button_book = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_auth
            // 
            this.button_auth.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_auth.Location = new System.Drawing.Point(64, 160);
            this.button_auth.Name = "button_auth";
            this.button_auth.Size = new System.Drawing.Size(138, 50);
            this.button_auth.TabIndex = 0;
            this.button_auth.Text = "читатель";
            this.button_auth.UseVisualStyleBackColor = true;
            this.button_auth.Click += new System.EventHandler(this.button_auth_Click);
            // 
            // button_book
            // 
            this.button_book.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_book.Location = new System.Drawing.Point(219, 159);
            this.button_book.Name = "button_book";
            this.button_book.Size = new System.Drawing.Size(126, 51);
            this.button_book.TabIndex = 1;
            this.button_book.Text = "книга";
            this.button_book.UseVisualStyleBackColor = true;
            this.button_book.Click += new System.EventHandler(this.button_book_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 84);
            this.label1.TabIndex = 2;
            this.label1.Text = "Какие данные \r\nхотите добавить?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddMess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_book);
            this.Controls.Add(this.button_auth);
            this.Name = "AddMess";
            this.Text = "AddMess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_auth;
        private System.Windows.Forms.Button button_book;
        private System.Windows.Forms.Label label1;
    }
}