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
    public partial class Form1 : MetroSetForm
    {
        Thread start;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.metroSetTabControl1.SelectedTab = this.metroSetSetTabPage3;
            Console.SetOut(new TextBoxWriter(metroSetTextBox1));
            start = new Thread(StartServer.Start);
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
                    break;
                default:
                    break;
            }
        }
    }
}
