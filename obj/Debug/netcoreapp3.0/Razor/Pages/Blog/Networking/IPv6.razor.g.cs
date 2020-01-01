#pragma checksum "/home/juan/Documents/Developing/JAguilarV3/Pages/Blog/Networking/IPv6.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69434bc6f68cce2b3170b2511cf8ecb292e07cc7"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Blog/Networking/IPv6")]
    public class IPv6 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<title>IPv6</title>\n\n<br>\n\n");
            __builder.AddMarkupContent(1, "<div class=\"pageFrame\">\n\n    <br>\n\n    <hr>\n    <h2 class=\"articleTitle\">IPv6</h2>\n\n    <p class=\"generalText\"><strong>By Juan Aguilar</strong></p>\n    <p class=\"generalText\"><em>April 29, 2019</em></p>\n    <hr>\n\n    <br>\n\n    <h4 class=\"articleTitle\">IPv6 Intro</h4>\n    <p class=\"generalText\">\n        IPv6 was created to replace IPv4. IPv4 is an outdated way of assigning hosts an address. There are only 4.3 billion IP addresses available with IPv4. That won\'t do because the amount of devices expected to connect to the Internet is going to be 26 billion by 2020. Even though IPv6 was released years ago, it\'s implementation has been slow. That\'s because there was no clear advantage to use IPv6 at first and we extended the lifespan of IPv4 with NAT and CIDR. All IPv4 addresses have basically been assigned in 2018. Now, it\'s difficult and expensive to get IPv4 addresses. It\'s also costly and complex to manage IPv4 on a large scale. IPv6 is a 128-bit address which supports a lot more devices than IPv4 which is 32-bit. IPv6 has 2^128 addresses which is 340,282,366,920,938,463,463,374,607,431,768,211,456 addresses. Basically that\'s 340 trillion trillion trillion addresses.\n    </p>\n    <p class=\"generalText\">\n        IPv6 was created by the Internet Engineering Task Force (IETF). IPv6 wasn\'t the first iteration to replace IPv4. There was IPv5 which was an Internet Stream Protocol, but it never caught on. Then there was a competition between IPv6, IPv7, IPv8, and IPv9 to replace IPv4. IPv7 was TP/IX: The Next Internet. IPv8 was PIP (P Internet Protocol). IPv9 was TUBA (TCP & UDP with Big Addresses). In the end, IPv6 won. For now, IPv4 and IPv6 coexist, but IPv6 is the future of assigning hosts an address.\n    </p>\n\n    <h4 class=\"articleTitle\">How to Get Your Own Public IPv6 Address</h4>\n    <p class=\"generalText\">\n        There are two options to get a public IPv6 address that is routable on the Internet. One way is to get an IPv6 address from your ISP (Internet Support Provider). You can configure your router or modem to use IPv6. That\'s implying that your ISP supports IPv6. If you\'re an organization/enterprise you can purchase an IPv6 address block from a RIR (Regional Internet Registry). For North American, you would want to go to ARIN. There are also private IPv6 addresses which will be discussed later.\n    </p>\n\n    <h4 class=\"articleTitle\">IPv6 Makeup</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/IPv6/ipv6Makeup.png\">\n    <p class=\"generalText\">\n        An IPv6 address is made up of 128 bits. Those 128 bits are then converted to 32 hexadecimal digits. Hexadecimal has a base of 16. Each hexadecimal digit is composed of 4 binary bits. For hexadecimal, you have the values of 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E and F. Those 32 digits are then separated into eight sets of four hex digits separated by a colon \":\".\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/IPv6/ipv6Abbreviation.png\">\n    <p class=\"generalText\">\n        Even when converted to hexadecimal format, the IPv6 address is still long. There are two rules for abbreviating an IPv6 address. The first rule is Discarding Leading Zeros. You can remove the leading zeros (left side) from each quartet. A quartet is a group of four hex digits. For example, 0033 will become 33. Even if you have a group of four zeros then the result will be a single zero. The second rule is Zero Compression. When two or more quartets full of zeros are next to each other, they can be replaced by a double colon (::). This double colon can only be used once since the device can\'t compute how many sets of zeros are missing. For example, \":0000:0000:0000:\" will just become \"::\". Computers and routers typically use the shortest abbreviation.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/IPv6/ipv6makeupv2.png\">\n    <p class=\"generalText\">\n        An IPv6 address is composed of a Prefix, Subnet ID, Interface ID, and Prefix Length. IPv6 has no classes unlike IPv4, but some IPv6 addresses are still reserved for other purposes. The Prefix represents the unique network assigned to you. The Subnet ID is used to create subnets for different networks in your environment. The Interface ID is for assigning hosts an IPv6 address. The Prefix Length is equivalent to an IPv4 subnet mask. For simplicity, the prefix is 48 bits, the subnet ID is 16 bits and interface ID is 64 bits.\n    </p>\n\n    <h4 class=\"articleTitle\">Global Unicast Address</h4>\n    <p class=\"generalText\">\n        A global unicast address is a type of IPv6 address that is routable through the Internet. It\'s the equivalent to an IPv4 public address. To get this type of address you need a global routing prefix assigned by an RIR (Regional Internet Registry). You could also use one offered by your ISP. The global routing prefix is your usual prefix you would use for an IPv6 address. Each global unicast address is unique. Also with the global routing prefix you have your usual Subnet ID and Interface ID.\n    </p>\n\n    <h4 class=\"articleTitle\">Unique Local Address</h4>\n    <p class=\"generalText\">\n        A Unique Local Address is similar to a private IPv4 address. IPv6 has reserved a block address to be used as private addresses. This block is FC00::/7. The block is broken up into two parts. The first part is FC00::/8 which is yet to be defined and isn\'t used. The other part is FD00::/8 which is used for private addresses. A Unique Local Address cannot be routed through the Internet and can only be used on the local network. They always start with FD and you don\'t have to register an address because they can be used by anyone.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/IPv6/ipv6UniqueLocalAddress.png\">\n    <p class=\"generalText\">\n        To create a Unique Local Address, the address must start with FD to identity that it is a Unique Local Address. The FD part consists of eight bits. The next 40 bits is generated by you. Technically you put anything you want, but it\'s best to choose something that is statistically unlikely to be chosen. The reasoning is because there is a chance for duplicates and when merging networks those duplicates can make things complex. After that, the next 16 bits is the Subnet ID. The last 64 bits is the Interface ID.\n    </p>\n\n    <h4 class=\"articleTitle\">Link-Local Addresses</h4>\n    <p class=\"generalText\">\n        Every single IPv6 enabled interface is required to have a link-local address. A link-local address isn\'t used for sending data instead, they are use for protocols like NDP and automatic address configuration. Link-local addresses only communicate with devices on the same link/directly connected to each other. Since link-local addresses aren\'t unique, they can\'t be routed through the Internet.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/IPv6/ipv6LinkLocal.png\">\n    <p class=\"generalText\">\n        The FE80:: /10 block is assigned to link-local addresses. Typically they start with FE80:0000:0000:0000 for the first 64 bits. The next 64 bits are auto generated or manually inputted. To automatically generate the last 64 bits, Cisco uses EUI-64. Microsoft uses a random process that changes over time to prevent attacks.\n    </p>\n\n    <h4 class=\"articleTitle\">DHCP for IPv6</h4>\n    <p class=\"generalText\">\n        Devices on the network will need an IPv6 address. It\'s best to automatically configure end devices with an address. IPv6 has two ways of automatically assigning IPv6 addresses and that\'s stateful DHCPv6 and stateless DHCPv6. Along with an IP address, the device needs a default router and DNS settings. DHCPv6 isn\'t actually version 6 of DHCP. The \"v6\" is added to indicate that it\'s used for IPv6.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/IPv6/ipv6DHCPv6.png\">\n    <p class=\"generalText\">\n        Stateless DHCPv6 is the preferred way of assigning IPv6 addresses. It uses Stateless Address Autoconfiguration (SLAAC). SLAAC contacts the router to learn the prefix, interface ID, prefix length, and default router using the NDP protocol. It then creates the Interface ID using a random process or EUI-64. The interface ID is then checked with Duplicate Address Detection (DAD) to make sure it\'s a unique address. Once that\'s all done, all that\'s left for the device is to learn DNS addresses. There is a central DHCPv6 server containing the DNS addresses. The end device contacts the server for the DNS addresses. The device now has it\'s fully configured IPv6 address, DNS servers and is now ready for networking. This way is preferred because devices automatically configure themselves. The DHCPv6 server doesn\'t have to keep track of addresses which means less work for administrators. The DHCPv6 server only has to give out the DNS addresses.\n    </p>\n    <p class=\"generalText\">\n        Stateful DHCPv6 works like a traditional DHCP server for IPv4. End devices get the prefix, prefix length, default rouer, and DNS settings all from the DHCPv6 server. Routers can be configured to be a DHCPv6 Relay Agent to help assign out IPv6 addresses to devices.\n    </p>\n\n    <h4 class=\"articleTitle\">Things to Note - IPv6</h4>\n    <p class=\"generalText\">\n        Several protocols were updated to support IPv6. Protocols like OSPF version 3 and ICMP version 6.\n    </p>\n    <p class=\"generalText\">\n        The IPv6 header was simplified to improve functionality.\n    </p>\n    <p class=\"generalText\">\n        IPv6 multicast addresses use the FF00:: /8 block.\n    </p>\n    <p class=\"generalText\">\n        The \"::\" address is used when the IPv6 address is not known yet or when the host thinks the IPv6 address has issues.\n    </p>\n    <p class=\"generalText\">\n        The loopback address for IPv6 is \"::1 /128\"\n    </p>\n    <p class=\"generalText\">\n        Ping and Traceroute commands change when dealing with an IPv6 address. For Linux and Mac OS you would use \"ping6\" and \"traceroute6\". For Windows, you will use \"ping -6\" and \"tracert -6\".\n    </p>\n    <p class=\"generalText\">\n        Neighbor Discovery Protocol (NDP) is used by IPv6 to learn its neighbors which works like ARP for IPv4. Stuff like MAC addresses of hosts in the same subnet are learned.\n    </p>\n    <p class=\"generalText\">\n        Duplicate Address Detection (DAD) is used in SLAAC to make sure the host has a unique address.\n    </p>\n    <p class=\"generalText\">\n        Just like IPv4, important devices such as router and switch are assigned a static IPv6 address. Less important devices such as end devices are automatically given an IPv6 address through stateful or stateless DHCPv6.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/IPv6/ipv6eui64.png\">\n    <p class=\"generalText\">\n        EUI-64 is a way to automatically configure the 64 bit interface ID for an IPv6 address. EUI-64 takes the MAC of the interface and splits it in half. Serial interfaces don\'t have a MAC address so they use the MAC address of a nearby device. EUI-64 then takes the split in half MAC address and inserts \"FFFE\" in the middle. This result is a 64 bit hexadecimal digit. Finally, EUI-64 inverts the seventh bit. The end result is a mostly unique IPv6 addresses because MAC addresses are unique. Then DAD is used to make sure the IPv6 address is unique in the subnet.\n    </p>\n\n    <h4 class=\"articleTitle\">References</h4>\n    <p class=\"citation\">\n        DeLong, Owen. “Why Does IP Have Versions? Why Do I Care?” <i>Socallinuxexpo.org</i>, Mar. 2017, www.socallinuxexpo.org/sites/default/files/presentations/Why%20IP%20Versions%20and%20Why%20do%20I%20care.pdf.\n    </p>\n    <p class=\"citation\">\n        “Frequently Asked Questions (FAQ) on IPv6 Adoption and IPv4 Exhaustion.” <i>Internet Society</i>, www.internetsociety.org/deploy360/ipv6/faq/.\n    </p>\n    <p class=\"citation\">\n        “IPv6 Address Types & Formats.” <i>www.tutorialspoint.com</i>, 28 Apr. 2019, www.tutorialspoint.com/ipv6/ipv6_address_types.htm.\n    </p>\n    <p class=\"citation\">\n        “IPv6 Basics, News, Guides & Tutorials.” <i>Internet Society</i>, www.internetsociety.org/deploy360/ipv6/.\n    </p>\n    <p class=\"citation\">\n        “Link-Local Address.” <i>Wikipedia</i>, Wikimedia Foundation, 4 Apr. 2019, en.wikipedia.org/wiki/Link-local_address.\n    </p>\n    <p class=\"citation\">\n        Maggio, Alessandro. “DHCPv6 Configuration: SLAAC, Stateless and Stateful.” <i>ICTShore.com</i>, 25AD, www.ictshore.com/free-ccna-course/dhcpv6-basics/.\n    </p>\n    <p class=\"citation\">\n        Odom, Wendell. <i>CCENT/CCNA ICND1 100-105 Official Cert Guide</i>. Cisco Press, 2016.\n    </p>\n    <p class=\"citation\">\n        “Understanding IPv6 Link Local Address.” <i>Cisco</i>, 29 Nov. 2011, www.cisco.com/c/en/us/support/docs/ip/ip-version-6-ipv6/113328-ipv6-lla.html.\n    </p>\n    <p class=\"citation\">\n        “Unique Local Address.” <i>Wikipedia</i>, Wikimedia Foundation, 18 Feb. 2019, en.wikipedia.org/wiki/Unique_local_address.\n    </p>\n    <p class=\"citation\">\n        “What Is a IPv6?” <i>WhatIsMyIPAddress.com</i>, 28 Apr. 2019, whatismyipaddress.com/ip-v6.\n    </p>\n\n    <br>\n</div>\n\n<br>\n<br>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591