#pragma checksum "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\ChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9ef08c2b8291b55f34ecb97358411015a2a4b16"
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
    public partial class ChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "style", (
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\ChildComponent.razor"
            ElementStyle

#line default
#line hidden
#nullable disable
            ) + ";" + " " + (
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\ChildComponent.razor"
                           H1Border

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "- Child Component Text");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<EmployeeManagement.Web.Pages.GrandChildComponent>(4);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\ChildComponent.razor"
       

    [CascadingParameter(Name = "ColorStyle")]
    public string ElementStyle { get; set; }
    
    [CascadingParameter(Name = "BorderStyle")]
    public string H1Border { get; set; }


    //[Parameter(CaptureUnmatchedValues = true)]
    //public Dictionary<string, object> InputAttributes { get; set; } = new Dictionary<string, object>();

    //[Parameter]
    //public string Value { get; set; } = "Child Value";

    //{
    //    { "required", "required" },
    //    { "placeholder", "Child Component Placeholder" },
    //    { "size", "100" },
    //    { "maxlength", "15" }
    //};



    //[Parameter]
    //public string Required { get; set; } = "required";

    //[Parameter]
    //public string Placeholder { get; set; } = "Child Component Placeholder";

    //[Parameter]
    //public string MaxLength { get; set; } = "15";

    //[Parameter]
    //public string Size { get; set; } = "25";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
