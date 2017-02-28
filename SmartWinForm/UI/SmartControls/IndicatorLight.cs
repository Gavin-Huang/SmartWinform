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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SmartWinForm.UI.SmartControls
{
  
    public partial class IndicatorLight : UserControl
    {
        public IndicatorLight()
        {
            InitializeComponent();
            BlinkControl.Tick += BlinkControl_Tick;
        }

        bool IsShowTrue = true;
        void BlinkControl_Tick(object sender, EventArgs e)
        {
            if (IsShowTrue)
            {
                IsShowTrue = false;
                pictureBox1.Image = GreyLight;

            }
            else
            {
                IsShowTrue = true;
                pictureBox1.Image = ImageShowing;
            }
        }
        private Image RedLight=global::SmartWinForm.Properties.Resources.Box_Red_128px;
        private Image GreenLight = global::SmartWinForm.Properties.Resources.Box_Green_128px;
        private Image YellowLigth = global::SmartWinForm.Properties.Resources.Box_Yellow_128px;
        private Image GreyLight = global::SmartWinForm.Properties.Resources.Box_Grey_128px;

        private Image ImageShowing = global::SmartWinForm.Properties.Resources.Box_Grey_128px;
        private IndicatorState state;
        public IndicatorState State
        {
            set
            {
                state = value;
                switch (value)
                {
                    case IndicatorState.Waiting:
                        pictureBox1.Image = YellowLigth;
                        ImageShowing = YellowLigth;
                        break;
                    case IndicatorState.Warning:
                        pictureBox1.Image = RedLight;
                        ImageShowing = RedLight;
                        break;
                    case IndicatorState.Working:
                        pictureBox1.Image = GreenLight;
                        ImageShowing = GreenLight;
                        break;
                    case IndicatorState.Blank:
                        pictureBox1.Image = GreyLight;
                        ImageShowing = GreyLight;
                        break;
                }
            }
        }
        private bool isblink=false;
        public bool IsBlink
        {
            set
            {
                isblink = value;
                if (value)
                {
                    BlinkControl.Start();
                }
                else
                {
                    BlinkControl.Stop();
                }

            }
            get
            {
                return isblink;
            }
        }
        public int BlinkTime
        {
            set
            {
                if (value > 0 && value < 2000)
                    BlinkControl.Interval = value;
            }
            get
            {
                return BlinkControl.Interval;
 
            }
        }
        //private ComponentSize PSize;
        //public ComponentSize ComponentSize
        //{
        //    set
        //    {   int Size=(int)value;
        //        this.Width=Size
        //    }
        //}
    }
    public enum IndicatorState
    {
        Waiting, Warning, Working, Blank
        //Size128=128,Size96=96,Size72=72,Size64=64,Size48=48,Size32=32,Size24=24,Size16=16
    }

}
