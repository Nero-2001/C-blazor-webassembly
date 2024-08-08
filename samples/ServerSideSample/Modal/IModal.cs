﻿using Microsoft.AspNetCore.Components;
using System;

namespace BlazorBootstrap.Modal.Services
{
    public interface IModal
    {
        event Action<string, RenderFragment> OnShow;

        event Action OnClose;

        void Show<T>(string title, params ModalParameter[] parameters)
            where T : ComponentBase;

        void Close();
    }
}
