using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Recognition;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;


namespace sound
{
    class Class1
    {
        
       public Class1()
        {

        }
       public void createfile(string x)
        {
           // string x = Directory.GetCurrentDirectory();

            //Create a new subfolder under the current active folder
           // string newPath = System.IO.Path.Combine(activeDir, "mySubDir");

            // Create the subfolder
          //  System.IO.Directory.CreateDirectory(newPath);
           // System.IO.File.Create("C:/Users/Saideh/Desktop/"+x+".txt");
            try
            {
                System.IO.File.Create(Directory.GetCurrentDirectory() + "/" + x + ".txt");
            }
           catch(Exception){
           }

        }
      public void open2(string x,string direct)
       {
          
           System.Diagnostics.Process p2 = new Process();
           ProcessStartInfo ps = new ProcessStartInfo(direct + ":/" + x + "/");
           Directory.SetCurrentDirectory(direct + ":/" + x + "/");
           p2.StartInfo = ps;
           p2.Start();


       }

        public void delete(string s){
           

            try
            {
                System.IO.File.Delete(Directory.GetCurrentDirectory()+s+ ".txt");
            }
            catch(Exception e){}
        }

        public void open(string s)
        {
            System.Diagnostics.Process p = new Process();
            ProcessStartInfo ps = new ProcessStartInfo("C:/Users/Saideh/Desktop/" +s+ ".txt");
            p.StartInfo = ps;
            p.Start();
 


        }
        public void site(string s)
        {
            System.Diagnostics.Process p = new Process();
            ProcessStartInfo ps = new ProcessStartInfo("C:/Program Files (x86)/Internet Explorer/iexplore.exe","www."+s+".com");
            p.StartInfo = ps;
            p.Start();
        }
        public void writetofile(){
            SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
            rec.SetInputToDefaultAudioDevice();
            rec.LoadGrammar(new DictationGrammar());
            rec.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec_SpeechRecognized);
            rec.RecognizeAsync(RecognizeMode.Single);

        }

        void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string x;
            System.IO.StreamWriter file = new System.IO.StreamWriter("C:/Users/Saideh/Desktop/gg.txt");
            foreach (RecognizedWordUnit word in e.Result.Words)
            {
                x = word.Text;
                if(x=="stop")
                {
                    break;
                }
                file.Write(x);

            }

        }


       public void translate(string[] a, Encoding encoding)
        {
          //  string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text="+a+"&langpair={1}", a,"es");
            System.Diagnostics.Process p = new Process();
            ProcessStartInfo ps = new ProcessStartInfo("http://translate.google.co.il/#en|iw|" + a[0]);
            p.StartInfo = ps;
            p.Start();
           
           


          }
    }
}
