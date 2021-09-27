using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.Extensions
{
    public static class JsRuntimeExtension
    {
        public static ValueTask ShowToastr(this IJSRuntime jSRuntime, string type, string message)
        {
            if (type == "success")
            {
                return jSRuntime.InvokeVoidAsync("ShowToastr", "success", message);
            }
            else if (type == "error")
            {
                return jSRuntime.InvokeVoidAsync("ShowToastr", "error", message);
            }
            else if (type == "info")
            {
                return jSRuntime.InvokeVoidAsync("ShowToastr", "info", message);
            }
            else
            {
                return jSRuntime.InvokeVoidAsync("ShowToastr", "warning", message);
            }
        }
    }
}
