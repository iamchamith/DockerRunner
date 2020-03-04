using DockerRunner.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DockerRunner
{
    public class Helper
    {
        public static bool Confirm(string message="Sure?",string caption="Confirm this")
        {
            return MessageBox.Show(message, caption,
                                      MessageBoxButtons.YesNo) == DialogResult.Yes;         
        }

        public static ArrayList GetList(string cmdOut, int startFromIndex)
        {
            var lst = cmdOut.Split('\n').ToList();
            lst.RemoveRange(0, startFromIndex);
            lst = lst.Select(s => s.Trim()).ToList();
            var finalList = new ArrayList();
            foreach (var item in lst)
            {
                var info = item.Split(new string[] { "  " }, StringSplitOptions.None).ToList();
                info.RemoveAll(p => p == "");
                if (info.Count==6)                
                    info.Insert(5, "0000");
                
                finalList.Add(info);
            }
            return finalList;
        }
    }
}
