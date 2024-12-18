namespace Project_4
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.txt_emp_id = new System.Windows.Forms.TextBox();
            this.txt_emp_sal = new System.Windows.Forms.TextBox();
            this.date_emp = new System.Windows.Forms.DateTimePicker();
            this.combo_emb_dpt = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_status = new System.Windows.Forms.ComboBox();
            this.combo_address = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat-Arabic Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(374, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "جديد";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(644, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم الموظف";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(647, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "رقم الموظف";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(652, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "تاريخ الميلاد";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(652, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "الراتب الشهري";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(652, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "رقم القسم";
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.Location = new System.Drawing.Point(513, 37);
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.Size = new System.Drawing.Size(122, 23);
            this.txt_emp_name.TabIndex = 2;
            this.txt_emp_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_emp_id
            // 
            this.txt_emp_id.Location = new System.Drawing.Point(513, 79);
            this.txt_emp_id.Name = "txt_emp_id";
            this.txt_emp_id.Size = new System.Drawing.Size(122, 23);
            this.txt_emp_id.TabIndex = 2;
            // 
            // txt_emp_sal
            // 
            this.txt_emp_sal.Location = new System.Drawing.Point(513, 163);
            this.txt_emp_sal.Name = "txt_emp_sal";
            this.txt_emp_sal.Size = new System.Drawing.Size(122, 23);
            this.txt_emp_sal.TabIndex = 2;
            // 
            // date_emp
            // 
            this.date_emp.CalendarFont = new System.Drawing.Font("Montserrat-Arabic", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_emp.Font = new System.Drawing.Font("Montserrat-Arabic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_emp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_emp.Location = new System.Drawing.Point(513, 124);
            this.date_emp.Name = "date_emp";
            this.date_emp.Size = new System.Drawing.Size(122, 21);
            this.date_emp.TabIndex = 3;
            // 
            // combo_emb_dpt
            // 
            this.combo_emb_dpt.FormattingEnabled = true;
            this.combo_emb_dpt.Location = new System.Drawing.Point(513, 208);
            this.combo_emb_dpt.Name = "combo_emb_dpt";
            this.combo_emb_dpt.Size = new System.Drawing.Size(122, 29);
            this.combo_emb_dpt.TabIndex = 4;
            this.combo_emb_dpt.SelectedIndexChanged += new System.EventHandler(this.combo_emb_dpt_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Montserrat-Arabic Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(448, 278);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "إضافة";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Montserrat-Arabic Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(522, 278);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 29);
            this.button3.TabIndex = 0;
            this.button3.Text = "تعديل";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Montserrat-Arabic Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(596, 278);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 29);
            this.button4.TabIndex = 0;
            this.button4.Text = "حذف";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(358, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "عنوان الموظف";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(369, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "حالة الموظف";
            // 
            // combo_status
            // 
            this.combo_status.FormattingEnabled = true;
            this.combo_status.Location = new System.Drawing.Point(227, 82);
            this.combo_status.Name = "combo_status";
            this.combo_status.Size = new System.Drawing.Size(122, 29);
            this.combo_status.TabIndex = 4;
            // 
            // combo_address
            // 
            this.combo_address.FormattingEnabled = true;
            this.combo_address.Location = new System.Drawing.Point(227, 37);
            this.combo_address.Name = "combo_address";
            this.combo_address.Size = new System.Drawing.Size(122, 29);
            this.combo_address.TabIndex = 4;
            this.combo_address.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 727);
            this.Controls.Add(this.combo_address);
            this.Controls.Add(this.combo_status);
            this.Controls.Add(this.combo_emb_dpt);
            this.Controls.Add(this.date_emp);
            this.Controls.Add(this.txt_emp_sal);
            this.Controls.Add(this.txt_emp_id);
            this.Controls.Add(this.txt_emp_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Montserrat-Arabic Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_emp_name;
        private System.Windows.Forms.TextBox txt_emp_id;
        private System.Windows.Forms.TextBox txt_emp_sal;
        private System.Windows.Forms.DateTimePicker date_emp;
        private System.Windows.Forms.ComboBox combo_emb_dpt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_status;
        private System.Windows.Forms.ComboBox combo_address;
    }
}

