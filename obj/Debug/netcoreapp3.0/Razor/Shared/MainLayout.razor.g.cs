#pragma checksum "/home/juan/Documents/Developing/JAguilarV3/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2cd56f84175045182327cc315cb10fad1bbcf7c"
// <auto-generated/>
#pragma warning disable 1591
namespace JAguilarV3.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/juan/Documents/Developing/JAguilarV3/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/juan/Documents/Developing/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/juan/Documents/Developing/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/juan/Documents/Developing/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/juan/Documents/Developing/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/juan/Documents/Developing/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/juan/Documents/Developing/JAguilarV3/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/juan/Documents/Developing/JAguilarV3/_Imports.razor"
using JAguilarV3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/juan/Documents/Developing/JAguilarV3/_Imports.razor"
using JAguilarV3.Shared;

#line default
#line hidden
#nullable disable
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<JAguilarV3.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "content px-4");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddContent(12, 
#nullable restore
#line 9 "/home/juan/Documents/Developing/JAguilarV3/Shared/MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n    ");
            __builder.AddMarkupContent(15, "<div class=\"bottom-row\">\r\n        <footer class=\"myFooter\">&copy; 2019 JUAN AGUILAR ALL RIGHTS RESERVED</footer>\r\n    </div>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
