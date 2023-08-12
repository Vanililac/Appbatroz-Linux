using System;
using Gtk;
using System.Collections.Generic;
using System.Diagnostics;
using UI = Gtk.Builder.ObjectAttribute;
namespace Appbatrozlinux
{
    class searchwindow : Window
    {
     
          [UI] private Entry entry1 = null;
        [UI] private TextView textview1 = null;
         [UI] private Entry entry2 = null;
        [UI] private TextView textview2 = null;
      string[] listexc;
        private int _counter;

        public searchwindow() : this(new Builder("searchwindow.glade")) { }
  List<string> lsname = new List<string>();
        private searchwindow(Builder builder) : base(builder.GetRawOwnedObject("searchwindow"))
        {
            string a = "";
            builder.Autoconnect(this);

            foreach (string ln in ExecuteCommand())
            {

                a += ln+"\n";

            }
            textview1.Buffer.Text = a;
            listexc =ExecuteCommand();
          //  DeleteEvent += Window_DeleteEvent;
         //   _button1.Clicked += Button1_Clicked;
        }
        
     
        public static string[] ExecuteCommand()
        {

            string[] ss ;
            string command = "ls /usr/share/applications";
            Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "/bin/bash";
            proc.StartInfo.Arguments = "-c \" " + command + " \"";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            List<string> list = new List<string>();
            while (!proc.StandardOutput.EndOfStream)
            {
                list.Add("/usr/share/applications/" + proc.StandardOutput.ReadLine());
              
                
               
            }
            ss = list.ToArray();
            proc.Close();
            return ss;
        }
        public static string finallist(string ms)
        {

            string ss="";
            string s ="";
               
                string command = "grep 'Exec' "+ms;

            Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "/bin/bash";
                proc.StartInfo.Arguments = "-c \" " + command + " \"";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.Start();
                while (!proc.StandardOutput.EndOfStream)
                {
                    s+=proc.StandardOutput.ReadLine()+"\n";
               


            }

            ss = s;
            return ss;
        }
  
        protected void OnTextview1Shown(object sender, EventArgs e)
        {
        }

        protected void OnEntry1KeyReleaseEvent(object o, KeyReleaseEventArgs args)
        {

            string a = "";
            List<string> list = new List<string>();
            foreach (string ms in listexc)
            {
                if (ms.ToLower().Contains(entry1.Text.ToLower()))
                {
                    list.Add(ms);
                }

             
            }
            foreach (string ln in list.ToArray())
            {

                a += ln + "\n";

            }
            textview1.Buffer.Text = a;
           
         }
          protected void OnButton1Clicked(object sender, EventArgs e)
        {
            textview2.Buffer.Text = finallist(entry2.Text);
        }
    }
    }
