using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
namespace LauncherSubnauticaBZMultiplayer
{
    public partial class launcher : MetroSetForm
    {
        Thread start;
        public launcher()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.metroSetTabControl1.SelectedTab = this.metroSetSetTabPage3;
            Console.SetOut(new TextBoxWriter(metroSetTextBox1));
            start = new Thread(StartServer.Start);
            string ip = iptb.Text;
            string path = pathtb.Text;
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            if (!start.IsAlive)
            {
                start.Start();
            }
                this.metroSetTabControl1.SelectedTab = this.metroSetSetTabPage5;
            
               
        }

        private void metroSetSetTabPage5_Click(object sender, EventArgs e)
        {

        }

        private void metroSetRichTextBox1_TextChanged(object sender)
        {

        }

        private void metroSetTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroSetSetTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void metroSetTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroSetControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroSetTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroSetSetTabPage6_Click(object sender, EventArgs e)
        {

        }

        private void metroSetLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroSetLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Damien2417/SubnauticaBZMultiplayerMod");
        }

        private void btnPolish_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
           
        }

        private void metroSetLabel3_Click(object sender, EventArgs e)
        {

        }
       
        private void metroSetComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = metroSetComboBox1.Text;
            switch (text)
            {
                case "English":
                   
                    metroSetSetTabPage3.Text = Properties.strings.servertab;
                    metroSetSetTabPage4.Text = Properties.strings.settingstab;
                    metroSetSetTabPage5.Text = Properties.strings.consoletab;
                    metroSetSetTabPage7.Text = Properties.strings.creditstab;
                    metroSetButton1.Text = Properties.strings.start_serverbtn;
                    metroSetLabel3.Text = Properties.strings.languagetext;
                    metroSetLabel1.Text = Properties.strings.consoletext;
                    metroSetLabel2.Text = Properties.strings.linkstext;
                    pathlb.Text = Properties.strings.pathlb;
                   
                    gamestart.Text = Properties.strings.gamestartbtn;
                    
                    break;
                case "Polish":
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("pl-PL");
                    metroSetSetTabPage3.Text = Properties.strings.servertab;
                    metroSetSetTabPage4.Text = Properties.strings.settingstab;
                    metroSetSetTabPage5.Text = Properties.strings.consoletab;
                    metroSetSetTabPage7.Text = Properties.strings.creditstab;
                    metroSetButton1.Text = Properties.strings.start_serverbtn;
                    metroSetLabel3.Text = Properties.strings.languagetext;
                    metroSetLabel1.Text = Properties.strings.consoletext;
                    metroSetLabel2.Text = Properties.strings.linkstext;
                    pathlb.Text = Properties.strings.pathlb;
                    
                    gamestart.Text = Properties.strings.gamestartbtn;
                   
                    break;
                default:
                    break;
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/Nr6nBdCUg2");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.patreon.com/subnauticabz");
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void gamestart_Click(object sender, EventArgs e)
        {
            string path = pathtb.Text;
            //if (System.IO.Directory.Exists(path))
            //{
                Process.Start(path);
           // }
            //else
            //{
                //MessageBox.Show("Could not find game path | Nie możemy znaleźć ścieżki gry","Error | Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            //}


           
        
        }
    }
}
