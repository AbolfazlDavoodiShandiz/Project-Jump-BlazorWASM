#pragma checksum "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Shared\ListGroup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "563ba589bc93dadb97beee1fab1a19b5b52c853f"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class ListGroup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Shared\ListGroup.razor"
 if (Groups is not null && Groups.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "list-group");
#nullable restore
#line 5 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Shared\ListGroup.razor"
         foreach (var item in Groups)
        {
            var name = item.Key;
            var text = item.Value;

            if (name==SelectedItem)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "type", "button");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Shared\ListGroup.razor"
                                                () => ListItemSelected(name)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "list-group-item active");
#nullable restore
#line 12 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Shared\ListGroup.razor"
__builder.AddContent(6, text);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 13 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Shared\ListGroup.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "type", "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Shared\ListGroup.razor"
                                                () => ListItemSelected(name)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "class", "list-group-item");
#nullable restore
#line 16 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Shared\ListGroup.razor"
__builder.AddContent(11, text);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 17 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Shared\ListGroup.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 20 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Shared\ListGroup.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Shared\ListGroup.razor"
      

    [Parameter]
    public Dictionary<string, string> Groups { get; set; }

    [Parameter]
    public string SelectedItem { get; set; }

    [Parameter]
    public EventCallback<string> OnListItemClicked { get; set; }

    private void ListItemSelected(string itemName)
    {
        OnListItemClicked.InvokeAsync(itemName);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
