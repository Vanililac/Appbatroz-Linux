using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace Appbatrozlinux
{
    class timerwindow : Window
    {
        [UI] private Entry entry1 = null;
        [UI] private Entry entry2 = null;
        [UI] private Entry entry3 = null;
        [UI] private Entry entry4 = null;
        [UI] private Entry entry5 = null;
         [UI] private Entry entry6 = null;
        [UI] private Entry entry7 = null;
        [UI] private Entry entry8 = null;
        [UI] private Entry entry9 = null;
        [UI] private Entry entry10 = null;
         [UI] private Entry entry11 = null;
        [UI] private Entry entry12 = null;
        [UI] private Entry entry13 = null;
        [UI] private Entry entry14 = null;
        [UI] private Entry entry15 = null;
         [UI] private Entry entry16 = null;
        [UI] private Entry entry17 = null;
        [UI] private Entry entry18 = null;
        [UI] private Entry entry19 = null;
        [UI] private Entry entry20 = null;
         [UI] private Entry entry21 = null;
        [UI] private Entry entry22 = null;
        [UI] private Entry entry23 = null;
        [UI] private Entry entry31 = null;
        [UI] private RadioButton radiobutton1 = null;
        [UI] private RadioButton radiobutton2 = null;
        [UI] private RadioButton radiobutton3 = null;
        [UI] private RadioButton radiobutton3n = null;
        [UI] private RadioButton radiobutton4 = null;
        [UI] private RadioButton radiobutton5 = null;
        [UI] private RadioButton radiobutton5n = null;
         [UI] private RadioButton radiobutton6 = null;
        [UI] private RadioButton radiobutton7 = null;
        [UI] private RadioButton radiobutton7n = null;
        [UI] private RadioButton radiobutton8 = null;
        [UI] private RadioButton radiobutton9 = null;
        [UI] private RadioButton radiobutton9n = null;
        [UI] private RadioButton radiobutton10 = null;
        [UI] private RadioButton radiobutton11 = null;
        [UI] private RadioButton radiobutton11n = null;
        [UI] private RadioButton radiobutton12 = null;
        [UI] private RadioButton radiobutton13 = null;
        [UI] private RadioButton radiobutton13n = null;
        [UI] private RadioButton radiobutton14 = null;
        [UI] private RadioButton radiobutton15 = null;
        [UI] private RadioButton radiobutton15n = null;
        [UI] private RadioButton radiobutton16 = null;
        [UI] private RadioButton radiobutton17 = null;
        [UI] private RadioButton radiobutton17n = null;
        [UI] private RadioButton radiobutton18 = null;
        [UI] private RadioButton radiobutton19n = null;
         
string c1, c2, c3, c4, c5, c6, c7, c8, c9, c10; 
string[] part;
int count =0;
public timerwindow() : this(new Builder("timerwindow.glade")) { }

        private timerwindow(Builder builder) : base(builder.GetRawOwnedObject("timerwindow"))
        {
            builder.Autoconnect(this);

        }
        private void cle(){
             entry1.Text = "";
            entry2.Text = "";
            entry3.Text = "";
            entry4.Text = "";
            entry5.Text = "";
            entry6.Text = "";
            entry7.Text = "";
            entry8.Text = "";
            entry9.Text = "";
            entry10.Text = "";
            entry11.Text = "";
            entry12.Text = "";
            entry13.Text = "";
            entry14.Text = "";
            entry15.Text = "";
            entry16.Text = "";
            entry17.Text = "";
            entry18.Text = "";
            entry19.Text = "";
            entry20.Text = "";
            entry21.Text = "";
            entry22.Text = "";
            entry23.Text = "";
          entry31.Text="";

            MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Success");
            md.Run();
            md.Destroy();
        }
         public static void ExecuteCommand(string command)
        {
            Process proc = new System.Diagnostics.Process();
          System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
  
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
      
     startInfo.FileName = "/bin/bash";
    startInfo.Arguments = "-c \" " + command + " \"";
            process.StartInfo = startInfo;
          process.StartInfo.RedirectStandardInput = true;
            
        process.StartInfo.RedirectStandardOutput = true;
            process.Start();
             process.Close();
    
          
  
         

           
        }
          public void ffun(bool status)
        {


            try
            {

                if (radiobutton1.Active == true)
                {
                    c1 = " &&read -p 'Press any key to continue...' &&";
                }
                if (radiobutton2.Active == true)
                {
                    c1 = " ||";
                }
                if (radiobutton3.Active == true)
                {
                    c2 = " &&read -p 'Press any key to continue...' &&";
                }
                if (radiobutton4.Active == true)
                {
                    c2 = " ||";

                }
                if (radiobutton5.Active == true)
                {
                    c3 = " &&read -p 'Press any key to continue...' &&";
                }
                if (radiobutton6.Active == true)
                {
                    c3 = " ||";
                }
                if (radiobutton7.Active == true)
                {
                    c4 = " &&read -p 'Press any key to continue...' &&";
                }
                if (radiobutton8.Active == true)
                {
                    c4 = " ||";
                }
                if (radiobutton9.Active == true)
                {
                    c5 = " &&read -p 'Press any key to continue...' &&";
                }
                if (radiobutton10.Active == true)
                {
                    c5 = " ||";
                }
                if (radiobutton11.Active == true)
                {
                    c6 = " &&read -p 'Press any key to continue...' &&";
                }
                if (radiobutton12.Active == true)
                {
                    c6 = " ||";
                }
                if (radiobutton13.Active == true)
                {
                    c7 = " &&read -p 'Press any key to continue...' &&";
                }
                if (radiobutton14.Active == true)
                {
                    c7 = " ||";
                }
                if (radiobutton15.Active == true)
                {
                    c8 = " &&read -p 'Press any key to continue...' &&";
                }
                if (radiobutton16.Active == true)
                {
                    c8 = " ||";
                }
                if (radiobutton17.Active == true)
                {
                    c9 = " &&read -p 'Press any key to continue...' &&";
                }
                if (radiobutton18.Active == true)
                {
                    c9 = " ||";
                }
                if (radiobutton3n.Active == true)
                {
                   c1 = " &";
                }
                if (radiobutton5n.Active == true)
                {
                    c2 = " &";
                }
                if (radiobutton7n.Active == true)
                {
                    c3 = " &";
                }
                if (radiobutton9n.Active == true)
                {
                    c4 = " &";
                }
                if (radiobutton11n.Active == true)
                {
                    c5 = " &";
                }
                if (radiobutton13n.Active == true)
                {
                    c6 = " &";
                }
                if (radiobutton15n.Active == true)
                {
                    c7 = " &";
                }
                if (radiobutton17n.Active == true)
                {
                    c8 = " &";
                }
                if (radiobutton19n.Active == true)
                {
                    c9 = " &";
                }
  string en2,en4,en6,en8,en10,en12,en14,en16,en18,en20;
            if(entry2.Text==""){
                en2="";
            }
            else{
                en2="'"+entry2.Text+"'";
            }

             if(entry4.Text==""){
                en4="";
            }
            else{
                en4="'"+entry4.Text+"'";
            }

            if(entry6.Text==""){
                en6="";
            }
            else{
                en6="'"+entry6.Text+"'";
            }

             if(entry8.Text==""){
                en8="";
            }
            else{
                en8="'"+entry8.Text+"'";
            }

            if(entry10.Text==""){
                en10="";
            }
            else{
                en10="'"+entry10.Text+"'";
            }

             if(entry12.Text==""){
                en12="";
            }
            else{
                en12="'"+entry12.Text+"'";
            }

            if(entry14.Text==""){
                en14="";
            }
            else{
                en14="'"+entry14.Text+"'";
            }

             if(entry16.Text==""){
                en16="";
            }
            else{
                en16="'"+entry16.Text+"'";
            }

            if(entry18.Text==""){
                en18="";
            }
            else{
                en18="'"+entry18.Text+"'";
            }

             if(entry20.Text==""){
                en20="";
            }
            else{
                en20="'"+entry20.Text+"'";
            }

//
 string cn1,cn3,cn5,cn7,cn9,cn11,cn13,cn15,cn17,cn19;
            if(entry1.Text==""){
                cn1="xdg-open";
            }
            else{
                cn1=""+entry1.Text+"";
            }

             if(entry3.Text==""){
                cn3="xdg-open";
            }
            else{
                cn3=""+entry3.Text+"";
            }

            if(entry5.Text==""){
                cn5="xdg-open";
            }
            else{
                cn5=""+entry5.Text+"";
            }

             if(entry7.Text==""){
                cn7="xdg-open";
            }
            else{
                cn7=""+entry7.Text+"";
            }

            if(entry9.Text==""){
                cn9="xdg-open";
            }
            else{
                cn9=""+entry9.Text+"";
            }

             if(entry11.Text==""){
                cn11="xdg-open";
            }
            else{
                cn11=""+entry11.Text+"";
            }

            if(entry13.Text==""){
                cn13="xdg-open";
            }
            else{
                cn13=""+entry13.Text+"";
            }

             if(entry15.Text==""){
                cn15="xdg-open";
            }
            else{
                cn15=""+entry15.Text+"";
            }

            if(entry17.Text==""){
                cn17="xdg-open";
            }
            else{
                cn17=""+entry17.Text+"";
            }

             if(entry19.Text==""){
                cn19="xdg-open";
            }
            else{
                cn19=""+entry19.Text+"";
            }
//
                String txt = "";
               if (entry1.Text != "" || entry2.Text != "")
            {
               
                    txt =  "echo '" + entry31.Text + "' |" +cn1+" " + en2 ;
                

            }
            if (entry3.Text != "" || entry4.Text != "")
            {
               
                txt =  "echo '" + entry31.Text + "' |" +cn1+" " + en2 +  " "+c1  +  "echo '" + entry31.Text + "' |" +cn3+" " + en4;

                
            }
            if (entry5.Text != "" || entry6.Text != "")
            {
                txt = "echo '" + entry31.Text + "' |" +cn1+" " + en2 +  " "+c1  + "echo '" + entry31.Text + "' |" +cn3+" " + en4 +  " "+c2  + "echo '" + entry31.Text + "' |" +cn5+" "  + en6 ;
            }
            if (entry7.Text != "" || entry8.Text != "")
            {
                txt = "echo '" + entry31.Text + "' |" +cn1+" " + en2 +  " "+c1  + "echo '" + entry31.Text + "' |" +cn3+" " +en4 +  " "+c2  +  "echo '" + entry31.Text + "' |" +cn5+" "  + en6 +  " "+c3  +  "echo '" + entry31.Text + "' |" +cn7+" "  + en8 ;
            }
            if (entry9.Text != "" || entry10.Text != "")
            {
                txt =  "echo '" + entry31.Text + "' |" +cn1+" " + en2 +  " "+c1  +  "echo '" + entry31.Text + "' |" +cn3+" " + en4 +  " "+c2  + "echo '" + entry31.Text + "' |" +cn5+" "  + en6 +  " "+c3  + "echo '" + entry31.Text + "' |" +cn7+" "  + en8 +  " "+c4  + "echo '" + entry31.Text + "' |" +cn9+" "  + en10 ;
            }
            if (entry11.Text != "" || entry12.Text != "")
            {
                txt =  "echo '" + entry31.Text + "' |" +cn1+" " + en2 + " "+c1  + "echo '" + entry31.Text + "' |" +cn3+" " + en4 +  " "+c2  +  "echo '" + entry31.Text + "' |" +cn5+" "  + en6 +  " "+c3  + "echo '" + entry31.Text + "' |" +cn7+" "  + en8 +  " "+c4  + "echo '" + entry31.Text + "' |" +cn9+" "  + en10 +  " "+c5  +  "echo '" + entry31.Text + "' |" +cn11+" "  + en12 ;
            }
            if (entry13.Text != "" || entry14.Text != "")
            {
                txt =  "echo '" + entry31.Text + "' |" +cn1+" " + en2 +  " "+c1  + "echo '" + entry31.Text + "' |" +cn3+" " + en4 +  " "+c2  +  "echo '" + entry31.Text + "' |" +cn5+" "  + en6 +  " "+c3  +  "echo '" + entry31.Text + "' |" +cn7+" "  + en8 +  " "+c4  + "echo '" + entry31.Text + "' |" +cn9+" "  + en10 +  " "+c5  +  "echo '" + entry31.Text + "' |" +cn11+" "  + en12 +  " "+c6  + "echo '" + entry31.Text + "' |" +cn13+" " + en14 ;
            }
            if (entry15.Text != "" || entry16.Text != "")
            {
                txt = "echo '" + entry31.Text + "' |" +cn1+" " + en2 +  " "+c1  +  "echo '" + entry31.Text + "' |" +cn3+" " + en4 +  " "+c2  + "echo '" + entry31.Text + "' |" +cn5+" "  + en6 + " "+c3  + "echo '" + entry31.Text + "' |" +cn7+" "  + en8 +  " "+c4  + "echo '" + entry31.Text + "' |" +cn9+" "  + en10 +  " "+c5  + "echo '" + entry31.Text + "' |" +cn11+" "  + en12 +  " "+c6  + "echo '" + entry31.Text + "' |" +cn13+" " + en14 +  " "+c7  +  "echo '" + entry31.Text + "' |" +cn15+" "  + en16 ;
            }
            if (entry17.Text != "" || entry18.Text != "")
            {
                txt =  "echo '" + entry31.Text + "' |" +cn1+" " + en2 +  " "+c1  + "echo '" + entry31.Text + "' |" +cn3+" " + en4 +  " "+c2  + "echo '" + entry31.Text + "' |" +cn5+" "  + en6 +  " "+c3  + "echo '" + entry31.Text + "' |" +cn7+" "  + en8 +  " "+c4  +  "echo '" + entry31.Text + "' |" +cn9+" "  + en10 +  " "+c5  + "echo '" + entry31.Text + "' |" +cn11+" "  + en12 +  " "+c6  + "echo '" + entry31.Text + "' |" +cn13+" " + en14 +  " "+c7  + "echo '" + entry31.Text + "' |" +cn15+" "  + en16 +  " "+c8  + "echo '" + entry31.Text + "' |" +cn17+" "  + en18 ;
            }
            if (entry19.Text != "" || entry20.Text != "")
            {
                txt =  "echo '" + entry31.Text + "' |" +cn1+" " + en2 + " "+c1 +  "echo '" + entry31.Text + "' |" +cn3+" " + en4 + " "+c2 + "echo '" + entry31.Text + "' |" +cn5+" "  + en6 +  " "+c3  + "echo '" + entry31.Text + "' |" +cn7+" "  + en8 +  " "+c4  + "echo '" + entry31.Text + "' |" +cn9+" "  +en10 +  " "+c5  + "echo '" + entry31.Text + "' |" +cn11+" "  + en12 +  " "+c6  + "echo '" + entry31.Text + "' |" +cn13+" " + en14 +  " "+c7  + "echo '" + entry31.Text + "' |" +cn15+" "  + en16 +  " "+c8  + "echo '" + entry31.Text + "' |" +cn17+" "  + en18 +  " "+c9  +  "echo '" + entry31.Text + "' |" +cn19+" "  + en20 ;
            }
               
                if (status == true) { 
            string ftxt; 
                    if (txt.Contains(" &&read -p 'Press any key to continue...' &&"))
                    {
                        ftxt = '"' + txt + " &&read -p 'Press any key to continue...'"+ '"';
                    }
                    else { 
                    ftxt = '"' + txt + '"';
                    }
                    var last = "";
                    if (entry23.Text != "") {
               string filepath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "/appbatrozlnx/appbatrozicon/";
                System.IO.FileInfo file = new System.IO.FileInfo(filepath);
                file.Directory.Create();
                var nicon=entry23.Text.Split('/').Last();
                var chicon=file+nicon;
                   if (!File.Exists(chicon)){
          
                File.Copy(entry23.Text, file.FullName+"/"+nicon);
          }
                last = file.FullName + entry23.Text.Split('/').Last();
            }
                 string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + "/";
              
                if(entry21.Text==""){
    MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Title is empty");
            md.Run();
            md.Destroy();
                }
                else{
                string dskfl;
                
                    if (txt.Contains(" &&read -p 'Press any key to continue...' &&"))
                    {
                       dskfl = "[Desktop Entry]" + "\n" +
                    "Name=" + entry21.Text + "\n" + "StartupWMClass=" + entry22.Text + "\n" + "Comment=" + entry21.Text + "\n" + "GenericName=Shortcut" + "\n" + "Exec= bash -c " + ftxt + "\n" + "Icon=" + last + "\n" + "Type=Application\nCategories=Application;\nTerminal=true" + "\n" + "MimeType=text/html;text/xml;application/xhtml+xml;application/xml;application/vnd.mozilla.xul+xml; application/rss+xml;application/rdf+xml;image/gif;image/jpeg;image/png;x-scheme-handler/http;x-scheme-handler/https;" + "\n" + "Keywords=Shortcut;Appbatroz;";
                    }
                    else
                    {
                        dskfl = "[Desktop Entry]" + "\n" +
                    "Name=" + entry21.Text + "\n" + "StartupWMClass=" + entry22.Text + "\n" + "Comment=" + entry21.Text + "\n" + "GenericName=Shortcut" + "\n" + "Exec= bash -c " + ftxt + "\n" + "Icon=" + last + "\n" + "Type=Application\nCategories=Application;\nTerminal=false" + "\n" + "MimeType=text/html;text/xml;application/xhtml+xml;application/xml;application/vnd.mozilla.xul+xml; application/rss+xml;application/rdf+xml;image/gif;image/jpeg;image/png;x-scheme-handler/http;x-scheme-handler/https;" + "\n" + "Keywords=Shortcut;Appbatroz;";

                    }
            string folders = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) +"/";
            // Filename

            string fileName = entry21.Text +".desktop";
           
            // Fullpath. You can direct hardcode it if you like.
            string fullPath = folders + fileName;
            //  ExecuteCommand(txt);
           
            File.WriteAllText(fullPath, dskfl);
                 cle();
                }
 
                }
                else
                {
            
                      if(txt.Contains(" &&read -p 'Press any key to continue...' &&")){
                         part = txt.Split(new string[] { " &&read -p 'Press any key to continue...' &&" }, StringSplitOptions.None);
                         ExecuteCommand(part[0]);
                           Console.Write(part[0]);
                      }
                      else{
                    ExecuteCommand(txt);
                    cle();
                   }
                }
    
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
          protected void save_Clicked(object sender, EventArgs e)
        {
            ffun(true);
            
        }

        protected void run_Clicked(object sender, EventArgs e)
        {
            ffun(false);
        }
           private void OpenOFD()
    {
        Gtk.FileChooserDialog filechooser =
            new Gtk.FileChooserDialog("Choose the file to open",
                this,
                FileChooserAction.Open,
                "Cancel", ResponseType.Cancel,
                "Open", ResponseType.Accept);

        if (filechooser.Run() == (int)ResponseType.Accept)
        {
            entry23.Text = filechooser.Filename;
           
            //file.Close();
        }

        filechooser.Destroy();
    }
      protected void icon_Clicked(object sender, EventArgs e)
    {
        OpenOFD();
    }
     protected void next_onclicked(object sender, EventArgs e)
    {
       
       if(count != (part.Length-1)){
          count++;
        ExecuteCommand(part[count]);
        }
        else{
            count =0;
            cle();
        }
        
    }
    
        }
        }