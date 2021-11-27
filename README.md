# LauncherSubnauticaBZMultiplayer
This is only launcher

Full mod is on:
https://github.com/Damien2417/SubnauticaBZMultiplayerMod

If you want to add language to the launcher:

1.First fork this repository
2.Open in Visual Studio
3.Add option in ComboBox
4.Add this code in the switch:

case "Your language":
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("your language shortcuts np.fr-FR");
                    metroSetSetTabPage3.Text = Properties.strings.servertab;
                    metroSetSetTabPage4.Text = Properties.strings.settingstab;
                    metroSetSetTabPage5.Text = Properties.strings.consoletab;
                    metroSetSetTabPage7.Text = Properties.strings.creditstab;
                    metroSetButton1.Text = Properties.strings.start_serverbtn;
                    metroSetLabel3.Text = Properties.strings.languagetext;
                    metroSetLabel1.Text = Properties.strings.consoletext;
                    metroSetLabel2.Text = Properties.strings.linkstext;
      break;

5.create file in the properties folder strings.your language shortcuts.resx
6.create the same names for the elements from the form1.cs and add your language words on the right
7.Create a pull request to this repository

