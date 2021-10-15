// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PMS.BlazorWASMClient.Pages.Project
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
#line 6 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Project\Projects.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/projects")]
    public partial class Projects : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Project\Projects.razor"
      
    [CascadingParameter]
    Task<AuthenticationState> AuthenticationState { get; set; }

    private ConfirmAlert ConfirmAlert;
    private Pagination Pagination;

    string Username { get; set; }
    int CurrentPage { get; set; } = 1;
    public int ItemCount { get; set; }
    int PageSize
    {
        get
        {
            return 10;
        }
    }
    string CurrentProjectTableGroup { get; set; } = ProjectAndTaskGroup.All.ToString();
    List<ProjectDTO> PureProjectList = new List<ProjectDTO>();
    private bool ShowModal = false;
    private bool IsCreateProjectMode = true;
    private ProjectDTO SelectedProject;

    Dictionary<string, string> ProjectTableGroups
    {
        get
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            foreach (var item in Enum.GetValues(typeof(ProjectAndTaskGroup)))
            {
                var name = item.ToString();
                var text = ((ProjectAndTaskGroup)(Enum.Parse(typeof(ProjectAndTaskGroup), name))).DisplayName();

                dic.Add(name, text);
            }

            return dic;
        }
    }

    List<ProjectDTO> ProjectList
    {
        get
        {
            List<ProjectDTO> list = FilteredTable();

            return list;
        }
    }
    ProjectRegisterDTO NewProject = new ProjectRegisterDTO();

    protected override async Task OnInitializedAsync()
    {
        var g = ProjectTableGroups;
        var authState = await AuthenticationState;
        Username = authState.User.Identity.GetUsername();

        await GetProjectList();
    }

    private async Task GetProjectList()
    {

        var list = await projectService.GetAll();

        if (list is not null && list.Data.Count() > 0)
        {
            PureProjectList = list.Data.ToList();
        }
        else
        {
            await jsRuntime.ShowToastr("error", "An error occured while getting projects from server.");
        }
    }

    private List<ProjectDTO> FilteredTable()
    {
        List<ProjectDTO> list = new List<ProjectDTO>();

        list = PaginateTable(GroupedTable(PureProjectList));

        return list;
    }

    private List<ProjectDTO> GroupedTable(List<ProjectDTO> pureList)
    {
        List<ProjectDTO> list = new List<ProjectDTO>();

        switch (CurrentProjectTableGroup)
        {
            case nameof(ProjectAndTaskGroup.All):
                list = pureList;
                break;
            case nameof(ProjectAndTaskGroup.InProgress):
                list = pureList.Where(p => !p.Finished).ToList();
                break;
            case nameof(ProjectAndTaskGroup.Finished):
                list = pureList.Where(p => p.Finished).ToList();
                break;
        }

        ItemCount = list.Count;

        return list;
    }

    private List<ProjectDTO> PaginateTable(List<ProjectDTO> pureList)
    {
        List<ProjectDTO> list = new List<ProjectDTO>();

        list = pureList.Skip(PageSize * (CurrentPage - 1)).Take(PageSize).ToList();

        return list;
    }

    private void OnProjectTableGroupChanged(string group)
    {
        CurrentProjectTableGroup = group;
        CurrentPage = 1;
    }

    private void OnPageChanged(int page)
    {
        CurrentPage = page;
    }

    private void ShowNewProjectModal(bool show, ProjectDTO project = null)
    {
        if (project is not null)
        {
            NewProject.Title = project.Title;
            NewProject.Description = project.Description;
            NewProject.DeadlineDate = project.DeadlineDate;
            SelectedProject = project;
            IsCreateProjectMode = false;
        }

        ShowModal = show;
    }

    private async Task CreateNewProject()
    {
        if (IsCreateProjectMode)
        {
            var result = await projectService.CreateProject(NewProject);

            string messageType = result.IsSuccess ? "success" : "error";

            await jsRuntime.ShowToastr(messageType, result.Message);

            if (result.IsSuccess)
            {
                ShowModal = false;

                NewProject.Title = string.Empty;
                NewProject.Description = string.Empty;
                NewProject.DeadlineDate = DateTime.Now;

                await GetProjectList();

                CurrentPage = Pagination.LastPageNumber;
            }
        }
        else
        {
            var updatedProject = new ProjectUpdateDTO
            {
                ProjectId = SelectedProject.Id,
                Description = NewProject.Description,
                DeadlineDate = NewProject.DeadlineDate

            };

            var result = await projectService.UpdateProject(updatedProject);

            string messageType = result.IsSuccess ? "success" : "error";

            await jsRuntime.ShowToastr(messageType, result.Message);

            if (result.IsSuccess)
            {
                ShowModal = false;

                NewProject.Title = string.Empty;
                NewProject.Description = string.Empty;
                NewProject.DeadlineDate = DateTime.Now;

                var updatedItem = ProjectList.Where(p => p.Id == updatedProject.ProjectId).Single();
                updatedItem.Description = updatedProject.Description;
                updatedItem.DeadlineDate = updatedProject.DeadlineDate.Value;
            }
        }
    }

    private void ShowDeleteModal(ProjectDTO project)
    {
        SelectedProject = project;
        ConfirmAlert.Show();
    }

    private async Task DeleteProject()
    {
        var result = await projectService.DeleteProject(SelectedProject.Id);

        ConfirmAlert.Hide();

        string messageType = result.IsSuccess ? "success" : "error";

        await jsRuntime.ShowToastr(messageType, result.Message);

        if (result.IsSuccess)
        {
            await GetProjectList();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectService projectService { get; set; }
    }
}
#pragma warning restore 1591
