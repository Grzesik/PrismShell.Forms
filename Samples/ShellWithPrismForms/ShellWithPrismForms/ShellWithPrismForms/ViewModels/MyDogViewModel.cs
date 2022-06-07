using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShellWithPrismForms.ViewModels
{
    internal class MyDogViewModel : BaseViewModel
    {
        private readonly INavigationService navigationService;

        public MyDogViewModel(INavigationService navigtionService)
        {
            this.navigationService = navigtionService;
            CloseCommand = new Command(OnCloseCommand);
        }

        public ICommand CloseCommand { get; private set; }

        public override void OnNavigatedTo(INavigatedParameters param)
        {
            base.OnNavigatedTo(param);
        }

        private void OnCloseCommand(object obj)
        {
            navigationService.GoToAsync("..");
        }
    }
}
