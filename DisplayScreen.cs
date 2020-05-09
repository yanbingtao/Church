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

namespace ChurchGame
{
    public partial class DisplayScreen : Form
    {
        int NumberOfPlayers;
        string filepath,filepath2,audioPath1;
        int warningWhenTimeLeft = 100;//when time left for this round =100s, waning message shown
        int colorControlTemp = 0;
        int colorControlChange1=0, colorControlChange2=0, colorControlChange3=0, colorControlChange4=0, colorControlChange5=0,
            colorControlChange6=0, colorControlChange7=0, colorControlChange8=0, colorControlChange9=0, colorControlChange10= 0;

        int StartNo = 0;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();



        private void timerIndividual10_Tick(object sender, EventArgs e)
        {
            if (colorControlChange10 == 0)
            {
                lbl10.BackColor = Color.Red;
                lbl1010.BackColor = Color.Red;

                colorControlChange10 = 1;
            }
            else
            {
                lbl10.BackColor = Color.Navy;
                lbl1010.BackColor = Color.Navy;

                colorControlChange10 = 0;
            }
        }

        private void timerIndividual9_Tick(object sender, EventArgs e)
        {
            if (colorControlChange9 == 0)
            {
                lbl9.BackColor = Color.Red;
                lbl99.BackColor = Color.Red;

                colorControlChange9 = 1;
            }
            else
            {
                lbl9.BackColor = Color.Navy;
                lbl99.BackColor = Color.Navy;

                colorControlChange9 = 0;
            }
        }

        private void timerIndividual8_Tick(object sender, EventArgs e)
        {
            if (colorControlChange8 == 0)
            {
                lbl8.BackColor = Color.Red;
                lbl88.BackColor = Color.Red;

                colorControlChange8 = 1;
            }
            else
            {
                lbl8.BackColor = Color.Navy;
                lbl88.BackColor = Color.Navy;

                colorControlChange8 = 0;
            }
        }

        private void timerIndividual7_Tick(object sender, EventArgs e)
        {
            if (colorControlChange7 == 0)
            {
                lbl7.BackColor = Color.Red;
                lbl77.BackColor = Color.Red;

                colorControlChange7 = 1;
            }
            else
            {
                lbl7.BackColor = Color.Navy;
                lbl77.BackColor = Color.Navy;

                colorControlChange7 = 0;
            }
        }

        private void timerIndividual6_Tick(object sender, EventArgs e)
        {
            if (colorControlChange6 == 0)
            {
                lbl6.BackColor = Color.Red;
                lbl66.BackColor = Color.Red;

                colorControlChange6 = 1;
            }
            else
            {
                lbl6.BackColor = Color.Navy;
                lbl66.BackColor = Color.Navy;

                colorControlChange6 = 0;
            }
        }

        private void timerIndividual5_Tick(object sender, EventArgs e)
        {
            if (colorControlChange5 == 0)
            {
                lbl5.BackColor = Color.Red;
                lbl55.BackColor = Color.Red;

                colorControlChange5 = 1;
            }
            else
            {
                lbl5.BackColor = Color.Navy;
                lbl55.BackColor = Color.Navy;

                colorControlChange5 = 0;
            }
        }

        private void timerIndividual4_Tick(object sender, EventArgs e)
        {
            if (colorControlChange4 == 0)
            {
                lbl4.BackColor = Color.Red;
                lbl44.BackColor = Color.Red;

                colorControlChange4 = 1;
            }
            else
            {
                lbl4.BackColor = Color.Navy;
                lbl44.BackColor = Color.Navy;

                colorControlChange4 = 0;
            }
        }

        private void timerIndividual3_Tick(object sender, EventArgs e)
        {
            if (colorControlChange3 == 0)
            {
                lbl3.BackColor = Color.Red;
                lbl33.BackColor = Color.Red;

                colorControlChange3 = 1;
            }
            else
            {
                lbl3.BackColor = Color.Navy;
                lbl33.BackColor = Color.Navy;

                colorControlChange3 = 0;
            }
        }

        private void timerIndividual2_Tick(object sender, EventArgs e)
        {
            if (colorControlChange2 == 0)
            {
                lbl2.BackColor = Color.Red;
                lbl22.BackColor = Color.Red;

                colorControlChange2 = 1;
            }
            else
            {
                lbl2.BackColor = Color.Navy;
                lbl22.BackColor = Color.Navy;

                colorControlChange2 = 0;
            }
        }

        private void timerIndividual1_Tick(object sender, EventArgs e)
        {
            if (colorControlChange1 == 0)
            {
                lbl1.BackColor = Color.Red;
                lbl11.BackColor = Color.Red;

                colorControlChange1 = 1;
            }
            else
            {
                lbl1.BackColor = Color.Navy;
                lbl11.BackColor = Color.Navy;

                colorControlChange1 = 0;
            }
        }


        public DisplayScreen(int NoOfPlayers,string path,string path2,string audioFilePath,int height, int width)
        {
           /* this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;*/

            InitializeComponent();

            
            Utility.fitFormToScreen(this, height, width);
            this.CenterToScreen();

            this.AutoScaleMode = AutoScaleMode.Dpi;

           // this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            filepath = path;
            filepath2 = path2;
            audioPath1 = audioFilePath;
            NumberOfPlayers = NoOfPlayers;

            timerChangePage.Start();

            //timerTime.Start();

            /*if (audioPath1 == "")
            {
                MessageBox.Show("Audio Sound Track hasn't been chosen, Please play the round-ending alarm audio manually, thanks!");
            }
            else
            {
                    player.SoundLocation = audioPath1;
            }*/


        }

       


       
           
        private void timerChangePage_Tick(object sender, EventArgs e)
        {
            //2 sec
            timerTime.Start();

            /* int totalPages;
             if (NumberOfPlayers % 10 == 0)
             {
                 totalPages = NumberOfPlayers / 10;
             }
             else
             {
                 totalPages = NumberOfPlayers / 10 + 1;
             }
             */
            var lines = File.ReadAllLines(filepath);
            var lineCount = File.ReadLines(filepath).Count();

            if (StartNo == 0)
            {
                StartNo = 1;
            }
            else if (StartNo +10 <= lineCount)
            {
                StartNo = StartNo + 10;
            }
            else
            {
                StartNo = 1;
            }

            //lbl0.BackColor = Color.Orange;
            lbl1.BackColor = Color.Navy;
            lbl11.BackColor = Color.Navy;
            lbl2.BackColor = Color.Navy;
            lbl22.BackColor = Color.Navy;
            lbl3.BackColor = Color.Navy;
            lbl33.BackColor = Color.Navy;
            lbl4.BackColor = Color.Navy;
            lbl44.BackColor = Color.Navy;
            lbl5.BackColor = Color.Navy;
            lbl55.BackColor = Color.Navy;
            lbl6.BackColor = Color.Navy;
            lbl66.BackColor = Color.Navy;
            lbl7.BackColor = Color.Navy;
            lbl77.BackColor = Color.Navy;
            lbl8.BackColor = Color.Navy;
            lbl88.BackColor = Color.Navy;
            lbl9.BackColor = Color.Navy;
            lbl99.BackColor = Color.Navy;
            lbl10.BackColor = Color.Navy;
            lbl1010.BackColor = Color.Navy;

            //lbl0.Visible = false;
            lbl1.Visible = false;
            lbl11.Visible = false;
            lbl2.Visible = false;
            lbl22.Visible = false;
            lbl3.Visible = false;
            lbl33.Visible = false;
            lbl4.Visible = false;
            lbl44.Visible = false;
            lbl5.Visible = false;
            lbl55.Visible = false;
            lbl6.Visible = false;
            lbl66.Visible = false;
            lbl7.Visible = false;
            lbl77.Visible = false;
            lbl8.Visible = false;
            lbl88.Visible = false;
            lbl9.Visible = false;
            lbl99.Visible = false;
            lbl10.Visible = false;
            lbl1010.Visible = false;

            timerIndividual1.Enabled = false;
            timerIndividual2.Enabled = false;
            timerIndividual3.Enabled = false;
            timerIndividual4.Enabled = false;
            timerIndividual5.Enabled = false;
            timerIndividual6.Enabled = false;
            timerIndividual7.Enabled = false;
            timerIndividual8.Enabled = false;
            timerIndividual9.Enabled = false;
            timerIndividual10.Enabled = false;

            colorControlChange1 = 0;
            colorControlChange2 = 0;
            colorControlChange3 = 0;
            colorControlChange4 = 0;
            colorControlChange5 = 0;
            colorControlChange6 = 0;
            colorControlChange7 = 0;
            colorControlChange8 = 0;
            colorControlChange9 = 0;
            colorControlChange10 = 0;

        }

       

        private void timerChangeColor_Tick(object sender, EventArgs e)
        {

            if (colorControlTemp == 0)
            {
                lbl0.BackColor = Color.Red;
                lbl1.BackColor = Color.Red;
                lbl11.BackColor = Color.Red;
                lbl2.BackColor = Color.Red;
                lbl22.BackColor = Color.Red;
                lbl3.BackColor = Color.Red;
                lbl33.BackColor = Color.Red;
                lbl4.BackColor = Color.Red;
                lbl44.BackColor = Color.Red;
                lbl5.BackColor = Color.Red;
                lbl55.BackColor = Color.Red;
                lbl6.BackColor = Color.Red;
                lbl66.BackColor = Color.Red;
                lbl7.BackColor = Color.Red;
                lbl77.BackColor = Color.Red;
                lbl8.BackColor = Color.Red;
                lbl88.BackColor = Color.Red;
                lbl9.BackColor = Color.Red;
                lbl99.BackColor = Color.Red;
                lbl10.BackColor = Color.Red;
                lbl1010.BackColor = Color.Red;

                colorControlTemp = 1;
            }
            else
            {
                lbl0.BackColor = Color.Orange;
                lbl1.BackColor = Color.Navy;
                lbl11.BackColor = Color.Navy;
                lbl2.BackColor = Color.Navy;
                lbl22.BackColor = Color.Navy;
                lbl3.BackColor = Color.Navy;
                lbl33.BackColor = Color.Navy;
                lbl4.BackColor = Color.Navy;
                lbl44.BackColor = Color.Navy;
                lbl5.BackColor = Color.Navy;
                lbl55.BackColor = Color.Navy;
                lbl6.BackColor = Color.Navy;
                lbl66.BackColor = Color.Navy;
                lbl7.BackColor = Color.Navy;
                lbl77.BackColor = Color.Navy;
                lbl8.BackColor = Color.Navy;
                lbl88.BackColor = Color.Navy;
                lbl9.BackColor = Color.Navy;
                lbl99.BackColor = Color.Navy;
                lbl10.BackColor = Color.Navy;
                lbl1010.BackColor = Color.Navy;

                colorControlTemp = 0;
            }
        }


        private void timerTime_Tick(object sender, EventArgs e)
        {
            string warningMsg = "RIP...";

            // Time Count Down=============================================================
            lbl0.Visible = true;

            var linesTime = File.ReadAllLines(filepath2);

            string tempTimeCountDown = linesTime[0];

            if (Convert.ToInt32(tempTimeCountDown) > warningWhenTimeLeft)
            {
                lbl0.BackColor = Color.Orange;
                timerChangeColor.Enabled = false;

                int mm = Convert.ToInt32(tempTimeCountDown) / 60;
                int ss = Convert.ToInt32(tempTimeCountDown) % 60;


                lbl0.Text = "Time Left for this Round: " + Convert.ToString(mm)+" Min"+" : "+Convert.ToString(ss)+" Sec";
            }
            else
            {
                //TIME countdown warning 
                if (Convert.ToInt32(tempTimeCountDown) > 0)
                {
                    if (timerChangeColor.Enabled == false)
                    {
                        timerChangeColor.Enabled = true;
                    }

                    lbl0.Text = "Time Left for this Round: " + tempTimeCountDown+" sec";
                    //btnStartAlarm.Visible = false;
                }
                else
                {
                    //This round end already!!
                    lbl0.Text = "Time's Up for this round!!";
                    lbl0.BackColor = Color.Red;
                    timerChangeColor.Enabled = false;

                   /* timerIndividual1.Enabled = false;
                    timerIndividual2.Enabled = false;
                    timerIndividual3.Enabled = false;
                    timerIndividual4.Enabled = false;
                    timerIndividual5.Enabled = false;
                    timerIndividual6.Enabled = false;
                    timerIndividual7.Enabled = false;
                    timerIndividual8.Enabled = false;
                    timerIndividual9.Enabled = false;
                    timerIndividual10.Enabled = false;*/

                    //player.Play();
                    //btnStartAlarm.Visible = true;

                }
            }

            //=============================================================================


            //=======================================================================
            string[] record = new string[100];
            //clear array
            for (int index = 0; index < 100; index++)
            {
                record[index] = "";
            }

            //save to array
            var lines = File.ReadAllLines(filepath);
            var lineCount = File.ReadLines(filepath).Count();

            for (int index = 0; index < lineCount; index++)
            {
                record[index] = lines[index];

            }

            //Get time string and display
            //1
            if (record[StartNo - 1] != "")
            {
                lbl1.Visible = true;
                lbl11.Visible = true;

                int NoFrom11 = record[StartNo - 1].IndexOf("&") + 1;
                int NoTo11 = record[StartNo - 1].LastIndexOf("&&");
                string NumberOnly11 = record[StartNo - 1].Substring(NoFrom11, NoTo11 - NoFrom11);
                lbl1.Text = NumberOnly11;

                int TimeFrom11 = record[StartNo - 1].IndexOf("&&") + 2;
                int TimeTo11 = record[StartNo - 1].LastIndexOf("#");
                string TimeOnly11 = record[StartNo - 1].Substring(TimeFrom11, TimeTo11 - TimeFrom11);

                if (Convert.ToInt32(TimeOnly11) >= 0)
                {
                    lbl11.Text = TimeOnly11;

                    if (Convert.ToInt32(TimeOnly11) <= 100)
                    {
                        timerIndividual1.Enabled = true;
                    }
                }
                else
                {
                    lbl11.Text = warningMsg;
                    lbl11.BackColor = Color.Red;
                    lbl1.BackColor = Color.Red;
                }
            }
            //2
            if (record[StartNo] != "")
            {
                lbl2.Visible = true;
                lbl22.Visible = true;

                int NoFrom22 = record[StartNo].IndexOf("&") + 1;
                int NoTo22 = record[StartNo].LastIndexOf("&&");
                string NumberOnly22 = record[StartNo].Substring(NoFrom22, NoTo22 - NoFrom22);
                lbl2.Text = NumberOnly22;

                int TimeFrom22 = record[StartNo].IndexOf("&&") + 2;
                int TimeTo22 = record[StartNo].LastIndexOf("#");
                string TimeOnly22 = record[StartNo].Substring(TimeFrom22, TimeTo22 - TimeFrom22);
                //lbl22.Text = TimeOnly22;

                if (Convert.ToInt32(TimeOnly22) >= 0)
                {
                    lbl22.Text = TimeOnly22;

                    if (Convert.ToInt32(TimeOnly22) <= 100)
                    {
                        timerIndividual2.Enabled = true;
                    }
                }
                else
                {
                    lbl22.Text = warningMsg;
                    lbl22.BackColor = Color.Red;
                    lbl2.BackColor = Color.Red;
                }
            }
            //3
            if (record[StartNo + 1] != "")
            {
                lbl3.Visible = true;
                lbl33.Visible = true;

                int NoFrom33 = record[StartNo + 1].IndexOf("&") + 1;
                int NoTo33 = record[StartNo + 1].LastIndexOf("&&");
                string NumberOnly33 = record[StartNo + 1].Substring(NoFrom33, NoTo33 - NoFrom33);
                lbl3.Text = NumberOnly33;

                int TimeFrom33 = record[StartNo + 1].IndexOf("&&") + 2;
                int TimeTo33 = record[StartNo + 1].LastIndexOf("#");
                string TimeOnly33 = record[StartNo + 1].Substring(TimeFrom33, TimeTo33 - TimeFrom33);
                //lbl33.Text = TimeOnly33;

                if (Convert.ToInt32(TimeOnly33) >= 0)
                {
                    lbl33.Text = TimeOnly33;

                    if (Convert.ToInt32(TimeOnly33) <= 100)
                    {
                        timerIndividual3.Enabled = true;
                    }
                }
                else
                {
                    lbl33.Text = warningMsg;
                    lbl33.BackColor = Color.Red;
                    lbl3.BackColor = Color.Red;
                }
            }
            //4
            if (record[StartNo + 2] != "")
            {
                lbl4.Visible = true;
                lbl44.Visible = true;

                int NoFrom44 = record[StartNo + 2].IndexOf("&") + 1;
                int NoTo44 = record[StartNo + 2].LastIndexOf("&&");
                string NumberOnly44 = record[StartNo + 2].Substring(NoFrom44, NoTo44 - NoFrom44);
                lbl4.Text = NumberOnly44;

                int TimeFrom44 = record[StartNo + 2].IndexOf("&&") + 2;
                int TimeTo44 = record[StartNo + 2].LastIndexOf("#");
                string TimeOnly44 = record[StartNo + 2].Substring(TimeFrom44, TimeTo44 - TimeFrom44);
                //lbl44.Text = TimeOnly44;

                if (Convert.ToInt32(TimeOnly44) >= 0)
                {
                    lbl44.Text = TimeOnly44;

                    if (Convert.ToInt32(TimeOnly44) <= 100)
                    {
                        timerIndividual4.Enabled = true;
                    }
                }
                else
                {
                    lbl44.Text = warningMsg;
                    lbl44.BackColor = Color.Red;
                    lbl4.BackColor = Color.Red;
                }
            }

            //5
            if (record[StartNo + 3] != "")
            {
                lbl5.Visible = true;
                lbl55.Visible = true;

                int NoFrom55 = record[StartNo + 3].IndexOf("&") + 1;
                int NoTo55 = record[StartNo + 3].LastIndexOf("&&");
                string NumberOnly55 = record[StartNo + 3].Substring(NoFrom55, NoTo55 - NoFrom55);
                lbl5.Text = NumberOnly55;

                int TimeFrom55 = record[StartNo + 3].IndexOf("&&") + 2;
                int TimeTo55 = record[StartNo + 3].LastIndexOf("#");
                string TimeOnly55 = record[StartNo + 3].Substring(TimeFrom55, TimeTo55 - TimeFrom55);
                //lbl55.Text = TimeOnly55;

                if (Convert.ToInt32(TimeOnly55) >= 0)
                {
                    lbl55.Text = TimeOnly55;

                    if (Convert.ToInt32(TimeOnly55) <= 100)
                    {
                        timerIndividual5.Enabled = true;
                    }
                }
                else
                {
                    lbl55.Text = warningMsg;
                    lbl55.BackColor = Color.Red;
                    lbl5.BackColor = Color.Red;
                }
            }
            //6
            if (record[StartNo + 4] != "")
            {
                lbl6.Visible = true;
                lbl66.Visible = true;

                int NoFrom66 = record[StartNo + 4].IndexOf("&") + 1;
                int NoTo66 = record[StartNo + 4].LastIndexOf("&&");
                string NumberOnly66 = record[StartNo + 4].Substring(NoFrom66, NoTo66 - NoFrom66);
                lbl6.Text = NumberOnly66;

                int TimeFrom66 = record[StartNo + 4].IndexOf("&&") + 2;
                int TimeTo66 = record[StartNo + 4].LastIndexOf("#");
                string TimeOnly66 = record[StartNo + 4].Substring(TimeFrom66, TimeTo66 - TimeFrom66);
                //lbl66.Text = TimeOnly66;

                if (Convert.ToInt32(TimeOnly66) >= 0)
                {
                    lbl66.Text = TimeOnly66;

                    if (Convert.ToInt32(TimeOnly66) <= 100)
                    {
                        timerIndividual6.Enabled = true;
                    }
                }
                else
                {
                    lbl66.Text = warningMsg;
                    lbl66.BackColor = Color.Red;
                    lbl6.BackColor = Color.Red;
                }
            }
            //7
            if (record[StartNo + 5] != "")
            {
                lbl7.Visible = true;
                lbl77.Visible = true;

                int NoFrom77 = record[StartNo + 5].IndexOf("&") + 1;
                int NoTo77 = record[StartNo + 5].LastIndexOf("&&");
                string NumberOnly77 = record[StartNo + 5].Substring(NoFrom77, NoTo77 - NoFrom77);
                lbl7.Text = NumberOnly77;

                int TimeFrom77 = record[StartNo + 5].IndexOf("&&") + 2;
                int TimeTo77 = record[StartNo + 5].LastIndexOf("#");
                string TimeOnly77 = record[StartNo + 5].Substring(TimeFrom77, TimeTo77 - TimeFrom77);
                //lbl77.Text = TimeOnly77;

                if (Convert.ToInt32(TimeOnly77) >= 0)
                {
                    lbl77.Text = TimeOnly77;

                    if (Convert.ToInt32(TimeOnly77) <= 100)
                    {
                        timerIndividual7.Enabled = true;
                    }
                }
                else
                {
                    lbl77.Text = warningMsg;
                    lbl77.BackColor = Color.Red;
                    lbl7.BackColor = Color.Red;
                }
            }
            //8
            if (record[StartNo + 6] != "")
            {
                lbl8.Visible = true;
                lbl88.Visible = true;

                int NoFrom88 = record[StartNo + 6].IndexOf("&") + 1;
                int NoTo88 = record[StartNo + 6].LastIndexOf("&&");
                string NumberOnly88 = record[StartNo + 6].Substring(NoFrom88, NoTo88 - NoFrom88);
                lbl8.Text = NumberOnly88;

                int TimeFrom88 = record[StartNo + 6].IndexOf("&&") + 2;
                int TimeTo88 = record[StartNo + 6].LastIndexOf("#");
                string TimeOnly88 = record[StartNo + 6].Substring(TimeFrom88, TimeTo88 - TimeFrom88);
                //lbl88.Text = TimeOnly88;

                if (Convert.ToInt32(TimeOnly88) >= 0)
                {
                    lbl88.Text = TimeOnly88;

                    if (Convert.ToInt32(TimeOnly88) <= 100)
                    {
                        timerIndividual8.Enabled = true;
                    }
                }
                else
                {
                    lbl88.Text = warningMsg;
                    lbl88.BackColor = Color.Red;
                    lbl8.BackColor = Color.Red;
                }
            }
            //9
            if (record[StartNo + 7] != "")
            {
                lbl9.Visible = true;
                lbl99.Visible = true;

                int NoFrom99 = record[StartNo + 7].IndexOf("&") + 1;
                int NoTo99 = record[StartNo + 7].LastIndexOf("&&");
                string NumberOnly99 = record[StartNo + 7].Substring(NoFrom99, NoTo99 - NoFrom99);
                lbl9.Text = NumberOnly99;

                int TimeFrom99 = record[StartNo + 7].IndexOf("&&") + 2;
                int TimeTo99 = record[StartNo + 7].LastIndexOf("#");
                string TimeOnly99 = record[StartNo + 7].Substring(TimeFrom99, TimeTo99 - TimeFrom99);
                //lbl99.Text = TimeOnly99;

                if (Convert.ToInt32(TimeOnly99) >= 0)
                {
                    lbl99.Text = TimeOnly99;

                    if (Convert.ToInt32(TimeOnly99) <= 100)
                    {
                        timerIndividual9.Enabled = true;
                    }
                }
                else
                {
                    lbl99.Text = warningMsg;
                    lbl99.BackColor = Color.Red;
                    lbl9.BackColor = Color.Red;
                }
            }
            //10
            if (record[StartNo + 8] != "")
            {
                lbl10.Visible = true;
                lbl1010.Visible = true;

                int NoFrom1010 = record[StartNo + 8].IndexOf("&") + 1;
                int NoTo1010 = record[StartNo + 8].LastIndexOf("&&");
                string NumberOnly1010 = record[StartNo + 8].Substring(NoFrom1010, NoTo1010 - NoFrom1010);
                lbl10.Text = NumberOnly1010;

                int TimeFrom1010 = record[StartNo + 8].IndexOf("&&") + 2;
                int TimeTo1010 = record[StartNo + 8].LastIndexOf("#");
                string TimeOnly1010 = record[StartNo + 8].Substring(TimeFrom1010, TimeTo1010 - TimeFrom1010);
                lbl1010.Text = TimeOnly1010;

                if (Convert.ToInt32(TimeOnly1010) >= 0)
                {
                    lbl1010.Text = TimeOnly1010;

                    if (Convert.ToInt32(TimeOnly1010) <= 100)
                    {
                        timerIndividual10.Enabled = true;
                    }
                }
                else
                {
                    lbl1010.Text = warningMsg;
                    lbl1010.BackColor = Color.Red;
                    lbl10.BackColor = Color.Red;
                }
            }
           



            
            //=======================================================================

        }

        void fileExitMenuItem_Click(object sender, DisplayScreen e)
        {
            // Close this window
            this.Close();
        }


    }

    //====================================================================================================
    //this is a utility static class
    public static class Utility
    {


        public static void fitFormToScreen(Form form, int h, int w)
        {

            //scale the form to the current screen resolution 
            form.Height =  (int)((float)form.Height * ((float)Screen.PrimaryScreen.Bounds.Size.Height / (float)h));
            form.Width = (int)((float)form.Width * ((float)Screen.PrimaryScreen.Bounds.Size.Width / (float)w));

            //here font is scaled like width
            form.Font = new Font(form.Font.FontFamily, form.Font.Size * ((float)Screen.PrimaryScreen.Bounds.Size.Width / (float)w));

            foreach (Control item in form.Controls)
            {
                fitControlsToScreen(item, h, w);
            }

        }

        static void fitControlsToScreen(Control cntrl, int h, int w)
        {
            if (Screen.PrimaryScreen.Bounds.Size.Height != h)
            {

                cntrl.Height = (int)((float)cntrl.Height * ((float)Screen.PrimaryScreen.Bounds.Size.Height / (float)h));
                cntrl.Top = (int)((float)cntrl.Top * ((float)Screen.PrimaryScreen.Bounds.Size.Height / (float)h));

            }
            if (Screen.PrimaryScreen.Bounds.Size.Width != w)
            {

                cntrl.Width = (int)((float)cntrl.Width * ((float)Screen.PrimaryScreen.Bounds.Size.Width / (float)w));
                cntrl.Left = (int)((float)cntrl.Left * ((float)Screen.PrimaryScreen.Bounds.Size.Width / (float)w));

                cntrl.Font = new Font(cntrl.Font.FontFamily, cntrl.Font.Size * ((float)Screen.PrimaryScreen.Bounds.Size.Width / (float)w));

            }

            foreach (Control item in cntrl.Controls)
            {
                fitControlsToScreen(item, h, w);
            }
        }
    }

}
