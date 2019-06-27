namespace CS_001_FirstFormsApp
{
    partial class FrmFirstApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirstApp));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.BtnHello = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GrpMood = new System.Windows.Forms.GroupBox();
            this.picSad = new System.Windows.Forms.PictureBox();
            this.picHappy = new System.Windows.Forms.PictureBox();
            this.rdoSad = new System.Windows.Forms.RadioButton();
            this.rdoHappy = new System.Windows.Forms.RadioButton();
            this.GrpOther = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.picTwo = new System.Windows.Forms.PictureBox();
            this.picOne = new System.Windows.Forms.PictureBox();
            this.GrpMood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHappy)).BeginInit();
            this.GrpOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(97, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(154, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to my first Forms app.";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // BtnHello
            // 
            this.BtnHello.Location = new System.Drawing.Point(542, 250);
            this.BtnHello.Name = "BtnHello";
            this.BtnHello.Size = new System.Drawing.Size(75, 23);
            this.BtnHello.TabIndex = 4;
            this.BtnHello.Text = "Hello";
            this.BtnHello.UseVisualStyleBackColor = true;
            this.BtnHello.Click += new System.EventHandler(this.BtnHello_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(624, 250);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GrpMood
            // 
            this.GrpMood.Controls.Add(this.picSad);
            this.GrpMood.Controls.Add(this.picHappy);
            this.GrpMood.Controls.Add(this.rdoSad);
            this.GrpMood.Controls.Add(this.rdoHappy);
            this.GrpMood.Location = new System.Drawing.Point(545, 282);
            this.GrpMood.Name = "GrpMood";
            this.GrpMood.Size = new System.Drawing.Size(235, 75);
            this.GrpMood.TabIndex = 6;
            this.GrpMood.TabStop = false;
            this.GrpMood.Text = "Moods";
            // 
            // picSad
            // 
            this.picSad.Image = global::CS_001_FirstFormsApp.Properties.Resources.Sad_128_31;
            this.picSad.Location = new System.Drawing.Point(79, 11);
            this.picSad.Name = "picSad";
            this.picSad.Size = new System.Drawing.Size(121, 58);
            this.picSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSad.TabIndex = 3;
            this.picSad.TabStop = false;
            this.picSad.Visible = false;
            // 
            // picHappy
            // 
            this.picHappy.Image = global::CS_001_FirstFormsApp.Properties.Resources.Happy_128_1;
            this.picHappy.Location = new System.Drawing.Point(79, 11);
            this.picHappy.Name = "picHappy";
            this.picHappy.Size = new System.Drawing.Size(121, 58);
            this.picHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHappy.TabIndex = 2;
            this.picHappy.TabStop = false;
            this.picHappy.Visible = false;
            // 
            // rdoSad
            // 
            this.rdoSad.AutoSize = true;
            this.rdoSad.Location = new System.Drawing.Point(7, 44);
            this.rdoSad.Name = "rdoSad";
            this.rdoSad.Size = new System.Drawing.Size(44, 17);
            this.rdoSad.TabIndex = 1;
            this.rdoSad.TabStop = true;
            this.rdoSad.Text = "Sad";
            this.rdoSad.UseVisualStyleBackColor = true;
            this.rdoSad.CheckedChanged += new System.EventHandler(this.rdoSad_CheckedChanged);
            // 
            // rdoHappy
            // 
            this.rdoHappy.AutoSize = true;
            this.rdoHappy.Location = new System.Drawing.Point(7, 20);
            this.rdoHappy.Name = "rdoHappy";
            this.rdoHappy.Size = new System.Drawing.Size(56, 17);
            this.rdoHappy.TabIndex = 0;
            this.rdoHappy.TabStop = true;
            this.rdoHappy.Text = "Happy";
            this.rdoHappy.UseVisualStyleBackColor = true;
            this.rdoHappy.CheckedChanged += new System.EventHandler(this.rdoHappy_CheckedChanged);
            // 
            // GrpOther
            // 
            this.GrpOther.Controls.Add(this.radioButton4);
            this.GrpOther.Controls.Add(this.radioButton3);
            this.GrpOther.Location = new System.Drawing.Point(545, 363);
            this.GrpOther.Name = "GrpOther";
            this.GrpOther.Size = new System.Drawing.Size(230, 75);
            this.GrpOther.TabIndex = 7;
            this.GrpOther.TabStop = false;
            this.GrpOther.Text = "Other";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 44);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // picTwo
            // 
            this.picTwo.Image = ((System.Drawing.Image)(resources.GetObject("picTwo.Image")));
            this.picTwo.Location = new System.Drawing.Point(542, 75);
            this.picTwo.Name = "picTwo";
            this.picTwo.Size = new System.Drawing.Size(184, 135);
            this.picTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTwo.TabIndex = 3;
            this.picTwo.TabStop = false;
            // 
            // picOne
            // 
            this.picOne.Image = global::CS_001_FirstFormsApp.Properties.Resources.IMG_20190219_125049899;
            this.picOne.Location = new System.Drawing.Point(58, 75);
            this.picOne.Name = "picOne";
            this.picOne.Size = new System.Drawing.Size(477, 352);
            this.picOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOne.TabIndex = 2;
            this.picOne.TabStop = false;
            // 
            // FrmFirstApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrpOther);
            this.Controls.Add(this.GrpMood);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnHello);
            this.Controls.Add(this.picTwo);
            this.Controls.Add(this.picOne);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmFirstApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstApp";
            this.GrpMood.ResumeLayout(false);
            this.GrpMood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHappy)).EndInit();
            this.GrpOther.ResumeLayout(false);
            this.GrpOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox picOne;
        private System.Windows.Forms.PictureBox picTwo;
        private System.Windows.Forms.Button BtnHello;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GrpMood;
        private System.Windows.Forms.RadioButton rdoSad;
        private System.Windows.Forms.RadioButton rdoHappy;
        private System.Windows.Forms.GroupBox GrpOther;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.PictureBox picHappy;
        private System.Windows.Forms.PictureBox picSad;
    }
}

