using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using PInvoke;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;

using WinUIEx;
using GenshinLauncher;
using GenshinLauncher.Tasks;
using Microsoft.UI.Windowing;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GenshinLauncher.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LaunchPage
    {

        public LaunchPage()
        {
            this.InitializeComponent();
        }

        private async void LaunchButton_Click(SplitButton sender, SplitButtonClickEventArgs args)
        {
            LaunchButton.IsEnabled = false;

            Task GameTask = LaunchTask.RunGame(@"E:\Genshin Impact\launcher.exe");
            await GameTask;

            LaunchButton.IsEnabled = true;
        }
    }
}
