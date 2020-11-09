namespace exercise_6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1_test1 = new System.Windows.Forms.Button();
            this.button2_test2 = new System.Windows.Forms.Button();
            this.button3_test3 = new System.Windows.Forms.Button();
            this.button4_test4 = new System.Windows.Forms.Button();
            this.button5_test5 = new System.Windows.Forms.Button();
            this.button6_test6 = new System.Windows.Forms.Button();
            this.button_Parser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_parseTiming = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Verification = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_test1
            // 
            this.button1_test1.Location = new System.Drawing.Point(23, 12);
            this.button1_test1.Name = "button1_test1";
            this.button1_test1.Size = new System.Drawing.Size(109, 35);
            this.button1_test1.TabIndex = 0;
            this.button1_test1.Text = "Test 1";
            this.button1_test1.UseVisualStyleBackColor = true;
            this.button1_test1.Click += new System.EventHandler(this.button1_test1_Click);
            // 
            // button2_test2
            // 
            this.button2_test2.Location = new System.Drawing.Point(23, 53);
            this.button2_test2.Name = "button2_test2";
            this.button2_test2.Size = new System.Drawing.Size(109, 35);
            this.button2_test2.TabIndex = 1;
            this.button2_test2.Text = "Test 2";
            this.button2_test2.UseVisualStyleBackColor = true;
            this.button2_test2.Click += new System.EventHandler(this.button2_test2_Click);
            // 
            // button3_test3
            // 
            this.button3_test3.Location = new System.Drawing.Point(23, 94);
            this.button3_test3.Name = "button3_test3";
            this.button3_test3.Size = new System.Drawing.Size(109, 35);
            this.button3_test3.TabIndex = 2;
            this.button3_test3.Text = "Test 3";
            this.button3_test3.UseVisualStyleBackColor = true;
            this.button3_test3.Click += new System.EventHandler(this.button3_test3_Click);
            // 
            // button4_test4
            // 
            this.button4_test4.Location = new System.Drawing.Point(23, 135);
            this.button4_test4.Name = "button4_test4";
            this.button4_test4.Size = new System.Drawing.Size(109, 35);
            this.button4_test4.TabIndex = 3;
            this.button4_test4.Text = "Test 4";
            this.button4_test4.UseVisualStyleBackColor = true;
            this.button4_test4.Click += new System.EventHandler(this.button4_test4_Click);
            // 
            // button5_test5
            // 
            this.button5_test5.Location = new System.Drawing.Point(23, 176);
            this.button5_test5.Name = "button5_test5";
            this.button5_test5.Size = new System.Drawing.Size(109, 35);
            this.button5_test5.TabIndex = 4;
            this.button5_test5.Text = "Test 5";
            this.button5_test5.UseVisualStyleBackColor = true;
            this.button5_test5.Click += new System.EventHandler(this.button5_test5_Click);
            // 
            // button6_test6
            // 
            this.button6_test6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6_test6.ForeColor = System.Drawing.Color.Red;
            this.button6_test6.Location = new System.Drawing.Point(23, 217);
            this.button6_test6.Name = "button6_test6";
            this.button6_test6.Size = new System.Drawing.Size(109, 35);
            this.button6_test6.TabIndex = 5;
            this.button6_test6.Text = "Test 6";
            this.button6_test6.UseVisualStyleBackColor = true;
            this.button6_test6.Click += new System.EventHandler(this.button6_test6_Click);
            // 
            // button_Parser
            // 
            this.button_Parser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Parser.Location = new System.Drawing.Point(12, 275);
            this.button_Parser.Name = "button_Parser";
            this.button_Parser.Size = new System.Drawing.Size(134, 45);
            this.button_Parser.TabIndex = 6;
            this.button_Parser.Text = "HTML Parser";
            this.button_Parser.UseVisualStyleBackColor = true;
            this.button_Parser.Click += new System.EventHandler(this.button_Parser_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Време за Парсване";
            // 
            // label_parseTiming
            // 
            this.label_parseTiming.BackColor = System.Drawing.Color.White;
            this.label_parseTiming.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_parseTiming.Location = new System.Drawing.Point(12, 364);
            this.label_parseTiming.Name = "label_parseTiming";
            this.label_parseTiming.Size = new System.Drawing.Size(134, 23);
            this.label_parseTiming.TabIndex = 8;
            this.label_parseTiming.Text = "0";
            this.label_parseTiming.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(12, 404);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(134, 33);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "Нулиране";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_Verification
            // 
            this.button_Verification.Location = new System.Drawing.Point(12, 443);
            this.button_Verification.Name = "button_Verification";
            this.button_Verification.Size = new System.Drawing.Size(134, 33);
            this.button_Verification.TabIndex = 10;
            this.button_Verification.Text = "Structural Verification";
            this.button_Verification.UseVisualStyleBackColor = true;
            this.button_Verification.Click += new System.EventHandler(this.button_Verification_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(152, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(251, 428);
            this.textBox1.TabIndex = 11;
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(152, 443);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(251, 33);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(317, 464);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(739, 482);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Verification);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label_parseTiming);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Parser);
            this.Controls.Add(this.button6_test6);
            this.Controls.Add(this.button5_test5);
            this.Controls.Add(this.button4_test4);
            this.Controls.Add(this.button3_test3);
            this.Controls.Add(this.button2_test2);
            this.Controls.Add(this.button1_test1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Павел Диянов Първанов ф.н.17621736 СИТ Курс: 4 Група: 2Б";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_test1;
        private System.Windows.Forms.Button button2_test2;
        private System.Windows.Forms.Button button3_test3;
        private System.Windows.Forms.Button button4_test4;
        private System.Windows.Forms.Button button5_test5;
        private System.Windows.Forms.Button button6_test6;
        private System.Windows.Forms.Button button_Parser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_parseTiming;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Verification;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

