using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label0.Text = "Амперы(I)";
            label00.Text = "Вольты(U)";
            label.Text = "Результат: ";
            labelt.Text = "Введите потребление напряжение(U) и силы тока(I) для каждого электроприбора.";
            button1.Text = "Вычислить";
            button2.Text = "Добавить элемент";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int y = 88, yf = 160, yb = 80, yl = 91, i = 1;

        private void textBox000_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label.Text = "Результат: ";
            Form f = ((Button)sender).FindForm();
            for (int n = 0; n < i; n++)//0...23
            {
                    string s = Convert.ToString(n);
                    TextBox tb2 = (TextBox)(from t in this.Controls.OfType<TextBox>() where t.Name == "textBox" + s select t).First();
                    string st2 = tb2.Text;
                    TextBox tb1 = (TextBox)(from t in this.Controls.OfType<TextBox>() where t.Name == "textBox" + s + s select t).First();
                    string st1 = tb1.Text;
                    label.Text = label.Text + Convert.ToString(Class1.R(Convert.ToDouble(st1), Convert.ToDouble(st2)));
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = Convert.ToString(i);
            TextBox text = new TextBox();yb += 50;
            text.Location = new Point(13, y);
            text.Size = new Size(196, 20);
            text.Name = "textBox" + s + s + s;
            this.Controls.Add(text);
            text = new TextBox();
            text.Location = new Point(300, y);
            text.Size = new Size(60, 20);
            text.Name = "textBox" + s + s;
            this.Controls.Add(text);
            text = new TextBox();
            text.Location = new Point(450, y);
            text.Size = new Size(60, 20);
            text.Name = "textBox" + s;
            this.Controls.Add(text);
            Label label = new Label();
            label.Location = new Point(230, yl);
            label.Name = "textBox" + s;
            label.Text = "Амперы(I)";
            this.Controls.Add(label); 
            label = new Label();
            label.Location = new Point(380, yl);
            label.Name = "textBox" + s + s;
            label.Text = "Вольты(U)";
            this.Controls.Add(label);
            this.button1.Location = new Point(275,yb);
            this.button2.Location = new Point(365,yb);
            this.label.Location = new Point(12,yb+5);
            this.ClientSize = new Size(525,yf); yf += 50;y += 50; yl += 50;
        }
    }
}
