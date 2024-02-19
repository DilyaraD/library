namespace library
{
    partial class BorrBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_brdate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_rdate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_give = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button_poisk = new System.Windows.Forms.Button();
            this.button_find = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(362, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выдача книг читателю";
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(12, 624);
            this.button_back.Margin = new System.Windows.Forms.Padding(2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(90, 32);
            this.button_back.TabIndex = 28;
            this.button_back.Text = "назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(31, 118);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(268, 22);
            this.textBox_title.TabIndex = 30;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(668, 118);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(268, 22);
            this.textBox_name.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(817, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "выдан с ";
            // 
            // label_brdate
            // 
            this.label_brdate.AutoSize = true;
            this.label_brdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_brdate.Location = new System.Drawing.Point(917, 38);
            this.label_brdate.Name = "label_brdate";
            this.label_brdate.Size = new System.Drawing.Size(56, 22);
            this.label_brdate.TabIndex = 33;
            this.label_brdate.Text = "дата1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1066, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "по";
            // 
            // label_rdate
            // 
            this.label_rdate.AutoSize = true;
            this.label_rdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rdate.Location = new System.Drawing.Point(1108, 38);
            this.label_rdate.Name = "label_rdate";
            this.label_rdate.Size = new System.Drawing.Size(56, 22);
            this.label_rdate.TabIndex = 35;
            this.label_rdate.Text = "дата2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(665, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "имя и фамилия читателя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(28, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "название книги";
            // 
            // button_give
            // 
            this.button_give.BackColor = System.Drawing.Color.Firebrick;
            this.button_give.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_give.Location = new System.Drawing.Point(596, 578);
            this.button_give.Name = "button_give";
            this.button_give.Size = new System.Drawing.Size(141, 45);
            this.button_give.TabIndex = 38;
            this.button_give.Text = "выдать книгу";
            this.button_give.UseVisualStyleBackColor = false;
            this.button_give.Click += new System.EventHandler(this.button_give_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(31, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 290);
            this.listBox1.TabIndex = 39;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(351, 287);
            this.dataGridView1.TabIndex = 42;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(917, 156);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(351, 287);
            this.dataGridView2.TabIndex = 44;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 22;
            this.listBox2.Location = new System.Drawing.Point(668, 156);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(233, 290);
            this.listBox2.TabIndex = 43;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button_poisk
            // 
            this.button_poisk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_poisk.Location = new System.Drawing.Point(336, 113);
            this.button_poisk.Name = "button_poisk";
            this.button_poisk.Size = new System.Drawing.Size(75, 30);
            this.button_poisk.TabIndex = 45;
            this.button_poisk.Text = "найти";
            this.button_poisk.UseVisualStyleBackColor = true;
            this.button_poisk.Click += new System.EventHandler(this.button_poisk_Click);
            // 
            // button_find
            // 
            this.button_find.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_find.Location = new System.Drawing.Point(960, 111);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(83, 35);
            this.button_find.TabIndex = 46;
            this.button_find.Text = "найти";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_title);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_rdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_brdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(31, 470);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1237, 92);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "данные";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 26);
            this.label6.TabIndex = 36;
            this.label6.Text = "Имя и Фамилия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(478, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 26);
            this.label7.TabIndex = 37;
            this.label7.Text = "Книга:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(184, 43);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(60, 22);
            this.label_name.TabIndex = 38;
            this.label_name.Text = "label8";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(560, 42);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(60, 22);
            this.label_title.TabIndex = 39;
            this.label_title.Text = "label8";
            // 
            // BorrBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 677);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.button_poisk);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_give);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label1);
            this.Name = "BorrBooks";
            this.Text = "BorrBooks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_brdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_rdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_give;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button_poisk;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_title;
    }
}