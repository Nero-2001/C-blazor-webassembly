// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
