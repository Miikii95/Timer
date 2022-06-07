﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer1
{
    public partial class Form1 : Form
    {
        int hour = 0;
        int minute = 30;
        int second = 0;

        public Form1()
        {
            InitializeComponent();
            hourDisplay.Text = hour.ToString();
            minuteDisplay.Text = minute.ToString();
            secondDisplay.Text = "0"+second.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveClock();
            if (hour < 0) 
            { passedTimeAction(); }
            updateDisplay();
        }

        public void moveClock()
        {
            second--;
            if (second < 0)
            {
                minute--;
                second = 59;

                if (minute < 0)
                {
                    hour--;
                    minute = 59;
                }
            }
            
        }
        public void updateDisplay()
        {
            hourDisplay.Text = hour.ToString();

            if (minute < 10)
            {minuteDisplay.Text = "0" + minute.ToString();}
            else { minuteDisplay.Text = minute.ToString(); }

            if (second < 10)
            { secondDisplay.Text = "0" + second.ToString(); }
            else { secondDisplay.Text = second.ToString(); }
        }

        public void passedTimeAction()
        {
            timer.Stop();
            System.Diagnostics.Process.Start("Shutdown", "-s -t 1");
            MessageBox.Show("Computer is shuting down");
           
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer2.Stop();
            hmSeparator.ForeColor = Color.LawnGreen;
            msSeparator.ForeColor = Color.LawnGreen;
            startButton.BackColor = Color.Gray;
            stopButton.BackColor = Color.DimGray;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();
            timer2.Start();
            startButton.BackColor = Color.DimGray;
            stopButton.BackColor = Color.Gray;
        }

        private void hourPlus_Click(object sender, EventArgs e)
        {
            hour++;
            updateDisplay();
        }

        private void hourMinus_Click(object sender, EventArgs e)
        {
            if (hour != 0) { hour--; updateDisplay(); }
        }

        private void minutePlus_Click(object sender, EventArgs e)
        {
            if (minute == 59) { minute = 0; hour++;}
            else { minute++; }
            updateDisplay();

        }

        private void minuteMinus_Click(object sender, EventArgs e)
        {
            if (minute != 0) { minute--; updateDisplay(); }
  
        }

        private void minuteDisplay_Click(object sender, EventArgs e)
        {

        }

        private void hmSeparator_Click(object sender, EventArgs e)
        {

        }

        private void secondDisplay_Click(object sender, EventArgs e)
        {

        }

        private void msSeparator_Click(object sender, EventArgs e)
        {

        }

        private void hourDisplay_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (hmSeparator.ForeColor == Color.DimGray)
            {
                hmSeparator.ForeColor = Color.LawnGreen;
                msSeparator.ForeColor = Color.LawnGreen;
            }
            else
            { 
                hmSeparator.ForeColor = Color.DimGray;
                msSeparator.ForeColor = Color.DimGray;
            }

        }
    }//public partial class timer 1
}// namespace timer
