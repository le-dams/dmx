namespace Dmx
{
    partial class Form3
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
            this.tiltUp = new System.Windows.Forms.Button();
            this.panLeft = new System.Windows.Forms.Button();
            this.tiltDown = new System.Windows.Forms.Button();
            this.panRight = new System.Windows.Forms.Button();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPan = new System.Windows.Forms.TextBox();
            this.textTilt = new System.Windows.Forms.TextBox();
            this.buttonUpper = new System.Windows.Forms.Button();
            this.timerRandom = new System.Windows.Forms.Timer(this.components);
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.vScrollBarRandom = new System.Windows.Forms.VScrollBar();
            this.labelRandom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tiltUp
            // 
            this.tiltUp.Enabled = false;
            this.tiltUp.Location = new System.Drawing.Point(115, 48);
            this.tiltUp.Name = "tiltUp";
            this.tiltUp.Size = new System.Drawing.Size(75, 23);
            this.tiltUp.TabIndex = 0;
            this.tiltUp.Text = "Haut";
            this.tiltUp.UseVisualStyleBackColor = true;
            this.tiltUp.Click += new System.EventHandler(this.tiltUp_Click);
            // 
            // panLeft
            // 
            this.panLeft.Enabled = false;
            this.panLeft.Location = new System.Drawing.Point(35, 91);
            this.panLeft.Name = "panLeft";
            this.panLeft.Size = new System.Drawing.Size(75, 23);
            this.panLeft.TabIndex = 1;
            this.panLeft.Text = "Gauche";
            this.panLeft.UseVisualStyleBackColor = true;
            this.panLeft.Click += new System.EventHandler(this.panLeft_Click);
            // 
            // tiltDown
            // 
            this.tiltDown.Enabled = false;
            this.tiltDown.Location = new System.Drawing.Point(115, 131);
            this.tiltDown.Name = "tiltDown";
            this.tiltDown.Size = new System.Drawing.Size(75, 23);
            this.tiltDown.TabIndex = 2;
            this.tiltDown.Text = "Bas";
            this.tiltDown.UseVisualStyleBackColor = true;
            this.tiltDown.Click += new System.EventHandler(this.tiltDown_Click);
            // 
            // panRight
            // 
            this.panRight.Enabled = false;
            this.panRight.Location = new System.Drawing.Point(195, 91);
            this.panRight.Name = "panRight";
            this.panRight.Size = new System.Drawing.Size(75, 23);
            this.panRight.TabIndex = 3;
            this.panRight.Text = "Droite";
            this.panRight.UseVisualStyleBackColor = true;
            this.panRight.Click += new System.EventHandler(this.panRight_Click);
            // 
            // buttonCenter
            // 
            this.buttonCenter.Enabled = false;
            this.buttonCenter.Location = new System.Drawing.Point(114, 77);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(75, 48);
            this.buttonCenter.TabIndex = 4;
            this.buttonCenter.Text = "Centrer";
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(330, 293);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Calibrer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(28, 293);
            this.hScrollBar1.Maximum = 255;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(299, 23);
            this.hScrollBar1.TabIndex = 12;
            this.hScrollBar1.Value = 255;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Canal:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(72, 260);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tilt:";
            // 
            // textPan
            // 
            this.textPan.Location = new System.Drawing.Point(74, 51);
            this.textPan.Name = "textPan";
            this.textPan.Size = new System.Drawing.Size(23, 20);
            this.textPan.TabIndex = 22;
            this.textPan.TextChanged += new System.EventHandler(this.textPan_TextChanged);
            // 
            // textTilt
            // 
            this.textTilt.Location = new System.Drawing.Point(74, 131);
            this.textTilt.Name = "textTilt";
            this.textTilt.Size = new System.Drawing.Size(23, 20);
            this.textTilt.TabIndex = 23;
            this.textTilt.TextChanged += new System.EventHandler(this.textTilt_TextChanged);
            // 
            // buttonUpper
            // 
            this.buttonUpper.Location = new System.Drawing.Point(411, 293);
            this.buttonUpper.Name = "buttonUpper";
            this.buttonUpper.Size = new System.Drawing.Size(55, 23);
            this.buttonUpper.TabIndex = 24;
            this.buttonUpper.Text = "Upper";
            this.buttonUpper.UseVisualStyleBackColor = true;
            this.buttonUpper.Click += new System.EventHandler(this.buttonUpper_Click);
            // 
            // timerRandom
            // 
            this.timerRandom.Tick += new System.EventHandler(this.timerRandom_Tick);
            // 
            // checkBoxRandom
            // 
            this.checkBoxRandom.AutoSize = true;
            this.checkBoxRandom.Enabled = false;
            this.checkBoxRandom.Location = new System.Drawing.Point(39, 12);
            this.checkBoxRandom.Name = "checkBoxRandom";
            this.checkBoxRandom.Size = new System.Drawing.Size(67, 17);
            this.checkBoxRandom.TabIndex = 25;
            this.checkBoxRandom.Text = "Aléatoire";
            this.checkBoxRandom.UseVisualStyleBackColor = true;
            this.checkBoxRandom.CheckedChanged += new System.EventHandler(this.checkBoxRandom_CheckedChanged);
            // 
            // vScrollBarRandom
            // 
            this.vScrollBarRandom.Enabled = false;
            this.vScrollBarRandom.Location = new System.Drawing.Point(428, 12);
            this.vScrollBarRandom.Maximum = 1000;
            this.vScrollBarRandom.Name = "vScrollBarRandom";
            this.vScrollBarRandom.Size = new System.Drawing.Size(38, 269);
            this.vScrollBarRandom.TabIndex = 26;
            this.vScrollBarRandom.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarRandom_Scroll);
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Location = new System.Drawing.Point(112, 13);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(35, 13);
            this.labelRandom.TabIndex = 27;
            this.labelRandom.Text = "label5";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 343);
            this.Controls.Add(this.labelRandom);
            this.Controls.Add(this.vScrollBarRandom);
            this.Controls.Add(this.checkBoxRandom);
            this.Controls.Add(this.buttonUpper);
            this.Controls.Add(this.textTilt);
            this.Controls.Add(this.textPan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.buttonCenter);
            this.Controls.Add(this.panRight);
            this.Controls.Add(this.tiltDown);
            this.Controls.Add(this.panLeft);
            this.Controls.Add(this.tiltUp);
            this.Name = "Form3";
            this.Text = "Form3";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tiltUp;
        private System.Windows.Forms.Button panLeft;
        private System.Windows.Forms.Button tiltDown;
        private System.Windows.Forms.Button panRight;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPan;
        private System.Windows.Forms.TextBox textTilt;
        private System.Windows.Forms.Button buttonUpper;
        private System.Windows.Forms.Timer timerRandom;
        private System.Windows.Forms.CheckBox checkBoxRandom;
        private System.Windows.Forms.VScrollBar vScrollBarRandom;
        private System.Windows.Forms.Label labelRandom;


    }
}