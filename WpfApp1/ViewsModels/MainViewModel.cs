using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Core;

namespace WpfApp1.ViewsModels
{
    internal class MainViewModel : ObservableObjects
    {

        private object _currentView;

        private HomeViewModel _homeViewModel;
        private StudentViewModel _studentViewModel;


        public RelayCommand changeHomeViewCommand 
        {
            get;set;
        }

        public RelayCommand changeStudentViewCommand
        {
            get;set;
        }


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
            changeHomeViewCommand = new RelayCommand(SetHomeView);
            changeStudentViewCommand = new RelayCommand(SetStudentView);
            
        }

        public void SetHomeView(object value) 
        {
            CurrentView = _homeViewModel = new HomeViewModel();
        }
        public void SetStudentView(object value)
        {
            CurrentView = _studentViewModel = new StudentViewModel();
        }



    }
}
