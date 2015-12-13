using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fight
{
    public partial class Form1 : Form
    {
        // global stream objects
        StreamWriter outputFilew;
        StreamWriter outputFilel;
        StreamReader inputFilew;
        StreamReader inputFilel;
        // class objects
        Creature ai = new Creature();
        Human p1 = new Human();
        // win loss variables
        static int win = 0;
        static int loss = 0;
        // random class object
        Random r = new Random();
        // global list to hold wins/losses
        List<int> winList = new List<int>();
        List<int> lossList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        public int Damage()
        {
            return r.Next(10,21);
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int dam1;
            ai.Hitpoints = 100;
            p1.Hitpoints = 100;
            p1.Name = "Player 1";
            ai.Name = "CPU";
            int dam2;
            //int hp2 = 0;
            bool isDead = false;
            string outputai;
            string outputp1;
            listBoxBattleResults.Items.Clear();
            do
            {
                dam1 = Damage();
                p1.Hitpoints -= dam1;
                outputai = ai.Name + " hit for " + dam1.ToString();
                listBoxBattleResults.Items.Add(outputai); 
                if (p1.Hitpoints < 1)
                {
                    MessageBox.Show(ai.Name + " is victorious!");
                    isDead = true;
                    loss += 1;
                    textBoxLosses.Text = loss.ToString();
                    return;
                }
                //p1.Hitpoints = hp2;
                dam2 = Damage();
                ai.Hitpoints -= dam2;
                outputp1 = p1.Name + " hit for " + dam2.ToString();
                listBoxBattleResults.Items.Add(outputp1);
                if (ai.Hitpoints < 1)
                {
                    MessageBox.Show(p1.Name + " is victorious!");
                    
                    isDead = true;
                    win += 1;
                    textBoxWins.Text = win.ToString();
                    
                }
                //ai.Hitpoints = hp2;
            } while (isDead == false);
            winList.Add(win);
            lossList.Add(loss);

        }
        // save wins and losses
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFilew = File.CreateText("winlist.txt");
                outputFilew.WriteLine(win);
                outputFilew.Close();
                StreamWriter outputFilel = File.CreateText("losslist.txt");
                outputFilel.WriteLine(loss);
                outputFilel.Close();
                MessageBox.Show("Your file has been saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No data to save. Enter values into the list first.");
            }
        }
        // load wins and losses
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFilew = File.OpenText("winlist.txt");
                while (!inputFilew.EndOfStream)
                {
                    textBoxWins.Text = (inputFilew.ReadLine());
                }
                inputFilew.Close();

                StreamReader inputFilel = File.OpenText("losslist.txt");
                while (!inputFilel.EndOfStream)
                {
                    textBoxLosses.Text = (inputFilel.ReadLine());
                }
                inputFilel.Close();

                MessageBox.Show("Your wins/loss record has been loaded.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No file to load. Save a file first then try loading.");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            win = 0;
            loss = 0;
            textBoxWins.Text = "";
            textBoxLosses.Text = "";
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Player 1 battles the AI. Each start with 100 health and take turns damaging each other based on random damage roll.");
        }
    }
}
