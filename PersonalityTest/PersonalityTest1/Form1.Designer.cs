namespace PersonalityTest1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.chkboxM = new System.Windows.Forms.CheckBox();
            this.chkboxF = new System.Windows.Forms.CheckBox();
            this.chkboxSocial = new System.Windows.Forms.CheckBox();
            this.chkboxWork = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSituation = new System.Windows.Forms.Label();
            this.chkboxFamily = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(277, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 22);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(51, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "姓名（Name）：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate.Location = new System.Drawing.Point(48, 164);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(116, 23);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "日期（Date）：";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSex
            // 
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSex.Location = new System.Drawing.Point(45, 223);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(116, 23);
            this.lblSex.TabIndex = 4;
            this.lblSex.Text = "性别（Sex）：";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkboxM
            // 
            this.chkboxM.AutoSize = true;
            this.chkboxM.BackColor = System.Drawing.Color.Transparent;
            this.chkboxM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkboxM.Location = new System.Drawing.Point(277, 222);
            this.chkboxM.Name = "chkboxM";
            this.chkboxM.Size = new System.Drawing.Size(73, 21);
            this.chkboxM.TabIndex = 5;
            this.chkboxM.Text = "男（M）";
            this.chkboxM.UseVisualStyleBackColor = false;
            this.chkboxM.CheckedChanged += new System.EventHandler(this.chkboxM_CheckedChanged);
            // 
            // chkboxF
            // 
            this.chkboxF.AutoSize = true;
            this.chkboxF.BackColor = System.Drawing.Color.Transparent;
            this.chkboxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkboxF.Location = new System.Drawing.Point(277, 250);
            this.chkboxF.Name = "chkboxF";
            this.chkboxF.Size = new System.Drawing.Size(70, 21);
            this.chkboxF.TabIndex = 6;
            this.chkboxF.Text = "女（F）";
            this.chkboxF.UseVisualStyleBackColor = false;
            this.chkboxF.CheckedChanged += new System.EventHandler(this.chkboxF_CheckedChanged);
            // 
            // chkboxSocial
            // 
            this.chkboxSocial.AutoSize = true;
            this.chkboxSocial.BackColor = System.Drawing.Color.Transparent;
            this.chkboxSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxSocial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkboxSocial.Location = new System.Drawing.Point(277, 329);
            this.chkboxSocial.Name = "chkboxSocial";
            this.chkboxSocial.Size = new System.Drawing.Size(120, 21);
            this.chkboxSocial.TabIndex = 9;
            this.chkboxSocial.Text = "社交（Social）";
            this.chkboxSocial.UseVisualStyleBackColor = false;
            this.chkboxSocial.CheckedChanged += new System.EventHandler(this.chkboxSocial_CheckedChanged);
            // 
            // chkboxWork
            // 
            this.chkboxWork.AutoSize = true;
            this.chkboxWork.BackColor = System.Drawing.Color.Transparent;
            this.chkboxWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxWork.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkboxWork.Location = new System.Drawing.Point(277, 301);
            this.chkboxWork.Name = "chkboxWork";
            this.chkboxWork.Size = new System.Drawing.Size(113, 21);
            this.chkboxWork.TabIndex = 8;
            this.chkboxWork.Text = "工作（Work）";
            this.chkboxWork.UseVisualStyleBackColor = false;
            this.chkboxWork.CheckedChanged += new System.EventHandler(this.chkboxWork_CheckedChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(47, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "所处的环境或";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSituation
            // 
            this.lblSituation.BackColor = System.Drawing.Color.Transparent;
            this.lblSituation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSituation.Location = new System.Drawing.Point(61, 322);
            this.lblSituation.Name = "lblSituation";
            this.lblSituation.Size = new System.Drawing.Size(171, 28);
            this.lblSituation.TabIndex = 10;
            this.lblSituation.Text = "扮演的角色（Situation）：";
            this.lblSituation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkboxFamily
            // 
            this.chkboxFamily.AutoSize = true;
            this.chkboxFamily.BackColor = System.Drawing.Color.Transparent;
            this.chkboxFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxFamily.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkboxFamily.Location = new System.Drawing.Point(277, 356);
            this.chkboxFamily.Name = "chkboxFamily";
            this.chkboxFamily.Size = new System.Drawing.Size(122, 21);
            this.chkboxFamily.TabIndex = 11;
            this.chkboxFamily.Text = "家庭（Family）";
            this.chkboxFamily.UseVisualStyleBackColor = false;
            this.chkboxFamily.CheckedChanged += new System.EventHandler(this.chkboxFamily_CheckedChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.Location = new System.Drawing.Point(277, 397);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(203, 38);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "确认（Confirm）";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(277, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(521, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.chkboxFamily);
            this.Controls.Add(this.lblSituation);
            this.Controls.Add(this.chkboxSocial);
            this.Controls.Add(this.chkboxWork);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkboxF);
            this.Controls.Add(this.chkboxM);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "性格测试（DISC Test）_Page1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.CheckBox chkboxM;
        private System.Windows.Forms.CheckBox chkboxF;
        private System.Windows.Forms.CheckBox chkboxSocial;
        private System.Windows.Forms.CheckBox chkboxWork;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSituation;
        private System.Windows.Forms.CheckBox chkboxFamily;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

