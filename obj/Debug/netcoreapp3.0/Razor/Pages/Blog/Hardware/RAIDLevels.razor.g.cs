#pragma checksum "/home/juan/Documents/Developing/JAguilarV3/Pages/Blog/Hardware/RAIDLevels.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "596b89c021a73a6319708aee4a2f3701bf4fb98c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Blog/Hardware/RAIDLevels")]
    public class RAIDLevels : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<title>RAID Levels</title>\n\n<br>\n<br>\n\n");
            __builder.AddMarkupContent(1, "<div class=\"pageFrame\">\n\n    <br>\n\n    <hr>\n    <h2 class=\"articleTitle\">RAID Levels</h2>\n\n    <p class=\"generalText\"><strong>By Juan Aguilar</strong></p>\n    <p class=\"generalText\"><em>August 16, 2019</em></p>\n    <hr>\n\n    <br>\n\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/RAIDLevels/RAIDController.png\">\n    <p class=\"generalText\">\n        RAID stands for Redundant Array of Independent Disks or Redundant Array of Inexpensive Disks. As the name suggests, RAID provides redundancy for an array/set of disks. Also, performance can be increased such as read performance. Redundancy can be achieved through different techniques such as mirroring and parity. Preventing data loss is important in an enterprise level. Even if one disk is lost, the data is still intact with RAID. It’s also important to note that RAID is NOT a replacement for backups!\n    </p>\n    <p class=\"generalText\">\n        RAID can be applied to both hard drives and SSDs. Disks can be connected through SCSI, IDE, SATA, or Fiber Channel for a RAID configuration. Configuration is done through a RAID Controller. The RAID Controller can be hardware or software. Hardware provides better performance overall. Hardware controllers are highly recommended for RAID 5, 6, 50, and 60 since they need to calculate parity and rebuild data. Also, if you have a large number of disks in a RAID cluster, it’s recommend to get a hardware controller.\n    </p>\n\n    <h4 class=\"articleTitle\">RAID Levels</h4>\n    <img class=\"bookImage\" src=\"/images/Blog/Hardware/RAIDLevels/RAIDLevels.png\">\n    <br>\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/RAIDLevels/RAID0.png\">\n     <br>\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/RAIDLevels/RAID1.png\">\n     <br>\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/RAIDLevels/RAID5.png\">\n     <br>\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/RAIDLevels/RAID6.png\">\n     <br>\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/RAIDLevels/RAID10.png\">\n     <br>\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/RAIDLevels/RAID01.png\">\n     <br>\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/RAIDLevels/RAID50.png\">\n     <br>\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/RAIDLevels/RAID60.png\">\n    <br>\n\n    <h4 class=\"articleTitle\">Not Widely Implemented RAID Levels</h4>\n    <p class=\"generalText\">\n        RAID 2 is bit-level striping with a dedicated disk for ECC storage. ECC is error correcting code and it’s similar to parity. ECC provides “on the fly” data error correction. This RAID level didn’t catch on because modern hard drives and SSDs already have ECC built into them.        \n    </p>\n    <p class=\"generalText\">\n        RAID 3 is byte-level striping with a dedicated parity disk. Instead of parity being spread across all disks, it’s stored on one disk.\n    </p>\n    <p class=\"generalText\">\n        RAID 4 is block-level striping with a dedicated parity disk.\n    </p>\n    <p class=\"generalText\">\n        RAID 03 or RAID 53 is byte-level striping with a dedicated parity disk.\n    </p>\n    <p class=\"generalText\">\n        RAID 100 is striping data across RAID 10 arrays.\n    </p>\n\n    <br>\n    <h4 class=\"articleTitle\">References</h4>\n    <p class=\"citation\">\n        Lynn, Samara. “RAID Levels Explained.” <em>PCMAG</em>, 27 Mar. 2014, www.pcmag.com/article/255278/raid-levels-explained.\n    </p>\n    <p class=\"citation\">\n        Natarajan, Ramesh. “RAID 2, RAID 3, RAID 4, RAID 6 Explained with Diagram.” <em>The Geek Stuff</em>, 21 Nov. 2011, www.thegeekstuff.com/2011/11/raid2-raid3-raid4-raid6/.\n    </p>\n    <p class=\"citation\">\n        “RAID Calculator.” <em>Free RAID Calculator - Caclulate RAID Array Capacity and Fault Tolerance.</em>, 16 Aug. 2019, www.raid-calculator.com/default.aspx.\n    </p>\n    <p class=\"citation\">\n        “Raid Level Tutorial to Understand Raid Technology.” <em>ACNC</em>, 16 Aug. 2019, www.acnc.com/raid.php.\n    </p>\n    <p class=\"citation\">\n        “RAID.” <em>Prepressure</em>, 17 Jan. 2017, www.prepressure.com/library/technology/raid.\n    </p>\n    <p class=\"citation\">\n        “Standard RAID Levels.” <em>Wikipedia</em>, Wikimedia Foundation, 25 July 2019, en.wikipedia.org/wiki/Standard_RAID_levels.\n    </p>\n\n    <br>\n</div>\n\n<br>\n<br>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
