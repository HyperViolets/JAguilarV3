#pragma checksum "/home/juan/Documents/Projects/JAv3Code/JAguilarV3/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87dea88fc64313f53ddc58dec02084ff2f7ec2da"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace JAguilarV3.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/juan/Documents/Projects/JAv3Code/JAguilarV3/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/juan/Documents/Projects/JAv3Code/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/juan/Documents/Projects/JAv3Code/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/juan/Documents/Projects/JAv3Code/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/juan/Documents/Projects/JAv3Code/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/juan/Documents/Projects/JAv3Code/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/juan/Documents/Projects/JAv3Code/JAguilarV3/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/juan/Documents/Projects/JAv3Code/JAguilarV3/_Imports.razor"
using JAguilarV3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/juan/Documents/Projects/JAv3Code/JAguilarV3/_Imports.razor"
using JAguilarV3.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "/home/juan/Documents/Projects/JAv3Code/JAguilarV3/Shared/NavMenu.razor"
       
    bool collapseNavMenu = true;
    bool collapseBlogMenu = false;
    
    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;
    
    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    void ToggleBlogMenu()
    {
        collapseNavMenu = !collapseNavMenu;
        collapseBlogMenu = !collapseBlogMenu;
    }
    private async Task toggleDarkLight()
    {
        await JSRuntime.InvokeVoidAsync("toggleDarkLight");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
