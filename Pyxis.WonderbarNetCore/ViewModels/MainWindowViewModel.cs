using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using WPFAndUWPDemo.MyWPFApp.Views;

namespace WPFAndUWPDemo.MyWPFApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public readonly IRegionManager _regionManager;
        public DelegateCommand LoadedCommand { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            LoadedCommand = new DelegateCommand(Loaded);
        }

        private void Loaded()
        {
        }

        /// <summary>
        /// MainWindow窗体加载完成之后再加载widget，防止webview加载布局错误
        /// </summary>
        public void PassiveLoading()
        {
            _regionManager.RegisterViewWithRegion("WonderBarRightRegion", typeof(ViewHost));
        }
    }
}
