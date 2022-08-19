using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicTacToe
{
    public partial class Form1 : Form
    {
        static int say = 0;
        bool x1, x2, x3, x4, x5, x6, x7, x8, x9 = false;
        bool o1, o2, o3, o4, o5, o6, o7, o8, o9 = false;
        bool bitti = false;
        static int p1, p2 = 0;
        

        private void player1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1 = 0;p2 = 0;
            player1Score.Text = p1.ToString();
            player2Score.Text = p2.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region click events
        private void restartButton_Click(object sender, EventArgs e)
        {
            x1 = false;x2 = false;x3 = false;x4 = false;x5 = false;x6 = false;x7 = false;x8 = false;x9 = false;
            o1 = false;o2 = false;o3 = false;o4 = false;o5= false;o6 = false;o7 = false;o8 = false;x9 = false;
            bitti = false;
            say= 0;
            kare1.BackgroundImage = null;kare1.Enabled = true;
            kare2.BackgroundImage = null;kare2.Enabled = true;
            kare3.BackgroundImage = null;kare3.Enabled = true;
            kare4.BackgroundImage = null;kare4.Enabled = true;
            kare5.BackgroundImage = null;kare5.Enabled = true;
            kare6.BackgroundImage = null;kare6.Enabled = true;
            kare7.BackgroundImage = null;kare7.Enabled = true;
            kare8.BackgroundImage = null;kare8.Enabled = true;
            kare9.BackgroundImage = null;kare9.Enabled = true;

        }
        
        private void kare9_Click_1(object sender, EventArgs e)
        {
            if (say % 2 == 1)
            {
                kare9.BackgroundImage = Properties.Resources.o;
                kare9.BackgroundImageLayout = ImageLayout.Stretch;
                o9 = true;
                okazandi();
                say++;
                kare9.Enabled = false;
            }
            else
            {
                kare9.BackgroundImage = Properties.Resources.x;
                kare9.BackgroundImageLayout = ImageLayout.Stretch;
                x9 = true;
                xkazandi();
                say++;
                kare9.Enabled = false;
            }
        }

        private void kare8_Click_1(object sender, EventArgs e)
        {
            if (say % 2 == 1)
            {
                kare8.BackgroundImage = Properties.Resources.o;
                kare8.BackgroundImageLayout = ImageLayout.Stretch;
                o8 = true;
                okazandi();
                say++;
                kare8.Enabled = false;
            }
            else
            {
                kare8.BackgroundImage = Properties.Resources.x;
                kare8.BackgroundImageLayout = ImageLayout.Stretch;
                x8 = true;
                xkazandi();
                say++;
                kare8.Enabled = false;
            }
        }

        private void kare7_Click_1(object sender, EventArgs e)
        {
            if (say % 2 == 1)
            {
                kare7.BackgroundImage = Properties.Resources.o;
                kare7.BackgroundImageLayout = ImageLayout.Stretch;
                o7 = true;
                okazandi();
                say++;
                kare7.Enabled = false;
            }
            else
            {
                kare7.BackgroundImage = Properties.Resources.x;
                kare7.BackgroundImageLayout = ImageLayout.Stretch;
                x7 = true;
                xkazandi();
                say++;
                kare7.Enabled = false;
            }
        }

        private void kare6_Click(object sender, EventArgs e)
        {
            if (say % 2 == 1)
            {
                kare6.BackgroundImage = Properties.Resources.o;
                kare6.BackgroundImageLayout = ImageLayout.Stretch;
                o6 = true;
                okazandi();
                say++;
                kare6.Enabled = false;

            }
            else
            {
                kare6.BackgroundImage = Properties.Resources.x;
                kare6.BackgroundImageLayout = ImageLayout.Stretch;
                x6 = true;
                xkazandi();
                say++;
                kare6.Enabled=false;
            }
        }

        private void kare5_Click(object sender, EventArgs e)
        {
            if (say % 2 == 1)
            {
                kare5.BackgroundImage = Properties.Resources.o;
                kare5.BackgroundImageLayout = ImageLayout.Stretch;
                o5 = true;
                okazandi();
                say++;
                kare5.Enabled = false;
            }
            else
            {
                kare5.BackgroundImage = Properties.Resources.x;
                kare5.BackgroundImageLayout = ImageLayout.Stretch;
                x5 = true;
                xkazandi();
                say++;
                kare5.Enabled = false;
            }
        }

        private void kare4_Click(object sender, EventArgs e)
        {
            if (say % 2 == 1)
            {
                kare4.BackgroundImage = Properties.Resources.o;
                kare4.BackgroundImageLayout = ImageLayout.Stretch;
                o4 = true;
                okazandi();
                say++;
                kare4.Enabled = false;
            }
            else
            {
                kare4.BackgroundImage = Properties.Resources.x;
                kare4.BackgroundImageLayout = ImageLayout.Stretch;
                x4 = true;
                xkazandi();
                say++;
                kare4.Enabled = false;
            }
        }

        private void kare3_Click(object sender, EventArgs e)
        {
            if (say % 2 == 1)
            {
                kare3.BackgroundImage = Properties.Resources.o;
                kare3.BackgroundImageLayout = ImageLayout.Stretch;
                o3 = true;
                okazandi();
                say++;
                kare3.Enabled = false;
            }
            else
            {
                kare3.BackgroundImage = Properties.Resources.x;
                kare3.BackgroundImageLayout = ImageLayout.Stretch;
                x3 = true;
                xkazandi();
                say++;
                kare3.Enabled=false;
            }
        }

        private void kare2_Click(object sender, EventArgs e)
        {
            if (say % 2 == 1)
            {
                kare2.BackgroundImage = Properties.Resources.o;
                kare2.BackgroundImageLayout = ImageLayout.Stretch;
                o2 = true;
                okazandi();
                say++;
                kare2.Enabled = false;
            }
            else
            {
                kare2.BackgroundImage = Properties.Resources.x;
                kare2.BackgroundImageLayout = ImageLayout.Stretch;
                x2 = true;
                xkazandi();
                say++;
                kare2.Enabled = false;
            }
        }

        private void kare1_Click_1(object sender, EventArgs e)
        {
            if (say % 2 == 1)
            {
                kare1.BackgroundImage = Properties.Resources.o;
                kare1.BackgroundImageLayout = ImageLayout.Stretch;
                o1 = true;
                okazandi();
                say++;
                kare1.Enabled = false;
            }
            else
            {
                kare1.BackgroundImage = Properties.Resources.x;
                kare1.BackgroundImageLayout = ImageLayout.Stretch;
                x1 = true;
                say++;
                xkazandi();
                kare1.Enabled = false;
            }

        }
        #endregion
        public Form1()
        {
            InitializeComponent();
            player1.BackgroundImage = Properties.Resources.P1;
            player1.BackgroundImageLayout = ImageLayout.Stretch;
            player2.BackgroundImage=Properties.Resources.P2;
            player2.BackgroundImageLayout = ImageLayout.Stretch;
           
            
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region win events
        private void xkazandi()
        {
            if (x1 && x2 && x3 == true)
            {
                MessageBox.Show("First Player Win");
                p1++;
                player1Score.Text = p1.ToString();
                bitti = true;
            }
            else if(x1 && x5 && x9 == true)
            {
                MessageBox.Show("First Player Win");
                p1++;
                player1Score.Text = p1.ToString();
                bitti = true;
            }
            else if(x1&&x4 && x7 == true)
            {
                MessageBox.Show("First Player Win");
                p1++;
                player1Score.Text = p1.ToString();
                bitti = true;
            }
            else if(x2&&x5&&x8 == true)
            {
                MessageBox.Show("First Player Win");
                p1++;
                player1Score.Text = p1.ToString();
                bitti = true;
            }
            else if (x3 && x5 && x7 == true) { MessageBox.Show("First Player Win"); p1++; player1Score.Text = p1.ToString(); bitti = true; }
            else if(x3 && x6 && x9 == true) { MessageBox.Show("First Player Win"); p1++; player1Score.Text = p1.ToString(); bitti = true; }
            else if (x4 && x5 && x6 == true) { MessageBox.Show("First Player Win"); p1++; player1Score.Text = p1.ToString(); bitti = true;}
            else if (x7 && x8 && x9 == true) { MessageBox.Show("First Player Win"); p1++; player1Score.Text = p1.ToString(); bitti = true;}
            
        }
        private void okazandi()
        {
            if (o1 && o2 && o3 == true)
            {
                MessageBox.Show("Second Player Win");
                p2++;
                player2Score.Text = p2.ToString();
                bitti = true;
            }
            else if (o1 && o5 && o9 == true)
            {
                MessageBox.Show("Second Player Win");
                p2++;
                player2Score.Text = p2.ToString();
                bitti = true;
            }
            else if (o1 && o4 && o7 == true)
            {
                MessageBox.Show("Second Player Win");
                p2++;
                player2Score.Text = p2.ToString();
                bitti = true;
            }
            else if (o2 && o5 && o8 == true)
            {
                MessageBox.Show("Second Player Win");
                p2++;
                player2Score.Text = p2.ToString();
                bitti = true;
            }
            else if (o3 && o5 && o7 == true) { MessageBox.Show("Second Player Win"); p2++; player2Score.Text = p2.ToString(); bitti = true; }
            else if (o3 && o6 && o9 == true) { MessageBox.Show("Second Player Win"); p2++; player2Score.Text = p2.ToString(); bitti = true; }
            else if (o4 && o5 && o6 == true) { MessageBox.Show("Second Player Win"); p2++; player2Score.Text = p2.ToString(); bitti = true; }
            else if (o7 && o8 && o9 == true) { MessageBox.Show("Second Player Win"); p2++; player2Score.Text = p2.ToString(); bitti = true; }
           

        }
        #endregion


    }
}
