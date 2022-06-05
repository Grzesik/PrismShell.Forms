﻿using System;
using System.Threading.Tasks;

namespace Prism.Navigation
{
    public interface INavigatingParameters
    {
        INavigationParameters NavigationParamaters { get; }

        //New for canceling the navigation (used in OnNavigatedFrom)
        ////false - don't cancel;  true - cancel
        Func<Task<bool>> NavigationDialog { get; set; }

        string CurrentUrl { get; set; }
        string TargetUrl { get; set; }
    }
}
