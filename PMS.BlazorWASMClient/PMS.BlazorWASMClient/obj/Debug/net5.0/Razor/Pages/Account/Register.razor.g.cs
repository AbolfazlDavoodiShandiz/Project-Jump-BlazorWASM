#pragma checksum "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9448a153fdfd91f956c5cc0c2479fd1dae4925d0"
// <auto-generated/>
#pragma warning disable 1591
namespace PMS.BlazorWASMClient.Pages.Account
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/account/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row justify-content-center");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "text-center");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor"
                             UserRegistrationDTO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor"
                                                                 UserRegister

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "OnInvalidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor"
                                                                                                InvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n                <i class=\"fa fa-user-plus fa-4x\" aria-hidden=\"true\"></i>\r\n                ");
                __builder2.AddMarkupContent(13, "<h1 class=\"h3 mb-3 fw-normal\">Register New User</h1>\r\n\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-floating mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "type", "email");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "id", "floatingEmail");
                __builder2.AddAttribute(20, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor"
                                            UserRegistrationDTO.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserRegistrationDTO.Email = __value, UserRegistrationDTO.Email))));
                __builder2.AddAttribute(22, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserRegistrationDTO.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.AddMarkupContent(24, "<label for=\"floatingEmail\">Email</label>\r\n                    ");
                __Blazor.PMS.BlazorWASMClient.Pages.Account.Register.TypeInference.CreateValidationMessage_0(__builder2, 25, 26, 
#nullable restore
#line 18 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor"
                                            (()=>UserRegistrationDTO.Email)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-floating mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "type", "text");
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "id", "floatingUsername");
                __builder2.AddAttribute(34, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor"
                                            UserRegistrationDTO.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserRegistrationDTO.Username = __value, UserRegistrationDTO.Username))));
                __builder2.AddAttribute(36, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserRegistrationDTO.Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                    ");
                __builder2.AddMarkupContent(38, "<label for=\"floatingUsername\">Username</label>\r\n                    ");
                __Blazor.PMS.BlazorWASMClient.Pages.Account.Register.TypeInference.CreateValidationMessage_1(__builder2, 39, 40, 
#nullable restore
#line 23 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor"
                                            (()=>UserRegistrationDTO.Username)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-floating mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "type", "text");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "id", "floatingMobile");
                __builder2.AddAttribute(48, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor"
                                            UserRegistrationDTO.Mobile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserRegistrationDTO.Mobile = __value, UserRegistrationDTO.Mobile))));
                __builder2.AddAttribute(50, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserRegistrationDTO.Mobile));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                    ");
                __builder2.AddMarkupContent(52, "<label for=\"floatingMobile\">Mobile</label>\r\n                    ");
                __Blazor.PMS.BlazorWASMClient.Pages.Account.Register.TypeInference.CreateValidationMessage_2(__builder2, 53, 54, 
#nullable restore
#line 28 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor"
                                            (()=>UserRegistrationDTO.Mobile)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-floating mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "type", "password");
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "id", "floatingPassword");
                __builder2.AddAttribute(62, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor"
                                            UserRegistrationDTO.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserRegistrationDTO.Password = __value, UserRegistrationDTO.Password))));
                __builder2.AddAttribute(64, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserRegistrationDTO.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n                    ");
                __builder2.AddMarkupContent(66, "<label for=\"floatingPassword\">Password</label>\r\n                    ");
                __Blazor.PMS.BlazorWASMClient.Pages.Account.Register.TypeInference.CreateValidationMessage_3(__builder2, 67, 68, 
#nullable restore
#line 33 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor"
                                            (()=>UserRegistrationDTO.Password)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-floating mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(72);
                __builder2.AddAttribute(73, "type", "password");
                __builder2.AddAttribute(74, "class", "form-control");
                __builder2.AddAttribute(75, "id", "floatingConfirmPassword");
                __builder2.AddAttribute(76, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor"
                                            UserRegistrationDTO.PasswordConfirm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserRegistrationDTO.PasswordConfirm = __value, UserRegistrationDTO.PasswordConfirm))));
                __builder2.AddAttribute(78, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserRegistrationDTO.PasswordConfirm));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n                    ");
                __builder2.AddMarkupContent(80, "<label for=\"floatingConfirmPassword\">Password Confirm</label>\r\n                    ");
                __Blazor.PMS.BlazorWASMClient.Pages.Account.Register.TypeInference.CreateValidationMessage_4(__builder2, 81, 82, 
#nullable restore
#line 38 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor"
                                            (()=>UserRegistrationDTO.PasswordConfirm)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                ");
                __builder2.AddMarkupContent(84, "<button class=\"w-100 btn btn-lg btn-primary mb-2\" type=\"submit\">Register</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\Programming\Projects\GitHubRepositories\Project-Jump-BlazorWASM\PMS.BlazorWASMClient\PMS.BlazorWASMClient\Pages\Account\Register.razor"
       
    UserRegistrationDTO UserRegistrationDTO = new UserRegistrationDTO();

    private async Task UserRegister()
    {
        var response = await accountService.Register(UserRegistrationDTO);

        string messageType = response.IsSuccess ? "success" : "error";

        await jsRuntime.ShowToastr(messageType, response.Message);

        if (response.IsSuccess)
        {
            navigationManager.NavigateTo("/dashboard");
        }
    }

    private async Task InvalidSubmit()
    {
        await jsRuntime.ShowToastr("error", "Check your inputes.");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService accountService { get; set; }
    }
}
namespace __Blazor.PMS.BlazorWASMClient.Pages.Account.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
