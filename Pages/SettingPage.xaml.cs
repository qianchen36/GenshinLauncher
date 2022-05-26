using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

using GenshinLauncher.Tasks;

namespace GenshinLauncher.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingPage : Page
    {
        public SettingPage()
        {
            this.InitializeComponent();

            iniConfigerTask ini_Launcher = new();
            ini_Launcher.Ini(@"E:\Genshin Impact\Genshin Impact Game\config.ini");
            TextBox_LauncherPath.Text = ini_Launcher.GetValue("sdk_version", "General");
            if (App.targetFPS != 0) TextBox_FPS.Value = App.targetFPS;
            TextBox_GamePath.Text = Convert.ToString(App.targetFPS);
        }

        private void TextBox_GamePath_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            App.gamePath = TextBox_GamePath.Text;
        }

        private void TextBox_GamePath_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {

        }

        private void TextBox_LauncherPath_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {

        }

        private void TextBox_LauncherPath_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {

        }

        private void TextBox_FPS_ValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args)
        {
            App.targetFPS = (int)TextBox_FPS.Value;
        }
    }
}
