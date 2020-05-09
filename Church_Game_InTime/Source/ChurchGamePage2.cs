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
    public partial class ChurchGamePage2 : Form
    {
        int NumberOfPlayers;
        string path = "ChurchGameDataBase.txt";
        string path2 = "TimeRecord.txt";
        string audioFilePath="";
        int screenHeight = 900;
        int screenWidth = 1600;
        int TimePerRound = 0;

        public ChurchGamePage2(int NoOfPlayers, int TimeForOneRound)
        {
            InitializeComponent();
            lblDisplay1.Text = "Total No. of players = "+Convert.ToString(NoOfPlayers);
            NumberOfPlayers = Convert.ToInt32(NoOfPlayers);
            TimePerRound = TimeForOneRound;

            int temp = 1;
            while (temp <= NoOfPlayers)
            {
                comboBoxAllPlayers.Items.Add(Convert.ToString(temp));
                comboBoxAllPlayers2.Items.Add(Convert.ToString(temp));
               
                temp++;
            }
        }

       

        private void comboBoxAllPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDisplay3.Text = "Currently you are setting initial time for Player No." + comboBoxAllPlayers.Text ;
            lblDisplay4.Text = "Initial Time (in Sec) for Player No." + comboBoxAllPlayers.Text+":";
            btnConfirm.Text = "Confirm";
            txtTimeLeft.Text = "";
           
           
            txtTimeLeft.Enabled = true;
            btnConfirm.Enabled = true;
           
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //btnStart.Text = "Start";
           // btnStop.Text = "Stop";
           // btnStart.Enabled = true;

            if (txtTimeLeft.Text == "")
            {
                MessageBox.Show("Please enter the initial Time of player " + comboBoxAllPlayers.Text);
            }
            else
            {
                
                if (File.Exists(path))
                {
                    //File exist

                    //check the specific player has been enterd in the database before or not

                    var lines = File.ReadAllLines(path);
                    var lineCount = File.ReadLines(path).Count();

                    Boolean repeat = false;
                    for (int index = 0; index < lineCount; index++)
                    {
                        if ( lines[index].Contains("&" + comboBoxAllPlayers.Text + "&&"))
                        {
                            repeat = true;
                           //firstFound = true;
                           // MessageBox.Show("You have entered the initial time for this player already");
                        }
                        else
                        {
                            repeat = false;
                            //not exist, write a new time inside later

                        }
                    }

                    if (repeat == true)
                    {
                        MessageBox.Show("You have entered the initial time for this player already");
                    }
                    else
                    {
                       
                        using (StreamWriter stream = new FileInfo(path).AppendText())
                        {
                            stream.WriteLine("&" + comboBoxAllPlayers.Text + "&&" + txtTimeLeft.Text + "#");
                            MessageBox.Show("The initial time for player " + comboBoxAllPlayers.Text + " has been entered, Thanks!");
                        }
                        //rearrange all data in order
                        string[] rearrange = new string[100];

                        //clear array
                        for (int index = 0; index < 100; index++)
                        {
                            rearrange[index] = "";
                        }
                        //rearrange order==========================================================
                        var lines1 = File.ReadAllLines(path);
                        var lineCount1 = File.ReadLines(path).Count();

                        for (int index = 0; index < lineCount1; index++)
                        {
                            string tempNo = lines1[index];

                            int pFrom = tempNo.IndexOf("&") + 1;
                            int pTo = tempNo.LastIndexOf("&&");

                            string NumberOnly = tempNo.Substring(pFrom, pTo - pFrom);

                            rearrange[Convert.ToInt32(NumberOnly) - 1] = tempNo;

                        }


                        //update txt file
                        if (rearrange[0] != "")
                        {
                            using (StreamWriter writer = new StreamWriter(path))
                            {
                                writer.WriteLine(rearrange[0]);
                            }
                        }
                        else
                        {
                            using (StreamWriter writer = new StreamWriter(path))
                            {
                                writer.Write("");
                            }
                        }

                        for (int index = 1; index < NumberOfPlayers; index++)
                        {
                            if (rearrange[index] != "")
                            {
                                using (StreamWriter stream = new FileInfo(path).AppendText())
                                {
                                    stream.WriteLine(rearrange[index]);
                                }
                            }
                        }
                        //=================================================================================


                    }
                }
                else
                {
                    //create txt file as database
                    StreamWriter File1 = new StreamWriter(path);

                    File1.WriteLine("&" + comboBoxAllPlayers.Text + "&&" + txtTimeLeft.Text + "#");
                    MessageBox.Show("The initial time for player " + comboBoxAllPlayers.Text + " has been entered, Thanks!");

                    File1.Close();

                  
                }
            }

            
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnResume.Enabled = false;
            btnStart.Enabled = false;

            lblTimeElapseDisplayMM.Text = "0";
            lblTimeElapseDisplaySS.Text = "0";

            timerElapse.Enabled = true;

            //write time to txt file to count down and auto stop==================================================================
            int totalTimeForOneRound = TimePerRound;

            if (File.Exists(path2))
            {
                //File exist

                var lines = File.ReadAllLines(path2);
                var lineCount = File.ReadLines(path2).Count();

                using (StreamWriter writer = new StreamWriter(path2))
                {
                    writer.Write(Convert.ToString(totalTimeForOneRound));
                }

            }
            else
            {
                //create txt file as database
                StreamWriter File1 = new StreamWriter(path2);

                File1.WriteLine(Convert.ToString(totalTimeForOneRound));
                
                File1.Close();

            }
            //=============================================================================================

            //Start Timer to count down-------------------------------------------------------
            timerCountDown.Enabled=true;
            //--------------------------------------------------------------------------
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnResume.Enabled = true;
            btnStop.Enabled = false;

            timerElapse.Enabled = false;
            timerCountDown.Enabled = false;
        }

        private void timerElapse_Tick(object sender, EventArgs e)
        {

            int ss=Convert.ToInt32(lblTimeElapseDisplaySS.Text);
            int mm= Convert.ToInt32(lblTimeElapseDisplayMM.Text);

            ss++;

            if (ss == 59)
            {
                mm++;
                ss = 0;
            }

            lblTimeElapseDisplayMM.Text = Convert.ToString(mm);
            lblTimeElapseDisplaySS.Text = Convert.ToString(ss);

            //calculation:
            int totalSec = mm * 60 + ss;


            //=======================================================================
            string[] record= new string[100];
            //clear array
            for (int index = 0; index < 100; index++)
            {
                record[index] = "";
            }

            var lines = File.ReadAllLines(path);
            var lineCount = File.ReadLines(path).Count();

            for (int index = 0; index < lineCount; index++)
            {
                record[index]= lines[index];

              
                int pFrom = record[index].IndexOf("&&")+2;
                int pTo = record[index].LastIndexOf("#");

               

                string TimeOnly = record[index].Substring(pFrom,pTo-pFrom);

                int TimeLeft = Convert.ToInt32(TimeOnly);
                TimeLeft = TimeLeft - 1;

                record[index] = record[index].Remove(pFrom, pTo - pFrom).Insert(pFrom, Convert.ToString(TimeLeft));

            }


            //update txt file
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(record[0]);
            }
            for (int index = 1; index < lineCount; index++)
            {
                using (StreamWriter stream = new FileInfo(path).AppendText())
                {
                    stream.WriteLine(record[index]);
                }
            }
                //=======================================================================


    
            }

        private void btnShowDisplayScreen_Click(object sender, EventArgs e)
        {
            DisplayScreen Page3 = new DisplayScreen(NumberOfPlayers,path,path2,audioFilePath,screenHeight,screenWidth);
            Page3.Show();
        }

        private void btnTimeFaster8_Click(object sender, EventArgs e)
        {
            timerElapse.Interval = 800;
            timerCheck.Interval = 800;
            timerCountDown.Interval = 800;
        }

        private void btnTimeFaster9_Click(object sender, EventArgs e)
        {
            timerElapse.Interval = 900;
            timerCheck.Interval = 900;
            timerCountDown.Interval = 900;
        }

        private void btnTimeFaster7_Click(object sender, EventArgs e)
        {
            timerElapse.Interval = 700;
            timerCheck.Interval = 700;
            timerCountDown.Interval = 700;
        }

        private void comboBoxAllPlayers2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblDisplay3.Text = "Currently you are setting initial time for Player No." + comboBoxAllPlayers2.Text;
            lblDisplay6.Text = "Time Left (in Sec) for Player No." + comboBoxAllPlayers2.Text + ":";
            // btnAddTime30s.Text = "Confirm";

            // txtTimeLeft2.Text = "";
            timerCheck.Enabled = true;

            btnTimeLeftDevideTwo.Enabled = true;
            btnAddTime50s.Enabled = true;
            btnAddTime100s.Enabled = true;
            btnAddTime300s.Enabled = true;
            btnAddTime500s.Enabled = true;
            btnDeductTime100s.Enabled = true;
            btnDeductTime300s.Enabled = true;
            btnDeductTime500s.Enabled = true;
            btnDeductTime50s.Enabled = true;

            
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                string[] check = new string[100];
                //clear array
                for (int index = 0; index < 100; index++)
                {
                    check[index] = "";
                }

                //save to array
                var lines = File.ReadAllLines(path);
                var lineCount = File.ReadLines(path).Count();

                for (int index = 0; index < lineCount; index++)
                {
                    string tempNo = lines[index];

                    int NoFrom = tempNo.IndexOf("&") + 1;
                    int NoTo = tempNo.LastIndexOf("&&");

                    int TimeFrom = tempNo.IndexOf("&&") + 2;
                    int TimeTo = tempNo.LastIndexOf("#");

                    string NumberOnly = tempNo.Substring(NoFrom, NoTo - NoFrom);
                    string TimeOnly = tempNo.Substring(TimeFrom, TimeTo - TimeFrom);

                    check[Convert.ToInt32(NumberOnly) - 1] = TimeOnly;
                }

                if (check[Convert.ToInt32(comboBoxAllPlayers2.Text) - 1] == "")
                {
                    lblTimeLeft2.Text = "User NOT in the system!!";
                }
                else
                {
                    if (Convert.ToInt32(check[Convert.ToInt32(comboBoxAllPlayers2.Text) - 1]) >= 0)
                    {
                        lblTimeLeft2.Text = check[Convert.ToInt32(comboBoxAllPlayers2.Text) - 1];
                    }
                    else
                    {
                        lblTimeLeft2.Text = "0 Sec...RIP Alr...";
                    }


                }
            }
            catch
            {
                MessageBox.Show("Please select a valid player serial number.");
            }
        }

        private void btnTimeNormal_Click(object sender, EventArgs e)
        {
            timerElapse.Interval = 1000;
            timerCheck.Interval = 1000;
            timerCountDown.Interval = 1000;
        }

        private void btnTimeLeftDevideTwo_Click(object sender, EventArgs e)
        {
            try
            {
                int half = Convert.ToInt32(lblTimeLeft2.Text) / 2;

                string[] TimeHalf = new string[100];
                //clear array
                for (int index = 0; index < 100; index++)
                {
                    TimeHalf[index] = "";
                }

                //save to array
                var lines = File.ReadAllLines(path);
                var lineCount = File.ReadLines(path).Count();

                for (int index = 0; index < lineCount; index++)
                {
                    string temp = lines[index];

                    int NoFrom = temp.IndexOf("&") + 1;
                    int NoTo = temp.LastIndexOf("&&");

                    int TimeFrom = temp.IndexOf("&&") + 2;
                    int TimeTo = temp.LastIndexOf("#");

                    string NumberOnly = temp.Substring(NoFrom, NoTo - NoFrom);
                    string TimeOnly = temp.Substring(TimeFrom, TimeTo - TimeFrom);

                    if (NumberOnly == comboBoxAllPlayers2.Text)
                    {
                        TimeHalf[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(half) + "#";
                    }
                    else
                    {
                        TimeHalf[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(TimeOnly) + "#";
                    }
                }
                //update txt file
                if (TimeHalf[0] != "")
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine(TimeHalf[0]);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.Write("");
                    }
                }

                for (int index = 1; index < NumberOfPlayers; index++)
                {
                    if (TimeHalf[index] != "")
                    {
                        using (StreamWriter stream = new FileInfo(path).AppendText())
                        {
                            stream.WriteLine(TimeHalf[index]);
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Warning: Unable to add time for this player!");
            }
        }

        private void btnAddTime30s_Click(object sender, EventArgs e)
        {
            //+50
            try
            {
                int Add30 = Convert.ToInt32(lblTimeLeft2.Text) + 50;

                string[] TimeAdd30 = new string[100];
                //clear array
                for (int index = 0; index < 100; index++)
                {
                    TimeAdd30[index] = "";
                }

                //save to array
                var lines = File.ReadAllLines(path);
                var lineCount = File.ReadLines(path).Count();

                for (int index = 0; index < lineCount; index++)
                {
                    string temp = lines[index];

                    int NoFrom = temp.IndexOf("&") + 1;
                    int NoTo = temp.LastIndexOf("&&");

                    int TimeFrom = temp.IndexOf("&&") + 2;
                    int TimeTo = temp.LastIndexOf("#");

                    string NumberOnly = temp.Substring(NoFrom, NoTo - NoFrom);
                    string TimeOnly = temp.Substring(TimeFrom, TimeTo - TimeFrom);

                    if (NumberOnly == comboBoxAllPlayers2.Text)
                    {
                        TimeAdd30[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(Add30) + "#";
                    }
                    else
                    {
                        TimeAdd30[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(TimeOnly) + "#";
                    }
                }
                //update txt file
                if (TimeAdd30[0] != "")
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine(TimeAdd30[0]);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.Write("");
                    }
                }

                for (int index = 1; index < NumberOfPlayers; index++)
                {
                    if (TimeAdd30[index] != "")
                    {
                        using (StreamWriter stream = new FileInfo(path).AppendText())
                        {
                            stream.WriteLine(TimeAdd30[index]);
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Warning: Unable to add time for this player!");


            }
        }

        private void btnAddTime60s_Click(object sender, EventArgs e)
        {
            //+100sec
            try
            {
                int Add60 = Convert.ToInt32(lblTimeLeft2.Text) + 100;

                string[] TimeAdd60 = new string[100];
                //clear array
                for (int index = 0; index < 100; index++)
                {
                    TimeAdd60[index] = "";
                }

                //save to array
                var lines = File.ReadAllLines(path);
                var lineCount = File.ReadLines(path).Count();

                for (int index = 0; index < lineCount; index++)
                {
                    string temp = lines[index];

                    int NoFrom = temp.IndexOf("&") + 1;
                    int NoTo = temp.LastIndexOf("&&");

                    int TimeFrom = temp.IndexOf("&&") + 2;
                    int TimeTo = temp.LastIndexOf("#");

                    string NumberOnly = temp.Substring(NoFrom, NoTo - NoFrom);
                    string TimeOnly = temp.Substring(TimeFrom, TimeTo - TimeFrom);

                    if (NumberOnly == comboBoxAllPlayers2.Text)
                    {
                        TimeAdd60[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(Add60) + "#";
                    }
                    else
                    {
                        TimeAdd60[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(TimeOnly) + "#";
                    }
                }
                //update txt file
                if (TimeAdd60[0] != "")
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine(TimeAdd60[0]);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.Write("");
                    }
                }

                for (int index = 1; index < NumberOfPlayers; index++)
                {
                    if (TimeAdd60[index] != "")
                    {
                        using (StreamWriter stream = new FileInfo(path).AppendText())
                        {
                            stream.WriteLine(TimeAdd60[index]);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Warning: Unable to add time for this player!");
            }

        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(path2);
            int temp = Convert.ToInt32(lines[0]);

            temp = temp - 1;

            if (temp >= 0)
            {
                using (StreamWriter writer = new StreamWriter(path2))
                {
                    writer.Write(Convert.ToString(temp));
                }
            }
            else
            {
                //stop timer
                timerCountDown.Enabled=false;
                timerCheck.Enabled=false;
                timerElapse.Enabled = false; ;

                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }

        }

      /*  private void btnSlower2_Click(object sender, EventArgs e)
        {
            timerElapse.Interval = 2000;
            timerCheck.Interval = 2000;
            timerCountDown.Interval = 2000;
        }*/

        /*private void btnOpenAudioFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            if (open1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                audioFilePath = open1.FileName;

                MessageBox.Show("Audio Has been successfully enterd into the system, Thanks.");
            }
        }*/

        void fileExitMenuItem_Click(object sender, ChurchGamePage2 e)
        {
            // Close this window
            this.Close();
        }

        private void btnConfrimScreenSize_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(txtH.Text) > 599 && Convert.ToInt32(txtW.Text) > 599))
            {
                screenHeight = Convert.ToInt32(txtH.Text);
                screenWidth = Convert.ToInt32(txtW.Text);

                MessageBox.Show("New Screen Resolution data has been entered. Thanks!");
            }
            else
            {
                MessageBox.Show("Pls enter the valid screen resolution height and width.");
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnResume.Enabled = true;
            btnStart.Enabled = false;

            lblTimeElapseDisplayMM.Text = "0";
            lblTimeElapseDisplaySS.Text = "0";

            timerElapse.Enabled = true;
        
            //Start Timer to count down-------------------------------------------------------
            timerCountDown.Enabled = true;
            //--------------------------------------------------------------------------
        }

        private void btnAddTime300s_Click(object sender, EventArgs e)
        {
            //+300sec
            try
            {
                int Add60 = Convert.ToInt32(lblTimeLeft2.Text) + 300;

                string[] TimeAdd60 = new string[100];
                //clear array
                for (int index = 0; index < 100; index++)
                {
                    TimeAdd60[index] = "";
                }

                //save to array
                var lines = File.ReadAllLines(path);
                var lineCount = File.ReadLines(path).Count();

                for (int index = 0; index < lineCount; index++)
                {
                    string temp = lines[index];

                    int NoFrom = temp.IndexOf("&") + 1;
                    int NoTo = temp.LastIndexOf("&&");

                    int TimeFrom = temp.IndexOf("&&") + 2;
                    int TimeTo = temp.LastIndexOf("#");

                    string NumberOnly = temp.Substring(NoFrom, NoTo - NoFrom);
                    string TimeOnly = temp.Substring(TimeFrom, TimeTo - TimeFrom);

                    if (NumberOnly == comboBoxAllPlayers2.Text)
                    {
                        TimeAdd60[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(Add60) + "#";
                    }
                    else
                    {
                        TimeAdd60[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(TimeOnly) + "#";
                    }
                }
                //update txt file
                if (TimeAdd60[0] != "")
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine(TimeAdd60[0]);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.Write("");
                    }
                }

                for (int index = 1; index < NumberOfPlayers; index++)
                {
                    if (TimeAdd60[index] != "")
                    {
                        using (StreamWriter stream = new FileInfo(path).AppendText())
                        {
                            stream.WriteLine(TimeAdd60[index]);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Warning: Unable to add time for this player!");
            }
        }

        private void btnAddTime500s_Click(object sender, EventArgs e)
        {
            //+500sec
            try
            {
                int Add60 = Convert.ToInt32(lblTimeLeft2.Text) + 500;

                string[] TimeAdd60 = new string[100];
                //clear array
                for (int index = 0; index < 100; index++)
                {
                    TimeAdd60[index] = "";
                }

                //save to array
                var lines = File.ReadAllLines(path);
                var lineCount = File.ReadLines(path).Count();

                for (int index = 0; index < lineCount; index++)
                {
                    string temp = lines[index];

                    int NoFrom = temp.IndexOf("&") + 1;
                    int NoTo = temp.LastIndexOf("&&");

                    int TimeFrom = temp.IndexOf("&&") + 2;
                    int TimeTo = temp.LastIndexOf("#");

                    string NumberOnly = temp.Substring(NoFrom, NoTo - NoFrom);
                    string TimeOnly = temp.Substring(TimeFrom, TimeTo - TimeFrom);

                    if (NumberOnly == comboBoxAllPlayers2.Text)
                    {
                        TimeAdd60[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(Add60) + "#";
                    }
                    else
                    {
                        TimeAdd60[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(TimeOnly) + "#";
                    }
                }
                //update txt file
                if (TimeAdd60[0] != "")
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine(TimeAdd60[0]);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.Write("");
                    }
                }

                for (int index = 1; index < NumberOfPlayers; index++)
                {
                    if (TimeAdd60[index] != "")
                    {
                        using (StreamWriter stream = new FileInfo(path).AppendText())
                        {
                            stream.WriteLine(TimeAdd60[index]);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Warning: Unable to add time for this player!");
            }
        }

        private void btnDeductTime100s_Click(object sender, EventArgs e)
        {
            //-100sec
            try
            {
                int Add60 = Convert.ToInt32(lblTimeLeft2.Text) - 100;

                string[] TimeAdd60 = new string[100];
                //clear array
                for (int index = 0; index < 100; index++)
                {
                    TimeAdd60[index] = "";
                }

                //save to array
                var lines = File.ReadAllLines(path);
                var lineCount = File.ReadLines(path).Count();

                for (int index = 0; index < lineCount; index++)
                {
                    string temp = lines[index];

                    int NoFrom = temp.IndexOf("&") + 1;
                    int NoTo = temp.LastIndexOf("&&");

                    int TimeFrom = temp.IndexOf("&&") + 2;
                    int TimeTo = temp.LastIndexOf("#");

                    string NumberOnly = temp.Substring(NoFrom, NoTo - NoFrom);
                    string TimeOnly = temp.Substring(TimeFrom, TimeTo - TimeFrom);

                    if (NumberOnly == comboBoxAllPlayers2.Text)
                    {
                        TimeAdd60[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(Add60) + "#";
                    }
                    else
                    {
                        TimeAdd60[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(TimeOnly) + "#";
                    }
                }
                //update txt file
                if (TimeAdd60[0] != "")
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine(TimeAdd60[0]);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.Write("");
                    }
                }

                for (int index = 1; index < NumberOfPlayers; index++)
                {
                    if (TimeAdd60[index] != "")
                    {
                        using (StreamWriter stream = new FileInfo(path).AppendText())
                        {
                            stream.WriteLine(TimeAdd60[index]);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Warning: Unable to add time for this player!");
            }
        }

        private void btnDeductTime300s_Click(object sender, EventArgs e)
        {
            //-300sec
            try
            {
                int Add60 = Convert.ToInt32(lblTimeLeft2.Text) -300;

                string[] TimeAdd60 = new string[100];
                //clear array
                for (int index = 0; index < 100; index++)
                {
                    TimeAdd60[index] = "";
                }

                //save to array
                var lines = File.ReadAllLines(path);
                var lineCount = File.ReadLines(path).Count();

                for (int index = 0; index < lineCount; index++)
                {
                    string temp = lines[index];

                    int NoFrom = temp.IndexOf("&") + 1;
                    int NoTo = temp.LastIndexOf("&&");

                    int TimeFrom = temp.IndexOf("&&") + 2;
                    int TimeTo = temp.LastIndexOf("#");

                    string NumberOnly = temp.Substring(NoFrom, NoTo - NoFrom);
                    string TimeOnly = temp.Substring(TimeFrom, TimeTo - TimeFrom);

                    if (NumberOnly == comboBoxAllPlayers2.Text)
                    {
                        TimeAdd60[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(Add60) + "#";
                    }
                    else
                    {
                        TimeAdd60[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(TimeOnly) + "#";
                    }
                }
                //update txt file
                if (TimeAdd60[0] != "")
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine(TimeAdd60[0]);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.Write("");
                    }
                }

                for (int index = 1; index < NumberOfPlayers; index++)
                {
                    if (TimeAdd60[index] != "")
                    {
                        using (StreamWriter stream = new FileInfo(path).AppendText())
                        {
                            stream.WriteLine(TimeAdd60[index]);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Warning: Unable to add time for this player!");
            }
        }

        private void btnDeductTime50s_Click(object sender, EventArgs e)
        {
            //-50sec
            try
            {
                int Add60 = Convert.ToInt32(lblTimeLeft2.Text) -50;

                string[] TimeAdd60 = new string[100];
                //clear array
                for (int index = 0; index < 100; index++)
                {
                    TimeAdd60[index] = "";
                }

                //save to array
                var lines = File.ReadAllLines(path);
                var lineCount = File.ReadLines(path).Count();

                for (int index = 0; index < lineCount; index++)
                {
                    string temp = lines[index];

                    int NoFrom = temp.IndexOf("&") + 1;
                    int NoTo = temp.LastIndexOf("&&");

                    int TimeFrom = temp.IndexOf("&&") + 2;
                    int TimeTo = temp.LastIndexOf("#");

                    string NumberOnly = temp.Substring(NoFrom, NoTo - NoFrom);
                    string TimeOnly = temp.Substring(TimeFrom, TimeTo - TimeFrom);

                    if (NumberOnly == comboBoxAllPlayers2.Text)
                    {
                        TimeAdd60[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(Add60) + "#";
                    }
                    else
                    {
                        TimeAdd60[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(TimeOnly) + "#";
                    }
                }
                //update txt file
                if (TimeAdd60[0] != "")
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine(TimeAdd60[0]);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.Write("");
                    }
                }

                for (int index = 1; index < NumberOfPlayers; index++)
                {
                    if (TimeAdd60[index] != "")
                    {
                        using (StreamWriter stream = new FileInfo(path).AppendText())
                        {
                            stream.WriteLine(TimeAdd60[index]);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Warning: Unable to add time for this player!");
            }
        }

        private void btnDeductTime500s_Click(object sender, EventArgs e)
        {
            //-500sec
            try
            {
                int Add60 = Convert.ToInt32(lblTimeLeft2.Text) -500;

                string[] TimeAdd60 = new string[100];
                //clear array
                for (int index = 0; index < 100; index++)
                {
                    TimeAdd60[index] = "";
                }

                //save to array
                var lines = File.ReadAllLines(path);
                var lineCount = File.ReadLines(path).Count();

                for (int index = 0; index < lineCount; index++)
                {
                    string temp = lines[index];

                    int NoFrom = temp.IndexOf("&") + 1;
                    int NoTo = temp.LastIndexOf("&&");

                    int TimeFrom = temp.IndexOf("&&") + 2;
                    int TimeTo = temp.LastIndexOf("#");

                    string NumberOnly = temp.Substring(NoFrom, NoTo - NoFrom);
                    string TimeOnly = temp.Substring(TimeFrom, TimeTo - TimeFrom);

                    if (NumberOnly == comboBoxAllPlayers2.Text)
                    {
                        TimeAdd60[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(Add60) + "#";
                    }
                    else
                    {
                        TimeAdd60[Convert.ToInt32(NumberOnly) - 1] = "&" + NumberOnly + "&&" + Convert.ToString(TimeOnly) + "#";
                    }
                }
                //update txt file
                if (TimeAdd60[0] != "")
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine(TimeAdd60[0]);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.Write("");
                    }
                }

                for (int index = 1; index < NumberOfPlayers; index++)
                {
                    if (TimeAdd60[index] != "")
                    {
                        using (StreamWriter stream = new FileInfo(path).AppendText())
                        {
                            stream.WriteLine(TimeAdd60[index]);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Warning: Unable to add time for this player!");
            }
        }
    }
}
