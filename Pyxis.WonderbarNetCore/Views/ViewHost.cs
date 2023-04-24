using Microsoft.Toolkit.Wpf.UI.XamlHost;
using WPFAndUWPDemo.ClassLibrary;

namespace WPFAndUWPDemo.MyWPFApp.Views
{
    public partial class ViewHost : WindowsXamlHost
    {
        public ViewHost()
        {
            InitialTypeName = typeof(MyUserControl1).FullName;
        }
    }
}
