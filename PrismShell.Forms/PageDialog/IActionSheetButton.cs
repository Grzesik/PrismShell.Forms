﻿using System;
using System.Windows.Input;

namespace Prism.PageDialog
{
    /// <summary>
    /// Convenient contract to enable executing commands directly when using <see cref="IPageDialogService.DisplayActionSheetAsync(string, IActionSheetButton[])"/>
    /// </summary>
    public interface IActionSheetButton
    {
        /// <summary>
        /// The button will be used as destroy
        /// </summary>
        bool IsDestroy { get; }

        /// <summary>
        /// The button will be used as cancel
        /// </summary>
        bool IsCancel { get; }

        /// <summary>
        /// Text to display in the action sheet
        /// </summary>
        string Text { get; }

        /// <summary>
        /// Presses the button.
        /// </summary>
        void PressButton();
    }
}
