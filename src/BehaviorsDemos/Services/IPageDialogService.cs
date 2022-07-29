﻿namespace BehaviorsDemos.Services
{
    public interface IPageDialogService
    {
        Task<bool> DisplayAlert(string title, string message, string acceptButtonText, string cancelButtonText);

        Task DisplayAlert(string title, string message, string cancelButtonText);
    }
}
