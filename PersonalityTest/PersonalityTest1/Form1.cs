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
    public partial class Form1 : Form
    {
        string path = "QuestionDatabase.txt";
        int NoOfLinesInTheFile = 0;
        int pageNoTotal = 0;

        public Form1()
        {
            InitializeComponent();

            //count how many lines in the file
            var lines = File.ReadAllLines(path);
            var lineCount = File.ReadLines(path).Count();

            for (int index = 0; index < lineCount; index++)
            {
                //origianlData[index] = lines[index];
                NoOfLinesInTheFile++;

            }

            pageNoTotal = NoOfLinesInTheFile / 5;

        }

        string userName = "";
        string date = "";
        string userSex = "";
        string userSituation = "";


    

        private void chkboxM_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxM.Checked == true)
            {
                userSex = "M";
                chkboxF.Enabled = false;
            }
            else
            {
                userSex = "";
                chkboxF.Enabled = true;
            }
        }

        private void chkboxF_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxF.Checked == true)
            {
                userSex = "F";
                chkboxM.Enabled = false;
            }
            else
            {
                userSex = "";
                chkboxM.Enabled = true;
            }
        }

        private void chkboxWork_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxWork.Checked == true)
            {
                userSituation = "Work";

                chkboxSocial.Enabled = false;
                chkboxFamily.Enabled = false;
            }
            else
            {
                userSituation = "";

                chkboxSocial.Enabled = true;
                chkboxFamily.Enabled = true;
            }
        }

        private void chkboxSocial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxSocial.Checked == true)
            {
                userSituation = "Social";

                chkboxWork.Enabled = false;
                chkboxFamily.Enabled = false;
            }
            else
            {
                userSituation = "";

                chkboxWork.Enabled = true;
                chkboxFamily.Enabled = true;
            }
        }

        private void chkboxFamily_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxFamily.Checked == true)
            {
                userSituation = "Family";

                chkboxWork.Enabled = false;
                chkboxSocial.Enabled = false;
            }
            else
            {
                userSituation = "";

                chkboxWork.Enabled = true;
                chkboxSocial.Enabled = true;
            }
        }

      


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            userName = txtName.Text;
            date=Convert.ToString(dateTimePicker1.Text);

            if (userName == "")
            {
                MessageBox.Show("请填写您的姓名。   Please fill in your name.");
            }
            else if (userSex == "")
            {
                MessageBox.Show("请选择您的性别。   Please choose your sex.");
            }
            else if (userSituation == "")
            {
                MessageBox.Show("请选择您所处的环境或扮演的角色。   Please choose your situation.");
            }
            else
            {
                QuestionPage page2 = new QuestionPage(userName, date, userSex, userSituation, NoOfLinesInTheFile, pageNoTotal);
                page2.Show();
                this.Hide();
            }
        }

   
    }
}
