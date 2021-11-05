// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PMS.BlazorWASMClient.Pages.Task
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
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Task\Tasks.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tasks")]
    public partial class Tasks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Task\Tasks.razor"
      
    [CascadingParameter]
    Task<AuthenticationState> AuthenticationState { get; set; }
    string Username { get; set; }
    int UserId { get; set; }

    Pagination Pagination;
    int ItemCount { get; set; }
    int PageSize { get; set; } = 15;
    int CurrentPage { get; set; }

    List<ProjectTaskDTO> PureTaskList = new List<ProjectTaskDTO>();
    List<ProjectTaskDTO> TaskList
    {
        get
        {
            return FilteredTable()
                .OrderByDescending(t => t.CreatedDate)
                .ToList();
        }
    }

    bool AssignedUsersModalVisible = false;
    int SelectedTaskId { get; set; }
    List<string> AssignedUsers = new List<string>();

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationState;
        if (authState.User.Identity.IsAuthenticated)
        {
            Username = authState.User.Identity.GetUsername();
            UserId = authState.User.Identity.GetUserId();

            await GetTasks();
        }
    }

    private async Task GetTasks()
    {
        var tasks = await projectTaskService.GetUserTasks();

        if (tasks.IsSuccess)
        {
            PureTaskList = tasks.Data.ToList();
            ItemCount = PureTaskList.Count;
            CurrentPage = 1;
        }
    }

    private List<ProjectTaskDTO> FilteredTable()
    {
        List<ProjectTaskDTO> list = new List<ProjectTaskDTO>();

        list = PaginateTable(GroupedTable(PureTaskList));

        return list;
    }

    private List<ProjectTaskDTO> GroupedTable(List<ProjectTaskDTO> pureList)
    {
        List<ProjectTaskDTO> list = new List<ProjectTaskDTO>();

        list = pureList;

        ItemCount = list.Count;

        return list;
    }

    private List<ProjectTaskDTO> PaginateTable(List<ProjectTaskDTO> pureList)
    {
        List<ProjectTaskDTO> list = new List<ProjectTaskDTO>();

        list = pureList.Skip(PageSize * (CurrentPage - 1)).Take(PageSize).ToList();

        return list;
    }

    private void OnPageChanged(int page)
    {
        CurrentPage = page;
    }

    private async Task MarkAsDone(ProjectTaskDTO projectTaskDTO)
    {
        var result = await projectTaskService.MarkAsDone(projectTaskDTO.Id);

        string messageType = result.IsSuccess ? "success" : "error";

        await jsRuntime.ShowToastr(messageType, result.Message);

        if (result.IsSuccess)
        {
            var item = PureTaskList.Where(t => t.Id == projectTaskDTO.Id).Single();

            item.Done = true;
            item.CompleteDate = DateTime.Now;
        }
    }

    private async Task ShowAssignedUsersModal(bool show, int? taskId = null)
    {
        if (show)
        {
            if (taskId is not null)
            {
                SelectedTaskId = taskId.Value;

                var response = await projectTaskService.GetTaskAssignedUsers(SelectedTaskId);

                if (response.IsSuccess)
                {
                    AssignedUsers = response.Data.ToList();
                }
            }
        }
        else
        {
            SelectedTaskId = 0;
        }

        AssignedUsersModalVisible = show;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectTaskService projectTaskService { get; set; }
    }
}
#pragma warning restore 1591
