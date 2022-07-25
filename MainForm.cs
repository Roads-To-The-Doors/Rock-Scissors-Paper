using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockScissorsPaper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int countUserWins = 0, countPCWins = 0;

        string result, beenResult, userChoice, PCChoice;

        string[] elements = 
        {
            "scissors", "rock", "paper"
        };

        string[] statuses =
        {
            " <--   draw   --> ", " -->   win   --> ", " <--   win   <-- "
        };

        private int Rand()
        {
            Random random = new Random();

            int c;

            int[] r1 = new int[10];

            for (int i = 0; i < r1.Length; ++i)
            {
                r1[i] = random.Next(elements.Length);
            }

            int[] r2 = new int[5];

            for (int i = 0; i < r2.Length; ++i)
            {
                c = random.Next(r1.Length);

                r2[i] = r1[c];
            }

            int[] r3 = new int[3];

            for (int i = 0; i < r3.Length; ++i)
            {
                c = random.Next(r2.Length);

                r3[i] = r2[c];
            }

            c = random.Next(r3.Length);

            return r3[c];
        }

        private string GetRandomElement()
        {
            Random random = new Random();

            int rand;

            string element;

            rand = Rand();

            element = elements[rand];

            /*
            do
            {
                rand = Rand();

                element = elements[rand];
            }
            while (element == beenResult);
            */

            return element;
        }

        private string NextElement(string elem)
        {
            int length = elements.Length;

            for (int i = 0; i < length; ++i)
            {
                if (elem == elements[i])
                {
                    if (i == length - 1)
                    {
                        return elements[0];
                    }
                    else
                    {
                        return elements[i + 1];
                    }
                }
            }

            return "error";
        }

        private string GetResults()
        {
            // если руки одинаковы
            if (userChoice == PCChoice)
            {
                return statuses[0];
            }
            // если у пк рука сильней
            if (PCChoice == NextElement(userChoice))
            {
                return statuses[1];
            }
            // если у нас рука сильней
            else
            {
                return statuses[2];
            }
        }

        private void CheckResult()
        {
            if (result == statuses[1])
            {
                ++countPCWins;
            }
            if (result == statuses[2])
            {
                ++countUserWins;
            }
        }

        private void SetResults()
        {
            cntUser.Text = Convert.ToString(countUserWins);

            cntPC.Text = Convert.ToString(countPCWins);
        }

        public void Game()
        {
            UChoice.Text = userChoice;

            PCChoice = GetRandomElement();

            beenResult = PCChoice;

            PChoice.Text = PCChoice;

            result = GetResults();

            AllResult.Text = result;

            CheckResult();

            SetResults();
        }

        private void butRock_Click(object sender, EventArgs e)
        {
            userChoice = elements[1];

            Game();
        }

        private void butScissors_Click(object sender, EventArgs e)
        {
            userChoice = elements[0];

            Game();
        }

        private void butPaper_Click(object sender, EventArgs e)
        {
            userChoice = elements[2];

            Game();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetResults();
        }
    }
}
