#pragma checksum "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a6111d84a1c709cf7bff8b3da6b5d6df6b35665"
// <auto-generated/>
#pragma warning disable 1591
namespace AnnuaireWebSite.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
                      contact

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
                                               HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "id", "first");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
                                           contact.First

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.First = __value, contact.First))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.First));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "id", "last");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
                                          contact.Last

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.Last = __value, contact.Last))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.Last));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "city");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
                                          contact.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.City = __value, contact.City))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.City));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "id", "street");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
                                            contact.Street

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.Street = __value, contact.Street))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.Street));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __Blazor.AnnuaireWebSite.Pages.Index.TypeInference.CreateInputNumber_0(__builder2, 35, 36, "zip", 37, 
#nullable restore
#line 12 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
                                           contact.Zip

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.Zip = __value, contact.Zip)), 39, () => contact.Zip);
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.AddMarkupContent(41, "<button type=\"submit\">Submit</button>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 15 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
     if( contactController.contacts != null)
    {
        foreach(Contact contact in contactController.contacts) 
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "            ");
            __builder.OpenElement(44, "div");
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "table");
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.AddMarkupContent(48, @"<tr>
                        <td>
                            Prénom
                        </td>
                        <td>
                            Nom
                        </td>
                        <td>
                            Ville
                        </td>
                        <td>
                            Rue
                        </td>
                        <td>
                            Code Postale
                        </td>
                    </tr>
                    ");
            __builder.OpenElement(49, "tr");
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "td");
            __builder.AddMarkupContent(52, "\r\n                            ");
            __builder.AddContent(53, 
#nullable restore
#line 40 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
                             contact.First

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.OpenElement(56, "td");
            __builder.AddMarkupContent(57, "\r\n                            ");
            __builder.AddContent(58, 
#nullable restore
#line 43 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
                             contact.Last

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.OpenElement(61, "td");
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.AddContent(63, 
#nullable restore
#line 46 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
                             contact.City

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "td");
            __builder.AddMarkupContent(67, "\r\n                            ");
            __builder.AddContent(68, 
#nullable restore
#line 49 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
                             contact.Street

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.OpenElement(71, "td");
            __builder.AddMarkupContent(72, "\r\n                            ");
            __builder.AddContent(73, 
#nullable restore
#line 52 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
                             contact.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 57 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
        }
            
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\a.dupont\source\repos\AnnuaireWebSite\AnnuaireWebSite\Pages\Index.razor"
       
    private Contact contact = new Contact();
    private async Task HandleValidSubmit()
    {
      await contactController.GetContactsByParameters(contact.First, contact.Last, contact.City, contact.Street, contact.Zip);
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContactController contactController { get; set; }
    }
}
namespace __Blazor.AnnuaireWebSite.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
