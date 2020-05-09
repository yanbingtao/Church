namespace ChurchGame
{
    partial class ChurchGamePage2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDisplay1 = new System.Windows.Forms.Label();
            this.comboBoxAllPlayers = new System.Windows.Forms.ComboBox();
            this.lblDisplay2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtTimeLeft = new System.Windows.Forms.TextBox();
            this.lblDisplay4 = new System.Windows.Forms.Label();
            this.lblDisplay3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerElapse = new System.Windows.Forms.Timer(this.components);
            this.lblTimeElapse = new System.Windows.Forms.Label();
            this.lblTimeElapseDisplayMM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeElapseDisplaySS = new System.Windows.Forms.Label();
            this.btnShowDisplayScreen = new System.Windows.Forms.Button();
            this.btnTimeLeftDevideTwo = new System.Windows.Forms.Button();
            this.btnTimeFaster8 = new System.Windows.Forms.Button();
            this.lblDisplay5 = new System.Windows.Forms.Label();
            this.comboBoxAllPlayers2 = new System.Windows.Forms.ComboBox();
            this.lblDisplay6 = new System.Windows.Forms.Label();
            this.btnAddTime50s = new System.Windows.Forms.Button();
            this.btnAddTime100s = new System.Windows.Forms.Button();
            this.btnTimeFaster7 = new System.Windows.Forms.Button();
            this.btnTimeFaster9 = new System.Windows.Forms.Button();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.btnTimeNormal = new System.Windows.Forms.Button();
            this.lblTimeLeft2 = new System.Windows.Forms.Label();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.btnConfrimScreenSize = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnAddTime500s = new System.Windows.Forms.Button();
            this.btnAddTime300s = new System.Windows.Forms.Button();
            this.btnDeductTime300s = new System.Windows.Forms.Button();
            this.btnDeductTime100s = new System.Windows.Forms.Button();
            this.btnDeductTime500s = new System.Windows.Forms.Button();
            this.btnDeductTime50s = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay1
            // 
            this.lblDisplay1.BackColor = System.Drawing.Color.DarkGreen;
            this.lblDisplay1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplay1.Location = new System.Drawing.Point(37, 18);
            this.lblDisplay1.Name = "lblDisplay1";
            this.lblDisplay1.Size = new System.Drawing.Size(620, 36);
            this.lblDisplay1.TabIndex = 0;
            this.lblDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxAllPlayers
            // 
            this.comboBoxAllPlayers.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxAllPlayers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAllPlayers.FormattingEnabled = true;
            this.comboBoxAllPlayers.Location = new System.Drawing.Point(419, 90);
            this.comboBoxAllPlayers.Name = "comboBoxAllPlayers";
            this.comboBoxAllPlayers.Size = new System.Drawing.Size(238, 37);
            this.comboBoxAllPlayers.TabIndex = 1;
            this.comboBoxAllPlayers.SelectedIndexChanged += new System.EventHandler(this.comboBoxAllPlayers_SelectedIndexChanged);
            // 
            // lblDisplay2
            // 
            this.lblDisplay2.BackColor = System.Drawing.SystemColors.Info;
            this.lblDisplay2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDisplay2.Location = new System.Drawing.Point(37, 90);
            this.lblDisplay2.Name = "lblDisplay2";
            this.lblDisplay2.Size = new System.Drawing.Size(355, 36);
            this.lblDisplay2.TabIndex = 2;
            this.lblDisplay2.Text = "Player\'s Serial No.:";
            this.lblDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(37, 306);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(620, 55);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtTimeLeft
            // 
            this.txtTimeLeft.BackColor = System.Drawing.Color.Navy;
            this.txtTimeLeft.Enabled = false;
            this.txtTimeLeft.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeLeft.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTimeLeft.Location = new System.Drawing.Point(419, 249);
            this.txtTimeLeft.Name = "txtTimeLeft";
            this.txtTimeLeft.Size = new System.Drawing.Size(238, 35);
            this.txtTimeLeft.TabIndex = 5;
            // 
            // lblDisplay4
            // 
            this.lblDisplay4.BackColor = System.Drawing.Color.Navy;
            this.lblDisplay4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplay4.Location = new System.Drawing.Point(37, 248);
            this.lblDisplay4.Name = "lblDisplay4";
            this.lblDisplay4.Size = new System.Drawing.Size(355, 36);
            this.lblDisplay4.TabIndex = 6;
            this.lblDisplay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplay3
            // 
            this.lblDisplay3.BackColor = System.Drawing.Color.DarkGreen;
            this.lblDisplay3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplay3.Location = new System.Drawing.Point(37, 198);
            this.lblDisplay3.Name = "lblDisplay3";
            this.lblDisplay3.Size = new System.Drawing.Size(620, 36);
            this.lblDisplay3.TabIndex = 7;
            this.lblDisplay3.Text = "Please choose the Player\'s Serial Number first, Thanks!";
            this.lblDisplay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(37, 670);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(258, 55);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(481, 670);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(174, 55);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerElapse
            // 
            this.timerElapse.Interval = 1000;
            this.timerElapse.Tick += new System.EventHandler(this.timerElapse_Tick);
            // 
            // lblTimeElapse
            // 
            this.lblTimeElapse.AutoSize = true;
            this.lblTimeElapse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapse.Location = new System.Drawing.Point(117, 629);
            this.lblTimeElapse.Name = "lblTimeElapse";
            this.lblTimeElapse.Size = new System.Drawing.Size(257, 29);
            this.lblTimeElapse.TabIndex = 10;
            this.lblTimeElapse.Text = "Time Elapse (Min : Sec):";
            // 
            // lblTimeElapseDisplayMM
            // 
            this.lblTimeElapseDisplayMM.AutoSize = true;
            this.lblTimeElapseDisplayMM.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapseDisplayMM.Location = new System.Drawing.Point(414, 629);
            this.lblTimeElapseDisplayMM.Name = "lblTimeElapseDisplayMM";
            this.lblTimeElapseDisplayMM.Size = new System.Drawing.Size(25, 29);
            this.lblTimeElapseDisplayMM.TabIndex = 11;
            this.lblTimeElapseDisplayMM.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 629);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // lblTimeElapseDisplaySS
            // 
            this.lblTimeElapseDisplaySS.AutoSize = true;
            this.lblTimeElapseDisplaySS.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapseDisplaySS.Location = new System.Drawing.Point(528, 629);
            this.lblTimeElapseDisplaySS.Name = "lblTimeElapseDisplaySS";
            this.lblTimeElapseDisplaySS.Size = new System.Drawing.Size(25, 29);
            this.lblTimeElapseDisplaySS.TabIndex = 13;
            this.lblTimeElapseDisplaySS.Text = "0";
            // 
            // btnShowDisplayScreen
            // 
            this.btnShowDisplayScreen.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnShowDisplayScreen.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDisplayScreen.Location = new System.Drawing.Point(37, 566);
            this.btnShowDisplayScreen.Name = "btnShowDisplayScreen";
            this.btnShowDisplayScreen.Size = new System.Drawing.Size(620, 53);
            this.btnShowDisplayScreen.TabIndex = 14;
            this.btnShowDisplayScreen.Text = "Show Display Screen";
            this.btnShowDisplayScreen.UseVisualStyleBackColor = false;
            this.btnShowDisplayScreen.Click += new System.EventHandler(this.btnShowDisplayScreen_Click);
            // 
            // btnTimeLeftDevideTwo
            // 
            this.btnTimeLeftDevideTwo.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTimeLeftDevideTwo.Enabled = false;
            this.btnTimeLeftDevideTwo.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeLeftDevideTwo.Location = new System.Drawing.Point(711, 142);
            this.btnTimeLeftDevideTwo.Name = "btnTimeLeftDevideTwo";
            this.btnTimeLeftDevideTwo.Size = new System.Drawing.Size(739, 55);
            this.btnTimeLeftDevideTwo.TabIndex = 15;
            this.btnTimeLeftDevideTwo.Text = "Time Left / 2";
            this.btnTimeLeftDevideTwo.UseVisualStyleBackColor = false;
            this.btnTimeLeftDevideTwo.Click += new System.EventHandler(this.btnTimeLeftDevideTwo_Click);
            // 
            // btnTimeFaster8
            // 
            this.btnTimeFaster8.BackColor = System.Drawing.Color.Turquoise;
            this.btnTimeFaster8.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeFaster8.Location = new System.Drawing.Point(1087, 607);
            this.btnTimeFaster8.Name = "btnTimeFaster8";
            this.btnTimeFaster8.Size = new System.Drawing.Size(356, 52);
            this.btnTimeFaster8.TabIndex = 16;
            this.btnTimeFaster8.Text = "Time Faster (0.8s=1s)";
            this.btnTimeFaster8.UseVisualStyleBackColor = false;
            this.btnTimeFaster8.Click += new System.EventHandler(this.btnTimeFaster8_Click);
            // 
            // lblDisplay5
            // 
            this.lblDisplay5.BackColor = System.Drawing.SystemColors.Info;
            this.lblDisplay5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDisplay5.Location = new System.Drawing.Point(711, 18);
            this.lblDisplay5.Name = "lblDisplay5";
            this.lblDisplay5.Size = new System.Drawing.Size(355, 36);
            this.lblDisplay5.TabIndex = 18;
            this.lblDisplay5.Text = "Player\'s Serial No.:";
            this.lblDisplay5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxAllPlayers2
            // 
            this.comboBoxAllPlayers2.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxAllPlayers2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAllPlayers2.FormattingEnabled = true;
            this.comboBoxAllPlayers2.Location = new System.Drawing.Point(1093, 18);
            this.comboBoxAllPlayers2.Name = "comboBoxAllPlayers2";
            this.comboBoxAllPlayers2.Size = new System.Drawing.Size(357, 37);
            this.comboBoxAllPlayers2.TabIndex = 17;
            this.comboBoxAllPlayers2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAllPlayers2_SelectedIndexChanged);
            // 
            // lblDisplay6
            // 
            this.lblDisplay6.BackColor = System.Drawing.Color.Navy;
            this.lblDisplay6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplay6.Location = new System.Drawing.Point(711, 83);
            this.lblDisplay6.Name = "lblDisplay6";
            this.lblDisplay6.Size = new System.Drawing.Size(355, 36);
            this.lblDisplay6.TabIndex = 20;
            this.lblDisplay6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddTime50s
            // 
            this.btnAddTime50s.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddTime50s.Enabled = false;
            this.btnAddTime50s.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTime50s.Location = new System.Drawing.Point(707, 219);
            this.btnAddTime50s.Name = "btnAddTime50s";
            this.btnAddTime50s.Size = new System.Drawing.Size(375, 55);
            this.btnAddTime50s.TabIndex = 21;
            this.btnAddTime50s.Text = "Add Time (+50S)";
            this.btnAddTime50s.UseVisualStyleBackColor = false;
            this.btnAddTime50s.Click += new System.EventHandler(this.btnAddTime30s_Click);
            // 
            // btnAddTime100s
            // 
            this.btnAddTime100s.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddTime100s.Enabled = false;
            this.btnAddTime100s.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTime100s.Location = new System.Drawing.Point(1098, 219);
            this.btnAddTime100s.Name = "btnAddTime100s";
            this.btnAddTime100s.Size = new System.Drawing.Size(352, 55);
            this.btnAddTime100s.TabIndex = 22;
            this.btnAddTime100s.Text = "Add Time (+100S)";
            this.btnAddTime100s.UseVisualStyleBackColor = false;
            this.btnAddTime100s.Click += new System.EventHandler(this.btnAddTime60s_Click);
            // 
            // btnTimeFaster7
            // 
            this.btnTimeFaster7.BackColor = System.Drawing.Color.Turquoise;
            this.btnTimeFaster7.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeFaster7.Location = new System.Drawing.Point(711, 670);
            this.btnTimeFaster7.Name = "btnTimeFaster7";
            this.btnTimeFaster7.Size = new System.Drawing.Size(355, 52);
            this.btnTimeFaster7.TabIndex = 23;
            this.btnTimeFaster7.Text = "Time Faster (0.7s=1s)";
            this.btnTimeFaster7.UseVisualStyleBackColor = false;
            this.btnTimeFaster7.Click += new System.EventHandler(this.btnTimeFaster7_Click);
            // 
            // btnTimeFaster9
            // 
            this.btnTimeFaster9.BackColor = System.Drawing.Color.Turquoise;
            this.btnTimeFaster9.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeFaster9.Location = new System.Drawing.Point(711, 608);
            this.btnTimeFaster9.Name = "btnTimeFaster9";
            this.btnTimeFaster9.Size = new System.Drawing.Size(355, 51);
            this.btnTimeFaster9.TabIndex = 24;
            this.btnTimeFaster9.Text = "Time Faster (0.9s=1s)";
            this.btnTimeFaster9.UseVisualStyleBackColor = false;
            this.btnTimeFaster9.Click += new System.EventHandler(this.btnTimeFaster9_Click);
            // 
            // timerCheck
            // 
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // btnTimeNormal
            // 
            this.btnTimeNormal.BackColor = System.Drawing.Color.Turquoise;
            this.btnTimeNormal.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeNormal.Location = new System.Drawing.Point(1087, 667);
            this.btnTimeNormal.Name = "btnTimeNormal";
            this.btnTimeNormal.Size = new System.Drawing.Size(356, 55);
            this.btnTimeNormal.TabIndex = 25;
            this.btnTimeNormal.Text = "Back to Normal Time (1s=1s)";
            this.btnTimeNormal.UseVisualStyleBackColor = false;
            this.btnTimeNormal.Click += new System.EventHandler(this.btnTimeNormal_Click);
            // 
            // lblTimeLeft2
            // 
            this.lblTimeLeft2.BackColor = System.Drawing.Color.Navy;
            this.lblTimeLeft2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimeLeft2.Location = new System.Drawing.Point(1093, 83);
            this.lblTimeLeft2.Name = "lblTimeLeft2";
            this.lblTimeLeft2.Size = new System.Drawing.Size(357, 36);
            this.lblTimeLeft2.TabIndex = 26;
            this.lblTimeLeft2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1000;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(37, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 36);
            this.label2.TabIndex = 28;
            this.label2.Text = "Height of the screen:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtH
            // 
            this.txtH.BackColor = System.Drawing.Color.LimeGreen;
            this.txtH.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtH.Location = new System.Drawing.Point(419, 400);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(238, 35);
            this.txtH.TabIndex = 27;
            this.txtH.Text = "900";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LimeGreen;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(37, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 35);
            this.label3.TabIndex = 30;
            this.label3.Text = "Width of the screen:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtW
            // 
            this.txtW.BackColor = System.Drawing.Color.LimeGreen;
            this.txtW.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtW.Location = new System.Drawing.Point(419, 446);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(238, 35);
            this.txtW.TabIndex = 29;
            this.txtW.Text = "1600";
            // 
            // btnConfrimScreenSize
            // 
            this.btnConfrimScreenSize.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfrimScreenSize.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfrimScreenSize.Location = new System.Drawing.Point(37, 494);
            this.btnConfrimScreenSize.Name = "btnConfrimScreenSize";
            this.btnConfrimScreenSize.Size = new System.Drawing.Size(620, 55);
            this.btnConfrimScreenSize.TabIndex = 31;
            this.btnConfrimScreenSize.Text = "Confirm";
            this.btnConfrimScreenSize.UseVisualStyleBackColor = false;
            this.btnConfrimScreenSize.Click += new System.EventHandler(this.btnConfrimScreenSize_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.PeachPuff;
            this.btnResume.Enabled = false;
            this.btnResume.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.Location = new System.Drawing.Point(301, 670);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(174, 55);
            this.btnResume.TabIndex = 32;
            this.btnResume.Text = "Resume ";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnAddTime500s
            // 
            this.btnAddTime500s.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddTime500s.Enabled = false;
            this.btnAddTime500s.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTime500s.Location = new System.Drawing.Point(1098, 280);
            this.btnAddTime500s.Name = "btnAddTime500s";
            this.btnAddTime500s.Size = new System.Drawing.Size(352, 55);
            this.btnAddTime500s.TabIndex = 34;
            this.btnAddTime500s.Text = "Add Time (+500S)";
            this.btnAddTime500s.UseVisualStyleBackColor = false;
            this.btnAddTime500s.Click += new System.EventHandler(this.btnAddTime500s_Click);
            // 
            // btnAddTime300s
            // 
            this.btnAddTime300s.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddTime300s.Enabled = false;
            this.btnAddTime300s.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTime300s.Location = new System.Drawing.Point(707, 280);
            this.btnAddTime300s.Name = "btnAddTime300s";
            this.btnAddTime300s.Size = new System.Drawing.Size(375, 55);
            this.btnAddTime300s.TabIndex = 33;
            this.btnAddTime300s.Text = "Add Time (+300S)";
            this.btnAddTime300s.UseVisualStyleBackColor = false;
            this.btnAddTime300s.Click += new System.EventHandler(this.btnAddTime300s_Click);
            // 
            // btnDeductTime300s
            // 
            this.btnDeductTime300s.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDeductTime300s.Enabled = false;
            this.btnDeductTime300s.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeductTime300s.Location = new System.Drawing.Point(707, 429);
            this.btnDeductTime300s.Name = "btnDeductTime300s";
            this.btnDeductTime300s.Size = new System.Drawing.Size(375, 55);
            this.btnDeductTime300s.TabIndex = 36;
            this.btnDeductTime300s.Text = "Deduct Time (-300S)";
            this.btnDeductTime300s.UseVisualStyleBackColor = false;
            this.btnDeductTime300s.Click += new System.EventHandler(this.btnDeductTime300s_Click);
            // 
            // btnDeductTime100s
            // 
            this.btnDeductTime100s.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDeductTime100s.Enabled = false;
            this.btnDeductTime100s.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeductTime100s.Location = new System.Drawing.Point(1098, 368);
            this.btnDeductTime100s.Name = "btnDeductTime100s";
            this.btnDeductTime100s.Size = new System.Drawing.Size(356, 55);
            this.btnDeductTime100s.TabIndex = 35;
            this.btnDeductTime100s.Text = "Deduct Time (-100S)";
            this.btnDeductTime100s.UseVisualStyleBackColor = false;
            this.btnDeductTime100s.Click += new System.EventHandler(this.btnDeductTime100s_Click);
            // 
            // btnDeductTime500s
            // 
            this.btnDeductTime500s.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDeductTime500s.Enabled = false;
            this.btnDeductTime500s.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeductTime500s.Location = new System.Drawing.Point(1098, 429);
            this.btnDeductTime500s.Name = "btnDeductTime500s";
            this.btnDeductTime500s.Size = new System.Drawing.Size(356, 55);
            this.btnDeductTime500s.TabIndex = 37;
            this.btnDeductTime500s.Text = "Deduct Time (-500S)";
            this.btnDeductTime500s.UseVisualStyleBackColor = false;
            this.btnDeductTime500s.Click += new System.EventHandler(this.btnDeductTime500s_Click);
            // 
            // btnDeductTime50s
            // 
            this.btnDeductTime50s.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDeductTime50s.Enabled = false;
            this.btnDeductTime50s.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeductTime50s.Location = new System.Drawing.Point(707, 368);
            this.btnDeductTime50s.Name = "btnDeductTime50s";
            this.btnDeductTime50s.Size = new System.Drawing.Size(375, 55);
            this.btnDeductTime50s.TabIndex = 38;
            this.btnDeductTime50s.Text = "Deduct Time (-50S)";
            this.btnDeductTime50s.UseVisualStyleBackColor = false;
            this.btnDeductTime50s.Click += new System.EventHandler(this.btnDeductTime50s_Click);
            // 
            // ChurchGamePage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 741);
            this.Controls.Add(this.btnDeductTime50s);
            this.Controls.Add(this.btnDeductTime500s);
            this.Controls.Add(this.btnDeductTime300s);
            this.Controls.Add(this.btnDeductTime100s);
            this.Controls.Add(this.btnAddTime500s);
            this.Controls.Add(this.btnAddTime300s);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnConfrimScreenSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblTimeLeft2);
            this.Controls.Add(this.btnTimeNormal);
            this.Controls.Add(this.btnTimeFaster9);
            this.Controls.Add(this.btnTimeFaster7);
            this.Controls.Add(this.btnAddTime100s);
            this.Controls.Add(this.btnAddTime50s);
            this.Controls.Add(this.lblDisplay6);
            this.Controls.Add(this.lblDisplay5);
            this.Controls.Add(this.comboBoxAllPlayers2);
            this.Controls.Add(this.btnTimeFaster8);
            this.Controls.Add(this.btnTimeLeftDevideTwo);
            this.Controls.Add(this.btnShowDisplayScreen);
            this.Controls.Add(this.lblTimeElapseDisplaySS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimeElapseDisplayMM);
            this.Controls.Add(this.lblTimeElapse);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDisplay3);
            this.Controls.Add(this.lblDisplay4);
            this.Controls.Add(this.txtTimeLeft);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblDisplay2);
            this.Controls.Add(this.comboBoxAllPlayers);
            this.Controls.Add(this.lblDisplay1);
            this.Name = "ChurchGamePage2";
            this.Text = "ChurchGame_ControlPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay1;
        private System.Windows.Forms.ComboBox comboBoxAllPlayers;
        private System.Windows.Forms.Label lblDisplay2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtTimeLeft;
        private System.Windows.Forms.Label lblDisplay4;
        private System.Windows.Forms.Label lblDisplay3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timerElapse;
        private System.Windows.Forms.Label lblTimeElapse;
        private System.Windows.Forms.Label lblTimeElapseDisplayMM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeElapseDisplaySS;
        private System.Windows.Forms.Button btnShowDisplayScreen;
        private System.Windows.Forms.Button btnTimeLeftDevideTwo;
        private System.Windows.Forms.Button btnTimeFaster8;
        private System.Windows.Forms.Label lblDisplay5;
        private System.Windows.Forms.ComboBox comboBoxAllPlayers2;
        private System.Windows.Forms.Label lblDisplay6;
        private System.Windows.Forms.Button btnAddTime50s;
        private System.Windows.Forms.Button btnAddTime100s;
        private System.Windows.Forms.Button btnTimeFaster7;
        private System.Windows.Forms.Button btnTimeFaster9;
        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.Button btnTimeNormal;
        private System.Windows.Forms.Label lblTimeLeft2;
        private System.Windows.Forms.Timer timerCountDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Button btnConfrimScreenSize;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnAddTime500s;
        private System.Windows.Forms.Button btnAddTime300s;
        private System.Windows.Forms.Button btnDeductTime300s;
        private System.Windows.Forms.Button btnDeductTime100s;
        private System.Windows.Forms.Button btnDeductTime500s;
        private System.Windows.Forms.Button btnDeductTime50s;
    }
}