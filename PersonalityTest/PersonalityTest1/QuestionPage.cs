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

namespace PersonalityTest1
{
    public partial class QuestionPage : Form
    {

        string path ="QuestionDatabase.txt";
        int NoOfLinesInTheFile1 = 0;
        int pageNoTotal1 = 0;
        int pageNoCurrent = 1;

        //create array to save data
        string[,] questionData = new string[100, 4]; // string[,] questionData = new string[pageNoTotal, 4];

        int[,] answerDate = new int[100,2]; //  int[,] answerDate = new int[pageNoTotal,2]; 
                                            // 1st row= best fit answer; 2nd row= least fit answer;


        public QuestionPage(string userName,string date,string userSex,string userSituation,int NoOfLinesInTheFile, int pageNoTotal)
        {
            InitializeComponent();

            NoOfLinesInTheFile1 = NoOfLinesInTheFile;
            pageNoTotal1 = pageNoTotal;


                //clear questionData array
                for (int a = 0; a < 100; a++)
                {
                    for (int b = 0; b < 4; b++)
                    {
                        questionData[a, b] = "";
                    }
                }

                //clear answerDate array
                for (int a = 0; a < 100; a++)
                {
                    for (int b = 0; b < 2; b++)
                    {
                        answerDate[a, b] = 0;
                    }
                }

            //read from the file,write them in the array 
            var lines1 = File.ReadAllLines(path);
            var lineCount1 = File.ReadLines(path).Count();

            for (int a = 0; a < lineCount1; a++)
            {
                int temp = (a + 1) % 5;

                if ( temp == 1)
                {
                    for (int b = 0; b < 4; b++)
                    {
                        questionData[((a+1)/5), b] = lines1[a+b];
                    }
                }

            }

            //display 1st question to the page from the array
            lblPageNo.Text = "Page " + Convert.ToString(pageNoCurrent) + " out of Page " + Convert.ToString(pageNoTotal1);
            
            //btnPrevious & btnNext control
            if (pageNoCurrent <= 1)
            {
                btnPrevious.Enabled = false;
            }
            else if (pageNoCurrent == pageNoTotal1)
            {
                btnNext.Enabled = false;
            }

            lblQ1.Text = questionData[0, 0];
            lblQ2.Text = questionData[0, 1];
            lblQ3.Text = questionData[0, 2];
            lblQ4.Text = questionData[0, 3];   

        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {

            // check user's choice and main program
            if (answerDate[pageNoCurrent - 1, 0] == 0)
            {
                MessageBox.Show("您还没有选择您的‘最贴切’选项，请选择。You haven't select you BEST-FIT answer, please select.");
            }
            else if (answerDate[pageNoCurrent - 1, 1] == 0)
            {
                MessageBox.Show("您还没有选择您的‘最不贴切’选项，请选择。You haven't select you LEAST-FIT answer, please select.");
            }
            else
            {
                pageNoCurrent++;

                /*//control btnPrevious, enable this button if possible
                if (pageNoCurrent <= 1)
                {
                    btnPrevious.Enabled = false;
                }
                else
                {
                    btnPrevious.Enabled = true;
                }

                //control btnFinish & btnNext
                if (pageNoCurrent > pageNoTotal1)
                {
                    btnFinish.Enabled = true;
                    btnNext.Enabled = false;
                }
                else
                {*/
                    //display next question to the page from the array
                    lblPageNo.Text = "Page " + Convert.ToString(pageNoCurrent) + " out of Page " + Convert.ToString(pageNoTotal1);

                //btnPrevious & btnNext control
                if (pageNoCurrent <= 1)
                {
                    btnPrevious.Enabled = false;
                }
                else if (pageNoCurrent >= pageNoTotal1)
                {
                    btnNext.Enabled = false;
                    btnFinish.Enabled = true;
                }
                else
                {
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnFinish.Enabled = false;
                }

                    lblQ1.Text = questionData[pageNoCurrent - 1, 0];
                    lblQ2.Text = questionData[pageNoCurrent - 1, 1];
                    lblQ3.Text = questionData[pageNoCurrent - 1, 2];
                    lblQ4.Text = questionData[pageNoCurrent - 1, 3];

                    //checkbox unselect control 
                    chkboxA1.Checked = false;
                    chkboxA2.Checked = false;
                    chkboxA3.Checked = false;
                    chkboxA4.Checked = false;

                    chkboxB1.Checked = false;
                    chkboxB2.Checked = false;
                    chkboxB3.Checked = false;
                    chkboxB4.Checked = false;


                /*}*/
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            /*if (answerDate[pageNoCurrent-1,0] == 0)
            {
                MessageBox.Show("您还没有选择您的‘最贴切’选项，请选择。You haven't select you BEST-FIT answer, please select.");
            }
            else if (answerDate[pageNoCurrent-1,1] == 0)
            {
                MessageBox.Show("您还没有选择您的‘最不贴切’选项，请选择。You haven't select you LEAST-FIT answer, please select.");
            }
            else
            {*/
            pageNoCurrent--;

            if (pageNoCurrent <= 1)
            {
                btnPrevious.Enabled = false;
            }
            /*else if (pageNoCurrent >= pageNoTotal1)
            {
                btnNext.Enabled = true;
                btnFinish.Enabled = false;
            }*/
            /*else
            {*/
                //display next question to the page from the array
                lblPageNo.Text = "Page " + Convert.ToString(pageNoCurrent) + " out of Page " + Convert.ToString(pageNoTotal1);

                //btnPrevious & btnNext control
                if (pageNoCurrent == 1)
                {
                    btnPrevious.Enabled = false;
                }
                else if (pageNoCurrent == pageNoTotal1)
                {
                    btnNext.Enabled = false;
                }

                lblQ1.Text = questionData[pageNoCurrent - 1, 0];
                lblQ2.Text = questionData[pageNoCurrent - 1, 1];
                lblQ3.Text = questionData[pageNoCurrent - 1, 2];
                lblQ4.Text = questionData[pageNoCurrent - 1, 3];

                //resume best fit answer
                if (answerDate[pageNoCurrent - 1, 0] == 1)
                {
                    chkboxA1.Checked = Enabled;
                }
                else if (answerDate[pageNoCurrent - 1, 0] == 2)
                {
                    chkboxA2.Checked = Enabled;
                }
                else if (answerDate[pageNoCurrent - 1, 0] == 3)
                {
                    chkboxA3.Checked = Enabled;
                }
                else if (answerDate[pageNoCurrent - 1, 0] == 4)
                {
                    chkboxA4.Checked = Enabled;
                }

                //resume least fit answer
                if (answerDate[pageNoCurrent - 1, 1] == 1)
                {
                    chkboxB1.Checked = Enabled;
                }
                else if (answerDate[pageNoCurrent - 1, 1] == 2)
                {
                    chkboxB2.Checked = Enabled;
                }
                else if (answerDate[pageNoCurrent - 1, 1] == 3)
                {
                    chkboxB3.Checked = Enabled;
                }
                else if (answerDate[pageNoCurrent - 1, 1] == 4)
                {
                    chkboxB4.Checked = Enabled;
                }
            /*}*/
            /*}*/
        }

        private void chkboxA1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxA1.Checked == true)
            {
                //Button enable control
                chkboxA2.Enabled = false;
                chkboxA3.Enabled = false;
                chkboxA4.Enabled = false;
                chkboxB1.Enabled = false;

                //write in answerDate array
                answerDate[ pageNoCurrent-1,0] = 1;
            }
            else
            {
                //Button enable control
                if (chkboxB1.Checked == true)
                {
                    chkboxA2.Enabled = true;
                    chkboxA3.Enabled = true;
                    chkboxA4.Enabled = true;
                }
                else if (chkboxB2.Checked == true)
                {
                    chkboxA1.Enabled = true;
                    chkboxA3.Enabled = true;
                    chkboxA4.Enabled = true;
                }
                else if (chkboxB3.Checked == true)
                {
                    chkboxA1.Enabled = true;
                    chkboxA2.Enabled = true;
                    chkboxA4.Enabled = true;
                }
                else if (chkboxB4.Checked == true)
                {
                    chkboxA1.Enabled = true;
                    chkboxA2.Enabled = true;
                    chkboxA3.Enabled = true;
                }
                else
                {
                    chkboxA2.Enabled = true;
                    chkboxA3.Enabled = true;
                    chkboxA4.Enabled = true;
                    chkboxB1.Enabled = true;
                }

                    //write in answerDate array
                    answerDate[pageNoCurrent - 1, 0] = 0;
            }
        }

        private void chkboxA2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxA2.Checked == true)
            {
                //Button enable control
                chkboxA1.Enabled = false;
                chkboxA3.Enabled = false;
                chkboxA4.Enabled = false;
                chkboxB2.Enabled = false;

                //write in answerDate array
                answerDate[pageNoCurrent - 1, 0] = 2;
            }
            else
            {
                //Button enable control
                if (chkboxB1.Checked == true)
                {
                    chkboxA2.Enabled = true;
                    chkboxA3.Enabled = true;
                    chkboxA4.Enabled = true;
                }
                else if (chkboxB2.Checked == true)
                {
                    chkboxA1.Enabled = true;
                    chkboxA3.Enabled = true;
                    chkboxA4.Enabled = true;
                }
                else if (chkboxB3.Checked == true)
                {
                    chkboxA1.Enabled = true;
                    chkboxA2.Enabled = true;
                    chkboxA4.Enabled = true;
                }
                else if (chkboxB4.Checked == true)
                {
                    chkboxA1.Enabled = true;
                    chkboxA2.Enabled = true;
                    chkboxA3.Enabled = true;
                }
                else
                {
                    chkboxA1.Enabled = true;
                    chkboxA3.Enabled = true;
                    chkboxA4.Enabled = true;
                    chkboxB2.Enabled = true;
                }

                //write in answerDate array
                answerDate[pageNoCurrent - 1, 0] = 0;
            }
        }

        private void chkboxA3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxA3.Checked == true)
            {
                //Button enable control
                chkboxA1.Enabled = false;
                chkboxA2.Enabled = false;
                chkboxA4.Enabled = false;
                chkboxB3.Enabled = false;

                //write in answerDate array
                answerDate[pageNoCurrent - 1, 0] = 3;
            }
            else
            {
                //Button enable control
                if (chkboxB1.Checked == true)
                {
                    chkboxA2.Enabled = true;
                    chkboxA3.Enabled = true;
                    chkboxA4.Enabled = true;
                }
                else if (chkboxB2.Checked == true)
                {
                    chkboxA1.Enabled = true;
                    chkboxA3.Enabled = true;
                    chkboxA4.Enabled = true;
                }
                else if (chkboxB3.Checked == true)
                {
                    chkboxA1.Enabled = true;
                    chkboxA2.Enabled = true;
                    chkboxA4.Enabled = true;
                }
                else if (chkboxB4.Checked == true)
                {
                    chkboxA1.Enabled = true;
                    chkboxA2.Enabled = true;
                    chkboxA3.Enabled = true;
                }
                else
                {
                    chkboxA1.Enabled = true;
                    chkboxA2.Enabled = true;
                    chkboxA4.Enabled = true;
                    chkboxB3.Enabled = true;
                }

                //write in answerDate array
                answerDate[pageNoCurrent - 1, 0] = 0;
            }
        }

        private void chkboxA4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxA4.Checked == true)
            {
                //Button enable control
                chkboxA1.Enabled = false;
                chkboxA2.Enabled = false;
                chkboxA3.Enabled = false;
                chkboxB4.Enabled = false;

                //write in answerDate array
                answerDate[pageNoCurrent - 1, 0] = 4;
            }
            else
            {
                //Button enable control
                if (chkboxB1.Checked == true)
                {
                    chkboxA2.Enabled = true;
                    chkboxA3.Enabled = true;
                    chkboxA4.Enabled = true;
                }
                else if (chkboxB2.Checked == true)
                {
                    chkboxA1.Enabled = true;
                    chkboxA3.Enabled = true;
                    chkboxA4.Enabled = true;
                }
                else if (chkboxB3.Checked == true)
                {
                    chkboxA1.Enabled = true;
                    chkboxA2.Enabled = true;
                    chkboxA4.Enabled = true;
                }
                else if (chkboxB4.Checked == true)
                {
                    chkboxA1.Enabled = true;
                    chkboxA2.Enabled = true;
                    chkboxA3.Enabled = true;
                }
                else
                {
                    chkboxA1.Enabled = true;
                    chkboxA2.Enabled = true;
                    chkboxA3.Enabled = true;
                    chkboxB4.Enabled = true;
                }

                //write in answerDate array
                answerDate[pageNoCurrent - 1, 0] = 0;
            }
        }

        private void chkboxB1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxB1.Checked == true)
            {
                //Button enable control
                chkboxB2.Enabled = false;
                chkboxB3.Enabled = false;
                chkboxB4.Enabled = false;
                chkboxA1.Enabled = false;

                //write in answerDate array
                answerDate[pageNoCurrent - 1, 1] = 1;
            }
            else
            {
                //Button enable control
                if (chkboxA1.Checked == true)
                {
                    chkboxB2.Enabled = true;
                    chkboxB3.Enabled = true;
                    chkboxB4.Enabled = true;
                }
                else if (chkboxA2.Checked == true)
                {
                    chkboxB1.Enabled = true;
                    chkboxB3.Enabled = true;
                    chkboxB4.Enabled = true;
                }
                else if (chkboxA3.Checked == true)
                {
                    chkboxB1.Enabled = true;
                    chkboxB2.Enabled = true;
                    chkboxB4.Enabled = true;
                }
                else if (chkboxA4.Checked == true)
                {
                    chkboxB1.Enabled = true;
                    chkboxB2.Enabled = true;
                    chkboxB3.Enabled = true;
                }
                else
                {
                    chkboxB2.Enabled = true;
                    chkboxB3.Enabled = true;
                    chkboxB4.Enabled = true;
                    chkboxA1.Enabled = true;
                }


                //write in answerDate array
                answerDate[pageNoCurrent - 1, 1] = 0;
            }
            
        }

        private void chkboxB2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxB2.Checked == true)
            {
                //Button enable control
                chkboxB1.Enabled = false;
                chkboxB3.Enabled = false;
                chkboxB4.Enabled = false;
                chkboxA2.Enabled = false;

                //write in answerDate array
                answerDate[pageNoCurrent - 1, 1] = 2;
            }
            else
            {
                //Button enable control
                if (chkboxA1.Checked == true)
                {
                    chkboxB2.Enabled = true;
                    chkboxB3.Enabled = true;
                    chkboxB4.Enabled = true;
                }
                else if (chkboxA2.Checked == true)
                {
                    chkboxB1.Enabled = true;
                    chkboxB3.Enabled = true;
                    chkboxB4.Enabled = true;
                }
                else if (chkboxA3.Checked == true)
                {
                    chkboxB1.Enabled = true;
                    chkboxB2.Enabled = true;
                    chkboxB4.Enabled = true;
                }
                else if (chkboxA4.Checked == true)
                {
                    chkboxB1.Enabled = true;
                    chkboxB2.Enabled = true;
                    chkboxB3.Enabled = true;
                }
                else
                {
                    chkboxB1.Enabled = true;
                    chkboxB3.Enabled = true;
                    chkboxB4.Enabled = true;
                    chkboxA2.Enabled = true;
                }

                //write in answerDate array
                answerDate[pageNoCurrent - 1, 1] = 0;
            }
        }

        private void chkboxB3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxB3.Checked == true)
            {
                //Button enable control
                chkboxB1.Enabled = false;
                chkboxB2.Enabled = false;
                chkboxB4.Enabled = false;
                chkboxA3.Enabled = false;

                //write in answerDate array
                answerDate[pageNoCurrent - 1, 1] = 3;
            }
            else
            {
                //Button enable control
                if (chkboxA1.Checked == true)
                {
                    chkboxB2.Enabled = true;
                    chkboxB3.Enabled = true;
                    chkboxB4.Enabled = true;
                }
                else if (chkboxA2.Checked == true)
                {
                    chkboxB1.Enabled = true;
                    chkboxB3.Enabled = true;
                    chkboxB4.Enabled = true;
                }
                else if (chkboxA3.Checked == true)
                {
                    chkboxB1.Enabled = true;
                    chkboxB2.Enabled = true;
                    chkboxB4.Enabled = true;
                }
                else if (chkboxA4.Checked == true)
                {
                    chkboxB1.Enabled = true;
                    chkboxB2.Enabled = true;
                    chkboxB3.Enabled = true;
                }
                else
                {
                    chkboxB1.Enabled = true;
                    chkboxB2.Enabled = true;
                    chkboxB4.Enabled = true;
                    chkboxA3.Enabled = true;
                }

                //write in answerDate array
                answerDate[pageNoCurrent - 1, 1] = 0;
            }
        }

        private void chkboxB4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxB4.Checked == true)
            {
                //Button enable control
                chkboxB1.Enabled = false;
                chkboxB2.Enabled = false;
                chkboxB3.Enabled = false;
                chkboxA4.Enabled = false;

                //write in answerDate array
                answerDate[pageNoCurrent - 1, 1] = 4;
            }
            else
            {
                //Button enable control
                if (chkboxA1.Checked == true)
                {
                    chkboxB2.Enabled = true;
                    chkboxB3.Enabled = true;
                    chkboxB4.Enabled = true;
                }
                else if (chkboxA2.Checked == true)
                {
                    chkboxB1.Enabled = true;
                    chkboxB3.Enabled = true;
                    chkboxB4.Enabled = true;
                }
                else if (chkboxA3.Checked == true)
                {
                    chkboxB1.Enabled = true;
                    chkboxB2.Enabled = true;
                    chkboxB4.Enabled = true;
                }
                else if (chkboxA4.Checked == true)
                {
                    chkboxB1.Enabled = true;
                    chkboxB2.Enabled = true;
                    chkboxB3.Enabled = true;
                }
                else
                {
                    chkboxB1.Enabled = true;
                    chkboxB2.Enabled = true;
                    chkboxB3.Enabled = true;
                    chkboxA4.Enabled = true;
                }

                //write in answerDate array
                answerDate[pageNoCurrent - 1, 1] = 0;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            //all checkboxes disable
            chkboxA1.Enabled = false;
            chkboxA2.Enabled = false;
            chkboxA3.Enabled = false;
            chkboxA4.Enabled = false;
            chkboxB1.Enabled = false;
            chkboxB2.Enabled = false;
            chkboxB3.Enabled = false;
            chkboxB4.Enabled = false;

            //TESTING
            for (int a = 0; a < pageNoTotal1; a++)
            {
                
                    MessageBox.Show(Convert.ToString(answerDate[a, 0]+"###"+ answerDate[a, 1]));
            }

        }
    }
}
