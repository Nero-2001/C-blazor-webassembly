// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ServerSideSample.Pages
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/interactive")]
    public partial class InteractiveView : CalendarPageBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "D:\Development\Blazor Test\Calendar\BlazorFullCalendar-CCTruckQ\samples\ServerSideSample\Pages\InteractiveView.razor"
       
    private CalendarSettings _calendarSettings { get; set; }

    private void OnClickHandler(CalendarEventChangeResponse response)
    {
        _jsRuntime.InvokeVoidAsync("alert", $"Click {response.Id} {response.Title}");
    }

    private void SecondCalendarOnClickHandler(CalendarEventChangeResponse response)
    {
        _jsRuntime.InvokeVoidAsync("alert", "22 " + response.ToString());
    }

    private void OnResizeHandler(CalendarEventChangeResponse response)
    {
        var oldEvent = eventList.FirstOrDefault(e => e.Id == response.Id);

        _jsRuntime.InvokeVoidAsync("alert", $"Change {response.Id} {response.Title} - New end date {response.End} - Old end date {oldEvent.End}");

        oldEvent.End = response.End;
    }

    protected override void OnInitialized()
    {
        eventList.AddRange(GetRandomEvents(50));

        _calendarSettings = new CalendarSettings()
        {
            Plugins = new[] { CalendarPluginTypes.DayGrid, CalendarPluginTypes.Interaction, CalendarPluginTypes.Bootstrap },
            InitialView = "dayGridTwoMonths",
            TimeZone = "UTC",
            Editable = true,
            HeaderToolbar  = new CalendarHeader()
            {
                Left = "title",
                Center = "",
                Right = "dayGridOneWeek,dayGridTwoWeeks,dayGridTwoMonths today prev,next"
            },
            ThemeSystem = "bootstrap",
            Views = new Dictionary<string, CalendarViewDefinition>()
            {
                { "dayGridOneWeek", CalendarViewDefinition.DayGridWeeks(1,"One Week") },
                { "dayGridTwoWeeks", CalendarViewDefinition.DayGridWeeks(2,"Two Weeks") },
                { "dayGridTwoMonths", CalendarViewDefinition.DayGridMonths(2,"Two Months") },
            },
            Events = eventList.ToArray()
        };
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
