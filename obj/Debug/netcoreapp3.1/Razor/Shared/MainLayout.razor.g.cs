#pragma checksum "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f299c24b903b26ede7c6b7efb4b34962b5ed51d"
// <auto-generated/>
#pragma warning disable 1591
namespace AnnuaireWebSite.Shared
{
    #line hidden
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using AnnuaireWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using AnnuaireWebSite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using AnnuaireWebSite.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using AnnuaireWebSite.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using AnnuaireWebSite.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main vh-100 vw-100");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Shared\MainLayout.razor"
       
    protected override async void OnInitialized()
    {
        Api.InitializeClient();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContactController contactController { get; set; }
    }
}
#pragma warning restore 1591
