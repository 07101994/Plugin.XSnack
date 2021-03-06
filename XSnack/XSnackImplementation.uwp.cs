﻿using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Plugin.XSnack
{
    /// <summary>
    /// UWP implementation for Plugin.XSnack
    /// </summary>
    public class XSnackImplementation : IXSnack
    {
        /// <summary>
        /// Displays a message and an optional action button within a snackbar
        /// </summary>
        /// <param name="message">The message you want to be displayed</param>
        /// <param name="duration">Duration of the snackbar in seconds (Default 3 seconds)</param>
        /// <param name="actionText">Text for the action button (optional)</param>
        /// <param name="actionCommand">Callback command for the action button (optional)</param>
        /// <returns></returns>
        public Task ShowMessageAsync(string message, int duration = 3, string actionText = null, ICommand actionCommand = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Displays a message and an optional action button within a snackbar
        /// </summary>
        /// <param name="message">The message you want to be displayed</param>
        /// <param name="duration">Duration of the snackbar in seconds (Default 5 seconds)</param>
        /// <param name="actionText">Text for the action button (optional)</param>
        /// <param name="actionCommand">Callback command for the action button (optional)</param>
        /// <returns></returns>
        public void ShowMessage(string message, int duration = 3, string actionText = null, ICommand actionCommand = null)
        {
            throw new NotImplementedException();
        }
    }
}
