#pragma checksum "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4486dbed9cb586e9c7b8db41850b2aa3e6235031"
// <auto-generated/>
#pragma warning disable 1591
namespace ServerSideSample.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\_Imports.razor"
using ServerSideSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\_Imports.razor"
using ServerSideSample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\_Imports.razor"
using BlazorFullCalendar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\_Imports.razor"
using BlazorFullCalendar.Data;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-light");
            __builder.AddMarkupContent(2, "<a class=\"navbar-brand\" href=\"#\">BlazorFullCalendar</a>\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "collapse navbar-collapse");
            __builder.AddAttribute(5, "id", "navbarNavAltMarkup");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "navbar-nav");
            __builder.AddMarkupContent(8, "<a class=\"nav-item nav-link active\" href=\"/\">Home <span class=\"sr-only\">(current)</span></a>\n                ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(9);
            __builder.AddAttribute(10, "class", "nav-link");
            __builder.AddAttribute(11, "href", "/monthviewjson");
            __builder.AddAttribute(12, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 6 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\Shared\NavMenu.razor"
                                                                       NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\n                    Month View (JSON)\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\n                ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(16);
            __builder.AddAttribute(17, "class", "nav-link");
            __builder.AddAttribute(18, "href", "/monthviewarray");
            __builder.AddAttribute(19, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 9 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\Shared\NavMenu.razor"
                                                                        NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(21, "\n                    Month View (Array)\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\n                ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(23);
            __builder.AddAttribute(24, "class", "nav-link");
            __builder.AddAttribute(25, "href", "/events");
            __builder.AddAttribute(26, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 12 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\Shared\NavMenu.razor"
                                                                NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "\n                    Event View (Array)\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\n                ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "/interactive");
            __builder.AddAttribute(33, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 15 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\Shared\NavMenu.razor"
                                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "\n                    Interactive View\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
