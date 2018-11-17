using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            draw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        //For Countdown
        int h = 0, m = 0, s = 0;


        //Start
        private void button1_Click(object sender, EventArgs e) {
            timer1.Enabled = true;
            timer2.Enabled = false;
            draw();
        }

        //Pause
        private void button2_Click(object sender, EventArgs e) {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        //Set Time
        private void button3_Click(object sender, EventArgs e) {
            timer1.Enabled = false;
            timer2.Enabled = true;
            h = Int32.Parse(textBox1.Text);
            m = Int32.Parse(textBox2.Text);
            s = Int32.Parse(textBox3.Text);           
        }

        //Reset
        private void button4_Click(object sender, EventArgs e) {
           
            timer1.Enabled = false;
            timer2.Enabled = false;
            label1.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            h = 0;
            m = 0;
            s = 0;
            draw();
            //Application.Restart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //Positive Timer
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (s == 59)
            {
                if (m == 59)
                {
                        s = 0;
                        m = 0;
                        h++;
                        draw();
                }
                else
                {
                    s = 0;
                    m++;
                    draw();
                }
            }
            else
            {
                s++;
                draw();
            }

        }
          


        //Negative Timer
        private void timer2_Tick(object sender, EventArgs e) {

            if (s == 0)
            {
                if (m == 0)
                {
                    if (h == 0)
                    {
                        timer2.Enabled = false;
                        MessageBox.Show("Time's up!");
                    }
                    else
                    {
                        h--;
                        m = 59;
                        s = 59;
                        draw();
                    }
                }
                else
                {
                    m--;
                    s = 59;
                    draw();
                }
            }
            else
            {
                s--;
                draw();
            }
            
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }
        
        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        void draw()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);

            double pie = Math.PI;
            

            g.DrawEllipse(new Pen(Color.Black), 15, 45, 150, 150);
            g.FillEllipse(new SolidBrush(Color.Black), 85, 117, 10, 10);
            g.DrawLine(new Pen(Color.Blue), new Point(90, 120), new Point((int)(90 + 70 * Math.Sin(6 * (pie / 180) * h)), (int)(120 - 70 * Math.Cos(6 * (pie / 180) * h))));
            g.DrawString("0", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(85, 120 - 70));
            g.DrawString("15", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(90 + 70 - 17, 115));
            g.DrawString("30", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(85, 120 + 70 - 17));
            g.DrawString("45", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(90 - 70, 115));

            g.DrawEllipse(new Pen(Color.Black), 225, 45, 150, 150);
            g.FillEllipse(new SolidBrush(Color.Black), 295, 117, 10, 10);
            g.DrawLine(new Pen(Color.Blue), new Point(300, 120), new Point((int)(300 + 70 * Math.Sin(6 * (pie / 180) * m)), (int)(120 - 70 * Math.Cos(6 * (pie / 180) * m))));
            g.DrawString("0", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(295, 120 - 70));
            g.DrawString("15", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(300 + 70 - 17, 115));
            g.DrawString("30", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(295, 120 + 70 - 17));
            g.DrawString("45", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(300 - 70, 115));

            g.DrawEllipse(new Pen(Color.Black), 425, 45, 150, 150);
            g.FillEllipse(new SolidBrush(Color.Black), 495, 117, 10, 10);
            g.DrawLine(new Pen(Color.Blue), new Point(500, 120), new Point((int)(500 + 70 * Math.Sin(6 * (pie / 180) * s)), (int)(120 - 70 * Math.Cos(6 * (pie / 180) * s))));
            g.DrawString("0", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(495, 120 - 70));
            g.DrawString("15", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(500 + 70 - 17, 115));
            g.DrawString("30", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(495, 120 + 70 - 17));
            g.DrawString("45", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(500 - 70, 115));

            label1.Text = h.ToString();
            label3.Text = m.ToString();
            label4.Text = s.ToString();

        }



    }
}
