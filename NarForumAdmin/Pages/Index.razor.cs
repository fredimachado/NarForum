﻿using NarForumAdmin.Contracts;
using NarForumAdmin.Providers;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using NarForumAdmin.Models.Section;
using NarForumAdmin.Services.UI;

namespace NarForumAdmin.Pages;

public partial class Index
{
    [Inject]
    private AuthenticationStateProvider AuthenticationStateProvider { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [Inject]
    public IAuthenticationService AuthenticationService { get; set; }

    [Inject]
    public ISectionService SectionsService { get; set; }

    [Inject]
    public RefreshStateService RefreshStateService { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await ((ApiAuthenticationStateProvider)AuthenticationStateProvider).GetAuthenticationStateAsync();
    }

    protected void GoToLogin()
    {
        NavigationManager.NavigateTo("login/");
    }

    protected async Task AddSection(SectionVM section)
    {
        await SectionsService.CreateSection(section);
        if(RefreshStateService.RefreshSectionList != null)
        {
            RefreshStateService.RefreshSectionList.Invoke();
        }
    }


    protected void GoToRegister()
    {
        NavigationManager.NavigateTo("register/");
    }

    protected async void Logout()
    {
        await AuthenticationService.Logout();
    }
}