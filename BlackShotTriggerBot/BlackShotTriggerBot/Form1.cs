using System;
using System.Drawing;
using System.Runtime.InteropServices;   //For GetAsyncKeyState
using System.Threading;
using System.Windows.Forms;
using AutoItX3Lib;  //autoit .dll library

namespace BlackShotTriggerBot
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]   //Library to emulate keyboard keys stokes & finding window handle
        public static extern short GetAsyncKeyState(Keys vKey);        //Get keyboard key strokes
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);    //Find Window Application
        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);     //Set Window Long

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);                    //Get Window Long

        object pixel;
        int newCol;
        int[] coor = { 960, 540 };   //coordinate for laptop screen size 1920x1080
        AutoItX3 au3 = new AutoItX3();
        bool TBCheckBoxFlag = false;

        public Form1()
        {
            InitializeComponent();
        }

        //Load the Form gui
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false; //Prevent "illegal cross thread call" problem when changing the checkbox tick ui
            //Make background transparent
            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.FormBorderStyle = FormBorderStyle.None;    //Remove program window border
            this.WindowState = FormWindowState.Maximized; 
            this.TopMost = true;    //Set the program window at top most


            //Enable user to click through this program
            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle,-20,initialStyle|0x8000|0x20);
            

            /*
            GetWindowRect(Handle, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);

            this.Left = rect.left;
            this.Top = rect.top;
            */

            Thread mn = new Thread(Main) {IsBackground=true};   //Create new thread called "main", the thread will be closed when program closed
            mn.Start(); //Start the thread
        }

        private void Main()
        {
            while (true)
            {
                if (GetAsyncKeyState(Keys.X) < 0)   //Set the keyboard hotkey to start/stop the bot
                {
                    TBCheckBoxFlag = !TBCheckBoxFlag;
                    Triggerbot_checkBox.Checked = !Triggerbot_checkBox.Checked; //Change the checkbox tick ui based on ON/OFF of the bot
                    Thread.Sleep(200);
                }
                else
                {
                    if (TBCheckBoxFlag == false)   //When triggerbot checkbox is not true
                    {
                        //Do nothing
                    }
                    else //When triggerbot checkbox is true
                    {
                        newCol = GrabColor();   //Grab color from coord: 960, 540 
                        if (newCol == 16711680) //If the color is red, then left click with a delay time
                        {
                            au3.MouseClick("LEFT");
                            Thread.Sleep(30);
                        }
                    }
                }
                
            }
        }

        //Grab screen pixel color function
        int GrabColor()
        {
            pixel = au3.PixelGetColor(coor[0], coor[1]);
            return Int32.Parse(pixel.ToString());
        }
        
        private void Triggerbot_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(Triggerbot_checkBox.Checked)
            {
                Triggerbot_checkBox.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Triggerbot_checkBox.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
