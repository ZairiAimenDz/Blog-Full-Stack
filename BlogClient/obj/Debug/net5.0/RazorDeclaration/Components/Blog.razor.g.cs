// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlogClient.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/zairi/Projects/BlogFullStack/BlogClient/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/zairi/Projects/BlogFullStack/BlogClient/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/zairi/Projects/BlogFullStack/BlogClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/zairi/Projects/BlogFullStack/BlogClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/zairi/Projects/BlogFullStack/BlogClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/zairi/Projects/BlogFullStack/BlogClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/zairi/Projects/BlogFullStack/BlogClient/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/zairi/Projects/BlogFullStack/BlogClient/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/zairi/Projects/BlogFullStack/BlogClient/_Imports.razor"
using BlogClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/zairi/Projects/BlogFullStack/BlogClient/_Imports.razor"
using BlogClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/zairi/Projects/BlogFullStack/BlogClient/_Imports.razor"
using BlogClient.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/zairi/Projects/BlogFullStack/BlogClient/_Imports.razor"
using BlogClient.Models;

#line default
#line hidden
#nullable disable
    public partial class Blog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/home/zairi/Projects/BlogFullStack/BlogClient/Components/Blog.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Title { get; set; }
    [Parameter]
    public string Author { get; set; }
    [Parameter]
    public int Likes { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
