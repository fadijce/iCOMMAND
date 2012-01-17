using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Recognition;
using System.Threading;

namespace sound
{
    class sound2
    {    
        private SpeechRecognitionEngine rec2;
      //  private SpeechRecognitionEngine rec3;
       string []arr=new string[5];
       int count = 0;
        Class1 cl = new Class1();
        string name = "zz";
        string dir = null;
        public sound2()
        {   
            //rec2 = new SpeechRecognitionEngine();
           // rec3 = new SpeechRecognitionEngine();
           // rec3.SpeechRecognized += rec3_SpeechRecognized;
           // rec3.SetInputToDefaultAudioDevice();
            //rec2.SpeechRecognized += rec2_SpeechRecognized;
          //  rec2.SetInputToDefaultAudioDevice();
           
        }
       public void speak()
        {

            //  listBox.Items.Add("create");
            SpeechRecognitionEngine rec2 = new SpeechRecognitionEngine();
            rec2.SetInputToDefaultAudioDevice();
            name = "zz";
            Choices chose = new Choices("file", "folder", "text", "document", "end");
            GrammarBuilder grammer = new GrammarBuilder(chose);
            Grammar gra = new Grammar(grammer);
            rec2.LoadGrammar(gra);
            rec2.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec2_SpeechRecognized);
            // rec2_SpeechRecognized(rec2,);
            //Thread.SpinWait(10);
          
            rec2.RecognizeAsync(RecognizeMode.Multiple);
            //if (name == "zz") speak();


        }

       void rec2_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
       { 
          
           string x=e.Result.Text;
          // if (x == null) speak();
           if(name=="zz")
           cl.createfile(x);
           name = x;
          }
       public void speak2()
       {
           name = "zz";
           SpeechRecognitionEngine rec3 = new SpeechRecognitionEngine();
           rec3.SetInputToDefaultAudioDevice();
           Choices chose = new Choices("file", "folder", "text", "document", "end");
           GrammarBuilder grammer = new GrammarBuilder(chose);
           Grammar gra = new Grammar(grammer);
           rec3.LoadGrammar(gra);
           rec3.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec3_SpeechRecognized);
            rec3.RecognizeAsync(RecognizeMode.Single);

       }

       void rec3_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
       {
           
         /*  string x = e.Result.Text;

           if (name == "zz")
               cl.delete(x);
           name = x;*/
           foreach (RecognizedWordUnit word in e.Result.Words)
           {
               string x = e.Result.Text;

               if (name == "zz")
               {
                   cl.delete(x);
                   break;
               }
               name = x;

           }
       }

       public void speak3()
       {
           name = "zz";
           /* SpeechRecognitionEngine rec4 = new SpeechRecognitionEngine();
            rec4.SetInputToDefaultAudioDevice();
            Choices chose = new Choices("C", "D", "Desktop", "documents", "end");
            GrammarBuilder grammer = new GrammarBuilder(chose);
            Grammar gra = new Grammar(grammer);
            rec4.LoadGrammar(gra);
            rec4.SpeechRecognized +=new EventHandler<SpeechRecognizedEventArgs>(rec4_SpeechRecognized);*/
           SpeechRecognitionEngine rec4 = new SpeechRecognitionEngine();
           rec4.SetInputToDefaultAudioDevice();
           rec4.LoadGrammar(new DictationGrammar());
           rec4.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec4_SpeechRecognized);
           rec4.RecognizeAsync(RecognizeMode.Multiple);
       }

       void rec4_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
       {  
           string x = e.Result.Text;
           string y = x;
           arr[count] = x;
           count++;
           while (x.CompareTo("End")==0 ||x.CompareTo("And")==0)
           {
               x = e.Result.Text;
               if(x!=null&&y!=x){
                   y = x;
               arr[count] = x;
               count++;
               }
           }
           return;
          // rec4_SpeechRecognized(sender, e);
       }



     public  void open2(Choices c,string direct)
       {

           SpeechRecognitionEngine rec8 = new SpeechRecognitionEngine();
           // name = "zz";
           rec8.SetInputToDefaultAudioDevice();
           dir = direct;
           GrammarBuilder grammer = new GrammarBuilder(c);
           Grammar gra = new Grammar(grammer);
           rec8.LoadGrammar(gra);

           rec8.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec8_SpeechRecognized);

           rec8.RecognizeAsync(RecognizeMode.Single);


       }

       void rec8_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
       {

          
        /*    string x = null;
            //Thread.Sleep(10);
           
                x = e.Result.Text;
                if (x != null)
                {
                   cl.open2(x,dir);
                }*/
            foreach (RecognizedWordUnit word in e.Result.Words){
                
           string x = null;
            x = e.Result.Text;
                if (x != null)
                {
                    cl.open2(x, dir); break; 
                }

            }
           
            
        }
    

      

       


      
           
       

       public void speak4()
       {
           name = "zz";
           SpeechRecognitionEngine rec5 = new SpeechRecognitionEngine();
           rec5.SetInputToDefaultAudioDevice();
           Choices chose = new Choices("google", "yahoo", "wwe", "youtube");
           GrammarBuilder grammer = new GrammarBuilder(chose);
           Grammar gra = new Grammar(grammer);
           rec5.LoadGrammar(gra);
           rec5.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec5_SpeechRecognized);
           rec5.RecognizeAsync(RecognizeMode.Single);
       }

       void rec5_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
       {
         /*  string x = e.Result.Text;

           if (name == "zz")
               cl.site(x);
           name = x;*/
           foreach (RecognizedWordUnit word in e.Result.Words)
           {
               string x = e.Result.Text;

               if (name == "zz")
               {
                   cl.site(x); break;
               }
               name = x;

           }
           
           
       }
       public void speak5()
       {
           name = "zz";
           SpeechRecognitionEngine rec6 = new SpeechRecognitionEngine();
           rec6.SetInputToDefaultAudioDevice();
           Choices chose = new Choices("yes", "no");
           GrammarBuilder grammer = new GrammarBuilder(chose);
           Grammar gra = new Grammar(grammer);
           rec6.LoadGrammar(gra);
           rec6.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec6_SpeechRecognized);
           rec6.RecognizeAsync(RecognizeMode.Single);
       }

       void rec6_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
       {
           string x = e.Result.Text;
         
          if (x=="yes"){
              cl.writetofile();

          }
          
       }


       public void speak6()
       {
           SpeechRecognitionEngine rec7 = new SpeechRecognitionEngine();
           rec7.SetInputToDefaultAudioDevice();
           rec7.LoadGrammar(new DictationGrammar());
           rec7.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec7_SpeechRecognized);
           rec7.RecognizeAsync(RecognizeMode.Single);

       }

       void rec7_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
       {
           string[] arr2 = new string[30];
           int i=0;
           foreach (RecognizedWordUnit word in e.Result.Words)
           {
               arr2[i] = word.Text;
               i++;
               if (i == 1) { 
                   cl.translate(arr2, System.Text.Encoding.UTF7); break; }
           }
       }

       
    }
}
