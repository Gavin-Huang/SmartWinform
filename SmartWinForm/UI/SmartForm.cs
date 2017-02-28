//MIT License
//
//Copyright (c) [2017] [Gavin-Huang]
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.
///
///
//*********************************************************
//*      Author: Gavin-Huang                              *
//*      Email:huangwangyi16@163.com                      *
//*      if you have any question , contact me !          *
//*********************************************************


using ShareTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SmartWinForm.UI
{
    /// <summary>
    ///     EN: smartForm can help you easily control its sons-form backcolor and forecolor 
    /// besides it can help you show new son form in 4 directions of itself which i think 
    /// is pretty useful if your application run in a computer with a touch screen.In that 
    /// way,all form can not be hided by others
    ///     CH:smartform 能帮助你方便快捷地控制所有实例化的子类的前景色和后景色，并且他能让你在母
    /// 窗体的四个方向并列显示子窗体,这在触摸屏上很有用，这使得窗体不会被其他窗体遮挡。
    /// </summary>
    public partial class SmartForm : Form
    {
        #region Attribute
        private bool isClosedGoback = true;
        
        public bool IsClosedGoback
        {
            get
            {
                return isClosedGoback;

            }
            set
            {
                isClosedGoback = value;
            }
        }
        #endregion Attribute
        #region  TellerAndReceive
        public delegate void OpenNewForm_Delegate(SmartForm sonForm);
        public delegate DialogResult OpenNewFormDidlog_Delegate(SmartForm SonForm);
        public delegate DialogResult OpenNewInputFormDidlog_Delegate(SmartForm SonForm);


        /// <summary>
        /// open new form in four directions and mather form will be froozed
        /// 打开在4个方向新的窗体，母窗体将被冻结
        /// 
        /// </summary>
        /// <param name="SonForm">the form to be showed</param>
        /// <param name="d">direction </param>
        public void OpenNewForm(SmartForm SonForm, Direction d)
        {
            SonForm.direc = d;
            this.EventLocationChanged += SonForm.form_EventLocationChanged;
            TellRightPoint();
            Form Son = (Form)SonForm;
            Son.Owner = this;
            this.Enabled = false;
            Son.Show();

        }
        /// <summary>
        /// open new form which will return dialogresult in four directions  and mather form will be froozed
        /// 打开在4个方向新的窗体，这个窗体将会返回窗体结果，母窗体将被冻结
        /// </summary>
        /// <param name="SonForm">the form to be showed</param>
        /// <param name="d">direction</param>
        /// <returns></returns>
        public DialogResult OpenNewFormDidlog(SmartForm SonForm,Direction d)
        {
            SonForm.direc = d;
            this.EventLocationChanged += SonForm.form_EventLocationChanged;
            TellRightPoint();
            Form Son = (Form)SonForm;
            Son.Owner = this;
            this.Enabled = false;
            return Son.ShowDialog();
        }
        public DialogResult OpenNewInputFormDidlog(SmartForm SonForm, Direction d)
        {
            SonForm.direc = d;
            this.EventLocationChanged += SonForm.form_EventLocationChanged;
            TellRightPoint();
            Form Son = (Form)SonForm;
            SonForm.TopLevel = true;
            SonForm.TopMost = true;
            Son.Owner = this;
            SonForm.IsClosedGoback = false;
            return Son.ShowDialog();
        }
        bool IsLoadLocation = false;
        Point LocationN = new Point();
        public Direction direc = Direction.right;
        public void form_EventLocationChanged(object sender, LocationChanged e)
        {   
            //check is out of range or not 
            Point BoundPoint = new Point();
            Point LocForSelf = new Point();
            switch (direc)
            {
                case Direction.right:
                    BoundPoint = new Point(e.pointNow.X + e.SelfWidth + this.Width, e.pointNow.Y);
                    LocForSelf = new Point(e.pointNow.X + e.SelfWidth, e.pointNow.Y);
                    break;
                case Direction.left: 
                    BoundPoint = new Point(e.pointNow.X - this.Width, e.pointNow.Y);
                    LocForSelf = new Point(e.pointNow.X - this.Width, e.pointNow.Y);
                    break;
                case Direction.top: 
                    BoundPoint = new Point(e.pointNow.X, e.pointNow.Y - this.Height);
                    LocForSelf = new Point(e.pointNow.X, e.pointNow.Y - this.Height);
                    break;
                case Direction.down: 
                    BoundPoint = new Point(e.pointNow.X, e.pointNow.Y + e.SelfHeight + this.Height);
                    LocForSelf = new Point(e.pointNow.X, e.pointNow.Y + e.SelfHeight);
                    break;
            }

            if (Screen.PrimaryScreen.Bounds.Contains(BoundPoint))
            {
                this.Location = LocForSelf;
                LocationN = this.Location;
                IsLoadLocation = true;
            }
            else
            {
                int offset = 0;
                switch (direc)
                {
                    case Direction.right:
                        offset = e.pointNow.X + e.SelfWidth + this.Width - Screen.PrimaryScreen.Bounds.Width;
                        this.Location = new Point(LocForSelf.X - offset, e.pointNow.Y);
                        break;
                    case Direction.left:
                        offset =e.pointNow.X-this.Width;
                        this.Location = new Point(LocForSelf.X - offset, e.pointNow.Y);
                        break;
                    case Direction.top:
                        offset = e.pointNow.Y - this.Height;
                        this.Location = new Point(e.pointNow.X, LocForSelf.Y- offset);
                        break;
                    case Direction.down:
                        offset = e.pointNow.Y + e.SelfHeight + this.Height - Screen.PrimaryScreen.Bounds.Height;
                        this.Location = new Point(e.pointNow.X, LocForSelf.Y - offset);
                        break;
                }

                TellMatherReLocated(sender as SmartForm, this, this.Location);
                LocationN = this.Location;
                IsLoadLocation = true;
            }
        }
        private void TellMatherReLocated(SmartForm mather, SmartForm son, Point sonLoca)
        {
            mather.EventLocationChanged -= son.form_EventLocationChanged;
            Point temp = new Point();
            switch (son.direc)
            {
                case Direction.right: temp = new Point(sonLoca.X - mather.Width, sonLoca.Y); break;
                case Direction.left: temp = new Point(sonLoca.X + son.Width, sonLoca.Y); break;
                case Direction.top: temp = new Point(sonLoca.X, sonLoca.Y + son.Height); break;
                case Direction.down: temp = new Point(sonLoca.X, sonLoca.Y - mather.Height); break;
            }
            if (mather.Owner != null && mather.Owner is SmartForm)
            {
                TellMatherReLocated(mather.Owner as SmartForm, mather, temp);
            }
            mather.Location = temp;
            mather.EventLocationChanged += son.form_EventLocationChanged;
        }
        #endregion TellerAndReceive
        public event EventHandler<LocationChanged> EventLocationChanged;

        public static Color PublicbackColor
        {
            set
            {
                backColor=value;
                if(ColorChanged!=null)
                {
                    ColorChanged(null,EventArgs.Empty);
                }
            }
            get
            {
                return backColor;
            }
        }
         public static Color PublicForeColor
        {
            set
            {
                foreColor=value;
                if(ColorChanged!=null)
                {
                    ColorChanged(null,EventArgs.Empty);
                }
            }
            get
            {
                return foreColor;
            }

        }
         public static void DisConnectTrigger()
         {
             foreach (Delegate d in ColorChanged.GetInvocationList())
             {
                 ColorChanged -= (EventHandler<EventArgs>)d;
             }
         }
        public static event EventHandler<EventArgs> ColorChanged;
        static System.Drawing.Color foreColor = System.Drawing.Color.FromArgb(43, 45, 66);
        static System.Drawing.Color backColor = System.Drawing.Color.FromArgb(239, 244, 244);
        //   Form Tool = null;
        public SmartForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            PrinftHelper.PrinftNormal("Connect Event");
            ColorChanged+=SmartForm_ColorChanged;
            //   this.AutoSize = true;
        }

         void SmartForm_ColorChanged(object sender, EventArgs e)
       {
 	       this.BackColor=backColor;
           this.ForeColor=foreColor;
           TurnControlBackColor(this);
           this.Refresh();
        }

        private void SmartForm_Load(object sender, EventArgs e)
        {
            TellRightPoint();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            this.BringToFront();
            this.Move += SmartForm_Move;
            if (IsLoadLocation)
            {
                this.Location = LocationN;
            }
            this.BackColor = backColor;
            this.ForeColor = foreColor;
            TurnControlBackColor(this);
        }
        void TurnControlBackColor(Control G)
        {
            foreach (Control f in G.Controls)
            {
                f.BackColor = backColor;
                f.ForeColor = foreColor;
                if (f is DataGridView)
                {
                    DataGridView tem = (DataGridView)f;
                    tem.RowsDefaultCellStyle.BackColor = backColor;
                    tem.RowsDefaultCellStyle.ForeColor = foreColor; 
                    tem.GridColor = backColor;
                    tem.RowHeadersDefaultCellStyle.BackColor = backColor;
                    tem.RowHeadersDefaultCellStyle.ForeColor = foreColor;
                    tem.BackgroundColor = backColor;
                    foreach (DataGridViewColumn te in tem.Columns)
                    {
                        te.DefaultCellStyle.BackColor = backColor;
                        te.DefaultCellStyle.ForeColor = foreColor;
                    }
                    tem.EnableHeadersVisualStyles = false;
                }
                if (f.HasChildren)
                {
                    TurnControlBackColor(f);
                }
            }
        }
        public void GetMoveTo_VisibleChanged(object sender, EventArgs e)
        {
            TellRightPoint();
            if (sender is Form)
            {
            }
        }

        void SmartForm_Move(object sender, EventArgs e)
        {
            TellRightPoint();
        }
        void TellRightPoint()
        {
            var temp = EventLocationChanged;
            if (temp != null)
            {
                Point point = this.Location;
                LocationChanged tem = new LocationChanged(point, this.Width,this.Height);
                EventLocationChanged(this, tem);
            }
        }

        private void SmartForm_FormClosed(object sender, FormClosedEventArgs e)
        {    
            if (this.Owner != null)
            {
                this.Owner.Enabled = true;

            }

        }
      //  override clo
       /// <summary>
       /// when Form Close ask sons change location 
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void SmartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PrinftHelper.PrinftNormal("Disconnect Event");
            ColorChanged -= SmartForm_ColorChanged;
            if (this.Owner is SmartForm && isClosedGoback)
            {
                SmartForm mather = (SmartForm)this.Owner;
                Point temp = new Point();
                switch (this.direc)
                {
                    case Direction.right:  temp = new Point(this.Location.X + this.Width, this.Location.Y); break;
                    case Direction.left: temp = new Point(this.Location.X - this.Width, this.Location.Y); break;
                    case Direction.top: temp = new Point(this.Location.X, this.Location.Y - this.Height); break;
                    case Direction.down: temp = new Point(this.Location.X, this.Location.Y + this.Height); break;
                }
                
                TellMatherReLocated(mather, this, temp);
                mather.EventLocationChanged -= this.form_EventLocationChanged;
            }
            else if (this.Owner is SmartForm)
            {
                SmartForm mather = (SmartForm)this.Owner;
                mather.EventLocationChanged -= this.form_EventLocationChanged;
            }
        }
        protected void OpenInputLabTip()
        {
            InputLak.openKeyboard(this.Location.X + this.Width, this.Location.Y);
        }

        public void SetBackColor(Color color)
        {
            backColor = color;
        }

        public void SetForeColor(Color color)
        {
            throw new NotImplementedException();
        }
    }
    public class LocationChanged : EventArgs
    {
        public Point pointNow = new Point();
        public int SelfWidth = 0,SelfHeight=0;
        public LocationChanged(Point point, int selfWidth,int height)
        {
            pointNow = point;
            SelfWidth = selfWidth;
            SelfHeight = height;
        }
    }
    public static class InputLak
    {
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool PostMessage(Int32 hWnd, Int32 Msg, Int32 wParam, Int32 lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);
        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X,
        int Y, int cx, int cy, uint uFlags);
        public const Int32 WM_USER = 1024;
        public const Int32 WM_CSKEYBOARDMOVE = WM_USER + 193;
        public static Process myProcess = null;
        public static void openKeyboard(int ToX, int ToY)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myProcess = Process.Start(startInfo);
        }
        public static void closeKeyboard()
        {
            Int32 WM_SYSCOMMAND = 274;
            Int32 SC_CLOSE = 61536;
            IntPtr KeyboardWnd = FindWindow("IPTip_Main_Window", null);
            PostMessage(KeyboardWnd.ToInt32(), WM_SYSCOMMAND, (int)SC_CLOSE, 0);
        }
    }
    public enum Direction
    {
        top,down,left,right
    }

}
