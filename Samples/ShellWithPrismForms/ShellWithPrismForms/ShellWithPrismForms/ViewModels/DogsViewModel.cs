using Prism.Navigation;
using ShellWithPrismForms.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShellWithPrismForms.ViewModels
{
    public class DogsViewModel : BaseViewModel
    {
        private readonly INavigationService navigationService;

        public DogsViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            CallPage = new Command(OnCallPage);
        }

        public ICommand CallPage { get; private set; }

        public override void OnNavigatedFrom(INavigatingParameters param)
        {
            base.OnNavigatedFrom(param);
        }

        public override void OnNavigatedTo(INavigatedParameters param)
        {
            base.OnNavigatedTo(param);
        }

        private void OnCallPage(object obj)
        {
            navigationService.GoToAsync(nameof(MyDogPage));
        }
    }
}
