using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int noOfPlayers = 0;
            int timeForOneRound = 730;

            try
            {
                noOfPlayers = Convert.ToInt16(nlblNumberOfPlayers.Value);
            }
            catch
            {
                MessageBox.Show("Warning: Value for Number-of-Players is not valid!");
            }

            if (Convert.ToInt16(nlblTimeForOneRound.Value) > 0)
            {
                try
                {
                    timeForOneRound = Convert.ToInt16(nlblTimeForOneRound.Value);
                }
                catch
                {
                    MessageBox.Show("Warning: Value for Time-per-round is not valid! ");
                }
            }

            if (noOfPlayers < 20)
            {
                MessageBox.Show("Sorry, min players for this game is 20. Thanks");
            }
            else
            {
                ChurchGamePage2 Page2 = new ChurchGamePage2(noOfPlayers,timeForOneRound);
                Page2.Show();
                this.Hide();
             //   this.Close();
            }

            
        }
    }
}
