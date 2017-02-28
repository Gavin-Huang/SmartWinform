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
using System.IO;
using System.Linq;
using System.Text;

namespace ShareTools
{   ////管理异常处理的类
    /// <summary>
    /// 管理异常日志的记录和处理异常
    /// 当异常出现时候，记录异常并写入到日志系统
    /// </summary>
    public static class ExceptionLog
    {
        public static string FileFolderName= "SmartWinformLogs";
        public static int SaveLogsDaysLength = 7;
        public static string GetFilePath(String Name)
        {
            return @"C:/" + FileFolderName + @"/" + Name;
        }
        public static string GetTodayDate()
        {
            return (DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day) + ".txt";
        }
        public static void DaysLogCheck()
        {
            String[] gg = Directory.GetFiles(@"C:\" + FileFolderName);
            if (gg.Length > SaveLogsDaysLength)
            {
                Dictionary<string, DateTime> Names =new  Dictionary<string, DateTime>();
                foreach (string gh in gg)
                {
                    DateTime ghtime = File.GetCreationTime(gh);
                    Names.Add(gh,ghtime);
                }
                Names.OrderBy(s=>s.Value);
                int i=0;
                foreach (KeyValuePair<string, DateTime> ght in Names)
                {
                    if (i < Names.Count - SaveLogsDaysLength)
                    {
                        if (File.Exists(ght.Key))
                        {
                            File.Delete(ght.Key);
                        }
                    }
                    i++;
                }
                
            }
           
        }
        public static void AddException(Exception fgb)
        {
            //BackgroundWorker work = new BackgroundWorker();
            //work.DoWork += (object sender, DoWorkEventArgs e) =>
            //    {
                 
            //    };
            //work.RunWorkerAsync();
            try
            {
                String abpath = @"C:\" + FileFolderName + @"\" + (DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day) + ".txt";
                CheckPath(abpath);
                string Value = DateTime.Now.ToLongTimeString() + ":" + fgb.ToString();
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(abpath))
                {
                    file.WriteLine(Value);
                }

            }
            catch (Exception gh)
            {

            }
        }

        public static void CheckPath(string path)
        {
           // String path = @"C:\" + Path + @"\" + DateTime.Now.ToShortDateString().Replace('\\', '_') + ".txt";
            if (!Directory.Exists(@"C:\" + FileFolderName))//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(@"C:\" + FileFolderName);
            }
            if (!File.Exists(path))
            {
                using (FileStream gh = File.Create(path))
                {

                }
            }
        }
    }
}
