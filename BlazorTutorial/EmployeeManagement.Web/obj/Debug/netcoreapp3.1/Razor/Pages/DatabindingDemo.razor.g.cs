#pragma checksum "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81c2b2c1b505bae9c75a7d692eba7c02d5826c50"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/databindingdemo")]
    public partial class DatabindingDemo : DatabindingDemoBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>One Way Data Binding</h3>\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(1, "<b>Description</b>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "textarea");
            __builder.AddAttribute(5, "style", "width: 500px;");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                     Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Description = __value, Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddMarkupContent(11, "\r\n    Count : ");
            __builder.AddContent(12, 
#nullable restore
#line 16 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
             Description.Length

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n\r\n<hr>\r\n\r\n\r\n");
            __builder.AddMarkupContent(15, "<h1>Databinding Demo</h1>\r\n<hr>\r\n");
            __builder.AddMarkupContent(16, "<h3>One Way Data Binding</h3>\r\n\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.AddMarkupContent(19, "<b>Name : </b> ");
            __builder.AddContent(20, 
#nullable restore
#line 28 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                    Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.AddMarkupContent(25, "<b>Name with solutation: </b> ");
            __builder.AddContent(26, 
#nullable restore
#line 32 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                    Gender == "Male" ? $"Mr. {Name}" : $"Mis. {Name}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n");
            __builder.OpenElement(29, "div");
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.AddMarkupContent(31, "<b>Name : </b> ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "value", 
#nullable restore
#line 36 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                  Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n\r\n<hr>\r\n");
            __builder.AddMarkupContent(36, "<h3>Two Way Data Binding</h3>\r\n\r\n");
            __builder.OpenElement(37, "div");
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.AddMarkupContent(39, "<b>Name : </b> ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "value", 
#nullable restore
#line 44 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                  Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                                     e => { Name = e.Value.ToString(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n");
            __builder.OpenElement(45, "div");
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.AddMarkupContent(47, "<b>Name : </b> ");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                 Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n");
            __builder.OpenElement(53, "div");
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.AddMarkupContent(55, "<b>Name : </b> ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                 Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n");
            __builder.OpenElement(61, "div");
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.AddMarkupContent(63, "<b>Colour :</b> ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                  Colour

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Colour = __value, Colour));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "style", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "C:\Users\ASUS\source\repos\BlazorTutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                  Colour

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Colour = __value, Colour));
            __builder.SetUpdatesAttributeName("style");
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.AddMarkupContent(73, "<h3>The background color of this text changes</h3>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
