#pragma checksum "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\GrandChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fafdfce073983049d5c54dd51a8ac77c2f2f8f7a"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using PragimTech.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    public partial class GrandChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "style", 
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\GrandChildComponent.razor"
            ElementStyle

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(2, "-- Grand Child Component Text");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\GrandChildComponent.razor"
       
    [CascadingParameter]
    public string ElementStyle { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
