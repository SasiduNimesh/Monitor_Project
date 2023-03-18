﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor_Project
{
    public partial class Form1 : Form
    {

        PerformanceCounter PerfCPU = new PerformanceCounter("Processor","% Processor time","_Total");
        PerformanceCounter PerfRAM = new PerformanceCounter("Memory","Available MBytes");
        PerformanceCounter PerfSYS = new PerformanceCounter("System","System Up Time");

        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            labelCPUUSAGE.Text = "CPU Usage : " + (int)PerfCPU.NextValue() + " " + "%";
            labelRAM.Text = "Available RAM : " + (int)PerfRAM.NextValue() + " ";
            labelSYSTEMUPTIME.Text = "Up Time System:" + (int)PerfSYS.NextValue() / 60 + "Minutes";

          
        }
    }

   
}