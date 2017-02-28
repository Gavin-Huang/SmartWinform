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
using System.Drawing;
using System.Linq;
using System.Text;

namespace ShareTools
{
    public enum ConsolePrinftType
    {
        Important, Error, Normal, Special
    }
    public class ConsolePrinftEventArgs : EventArgs
    {
        public ConsolePrinftType prinftType;
        string message;
        public Color TextColor;
        public string MessageString
        {
            get
            {
                return message;
            }
        }
        public ConsolePrinftEventArgs(string PrinftMessage, ConsolePrinftType type, Color textColor)
        {
            message = PrinftMessage;
            prinftType = type;
            TextColor = textColor;

        }
        public ConsolePrinftEventArgs(string PrinftMessage, ConsolePrinftType type)
        {
            message = PrinftMessage;
            prinftType = type;

        }

    }
    public class ShowErrorEventArgs : EventArgs
    {
        public String Message;
        public double Seconds;
        public ShowErrorEventArgs(string message, double seconds)
        {
            Message = message;
            Seconds = seconds;
        }
    }
  public static  class PrinftHelper
    {
        #region Prinft
        public  static event EventHandler<ConsolePrinftEventArgs> ConsolePrinft;
        public static event EventHandler<ShowErrorEventArgs> ShowErrored;

        public static List<ConsolePrinftEventArgs> PrinftBuffer = new List<ConsolePrinftEventArgs>();
        public static List<ShowErrorEventArgs> ErrorPrinftBuffer = new List<ShowErrorEventArgs>();
        static  void Check()
        {
            foreach (ConsolePrinftEventArgs fedg in PrinftBuffer)
            {
                ConsolePrinft(null, fedg);
            }
            PrinftBuffer.Clear();

            foreach (ShowErrorEventArgs fedg in ErrorPrinftBuffer)
            {
                ShowErrored(null, fedg);
            }
            ErrorPrinftBuffer.Clear();
        }
        public static void PrinftNormal(string Message)
        {
            ConsolePrinftEventArgs temp = new ConsolePrinftEventArgs(Message, ConsolePrinftType.Normal);
            var s = ConsolePrinft;
            if (s != null)
            {
                ConsolePrinft(null, temp);
                Check();
            }
            else
            {
                PrinftBuffer.Add(temp);
            }
        }
        public static void PrinftError(string Message)
        {
            ConsolePrinftEventArgs temp = new ConsolePrinftEventArgs(Message, ConsolePrinftType.Error);
            var s = ConsolePrinft;
            if (s != null)
            {
                ConsolePrinft(null, temp);
                Check();
            }
            else
            {
                PrinftBuffer.Add(temp);
            }
        }
        public static void PrinftImportant(string Message)
        {
            ConsolePrinftEventArgs temp = new ConsolePrinftEventArgs(Message, ConsolePrinftType.Important);
            var s = ConsolePrinft;
            if (s != null)
            {
                ConsolePrinft(null, temp);
                Check();
            }
            else
            {
                PrinftBuffer.Add(temp);
            }
        }
        public static void ShowError(string Message,double Seconds)
        {
            ShowErrorEventArgs temp = new ShowErrorEventArgs(Message, Seconds);
            var s = ShowErrored;
            if (s != null)
            {
                ShowErrored(null, temp);
                Check();
            }
            else
            {
                ErrorPrinftBuffer.Add(temp);
            }
        }
        public static void LogException(Exception gh)
        {
            ExceptionLog.AddException(gh);
        }
        #endregion Prinft
    }
}
