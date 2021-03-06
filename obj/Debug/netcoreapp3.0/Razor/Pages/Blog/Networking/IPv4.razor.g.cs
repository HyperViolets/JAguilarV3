#pragma checksum "/home/juan/Documents/Programming/JAv3Code/JAguilarV3/Pages/Blog/Networking/IPv4.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16f203298041ea285c9f51bb78bc84f75fe30abf"
// <auto-generated/>
#pragma warning disable 1591
namespace JAguilarV3.Pages.Blog.Networking
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/juan/Documents/Programming/JAv3Code/JAguilarV3/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/juan/Documents/Programming/JAv3Code/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/juan/Documents/Programming/JAv3Code/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/juan/Documents/Programming/JAv3Code/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/juan/Documents/Programming/JAv3Code/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/juan/Documents/Programming/JAv3Code/JAguilarV3/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/juan/Documents/Programming/JAv3Code/JAguilarV3/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/juan/Documents/Programming/JAv3Code/JAguilarV3/_Imports.razor"
using JAguilarV3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/juan/Documents/Programming/JAv3Code/JAguilarV3/_Imports.razor"
using JAguilarV3.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Blog/Networking/IPv4")]
    public partial class IPv4 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<title>IPv4</title>\n\n<br>\n\n");
            __builder.AddMarkupContent(1, "<div class=\"pageFrame\">\n\n    <br>\n\n    <hr>\n    <h2 class=\"articleTitle\">IPv4</h2>\n\n    <p class=\"generalText\"><strong>By Juan Aguilar</strong></p>\n    <p class=\"generalText\"><em>April 20, 2019</em></p>\n    <hr>\n\n    <br>\n\n    <h4 class=\"articleTitle\">IPv4 Intro</h4>\n    <p class=\"generalText\">\n        An IPv4 address is used to identify a device on the network. These days, IPv4 is obsolete and being replaced by IPv6. However, a majority of networks still use IPv4 and the implementation of IPv6 is slow. IPv4 (Internet Protocol version 4) started off as part of the TCP protocol with IPv1 and IPv2. IPv3 was when it moved away from the TCP protocol and became its own entity, but it still required further revisions. After a few revisions, IPv4 came into existence.\n    </p>\n    <p class=\"generalText\">\n        IPv4 is an obsolete way of assigning addresses to devices. It\'s obsolete because we ran out of IPv4 addresses and a better version (IPv6) is being rolled out. IPv4 was never designed to be used in the real world. The creators were using IPv4 for a lab experiment, but it quickly became popular. By 2011, all IPv4 addresses where assigned out to organizations. Then in 2018, all IPv4 addresses were actually being used.\n    </p>\n\n    <h4 class=\"articleTitle\">IP Makeup</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/IPv4/IPMakeup.png\">\n    <p class=\"generalText\">\n        An IPv4 address is a number composed of 32 bits. These 32 bits are separated into four octets (bytes). Each octet has eight bits and are separated by decimals. The binary number is represented in decimal format for human readability. This format is called Dot-Decimal Notation (DDN). Also, since each octet has eight bits, the value of an octet can only be between 0–255 because 2^8 is 256.\n    </p>\n    <p class=\"generalText\">\n        With 32 bits, you can have 2^32 possible IPv4 addresses. That comes to 4,294,967,296 possible IPv4 addresses. Four billion addresses is a small number considering there are seven billion people in the world and many of those people have multiple devices that need IP addresses.\n    </p>\n\n    <h4 class=\"articleTitle\">Classes</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/IPv4/IPClasses.png\">\n    <p class=\"generalText\">\n        In the early days of IPv4, IP addresses were separated into classes. There are five classes in total. The value of the first octet determined which class the IP was in. Class A was used to support environments where there were few networks, but a lot hosts. Class C supported environments with a lot of networks but few hosts. Class D was reserved for multicast. Class E was reserved for experimental and research purposes. These days, Classes aren\'t used anymore because they waste a lot of IP addresses. Classes have been replaced by Classless Inter-Domain Routing (CIDR). CIDR can further separate a range of IP addresses so that most of the IPs are being used.\n    </p>\n\n    <h4 class=\"articleTitle\">Subnetting</h4>\n    <p class=\"generalText\">\n        Subnetting is the process of dividing IPv4 address ranges into groups that are smaller than a single IP network or class (Class A, B, or C). This way, a large amount of IP addresses aren\'t being unused like with Classes. Subnet is actually short for Subdivided Network. Instead of the usual /8, /16, or /24 with Classes, you can choose the subnet mask. If you have a network with only two hosts then you can use a /30 subnet mask and so on. This process of using subnet masks is called Classless Inter-Domain Routing (CIDR). The value of the subnet mask/CIDR can be 0 – 32 because there are only 32-bits in an IP address.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/IPv4/IPBinary.png\">\n    <p class=\"generalText\">\n        To find the total number of usable IP addresses follow this equation: 2^(32-CIDR) -2. For example, 192.168.20.60 /17 will have 32,766 usable hosts (2^(32-17)-2). The reason why we subtract two is because two IP addresses are reserved for other purposes. One IP address is used to identify the Network ID and the other is used for the broadcast IP. The Network ID identifies the subnet of IPs being used. The broadcast IP is used to send everybody in the subnet a message. We use the power of two because IP addresses are binary which has two values. Math works out trust me. The wildcard IP is basically the \"inverted subnet mask\". It\'s used for routing for stuff like OSPF and ACLs. A subnet mask of /17 means that the first 17 bits are being used by the network and you can\'t be fiddle with.\n    </p>\n\n    <h4 class=\"articleTitle\">Public & Private</h4>\n    <p class=\"generalText\">\n        Public IP addresses can be routed through the Internet while private IPs cannot. If a router detects a private IP trying to route through the Internet then it just drops the packet. Since we ran out of IP addresses, there is a limited amount of public IP addresses. These days it\'s typical to give a device a private IP. Private IP addresses can\'t access the Internet, but they can be used several times. Since we ran out of IP addresses, we decided to separate a group of IP addresses that can be used over and over again. This is the private IP range. Private IP address come in three ranges. You can also further divide each range with your own subnet mask if desired. Now we don\'t have to worry about running out of addresses.\n    </p>\n    <p class=\"generalText\">\n        Private IP Addresses\n    </p>\n    <ul>\n        <li class=\"bulletPointGeneralText\">192.168.0.0 - 192.168.255.255 (65,536 IP addresses)</li>\n        <li class=\"bulletPointGeneralText\">172.16.0.0 - 172.31.255.255 (1,048,576 IP addresses)</li>\n        <li class=\"bulletPointGeneralText\">10.0.0.0 - 10.255.255.255 (16,777,216 IP addresses)</li>\n    </ul>\n    <p class=\"generalText\">\n        Then how does my phone connect to the Internet if it has a private IP and private IPs can\'t route through the Internet? Devices connect to the Internet through a router. The router has a public IP address provided by the ISP (Internet Service Provider). The router uses that public IP to route traffic from devices to the Internet. The router keeps track of the Internet traffic for each private IP address with NAT tables. NAT stands for Network Address Translation. NAT is used to convert a private IP to a public IP and keeps track of it. When the Internet traffic comes back, NAT translates the public IP back to a private one.\n    </p>\n    <p class=\"generalText\">\n        This is how IPv4 is still used today even though we ran out of IP addresses. However, NAT has a lot of overhead which slows things down. This overhead is eliminated with IPv6 and IPv6 has more features. IPv6 implementation is slow, but it is the future of networking.\n    </p>\n\n    <h4 class=\"articleTitle\">Common Reserved IP Addresses</h4>\n    <p class=\"generalText\">\n        With IPv4, there are IPs which are reserved for other purposes. One IP range is the link-local address. The addresses reserved are 169.254.0.0 /16 (169.254.0.0 - 169.254.255.255). Link-local addresses are used automatically if there is no DHCP or a static IP. If a device isn\'t assigned an IP then it\'s given a link-local address. Link-local addresses are assigned by the operating system or manually inputted.\n    </p>\n    <p class=\"generalText\">\n        The loopback IP range is 127.0.0.0 /8 (127.0.0.0 - 127.255.255.255). The loopback address is used to identify your own computer. Telling yourself: \"all packets destined for this address goes to me\". It\'s used to access network devices running on the host. For example, if you\'re running a web server on your computer, you can access the website on the same device through a loopback address. Usually the most common loopback IP used is 127.0.0.1 and the most common DNS name is localhost.\n    </p>\n\n    <h4 class=\"articleTitle\">References</h4>\n    <p class=\"citation\">\n        “Classes of IP Addresses.” <i>Classes of IP Addresses</i>, 19 Apr. 2019, study-ccna.com/classes-of-ip-addresses/.\n    </p>\n    <p class=\"citation\">\n        DeLong, Owen. “Why Does IP Have Versions? Why Do I Care?” <i>SocalLinuxExpo</i>, Mar. 2017, www.socallinuxexpo.org/sites/default/files/presentations/Why%20IP%20Versions%20and%20Why%20do%20I%20care.pdf.\n    </p>\n    <p class=\"citation\">\n        “Localhost.” <i>Wikipedia</i>, Wikimedia Foundation, 19 Mar. 2019, en.wikipedia.org/wiki/Localhost.\n    </p>\n    <p class=\"citation\">\n        Nott, George. “Father of the Internet Vint Cerf: IPv4 Was Never the \'Production Version\'.” <i>Computerworld</i>, 2 July 2018, www.computerworld.com.au/article/643174/father-internet-vint-cerf-ipv4-never-production-version/.\n    </p>\n    <p class=\"citation\">\n        Odom, Wendell. <i>CCENT/CCNA ICND1 100-105: Official Cert Guide</i>. Cisco Press, 2016.\n    </p>\n    <p class=\"citation\">\n        “Reserved IP Addresses.” <i>Wikipedia</i>, Wikimedia Foundation, 8 Mar. 2019, en.wikipedia.org/wiki/Reserved_IP_addresses.\n    </p>\n    <p class=\"citation\">\n        Rouse, Margaret. “What Is CIDR (Classless Inter-Domain Routing or Supernetting).” <i>SearchNetworking</i>, Aug. 2015, searchnetworking.techtarget.com/definition/CIDR.\n    </p>\n    <p class=\"citation\">\n        “What Is a Private IP Address?” <i>WhatIsMyIPAddress.com</i>, 19 Apr. 2019, whatismyipaddress.com/private-ip.\n    </p>\n    <p class=\"citation\">\n        “Wildcard Masks.” <i>Wildcard Masks</i>, 19 Apr. 2019, study-ccna.com/wildcard-masks/.\n    </p>\n    <p class=\"citation\">\n        https://www.quora.com/Why-is-an-IP-address-class-needed\n    </p>\n\n    <br>\n</div>\n\n<br>\n<br>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
