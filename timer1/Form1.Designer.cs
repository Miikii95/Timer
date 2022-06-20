namespace timer1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hourPlus = new System.Windows.Forms.Button();
            this.minutePlus = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.hourMinus = new System.Windows.Forms.Button();
            this.minuteMinus = new System.Windows.Forms.Button();
            this.hourDisplay = new System.Windows.Forms.Label();
            this.minuteDisplay = new System.Windows.Forms.Label();
            this.secondDisplay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.hmSeparator = new System.Windows.Forms.Label();
            this.msSeparator = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minuteMinusMini = new System.Windows.Forms.Button();
            this.minutePlusMini = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hourPlus
            // 
            this.hourPlus.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.hourPlus, "hourPlus");
            this.hourPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hourPlus.Name = "hourPlus";
            this.hourPlus.UseVisualStyleBackColor = false;
            this.hourPlus.Click += new System.EventHandler(this.hourPlus_Click);
            // 
            // minutePlus
            // 
            this.minutePlus.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.minutePlus, "minutePlus");
            this.minutePlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.minutePlus.Name = "minutePlus";
            this.minutePlus.UseVisualStyleBackColor = false;
            this.minutePlus.Click += new System.EventHandler(this.minutePlus_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // hourMinus
            // 
            this.hourMinus.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.hourMinus, "hourMinus");
            this.hourMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hourMinus.Name = "hourMinus";
            this.hourMinus.UseVisualStyleBackColor = false;
            this.hourMinus.Click += new System.EventHandler(this.hourMinus_Click);
            // 
            // minuteMinus
            // 
            this.minuteMinus.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.minuteMinus, "minuteMinus");
            this.minuteMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.minuteMinus.Name = "minuteMinus";
            this.minuteMinus.UseVisualStyleBackColor = false;
            this.minuteMinus.Click += new System.EventHandler(this.minuteMinus_Click);
            // 
            // hourDisplay
            // 
            resources.ApplyResources(this.hourDisplay, "hourDisplay");
            this.hourDisplay.ForeColor = System.Drawing.Color.LawnGreen;
            this.hourDisplay.Name = "hourDisplay";
            this.hourDisplay.Click += new System.EventHandler(this.hourDisplay_Click);
            // 
            // minuteDisplay
            // 
            resources.ApplyResources(this.minuteDisplay, "minuteDisplay");
            this.minuteDisplay.ForeColor = System.Drawing.Color.LawnGreen;
            this.minuteDisplay.Name = "minuteDisplay";
            this.minuteDisplay.Click += new System.EventHandler(this.minuteDisplay_Click);
            // 
            // secondDisplay
            // 
            resources.ApplyResources(this.secondDisplay, "secondDisplay");
            this.secondDisplay.ForeColor = System.Drawing.Color.LawnGreen;
            this.secondDisplay.Name = "secondDisplay";
            this.secondDisplay.Click += new System.EventHandler(this.secondDisplay_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stopButton.Name = "stopButton";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // hmSeparator
            // 
            resources.ApplyResources(this.hmSeparator, "hmSeparator");
            this.hmSeparator.ForeColor = System.Drawing.Color.LawnGreen;
            this.hmSeparator.Name = "hmSeparator";
            this.hmSeparator.Click += new System.EventHandler(this.hmSeparator_Click);
            // 
            // msSeparator
            // 
            resources.ApplyResources(this.msSeparator, "msSeparator");
            this.msSeparator.ForeColor = System.Drawing.Color.LawnGreen;
            this.msSeparator.Name = "msSeparator";
            this.msSeparator.Click += new System.EventHandler(this.msSeparator_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // minuteMinusMini
            // 
            this.minuteMinusMini.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.minuteMinusMini, "minuteMinusMini");
            this.minuteMinusMini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.minuteMinusMini.Name = "minuteMinusMini";
            this.minuteMinusMini.UseVisualStyleBackColor = false;
            this.minuteMinusMini.Click += new System.EventHandler(this.minuteMinusMini_Click);
            // 
            // minutePlusMini
            // 
            this.minutePlusMini.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.minutePlusMini, "minutePlusMini");
            this.minutePlusMini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.minutePlusMini.Name = "minutePlusMini";
            this.minutePlusMini.UseVisualStyleBackColor = false;
            this.minutePlusMini.Click += new System.EventHandler(this.minutePlusMini_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.minuteMinusMini);
            this.Controls.Add(this.minutePlusMini);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msSeparator);
            this.Controls.Add(this.hmSeparator);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.secondDisplay);
            this.Controls.Add(this.minuteDisplay);
            this.Controls.Add(this.hourDisplay);
            this.Controls.Add(this.minuteMinus);
            this.Controls.Add(this.hourMinus);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.minutePlus);
            this.Controls.Add(this.hourPlus);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hourPlus;
        private System.Windows.Forms.Button minutePlus;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button hourMinus;
        private System.Windows.Forms.Button minuteMinus;
        private System.Windows.Forms.Label hourDisplay;
        private System.Windows.Forms.Label minuteDisplay;
        private System.Windows.Forms.Label secondDisplay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label hmSeparator;
        private System.Windows.Forms.Label msSeparator;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button minuteMinusMini;
        private System.Windows.Forms.Button minutePlusMini;
    }
}

