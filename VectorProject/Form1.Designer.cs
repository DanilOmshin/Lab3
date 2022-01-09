
namespace VectorProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Len1Label = new System.Windows.Forms.Label();
            this.V1LenButton = new System.Windows.Forms.Button();
            this.Z1tb = new System.Windows.Forms.TextBox();
            this.Y1tb = new System.Windows.Forms.TextBox();
            this.X1tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Len2Label = new System.Windows.Forms.Label();
            this.Z2tb = new System.Windows.Forms.TextBox();
            this.V2LenButton = new System.Windows.Forms.Button();
            this.Y2tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.X2tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ScalarResLabel = new System.Windows.Forms.Label();
            this.LenResLabel = new System.Windows.Forms.Label();
            this.ZRtb = new System.Windows.Forms.TextBox();
            this.YRtb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.XRtb = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DiffButton = new System.Windows.Forms.Button();
            this.MultButton = new System.Windows.Forms.Button();
            this.ScalarButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Len1Label);
            this.groupBox1.Controls.Add(this.V1LenButton);
            this.groupBox1.Controls.Add(this.Z1tb);
            this.groupBox1.Controls.Add(this.Y1tb);
            this.groupBox1.Controls.Add(this.X1tb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вектор 1";
            // 
            // Len1Label
            // 
            this.Len1Label.AutoSize = true;
            this.Len1Label.Location = new System.Drawing.Point(111, 73);
            this.Len1Label.Name = "Len1Label";
            this.Len1Label.Size = new System.Drawing.Size(87, 13);
            this.Len1Label.TabIndex = 23;
            this.Len1Label.Text = "Длина вектора:";
            // 
            // V1LenButton
            // 
            this.V1LenButton.Location = new System.Drawing.Point(111, 21);
            this.V1LenButton.Name = "V1LenButton";
            this.V1LenButton.Size = new System.Drawing.Size(100, 23);
            this.V1LenButton.TabIndex = 22;
            this.V1LenButton.Text = "Длина вектора";
            this.V1LenButton.UseVisualStyleBackColor = true;
            this.V1LenButton.Click += new System.EventHandler(this.V1LenButton_Click);
            // 
            // Z1tb
            // 
            this.Z1tb.Location = new System.Drawing.Point(26, 73);
            this.Z1tb.Name = "Z1tb";
            this.Z1tb.Size = new System.Drawing.Size(79, 20);
            this.Z1tb.TabIndex = 5;
            this.Z1tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coeffsTB_KeyPress);
            // 
            // Y1tb
            // 
            this.Y1tb.Location = new System.Drawing.Point(26, 47);
            this.Y1tb.Name = "Y1tb";
            this.Y1tb.Size = new System.Drawing.Size(79, 20);
            this.Y1tb.TabIndex = 4;
            this.Y1tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coeffsTB_KeyPress);
            // 
            // X1tb
            // 
            this.X1tb.Location = new System.Drawing.Point(26, 21);
            this.X1tb.Name = "X1tb";
            this.X1tb.Size = new System.Drawing.Size(79, 20);
            this.X1tb.TabIndex = 3;
            this.X1tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coeffsTB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Len2Label);
            this.groupBox2.Controls.Add(this.Z2tb);
            this.groupBox2.Controls.Add(this.V2LenButton);
            this.groupBox2.Controls.Add(this.Y2tb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.X2tb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вектор 2";
            // 
            // Len2Label
            // 
            this.Len2Label.AutoSize = true;
            this.Len2Label.Location = new System.Drawing.Point(112, 82);
            this.Len2Label.Name = "Len2Label";
            this.Len2Label.Size = new System.Drawing.Size(87, 13);
            this.Len2Label.TabIndex = 25;
            this.Len2Label.Text = "Длина вектора:";
            // 
            // Z2tb
            // 
            this.Z2tb.Location = new System.Drawing.Point(27, 82);
            this.Z2tb.Name = "Z2tb";
            this.Z2tb.Size = new System.Drawing.Size(79, 20);
            this.Z2tb.TabIndex = 11;
            this.Z2tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coeffsTB_KeyPress);
            // 
            // V2LenButton
            // 
            this.V2LenButton.Location = new System.Drawing.Point(112, 30);
            this.V2LenButton.Name = "V2LenButton";
            this.V2LenButton.Size = new System.Drawing.Size(100, 23);
            this.V2LenButton.TabIndex = 24;
            this.V2LenButton.Text = "Длина вектора";
            this.V2LenButton.UseVisualStyleBackColor = true;
            this.V2LenButton.Click += new System.EventHandler(this.V2LenButton_Click);
            // 
            // Y2tb
            // 
            this.Y2tb.Location = new System.Drawing.Point(27, 56);
            this.Y2tb.Name = "Y2tb";
            this.Y2tb.Size = new System.Drawing.Size(79, 20);
            this.Y2tb.TabIndex = 10;
            this.Y2tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coeffsTB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "X";
            // 
            // X2tb
            // 
            this.X2tb.Location = new System.Drawing.Point(27, 30);
            this.X2tb.Name = "X2tb";
            this.X2tb.Size = new System.Drawing.Size(79, 20);
            this.X2tb.TabIndex = 9;
            this.X2tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coeffsTB_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Z";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ScalarResLabel);
            this.groupBox3.Controls.Add(this.LenResLabel);
            this.groupBox3.Controls.Add(this.ZRtb);
            this.groupBox3.Controls.Add(this.YRtb);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.XRtb);
            this.groupBox3.Location = new System.Drawing.Point(301, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 157);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вектор-результат";
            // 
            // ScalarResLabel
            // 
            this.ScalarResLabel.AutoSize = true;
            this.ScalarResLabel.Location = new System.Drawing.Point(6, 136);
            this.ScalarResLabel.Name = "ScalarResLabel";
            this.ScalarResLabel.Size = new System.Drawing.Size(140, 13);
            this.ScalarResLabel.TabIndex = 27;
            this.ScalarResLabel.Text = "Скалярное произведение:";
            // 
            // LenResLabel
            // 
            this.LenResLabel.AutoSize = true;
            this.LenResLabel.Location = new System.Drawing.Point(6, 110);
            this.LenResLabel.Name = "LenResLabel";
            this.LenResLabel.Size = new System.Drawing.Size(87, 13);
            this.LenResLabel.TabIndex = 26;
            this.LenResLabel.Text = "Длина вектора:";
            // 
            // ZRtb
            // 
            this.ZRtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZRtb.Location = new System.Drawing.Point(25, 77);
            this.ZRtb.Name = "ZRtb";
            this.ZRtb.ReadOnly = true;
            this.ZRtb.Size = new System.Drawing.Size(79, 20);
            this.ZRtb.TabIndex = 17;
            this.ZRtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coeffsTB_KeyPress);
            // 
            // YRtb
            // 
            this.YRtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YRtb.Location = new System.Drawing.Point(25, 51);
            this.YRtb.Name = "YRtb";
            this.YRtb.ReadOnly = true;
            this.YRtb.Size = new System.Drawing.Size(79, 20);
            this.YRtb.TabIndex = 16;
            this.YRtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coeffsTB_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Y";
            // 
            // XRtb
            // 
            this.XRtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.XRtb.Location = new System.Drawing.Point(26, 25);
            this.XRtb.Name = "XRtb";
            this.XRtb.ReadOnly = true;
            this.XRtb.Size = new System.Drawing.Size(79, 20);
            this.XRtb.TabIndex = 15;
            this.XRtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coeffsTB_KeyPress);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(301, 235);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(146, 23);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Сложение векторов";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DiffButton
            // 
            this.DiffButton.Location = new System.Drawing.Point(301, 177);
            this.DiffButton.Name = "DiffButton";
            this.DiffButton.Size = new System.Drawing.Size(146, 23);
            this.DiffButton.TabIndex = 19;
            this.DiffButton.Text = "Вычитание векторов";
            this.DiffButton.UseVisualStyleBackColor = true;
            this.DiffButton.Click += new System.EventHandler(this.DiffButton_Click);
            // 
            // MultButton
            // 
            this.MultButton.Location = new System.Drawing.Point(301, 206);
            this.MultButton.Name = "MultButton";
            this.MultButton.Size = new System.Drawing.Size(146, 23);
            this.MultButton.TabIndex = 20;
            this.MultButton.Text = "Произведение векторов";
            this.MultButton.UseVisualStyleBackColor = true;
            this.MultButton.Click += new System.EventHandler(this.MultButton_Click);
            // 
            // ScalarButton
            // 
            this.ScalarButton.Location = new System.Drawing.Point(301, 264);
            this.ScalarButton.Name = "ScalarButton";
            this.ScalarButton.Size = new System.Drawing.Size(146, 23);
            this.ScalarButton.TabIndex = 21;
            this.ScalarButton.Text = "Скалярное произведение";
            this.ScalarButton.UseVisualStyleBackColor = true;
            this.ScalarButton.Click += new System.EventHandler(this.ScalarButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(453, 180);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(95, 107);
            this.ClearButton.TabIndex = 22;
            this.ClearButton.Text = "Очистить все";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 294);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ScalarButton);
            this.Controls.Add(this.MultButton);
            this.Controls.Add(this.DiffButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Калькулятор векторов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Z1tb;
        private System.Windows.Forms.TextBox Y1tb;
        private System.Windows.Forms.TextBox X1tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Z2tb;
        private System.Windows.Forms.TextBox Y2tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox X2tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Len1Label;
        private System.Windows.Forms.Label Len2Label;
        private System.Windows.Forms.TextBox ZRtb;
        private System.Windows.Forms.TextBox YRtb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox XRtb;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DiffButton;
        private System.Windows.Forms.Button MultButton;
        private System.Windows.Forms.Button ScalarButton;
        private System.Windows.Forms.Label ScalarResLabel;
        private System.Windows.Forms.Label LenResLabel;
        private System.Windows.Forms.Button V1LenButton;
        private System.Windows.Forms.Button V2LenButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

