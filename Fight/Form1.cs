using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fight
{
    public partial class Form1 : Form
    {
        Creature ai = new Creature();
        Human p1 = new Human();
        static int win = 0;
        static int loss = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public int Damage()
        {
            Random r = new Random();
            return r.Next(10,21);
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int dam1 = 0;
            int hp1 = 0;
            int dam2 = 0;
            int hp2 = 0;
            bool isDead = false;
            do
            {
                dam1 = Damage();
                hp2 = (p1.Hitpoints - dam1);
                if (hp2 < 1)
                {
                    MessageBox.Show(ai.Name + " is victorious!");
                    isDead = true;
                    loss += 1;
                    textBoxLosses.Text = loss.ToString();
                    //return;
                }
                p1.Hitpoints = hp2;
                dam2 = Damage();
                hp1 = (ai.Hitpoints - dam2);
                if (hp1 < 1)
                {
                    MessageBox.Show(p1.Name + " is victorious!");
                    //cout << p1.getName() << " Is victorious! " << endl;
                    isDead = true;
                    win += 1;
                    textBoxWins.Text = win.ToString();
                    //return;
                }
                ai.Hitpoints = hp2;
            } while (isDead == false);   
        }

        //public void battleArena(Creature ai, Human p1)  
        //{
        //    int dam1 = 0;
        //    int hp1 = 0;
        //    int dam2 = 0;
        //    int hp2 = 0;
        //    bool isDead = false;
        //    do
        //    {
        //        dam1 = Damage();
        //        hp2 = (p1.Hitpoints - dam1);
        //        if (hp2 < 1)
        //        {
        //            MessageBox.Show(ai.Name + " is victorious!");
        //            isDead = true;
        //            loss += 1;
        //            textBoxLosses.Text = loss.ToString();
        //            //return;
        //        }
        //        p1.Hitpoints = hp2;
        //        dam2 = Damage();
        //        hp1 = (ai.Hitpoints - dam2);
        //        if (hp1 < 1)
        //        {
        //            MessageBox.Show(p1.Name + " is victorious!");
        //            //cout << p1.getName() << " Is victorious! " << endl;
        //            isDead = true;
        //            win += 1;
        //            textBoxWins.Text = win.ToString();
        //            //return;
        //        }
        //        ai.Hitpoints = hp2;
        //        }while(isDead == false);

        //}
    }
}
