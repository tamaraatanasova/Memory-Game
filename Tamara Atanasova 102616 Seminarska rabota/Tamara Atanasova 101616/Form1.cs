using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamara_Atanasova_101616
{

    public partial class Form1 : Form
    {
        private int vreme = 150;
        private int rezultat = 0;
        
        List<Point> points = new List<Point>();
        Button prva = new Button();
        Button vtora = new Button();
        private Color boja = Color.DodgerBlue;
        public Form1()
        {
            InitializeComponent();
            prva = null;
            vtora = null;
        }
        private Button[] buttons
        {
            get { return panel1.Controls.OfType<Button>().ToArray(); }
        }

        private void proverka(Button btn)
        {
            if (prva == null && vtora == null)
            {
                prva = btn;
                prva.Enabled = false;
            }
            else if (prva != null && vtora == null)
            {
                vtora = btn;
                if (prva.Tag == vtora.Tag)
                {
                    prva.BackColor = Color.Green;
                    vtora.BackColor = Color.Green;
                    prva.Enabled = false;
                    vtora.Enabled = false;
                    prva = null;
                    vtora = null;
                    rezultat++;

                }
                else if (prva.Tag != vtora.Tag)
                {
                    prva.BackColor = Color.Red;
                    vtora.BackColor = Color.Red;
                    timer2.Start();

                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            vreme--;
            label1.Text = @"Преостанато време: " + vreme.ToString();
            label2.Text = @"Резултат: " + rezultat.ToString();
            if (vreme == 0)
            {
                timer1.Stop();
                MessageBox.Show("Вашето време истече!\r\nПовеќе среќа наредниот пат!");
            }
            if (rezultat == 18)
            {
                timer1.Stop();
                if(vreme>=75)
                {
                    MessageBox.Show("Честитки\r\nИмаш одлична меморија");
                }
                else
                {
                    MessageBox.Show("Честитки! Успешно завршена игра");
                }

            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Button b in buttons)
            {
                b.Enabled = false;
                points.Add(b.Location);
            }
            Random lokacija = new Random();
            foreach (Button b in buttons)
            {
                int next = lokacija.Next(points.Count);
                Point p = points[next];
                b.Location = p;
                points.Remove(p);
            }
        }

        
        private void button37_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button37.Enabled = false;
            button37.Cursor = Cursors.No;
            foreach (Button b in buttons)
            {
                b.Enabled = true;
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            b13.BackgroundImage = Properties.Resources.ikona7;
            proverka(b13);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            b14.BackgroundImage = Properties.Resources.ikona7;
            proverka(b14);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            b15.BackgroundImage = Properties.Resources.ikona8;
            proverka(b15);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            b16.BackgroundImage = Properties.Resources.ikona8;
            proverka(b16);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            b17.BackgroundImage = Properties.Resources.ikona9;
            proverka(b17);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            b18.BackgroundImage = Properties.Resources.ikona9;
            proverka(b18);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            b24.BackgroundImage = Properties.Resources.ikona12;
            proverka(b24);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            b23.BackgroundImage = Properties.Resources.ikona12;
            proverka(b23);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            b22.BackgroundImage = Properties.Resources.ikona11;
            proverka(b22);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            b21.BackgroundImage = Properties.Resources.ikona11;
            proverka(b21);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            b20.BackgroundImage = Properties.Resources.ikona10;
            proverka(b20);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            b19.BackgroundImage = Properties.Resources.ikona10;
            proverka(b19);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            b25.BackgroundImage = Properties.Resources.ikona13;
            proverka(b25);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            b26.BackgroundImage = Properties.Resources.ikona13;
            proverka(b26);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            b27.BackgroundImage = Properties.Resources.ikona14;
            proverka(b27);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            b28.BackgroundImage = Properties.Resources.ikona14;
            proverka(b28);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            b29.BackgroundImage = Properties.Resources.ikona15;
            proverka(b29);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            b30.BackgroundImage = Properties.Resources.ikona15;
            proverka(b30);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            b36.BackgroundImage = Properties.Resources.ikona18;
            proverka(b36);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            b35.BackgroundImage = Properties.Resources.ikona18;
            proverka(b35);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            b34.BackgroundImage = Properties.Resources.ikona17;
            proverka(b34);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            b33.BackgroundImage = Properties.Resources.ikona17;
            proverka(b33);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            b32.BackgroundImage = Properties.Resources.ikona16;
            proverka(b32);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            b31.BackgroundImage = Properties.Resources.ikona16;
            proverka(b31);

        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.BackgroundImage = Properties.Resources.ikona1;
            proverka(b2);

        }

        private void b1_Click(object sender, EventArgs e)
        {
            b1.BackgroundImage = Properties.Resources.ikona1;
            proverka(b1);

        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.BackgroundImage = Properties.Resources.ikona2;
            proverka(b3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            b4.BackgroundImage = Properties.Resources.ikona2;
            proverka(b4);

        }

        private void b5_Click(object sender, EventArgs e)
        {
            b5.BackgroundImage = Properties.Resources.ikona3;
            proverka(b5);

        }

        private void b6_Click(object sender, EventArgs e)
        {
            b6.BackgroundImage = Properties.Resources.ikona3;
            proverka(b6);

        }

        private void b7_Click(object sender, EventArgs e)
        {
            b7.BackgroundImage = Properties.Resources.ikona4;
            proverka(b7);

        }

        private void b8_Click(object sender, EventArgs e)
        {
            b8.BackgroundImage = Properties.Resources.ikona4;
            proverka(b8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            b9.BackgroundImage = Properties.Resources.icona5;
            proverka(b9);

        }

        private void b10_Click(object sender, EventArgs e)
        {
            b10.BackgroundImage = Properties.Resources.icona5;
            proverka(b10);

        }

        private void b11_Click(object sender, EventArgs e)
        {
            b11.BackgroundImage = Properties.Resources.ikona6;
            proverka(b11);

        }

        private void b12_Click(object sender, EventArgs e)
        {
            b12.BackgroundImage = Properties.Resources.ikona6;
            proverka(b12);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            prva.BackColor = Color.DodgerBlue;
            vtora.BackColor = Color.DodgerBlue;
            prva.BackgroundImage = Properties.Resources.prva;
            vtora.BackgroundImage = Properties.Resources.prva;
            prva.Enabled = true;
            prva= null;
            vtora = null;
        }

    }
}
