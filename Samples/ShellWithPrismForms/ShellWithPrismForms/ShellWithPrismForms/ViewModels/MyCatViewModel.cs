using Prism.Navigation;
using Prism.PageDialog;
using Prism.SystemEvents;
using ShellWithPrismForms.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShellWithPrismForms.ViewModels
{
    public class MyCatViewModel : BaseViewModel
    {
        private readonly INavigationService navigtionService;
        private readonly IPageDialogService pageDialogService;
        private readonly IEventAggregator eventAggregator;

        public MyCatViewModel(INavigationService navigtionService, IPageDialogService pageDialogService, IEventAggregator eventAggregator)
        {
            this.navigtionService = navigtionService;
            this.pageDialogService = pageDialogService;
            this.eventAggregator = eventAggregator;
            
            DialogCommand = new Command(OnDialogCommand);
            EventCommand = new Command(OnEventCommand);
        }

        public ICommand DialogCommand { get; private set; }
        public ICommand EventCommand { get; private set; }


        public override void OnNavigatedFrom(INavigatingParameters param)
        {
            base.OnNavigatedFrom(param);

            //Call dialog, before navigate back
            if (param.TargetUrl.Contains(".."))
            {
                param.OnCancel = CancelDialog;
            }
        }

        public override void OnNavigatedTo(INavigatedParameters param)
        {
            base.OnNavigatedTo(param);
        }

        private async void OnDialogCommand(object obj)
        {
            await pageDialogService.DisplayAlertAsync("My dialog", "This is a prism like dialog", "OK");
        }

        private void OnEventCommand(object obj)
        {
            eventAggregator.GetEvent<NotifyEvent>().Publish(new NotifyEventData { SelectedId = 1, Title = "Selected item 1" });
        }

        /// <summary>
        /// This dialog is called, when you try to navigate back
        /// </summary>
        /// <returns></returns>
        private async Task<bool> CancelDialog()
        {
            var ret = await pageDialogService.DisplayAlertAsync("Navigation Dialog", "Do you want to cancel the navigation?", "Yes", "No");
            return ret;
        }

    }
}
