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
using System.IO;
using System.Diagnostics;
namespace sound2
{
    
    public partial class MainWindow : Window
    {
        private SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
        Choices chose;
        sound sound=new sound();
        int id=0,num=0,id2=0;
        Choices cho = new Choices(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            rec.SetInputToDefaultAudioDevice();
            chose = new Choices("open", "goto", "new", "translate" ,"delete","map","close");
            //arr = new string[5] { "open", "goto", "create", "save", "delete" };

            GrammarBuilder grammer = new GrammarBuilder(chose);
            Grammar gra = new Grammar(grammer);

            rec.LoadGrammar(gra);
            rec.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec_SpeechRecognized);
            rec.RecognizeAsync(RecognizeMode.Multiple);
           

        }
       
        

        void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {


            string s;
            foreach (RecognizedWordUnit word in e.Result.Words)
            {
               
                s = word.Text;
                listBox1.Items.Add(s);
                if (s == "text" && id2 == 1)
                { 
                    num = 3; id2 = 0; s = "blah"; }
                if (s == "folder" && id2 == 1) { num = 3; id2 = 0; }
                switch(s){
                    case "open":
                        {
                            if(id==0){
                                change(1);
                                num = 1;
                                
                            }
                            if (id == 1)
                            {
                                upload(1);
                                change(0);
                                num = 2;
                            }
                            id++;
                            break;
                        }
                    case "new":
                        {
                            if (id2 == 0)
                            {
                                listBox1.Items.Add("say what type text or folder?");
                                change(2);
                                id2++;

                            }
                            break;
                        }
                    case "delete":
                        {
                            listBox1.Items.Add("which one?");
                            upload(2);
                            change(0);
                            num = 5;
                            break;
                        }
                    case "translate":
                        {
                            change(4);
                            num = 6;
                            break;
                        }
                    case "goto":
                        {
                            change(5);
                            num = 7;
                            break;
                        }
                    case "map":
                        {
                            change(6);
                            num = 8;
                            break;
                        }
                    case "close":
                        {
                           
                            sound.close();
                           // this.Close();
                            //Directory.GetCurrentDirectory();
                            break;
                        }

                    default:
                        {
                          if(num==1){
                              sound.open(s);
                              changeback();
                              num = 0;
                          }
                          if (num == 2)
                          {
                              sound.open2(s);
                              changeback();
                              num = 0;
                              id--;
                          }
                          if (num == 3)
                          {
                              change(3);
                             // changeback();
                             // num = 0;
                            //  num = 0;
                              break;
                          }
                          if (num == 4)
                          {
                              sound.create(s);
                              changeback();
                              num = 0;
                          }
                          if (num == 5)
                          {

                              sound.delete(s);
                              changeback();
                              num = 0;
                          }
                          if (num == 6)
                          {
                              sound.translate(s);
                              changeback();
                              num = 0;
                          }
                          if (num == 7)
                          {
                              sound.internet(s);
                              changeback();
                              num = 0;

                          }
                          if (num == 8)
                          {
                              sound.maps(s);
                              changeback();
                              num = 0;

                          }

                          
                          break;

                        }



                }



            }
        }


        void change(int a)
        {
          //  Choices cho=new Choices(); 
            if (a == 0)
            {
                GrammarBuilder grammer = new GrammarBuilder(chose);
                Grammar gra = new Grammar(grammer);

                rec.LoadGrammar(gra);
                return;
            }
            if (a == 1)
            {
               //  cho = new Choices("C","D");
                 chose.Add("C","D");
                 rec.UnloadAllGrammars();
                 GrammarBuilder grammer = new GrammarBuilder(chose);
                 Grammar gra = new Grammar(grammer);

                 rec.LoadGrammar(gra);
                 return;

            }
            if (a == 2)
            {
                chose.Add("text", "file");

                GrammarBuilder grammer = new GrammarBuilder(chose);
                Grammar gra = new Grammar(grammer);

                rec.LoadGrammar(gra);
                return;

            }
            if (a == 3)
            {
                rec.UnloadAllGrammars();
                rec.LoadGrammar(new DictationGrammar());
                num = 4;
                return;
            }
            if (a == 4)
            {
                rec.UnloadAllGrammars();
                rec.LoadGrammar(new DictationGrammar());
               
                return;
            }
            if (a == 5)
            {
                chose.Add("google","yahoo","youtube");

                GrammarBuilder grammer = new GrammarBuilder(chose);
                Grammar gra = new Grammar(grammer);

                rec.LoadGrammar(gra);
                return;
            }
            if (a == 6)
            {
                chose.Add("telaviv","jerusalem","haifa","yafo","elat");

                GrammarBuilder grammer = new GrammarBuilder(chose);
                Grammar gra = new Grammar(grammer);

                rec.LoadGrammar(gra);
                return;

            }

           
           


           
        }
        void changeback()
        {
            rec.UnloadAllGrammars(); 
            chose = new Choices("open", "goto", "new", "translate","delete","close");
            GrammarBuilder grammer = new GrammarBuilder(chose);
            Grammar gra = new Grammar(grammer);
           
            rec.LoadGrammar(gra);

        }
        void upload(int a)
        {
            string k = Directory.GetCurrentDirectory();
            
            if (a == 1)
            {
                string[] fileEntries = Directory.GetDirectories(k);
                rec.UnloadAllGrammars();
                foreach (string fileName in fileEntries)
                {


                    //  listBox3.Items.Add(System.IO.Path.GetFileName(fileName));
                    string w = fileName.Remove(0, 3);
                    chose.Add(w);


                }
            }
            if (a == 2)
            {
                String w;
                string[] fileEntries = Directory.GetFiles(k);
                char[] c = k.ToCharArray();
               // string h = ".txt";
                char[] x = ".txt".ToCharArray();
                rec.UnloadAllGrammars();
                foreach (string fileName in fileEntries)
                {


                    string h;
                 h = fileName.TrimStart(c);
                 w=h.TrimEnd(x);
                  // w = fileName;
                    chose.Add(w);


                }

            }
        }

        

    }
}
