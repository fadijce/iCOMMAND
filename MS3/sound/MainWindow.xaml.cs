using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Speech.Recognition;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Windows.Shapes;

namespace sound
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SpeechRecognitionEngine rec=new SpeechRecognitionEngine();
       private SpeechRecognitionEngine rec3 = new SpeechRecognitionEngine();
       SpeechRecognitionEngine rec2 = new SpeechRecognitionEngine();
      
        Class1 cl = new Class1();
        Choices chose;
        Choices chose2=new Choices();
        int b = 0,co=0;
        string[] arr=new string[20];
        string name="zz";
        string ss1 = null;
        Boolean init = false;
        Boolean sp = false;
        Boolean into = false;
        string direct="zz";
        sound2 s1 = new sound2();
        public MainWindow()
        {
           
            InitializeComponent();
            Stream imageStreamSource = new FileStream("C:/Users/Saideh/Desktop/siri_icon_lg[1].png", FileMode.Open, FileAccess.Read, FileShare.Read);
            PngBitmapDecoder decoder = new PngBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
            BitmapSource bitmapSource = decoder.Frames[0];
            image1.Source = bitmapSource;
            Style s = new Style();
          // label1.s
            
          
           // Color z = Color.FromArgb(255, 0, 0, 255);
            rectangle1.Fill=new SolidColorBrush(Colors.Black);
            

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            rec.SetInputToDefaultAudioDevice();
          //  rec.RecognizeAsync(RecognizeMode.Multiple);

            initrec();
           // rec7.SetInputToDefaultAudioDevice();
          /*  rec.SetInputToDefaultAudioDevice();
           chose = new Choices("open","goto","new","translate","delete");
            arr = new string[5] { "open", "goto", "create", "save", "delete" };
          
            
            GrammarBuilder grammer = new GrammarBuilder(chose);
            Grammar gra = new Grammar(grammer);
            
            rec.LoadGrammar(gra);
            rec.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec_SpeechRecognized);
            rec.RecognizeAsync(RecognizeMode.Multiple);*/
            
           // rec.LoadGrammar(new DictationGrammar());
           //rec.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec_SpeechRecognized);
          //rec.RecognizeAsync(RecognizeMode.Multiple);
            

        }
        void initrec()
        {
           // rec = new SpeechRecognitionEngine();
            rec.SetInputToDefaultAudioDevice();
            chose = new Choices("open", "goto", "new", "translate", "delete");
            arr = new string[5] { "open", "goto", "create", "save", "delete" };

            GrammarBuilder grammer = new GrammarBuilder(chose);
            Grammar gra = new Grammar(grammer);

            rec.LoadGrammar(gra);
            rec.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec_SpeechRecognized);
           
            rec.RecognizeAsync(RecognizeMode.Multiple);
           


        }
        void change(Choices s)
        {
            GrammarBuilder gram = new GrammarBuilder(s);
            Grammar gr = new Grammar(gram);

            rec.LoadGrammar(gr);


        }
        void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string []arr = new string[2];
           
            //System.IO.StreamWriter file = new System.IO.StreamWriter("C:/Users/Saideh/Desktop/n.txt");
           foreach(RecognizedWordUnit word in e.Result.Words){
               string s = word.Text;
             
               listBox1.Items.Add(word.Text);
               
             //  file.WriteLine(s);
               if (s == "new")
               {
                 /* Thread thre = new Thread(new ThreadStart(s1.speak));
                  try
                   {
                       thre.Start();
                 //  s1.speak(); s1.speak();
                  // s1.speak(); s1.speak();
                   }
                   catch (ThreadStateException) { }
                   Thread.Sleep(100);*/
                 // thre.Join();
                 //  thre.Abort();
                  // s1.speak();
                   //speak();
                   s1.speak(); s1.speak();
                   s1.speak();
                   s1.speak();
               }
               if(b%2==0){
               arr[0] = s;//must remember the previous string
               System.IO.File.WriteAllLines("C:/Users/Saideh/Desktop/new.txt", arr);
               }
               b++;
               if(s=="delete"){
                  /* Thread thre = new Thread(s1.speak2);
                   Thread.Sleep(30);
                   try
                   {
                       thre.Start();
                   }
                   catch (ThreadStateException) { }
                  

                   thre.Join();
                   
                   thre.Abort();
                   thre.Start();*/
                   s1.speak2(); s1.speak2(); s1.speak2(); s1.speak2();
               }
               if (s == "open" || into==true)
               {
                 
                 //  listBox.Items.Add("do you want to write on it?");
                   //s1.speak3();
                   if (direct == "zz")
                   { director(); director(); 
                    }

                   else
                   {
                       // s1.open2(chose2,direct);
                       // Thread.Sleep(1);
                       change(chose2);
                      // into = true;
                      if(into==true){
                       cl.open2(s, direct);
                       into = false;
                      }// s1.open2(chose2, direct); s1.open2(chose2, direct);
                       //if (init == false) { open2(); }
                      into = true;

                       init = false;
                      
                       // open2();
                   }
                  // rec.Dispose();
                  // initrec();
                  // gra.
                   
               }
                   
                  // Thread.Sleep(1000);
                   //s1.speak5() 
               if (s == "goto") {
                  // Thread thr=new Thread(s1.speak4);
                //   s1.speak4(); s1.speak4(); s1.speak4();
                   s1.speak4(); s1.speak4(); s1.speak4(); //s1.speak4(); s1.speak4();
                  // rec.Dispose();
                  // initrec();
                  
                  // Thread.Sleep(1);
                  // thr.Start();
                  // Thread.Sleep(100);
                  // thr.Join();
                  // thr.Abort();
                   
                  // Thread.Sleep(35);
                 //  thr.Join();
                  // thr.Abort();
                   
               }
               if(s=="translate"){

                   Thread thre = new Thread(s1.speak6);
                   thre.Start();
                   Thread.Sleep(80);
                   try
                   {
                       thre.Start();
                   }
                   catch (ThreadStateException) { }

                   thre.Join();
                   thre.Abort();
                   
               }
               if (s != null)
               {
                  // Boolean t = check(arr[0]);
                   //listBox.Items.Add(t);
               }
              
             /*  if (s == "file"  ) {
                   string x="file";
                   listBox.Items.Add("say name of the file");
                   speak2();
                   //SpeechRecognizedEventArgs e2=null;
                  // rec3_SpeechRecognized(rec3, e);
                  
                   cl.createfile(name);
                  
                  
                   }*/
              
           }
           //file.Close();
        }


        void speak()
        {

          //  listBox.Items.Add("create");
            SpeechRecognitionEngine rec2 = new SpeechRecognitionEngine();
            rec2.SetInputToDefaultAudioDevice();
            Choices chose = new Choices("file", "folder", "text", "document","end");
            GrammarBuilder grammer = new GrammarBuilder(chose);
            Grammar gra = new Grammar(grammer);
            rec2.LoadGrammar(gra);
            rec2.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec2_SpeechRecognized);
           // rec2_SpeechRecognized(rec2,);
            rec2.RecognizeAsync(RecognizeMode.Multiple);
           

        }

        void rec2_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string x;
            speak();
            foreach (RecognizedWordUnit word in e.Result.Words)
            {

                x = word.Text;
                switch (x)
                {
                    case "file": cl.createfile(name); break;
                    case "end": break;
                    default: continue;

                }

                break;


            }
            
        }


        Boolean check(string s)
        {
            for (int i = 0; i < 5; i++)
            {
                if (arr[i].Contains(s))
                {
                    return true;
                }
               ;
            }
            return false;
        }
        void director()
        {
            SpeechRecognitionEngine rec3 = new SpeechRecognitionEngine();
            name = "zz";
           rec3.SetInputToDefaultAudioDevice();
           Choices chose = new Choices("C", "D", "myDocument", "my computer");
           GrammarBuilder grammer = new GrammarBuilder(chose);
           Grammar gra = new Grammar(grammer);
           rec3.LoadGrammar(gra);
           rec3.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec3_SpeechRecognized);
           rec3.RecognizeAsync(RecognizeMode.Multiple);
        }

        void rec3_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string x = e.Result.Text;

            if (name == "zz")
                displaycontent(x);
            name = x;
            
        }

        void displaycontent(string s)
        {
            int i = 0;

            if (direct == "zz")
            {
                direct = s;
                string[] dirEntries = Directory.GetDirectories(s + "://");
                System.Diagnostics.Process p = new Process();
                ProcessStartInfo ps = new ProcessStartInfo(s+"://");
                p.StartInfo = ps;
                p.Start();
               // foreach (string dirName in dirEntries)
               // {

                    //listBox2.Items.Add(System.IO.Path.GetFileName(dirName));

              //  }
               
                Directory.SetCurrentDirectory(s+"://");
                string[] fileEntries = Directory.GetDirectories(s+"://");
               // image1 = new System.Windows.Controls.Image(); 
               

                foreach (string fileName in fileEntries)
                {


                  //  listBox3.Items.Add(System.IO.Path.GetFileName(fileName));
                   string w= fileName.Remove(0,4);
                    chose2.Add(w);


                }
            }
           
        }
        void open2(/*Choices c*/)
        {
            
            SpeechRecognitionEngine rec7 = new SpeechRecognitionEngine();
           // name = "zz";
           rec7.SetInputToDefaultAudioDevice();
           
           GrammarBuilder grammer = new GrammarBuilder(chose2);
           Grammar gra = new Grammar(grammer);
           rec7.LoadGrammar(gra);

           rec7.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec7_SpeechRecognized);
          
           rec7.RecognizeAsync(RecognizeMode.Single);
           

        }

        void rec7_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string x = null;
            //Thread.Sleep(10);
           
                x = e.Result.Text;
                if (x != null)
                {
                    open2(x);
                }
            
        }

        void open2(string x)
        {
            init = true;
            System.Diagnostics.Process p2 = new Process();
            ProcessStartInfo ps = new ProcessStartInfo(direct + ":/" + x + "/");
            Directory.SetCurrentDirectory(direct + ":/" + x + "/");
            p2.StartInfo = ps;
            p2.Start();
          

        }

        
        }

      

      
    }

