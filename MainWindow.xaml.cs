﻿using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Interop;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Windowing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WinRT;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics;
using Microsoft.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GenshinLauncher
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            //获得窗口句柄
            GetAppWindowAndPresenter();
            //默认窗口大小
            SizeInt32 MainWindowSize;
            MainWindowSize.Width = 1280;
            MainWindowSize.Height = 720;
            _apw.Resize(MainWindowSize);
            //禁止调整窗口大小
            _presenter.IsResizable = false;
            //重设标题栏样式
            _apw.TitleBar.ExtendsContentIntoTitleBar = true;
            _apw.TitleBar.ButtonBackgroundColor = Colors.Black;
            _apw.TitleBar.ButtonHoverBackgroundColor = Colors.Black;
            _apw.TitleBar.ButtonPressedBackgroundColor = Colors.Black;
            _apw.TitleBar.ButtonInactiveBackgroundColor = Colors.Black;
            _apw.TitleBar.ButtonForegroundColor = Colors.White;
            _apw.TitleBar.ButtonHoverForegroundColor = Colors.Gray;
            _apw.TitleBar.ButtonPressedForegroundColor = Colors.DimGray;
            _apw.TitleBar.ButtonInactiveForegroundColor = Colors.DimGray;
            //重设可拖拽区域大小
            RectInt32 rect = new RectInt32( 0, 0, 1050, 32);
            _apw.TitleBar.SetDragRectangles(new RectInt32[] { rect });
            //隐藏标题栏和边框
            //_presenter.SetBorderAndTitleBar(false, false);

            //显示LaunchPage
            MainView.Navigate(typeof(Pages.LaunchPage));
        }

        private AppWindow _apw;
        private OverlappedPresenter _presenter;

        public void GetAppWindowAndPresenter()
        {
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            WindowId myWndId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            _apw = AppWindow.GetFromWindowId(myWndId);
            _presenter = _apw.Presenter as OverlappedPresenter;
        }

        private void TitleBarButton_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TitleBarButton_Setting_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
