#pragma checksum "c:\Labs\BlazorStaticWebApps\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dbdfe56f7cab43fc1102063bef2c0b4bb2d8a31"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace StaticWebApps.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Labs\BlazorStaticWebApps\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Labs\BlazorStaticWebApps\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Labs\BlazorStaticWebApps\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Labs\BlazorStaticWebApps\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Labs\BlazorStaticWebApps\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Labs\BlazorStaticWebApps\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Labs\BlazorStaticWebApps\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Labs\BlazorStaticWebApps\Client\_Imports.razor"
using StaticWebApps.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Labs\BlazorStaticWebApps\Client\_Imports.razor"
using StaticWebApps.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Labs\BlazorStaticWebApps\Client\Pages\Index.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "c:\Labs\BlazorStaticWebApps\Client\Pages\Index.razor"
       
    private string Message { get; set; }
    protected override async Task OnInitializedAsync()
    {
        var res = await Http.GetAsync($"{Configuration.GetValue<string>("API")}/GetMessage?name=BlazorWASM");
        Message = res.IsSuccessStatusCode ?
            await res.Content.ReadAsStringAsync() :
            "Failed";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration Configuration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
