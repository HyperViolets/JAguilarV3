#pragma checksum "/home/juan/Documents/Developing/JAguilarV3/Pages/Blog/Hardware/EthernetPatchPanel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5362b5816af3a297059a599c53172cc9d058a321"
// <auto-generated/>
#pragma warning disable 1591
namespace JAguilarV3.Pages.Blog.Hardware
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Blog/Hardware/EthernetPatchPanel")]
    public class EthernetPatchPanel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<title>Ethernet Patch Panel</title>\n\n<br>\n\n");
            __builder.AddMarkupContent(1, "<div class=\"pageFrame\">\n\n    <br>\n\n    <hr>\n    <h2 class=\"articleTitle\">Ethernet Patch Panel</h2>\n\n    <p class=\"generalText\"><strong>By Juan Aguilar</strong></p>\n    <p class=\"generalText\"><em>July 5, 2019</em></p>\n    <hr>\n\n    <br>\n\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/EthernetPatchPanel/patchpanel.png\">\n    <p class=\"generalText\">\n        A patch panel is used to manage network cables in a building. They are an array of Ethernet ports on a panel. All Ethernet cables in a building are connected to the patch panel in a server room. The other end of the Ethernet cable is terminated on a wall plate with a keystone.\n    </p>\n    <p class=\"generalText\">\n        In homes or small organizations, a patch panel isn’t necessarily required. You can just run the Ethernet cables directly into a switch. The switch can then be connected to an ISP or other network device. \n    </p>\n    <p class=\"generalText\">\n        Once you have to manage multiple Ethernet cables, a patch panel becomes very useful. All your cables run into a central place ready to be managed. Without a patch panel all your unused cables will be dangling there or using up space on a switch. It’s also easier to reconfigure networks. \n    </p>\n    <p class=\"generalText\">\n        Patch panels work best when they’re labeled correctly. Each Ethernet port on a patch panel will be numbered. Take a labeler, like P-Touch, to label wall plates to its corresponding port on the patch panel. Then you document this in a diagram/documentation. This avoids situations where you don’t know what is plugged into what and you have to manually test each port to see where everything is. \n    </p>\n    <p class=\"generalText\">\n        It’s recommended to place your patch panels and switches near the top of a server rack. This way heavier equipment is reserved for the bottom portion of the rack. You don’t want the rack to become top heavy and risk tipping over. \n    </p>\n\n    <h4 class=\"articleTitle\">Types of Patch Panels</h4>\n    <p class=\"generalText\">\n        There are different types of patch panels out there. Most notably there are Punch Down, Feed-Through, and Keystone patch panels. With Punch Down patch panels, you take the individual wires on an Ethernet cable and punch them down to the patch panel. You can use the T568A or T568B wire schemes when punching down. A Feed-Through patch panel will have Ethernet ports on both sides of the patch panel. You simply plug the end of an Ethernet cables into the Ethernet slot (assuming it has an Ethernet male connector). There is no need to punch down anything. Lastly, there is a Keystone patch panel. Instead of punching down to the patch panel, you punch down to a keystone or slot into a keystone. The advantage is you’re not restricted to only using Ethernet keystones. You can have coaxial, HDMI, and Ethernet keystones in the same patch panel. You choose the type of keystones used on the patch panel.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/EthernetPatchPanel/keystone.jpg\">\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/EthernetPatchPanel/feedthrough.png\">\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/EthernetPatchPanel/PunchDown.png\">\n    <p class=\"generalText\">\n        Another option is getting the number of ports you need. In general, the most common number of ports is 24 or 48. You can get higher counts of ports like a 96 port patch panel. It all depends on how many Ethernet cables you have in the building.\n    </p>\n    <p class=\"generalText\">\n        Each patch panel is designed for a specific Ethernet standard like CAT5e or CAT6. If you’re using CAT6 then get CAT6 patch panels. CAT standards are also backward compatible. You can use a CAT5e cable on a CAT6 patch panel. Also, check if you’re using shielded or unshielded Ethernet cables and get shielded or unshielded patch panels.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/EthernetPatchPanel/angledPatchPanel.png\">\n    <p class=\"generalText\">\n        Additionally, you can choose to have a flat or angled patch panel. Flat is the most common. Angled patch panels have a bit better port density, but there is no clear reason to choose angled over flat. It all depends on preference.\n    </p>\n\n    <h4 class=\"articleTitle\">Tools</h4>\n    <p class=\"generalText\">\n        To punch down wires you will need a punch down tool. You can get a very basic punch down tool that gets the job done. Get a tool that is rated for 110 blocks since 110 is for twisted pair (Ethernet). The tool will have an adjustable impact setting. Set this to low since many patch panels are rated for low impact. There are also battery powered punch down tools. They work the same except that they are battery powered.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/EthernetPatchPanel/punchDownTool.png\">\n    <p class=\"generalText\">\n        To remove wires from a keystone or patch panel you can use a spudger or needle-nose pliers. Lift the wires straight up from the grooves. You can also get a network cable tester to check if you punch downed the wires correctly. Check online for tutorials on how to punch down. \n    </p>\n\n    <h4 class=\"articleTitle\">References</h4>\n    <p class=\"citation\">\n        Budget Nerd. “What Is a Patch Panel? Do You Need One?” <em>YouTube</em>, 28 Apr. 2017, youtu.be/lg2oGE02DJE.\n    </p>\n    <p class=\"citation\">\n        FS. “How to Terminate and Install Cat5e, Cat6 Keystone Jacks?” <em>FS</em>, 6 Oct. 2013, www.fs.com/how-to-terminate-and-install-cat5e-cat6-keystone-jacks-aid-214.html.\n    </p>\n    <p class=\"citation\">\n        FS. “How to Select Copper Patch Panel? Know Patch Panel Sizes/Types.” <em>FS Blog</em>, 26 Oct. 2016, community.fs.com/blog/how-to-select-the-suitable-copper-patch-panel.html.\n    </p>\n    <p class=\"citation\">\n        FS. “Should We Choose Punch Down or Feedthrough Patch Panel?” <em>FS Blog</em>, 1 Mar. 2017, community.fs.com/blog/should-we-choose-punch-down-or-feed-through-patch-panel.html.\n    </p>\n    <p class=\"citation\">\n        “Punch down Tool.” <em>Wikipedia</em>, Wikimedia Foundation, 1 Feb. 2019, en.m.wikipedia.org/wiki/Punch_down_tool.\n    </p>\n    <p class=\"citation\">\n        slimjimany. “How to Use Punch down Tool with Cat 5 Punch Panels.” <em>YouTube</em>, 17 June 2012, youtu.be/T40Z1W6kmmw.\n    </p>\n    <p class=\"citation\">\n        SteveFL. “Patch Panel Placement Preferences.” <em>The Spiceworks Community</em>, 31 Mar. 2014, community.spiceworks.com/topic/466690-patch-panel-placement-preferences.\n    </p>\n    <p class=\"citation\">\n        Wang, Chloe. “Network Patch Panel Wiki: What\'s It? Why Use It? How to Buy It?” <em>Fiber Transceiver Solution</em>, 11 Sept. 2018, www.fiber-optic-transceiver-module.com/network-patch-panel-wiki-why-use-it-how-to-buy-it.html.\n    </p>\n    <p class=\"citation\">\n        “What Is a Patch Panel and What Is Its Purpose?” <em>FireFold</em>, 5 July 2019, www.firefold.com/blogs/news/what-is-a-patch-panel-and-what-is-its-purpose.\n    </p>\n\n    <br>\n</div>\n\n<br>\n<br>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591