using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System;
using Microsoft.UI.Xaml.Controls;
namespace WPFAndUWPDemo.ClassLibrary
{
    public sealed partial class MyUserControl1 : UserControl
    {
        public MyUserControl1()
        {
            this.InitializeComponent();
        }

        private async void InitWebview2()
        {
            WebView2 webView2 = new WebView2();
            webView2.Width = 1800;
            webView2.Height = 1200;
            Canvas.SetTop(webView2, 0);
            this.Canvas.Children.Add(webView2);
            await webView2.EnsureCoreWebView2Async();
            webView2.CoreWebView2?.Navigate("https://www.msn.cn/zh-cn/feed?ocid=entnewsntp");
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            InitWebview2();
        }
    }
}
