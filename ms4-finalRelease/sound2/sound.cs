using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Recognition;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace sound2
{
    class sound
    {
        ProcessStartInfo ps;

        public int open(string a)
        {
            System.Diagnostics.Process p2 = new Process();
             ps = new ProcessStartInfo(a+":/");
            Directory.SetCurrentDirectory(a+":/");

         
            p2.StartInfo = ps;
            try
            {
                p2.Start();
            }
            catch { return -1; }
            return 0;
            
        //    p2.MainWindowHandle();
           
        }
        public void close()
        {
           // ProcessStartInfo ps = new ProcessStartInfo("C:/") ;
            ps.WindowStyle = ProcessWindowStyle.Minimized;
          //  this.close();
           
           
           
            Process.Start(ps);

        }
        public void open2(string s)
        {
            string w = Directory.GetCurrentDirectory();
            System.Diagnostics.Process p = new Process();
            ProcessStartInfo ps = new ProcessStartInfo(w+s);
            Directory.SetCurrentDirectory(w+s);
            p.StartInfo = ps;
            p.Start();

        }

        public int create(string s)
        {
            try
            {
                System.IO.File.Create(Directory.GetCurrentDirectory() + "/" + s + ".txt");
            }
            catch (Exception)
            {
                return -1;
            }
            return 0;

        }

        public int delete(string s){
            string k = Directory.GetCurrentDirectory();
            try
            {
                System.IO.File.Delete(Directory.GetCurrentDirectory()+"/" + s + ".txt");
            }
            catch { return -1; }
            return 0;
        }

        public void translate(string s)
        {
            System.Diagnostics.Process p = new Process();
            ProcessStartInfo ps = new ProcessStartInfo("http://translate.google.co.il/#en|iw|" + s);
            p.StartInfo = ps;
            p.Start();

        }
        public int internet(string s)
        {
            System.Diagnostics.Process p = new Process();
            ProcessStartInfo ps = new ProcessStartInfo("C:/Program Files (x86)/Internet Explorer/iexplore.exe","www."+s+".com");
            p.StartInfo = ps;
            try
            {
                p.Start();
            }
            catch { return -1; }
            return 0;

        }
        public void maps(string s)
        {

            System.Diagnostics.Process p = new Process();
            ProcessStartInfo ps = new ProcessStartInfo("C:/Program Files (x86)/Internet Explorer/iexplore.exe", "http://ymap.winwin.co.il/Navigate.aspx?tab=1&CityNmS="+s+"jerusalem&StreetNmS=&HouseNbrS=&Mode=1");
            p.StartInfo = ps;
            p.Start();

        }

       


    }
}
