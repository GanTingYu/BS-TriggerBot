using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;  //autoit .dll library

namespace BlackShotTriggerBot
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]   //Library to emulate keyboard keys stokes
        static extern short GetAsyncKeyState(Keys vKey);
        object pixel;
        int newCol;
        int[] coor = { 960, 540 };   //coordinate for 1920x1080
        AutoItX3 au3 = new AutoItX3();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread mn = new Thread(Main) {IsBackground=true};
            mn.Start();
        }

        private void Main()
        {
            
        }

        //Triggerbot start
        int GrabColor()
        {
            pixel = au3.PixelGetColor(coor[0], coor[1]);
            return Int32.Parse(pixel.ToString());
        }

        private void Triggerbot_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Triggerbot_checkBox.Checked)
            {
                while (true)
                {
               
                    newCol = GrabColor();
                    if (newCol  == 16711680)
                    {
                        au3.MouseClick("LEFT");
                        Thread.Sleep(1);
                    }
                    
                    //Thread.Sleep(1);
                }
                
            }
        }
        //Triggerbot end
        private void Customcursor_checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }   
}
