using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookVault.App.ViewModels
{
    public partial class MainViewModel:ViewModelBase
    {
        [ObservableProperty]
        private object _current;

        private readonly BookListViewModel _listVM;
        private readonly BookRegisterViewModel _registerVM;

        public MainViewModel(BookListViewModel listVM,BookRegisterViewModel registerVM)
        {
            _listVM = listVM;
            _registerVM = registerVM;
            Current = _registerVM;
        }

        [RelayCommand]
        private void Register()
        {
            Current = _registerVM;
        }
        [RelayCommand]
        private void Catalog()
        {
            Current = _listVM;
        }
    }
}
