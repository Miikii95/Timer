namespace timer1
{
    partial class Form2
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
            this.Delay = new System.Windows.Forms.Button();
            this.ShoutDown = new System.Windows.Forms.Button();
            this.secondDisplay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Delay
            // 
            this.Delay.BackColor = System.Drawing.Color.Gray;
            this.Delay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Delay.ForeColor = System.Drawing.Color.LawnGreen;
            this.Delay.Location = new System.Drawing.Point(12, 173);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(152, 86);
            this.Delay.TabIndex = 0;
            this.Delay.Text = "Half an hour more";
            this.Delay.UseVisualStyleBackColor = false;
            this.Delay.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShoutDown
            // 
            this.ShoutDown.BackColor = System.Drawing.Color.Gray;
            this.ShoutDown.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ShoutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShoutDown.ForeColor = System.Drawing.Color.LawnGreen;
            this.ShoutDown.Location = new System.Drawing.Point(217, 173);
            this.ShoutDown.Name = "ShoutDown";
            this.ShoutDown.Size = new System.Drawing.Size(152, 86);
            this.ShoutDown.TabIndex = 1;
            this.ShoutDown.Text = "Turn off now";
            this.ShoutDown.UseVisualStyleBackColor = false;
            this.ShoutDown.Click += new System.EventHandler(this.ShoutDown_Click);
            // 
            // secondDisplay
            // 
            this.secondDisplay.AutoSize = true;
            this.secondDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.8F);
            this.secondDisplay.ForeColor = System.Drawing.Color.LawnGreen;
            this.secondDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.secondDisplay.Location = new System.Drawing.Point(116, 28);
            this.secondDisplay.Name = "secondDisplay";
            this.secondDisplay.Size = new System.Drawing.Size(149, 105);
            this.secondDisplay.TabIndex = 8;
            this.secondDisplay.Text = "15";
            this.secondDisplay.Click += new System.EventHandler(this.secondDisplay_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(381, 303);
            this.Controls.Add(this.secondDisplay);
            this.Controls.Add(this.ShoutDown);
            this.Controls.Add(this.Delay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Shouting down in:";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delay;
        private System.Windows.Forms.Button ShoutDown;
        private System.Windows.Forms.Label secondDisplay;
        private System.Windows.Forms.Timer timer1;
    }
}