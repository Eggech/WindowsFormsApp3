namespace WindowsFormsApp3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox000 = new System.Windows.Forms.TextBox();
            this.textBox00 = new System.Windows.Forms.TextBox();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.label00 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox000
            // 
            this.textBox000.Location = new System.Drawing.Point(13, 38);
            this.textBox000.Name = "textBox000";
            this.textBox000.Size = new System.Drawing.Size(196, 20);
            this.textBox000.TabIndex = 2;
            this.textBox000.TextChanged += new System.EventHandler(this.textBox000_TextChanged);
            // 
            // textBox00
            // 
            this.textBox00.Location = new System.Drawing.Point(300, 38);
            this.textBox00.Name = "textBox00";
            this.textBox00.Size = new System.Drawing.Size(60, 20);
            this.textBox00.TabIndex = 3;
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(450, 38);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(60, 20);
            this.textBox0.TabIndex = 4;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(230, 41);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(35, 13);
            this.label0.TabIndex = 5;
            this.label0.Text = "label1";
            // 
            // label00
            // 
            this.label00.AutoSize = true;
            this.label00.Location = new System.Drawing.Point(380, 41);
            this.label00.Name = "label00";
            this.label00.Size = new System.Drawing.Size(35, 13);
            this.label00.TabIndex = 6;
            this.label00.Text = "label2";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 85);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 7;
            this.label.Text = "label3";
            // 
            // labelt
            // 
            this.labelt.AutoSize = true;
            this.labelt.Location = new System.Drawing.Point(13, 13);
            this.labelt.Name = "labelt";
            this.labelt.Size = new System.Drawing.Size(35, 13);
            this.labelt.TabIndex = 8;
            this.labelt.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 111);
            this.Controls.Add(this.labelt);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label00);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.textBox00);
            this.Controls.Add(this.textBox000);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Калькулятор расчета сопротивления электроцепи.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox000;
        private System.Windows.Forms.TextBox textBox00;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label00;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelt;
    }
}

