using CommunityToolkit.Mvvm.Input;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp4.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel
    {
        private readonly TestService testService;

        public MainPageViewModel(TestService testService)
        {
            CountMessage = "Hello!!!!";
            this.testService = testService;
        }

        private int Count = 0;
        public string CountMessage { get; set; } = string.Empty;


        public ICommand YeahCommand => new RelayCommand(() =>
        {
            Count++;
            CountMessage = $"Count:{Count}";
        });
    }
}
