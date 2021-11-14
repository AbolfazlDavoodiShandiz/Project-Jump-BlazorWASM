// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PMS.BlazorWASMClient.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using PMS.BlazorWASMClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using PMS.BlazorWASMClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using PMS.BlazorWASMClient.Utility.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using PMS.BlazorWASMClient.Utility.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using PMS.BlazorWASMClient.Utility.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using PMS.BlazorWASMClient.Utility.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using PMS.BlazorWASMClient.Utility.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    public partial class PushNotification : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Shared\PushNotification.razor"
       

    public List<ClientNotification> Notifications { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await GetNotifications();
        }
    }

    private async Task GetNotifications()
    {
        var notificationResponse = await notificationService.GetAll();

        //await jsRuntime.ShowToastr("info", "Here");
        await jsRuntime.ShowPopover();

        if (notificationResponse.Count() > 0)
        {
            Notifications = notificationResponse.ToList();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService notificationService { get; set; }
    }
}
#pragma warning restore 1591
