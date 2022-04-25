using sideMenuBarTrial.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sideMenuBarTrial.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand TruckViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public TruckViewModel TruckVM { get; set; }

        
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value; 
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            TruckVM = new TruckViewModel();
            CurrentView = HomeVM;
            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });
            TruckViewCommand = new RelayCommand(o =>
            {
                CurrentView = TruckVM;
            });
        }
    }
}
