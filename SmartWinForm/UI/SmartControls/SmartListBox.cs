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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartWinForm.UI.SmartControls
{
    public partial class SmartListBox : ListBox
    {
        bool IsStart = false;
        public bool IsAutoScrollColomn
        {
            set
            {
                if (value)
                {
                    IsStart = true;
                    im.Start();
                }
                else
                {
                    IsStart = false;
                    im.Stop();

                }
            }
            get
            {
                return IsStart;
            }
        }
        Timer im = new Timer();
        int index = 0;
        public SmartListBox():base()
        {
            InitializeComponent();
            im.Interval = 1000;
            im.Tick += im_Tick;
            this.DrawItem += lst_DrawItem;
            this.Enter += SmartListBox_Enter;
            this.Leave += SmartListBox_Leave;
            this.DataSourceChanged += SmartListBox_DataSourceChanged;
        }
        int n = 0;
        int BigCount = 0;
        void SmartListBox_DataSourceChanged(object sender, EventArgs e)
        {
            n = 0;
            BigCount = 0;
        }

        void SmartListBox_Leave(object sender, EventArgs e)
        {
          //  im.Stop();
        }

        void SmartListBox_Enter(object sender, EventArgs e)
        {
            
        }

      
        
   
        void im_Tick(object sender, EventArgs e)
        {
            try
            {
                index++;
                index = index % (Int32.MaxValue/2);
                Refresh();
            }
            catch (Exception fs)
            {
                PrinftHelper.LogException(fs);

            }
        }

        public SmartListBox(IContainer container)
            : base()
        {
            container.Add(this);

            InitializeComponent();
            im.Interval = 1000;
            im.Tick += im_Tick;
            this.DrawItem += lst_DrawItem;
            this.Enter += SmartListBox_Enter;
            this.Leave += SmartListBox_Leave;
        }
        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {  
              
                n++;
                e.DrawBackground();
                e.DrawFocusRectangle();
                string tex = (this.Items[e.Index]).ToString();
                SizeF sizeF = e.Graphics.MeasureString(tex, e.Font);
                if (sizeF.Width < e.Bounds.Width)
                {
                    e.Graphics.DrawString(tex, e.Font, new SolidBrush(e.ForeColor), e.Bounds);
                }
                else
                {
                    BigCount++;
                    int start = index % tex.Length;
                    string ForeString = tex.Substring(0, start);
                    string Beforestring = tex.Substring(start);
                    string ChangedString = Beforestring + ForeString;
                    start = 0;
                    while (start < ChangedString.Length && e.Graphics.MeasureString(ChangedString.Substring(0, start), e.Font).Width < e.Bounds.Width)
                    {
                        start++;
                    }
                    string RealString = ChangedString.Substring(0, start);
                    e.Graphics.DrawString(RealString, e.Font, new SolidBrush(e.ForeColor), e.Bounds);
                }
                if (n >= this.Items.Count)
                {
                    IsAutoScrollColomn = BigCount > 0;
                    n = 0;
                    BigCount = 0;
                }
            }
            catch (Exception fgg)
            {
                PrinftHelper.LogException(fgg);
                try
                {
                    string tex = (this.Items[e.Index]).ToString();
                    e.Graphics.DrawString(tex, e.Font, new SolidBrush(e.ForeColor), e.Bounds);

                }
                catch (Exception gd)
                {
                    PrinftHelper.LogException(gd);
                    e.Graphics.DrawString(this.Name, e.Font, new SolidBrush(e.ForeColor), e.Bounds);
                }
            }
        }

    }
}
