#pragma checksum "/home/juan/Documents/Projects/JAv3Code/JAguilarV3/Pages/Blog/Networking/WiFiOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d64474f70ba3c1200b605980d6c5bdbdbc0f5ef2"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Blog/Networking/WiFiOverview")]
    public partial class WiFiOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<title>Wi-Fi Overview</title>\n\n<br>\n\n");
            __builder.AddMarkupContent(1, "<div class=\"pageFrame\">\n\n    <br>\n\n    <hr>\n    <h2 class=\"articleTitle\">Wi-Fi Overview</h2>\n\n    <p class=\"generalText\"><strong>By Juan Aguilar</strong></p>\n    <p class=\"generalText\"><em>July 17, 2019</em></p>\n    <hr>\n\n    <br>\n\n    <p class=\"generalText\">\n        Radio technology used for a Wireless Local Area Network (WLAN) is called Wi-Fi. They’re under the 802.11 family of standards set by the IEEE. The term “Wi-Fi” was coined by the Wi-Fi Alliance who wanted a catchy name for wireless networks. The Wi-Fi alliance is a non-profit organization that mainly certifies Wi-Fi products. \n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/WiFiOverview/WiFiVersions.png\">\n    <p class=\"generalText\">\n        As of 2018, the Wi-Fi Alliance has renamed the Wi-Fi versions. They will be renamed to Wi-Fi 6, Wi-Fi 5, and Wi-Fi 4. These will replace the old names such as 802.11ac, 802.11n, and 802.11g.\n    </p>\n    <p class=\"generalText\">\n        Wi-Fi versions 802.11b and 802.11a were developed during the same time. 802.11a had faster speeds, but less range. 802.11b had more range, but lacked the speed of 802.11a. 802.11g is the best of both worlds where it has the speed of 802.11a and range of 802.11b. 802.11n greatly increased the speed using MIMO. It also had more range due to the increase signal intensity. 802.11ac currently has the fastest speeds, but lacks the range of 802.11n. Most wireless networks are dual band supporting both 802.11n and 802.11ac. Since 802.11b, 802.11g, and 802.11n use the 2.4 GHz radio band, they are backward compatible with each other. The same is said with 802.11a, 802.11n, and 802.11ac in the 5 GHz radio band. \n    </p>\n\n     <h4 class=\"articleTitle\">Wi-Fi Channels</h4>\n    <p class=\"generalText\">\n        Within the 2.4 and 5 GHz band, there are multiple channels/frequencies. Channels also have a width to them. They are usually 20 MHz wide. This width determines how much bandwidth can be pushed through a channel. You can combine 20 MHz channels to have a wider width. The 2.4 GHz band has 20 MHz and 40 MHz widths. Even though a bigger width has more bandwidth, it can cause more interference since it’s overlapping with other channels. Also, both ends of the devices have to support the additional width sizes. The 5 GHz band has 20, 40, 80, and 160 MHz widths.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/WiFiOverview/2point4Frequency.png\">\n    <p class=\"generalText\">\n        The 2.4 GHz band has a total of 14 channels. In the United States, only 11 channels are used. Channels in the United States are separated by 5 MHz from each other. The 2.4 GHz spectrum is only 100 MHz. Due to the lack of room, many channels overlap with each other. The interference of overlapping channels trying to “talk” over each other is the worst type of interference. Due to this issue, most people choose the 1, 6 or 11 as their channel. These channels don’t overlap with each other. Other interference includes multiple devices on the same channel and outside sources like microwaves. \n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/WiFiOverview/5GHz.png\">\n    <p class=\"generalText\">\n        The 5 GHz band is broken down into four major sections by the FCC. There is the U-NII-1, U-NII-2A, U-NII-2 Extended, and U-NII-3 bands. Equipment in the U-NII-2A and U-NII-2 Extended bands are required to have DFS in the United States. DFS is Dynamic Frequency Selection. It’s used to give priority to critical systems like military, radar, or weather signals. Other countries may also require TPC which is Transmit Power Control. It auto adjusts the power to not interfere with critical systems. \n    </p>\n    <p class=\"generalText\">\n        The 5 GHz band has a lot more room for channels. This means that every 20 MHz wide channel doesn’t overlap with each other. You can combine channels to give you 40 MHz, 80 MHz, and even 160 MHz wide channels for more bandwidth. As usual, a wider width will overlap more channels. \n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/WiFiOverview/5GHz Channel Width.png\">\n\n    <h4 class=\"articleTitle\">Routers</h4>\n    <p class=\"generalText\">\n        A router is composed of three parts. The first part is a router. The router is used to send data out to the Internet through the WAN port. The second part is a switch. The switch is used to connect wired devices together in a network. The last part is a Wireless Access Point (WAP). The WAP is used to connect wireless devices to the network. \n    </p>\n    <p class=\"generalText\">\n        Most routers come in Dual Band or Tri-Band. Dual Band routers have a 2.4 GHz and 5 GHz band. You can have selected or simultaneous dual band. With selected dual band, you can only use the 2.4 or 5 GHz one at a time. A simultaneous dual band lets you use both the 2.4 and 5 GHz band at the same time. Enable both bands so you can support 2.4 and 5 GHz devices. 2.4 GHz has a higher range, but slower speeds compared to 5GHz. 5GHz has higher speed, but lacks the range of 2.4 GHz. Typically low bandwidth and older devices that don’t support 5 GHz go in the 2.4 GHz band. High bandwidth devices go in the 5 GHz band. That’s implying that you have a high enough Internet speed to fully take advantage of the 5 GHz band. \n    </p>\n    <p class=\"generalText\">\n        A Tri-Band router has two 5 GHz bands and a single 2.4 GHz band. Having two 5 GHz bands means that you support more 5 GHz devices. \n    </p>\n\n    <h4 class=\"articleTitle\">MIMO and Antennas</h4>\n    <p class=\"generalText\">\n        When the 802.11n standard was released it also defined MIMO streams. Multiple Input Multiple Output is about using multiple receiving and transmitting antennas. Having a MIMO of 4x4 means that there are physically four receiving and four transmitting antennas on the device. All these antennas are used to send multiple streams of data. These streams increase bandwidth, reliability, and more device support. The main drawback is that both ends have to support the number of MIMO antennas. MIMO uses more power and the complexity of implementing it means that it’s going to cost more. \n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Networking/WiFiOverview/dipole_pattern.jpg\">\n    <p class=\"generalText\">\n        Most antennas on home routers are dipole. Dipole antennas are a type of omnidirectional antennas that transmit their signal in all directions. Dipole antennas transmit 360 degrees horizontally and 75 degrees vertically. This creates a doughnut shape around the antenna. Also, having the antenna upright causes the doughnut to lay flat.\n    </p>\n    <p class=\"generalText\">\n        Another antenna type is directional. Directional antennas transmit it’s signal in one direction. Since it’s transmitting in one direction, the range can be greatly extended.\n    </p>\n    <p class=\"generalText\">\n        The strength of an antenna is measured in decibels relative to milliwatt (dBm). This is usually between -30 and -100. You’ll notice that these values are in negative which means -30 is higher value than -100. dBm doesn’t scale linearly. Instead, it scales logarithmically. A signal of -30 is excellent, -67 is good, -70 is okay, -80 is not good, -90 is unusable.\n    </p>\n\n    <h4 class=\"articleTitle\">Beamforming</h4>\n    <p class=\"generalText\">\n        Beamforming was present in the 802.11n specification, but it wasn’t standardized. Due to the lack of standardization, beamforming wasn’t widely implemented. With 802.11ac, beamforming was actually standardized and implementation was more common.\n    </p>\n    <p class=\"generalText\">\n        Instead of sending Wi-Fi signals in all directions, beamforming concentrates the signal to your device. This narrow signal increases the distance and reliability of Wi-Fi signals. It’s more reliable because it can pass through interference, like walls, easier due to a stronger signal.\n    </p>\n    <p class=\"generalText\">\n        There are two types of beamforming. There is implicit beamforming and explicit beamforming. Implicit beamforming is where support for beamforming is not required for end devices. This option improves the signal for older devices that don’t support beamforming. The improvement won’t be drastic, but an improvement nonetheless. Explicit beamforming is where both ends support beamforming. Enable both options so you can enable beamforming for devices that can support or don’t support it. \n    </p>\n\n    <h4 class=\"articleTitle\">Security</h4>\n    <p class=\"generalText\">\n        Wireless signals were originally encrypted with Wired Equivalent Privacy (WEP). Eventually, this encryption was easily compromised. WEP used Rivest Cipher 4 (RC4) to encrypt and authenticate data. RC4 was easy on the processor which was needed in low computation routers. Originally, the encryption key was composed of a master key and a 24-bit initialization vector (IV). An IV is meant to prevent duplicate encryption keys from showing up in the network by changing the IV key with every packet. The problem was that a 24-bit IV wasn’t enough.  With 24 bits, there was only 16 million possible IVs. With a network with high traffic, reaching this number was very common. It didn’t help that the IV was sent in plain text and about 9000 IVs are “weak” that lead to revealing more info. Over time, the IV key was extended to 104-bits, but it was still very vulnerable to hacking.\n    </p>\n    <p class=\"generalText\">\n        Due to the lack of security with WEP, Wi-Fi Protected Access (WPA) was quickly developed until a more permanent solution was found. WPA still used RC4, but improvements were made. The biggest improvement was using Temporal Key Integrity Protocol (TKIP). TKIP used IVs, a master key, MAC address, and a sequence counter to create the encryption key. This greatly improved the encryption and removed the use of “weak IVs”. WPA also introduced Enterprise Mode. With Enterprise Mode, users access the wireless network with credentials instead of a passphrase. Credentials such as a username and password. Those credentials would then be authenticated against an authentication server such as RADIUS server or a 802.1x server. The authentication server would then be secured through some implementation of EAP. Extensible Authentication Protocol (EAP) is an authentication framework. Another mode is Personal Mode. Users access the network by only inputting the Wi-Fi password. Personal Mode uses the same master key for users while enterprise mode uses different master keys for each user. Other improvements have been made such as an improved checksum and defeating replay attacks. \n    </p>\n    <p class=\"generalText\">\n        Wi-Fi Protected Access 2 (WPA2) was the permanent replacement for WEP. WPA2 uses CCMP for authentication and encryption which is based on the AES algorithm. Using WPA2 with CCMP is more secure than using RC4 with TKIP or WPA2 with TKIP. Unlike RC4, CCMP uses more processing power which meant older routers couldn’t support CCMP. WPA2 also used Personal Mode and Enterprise Mode. CCMP makes use of a pairwise master key (PMK), a pairwise transient key (PTK), and a group temporal key (GTK) to secure wireless connections. CCMP is sometime referred to as AES in some routers which is the source of some confusion.\n    </p>\n    <p class=\"generalText\">\n        The latest iteration of wireless security is WPA3. It was finalized in 2018 and it promises four major improvements. First, open Wi-Fi networks will now be encrypted for each person even if the Wi-Fi network doesn’t initially include a passphrase. This is to solve insecure open networks in public places like McDonald\'s and Starbucks. Second, there will be protection against brute force attacks even if the user has set a weak password. Methods like dictionary attacks will no longer work. Third, wireless enabled devices without displays can now be easily and securely connected to the wireless network. Devices such as an Amazon Echo would previously need to use an external app or use the WPS button on a router which is unsecure. Lastly, WPA3 will have a 192-bit security suite for enterprise networks. This will further improve security using several methods such as a larger encryption key. WPA3 is still quite a ways from being fully implemented since both ends must support it.\n    </p>\n\n    <h4 class=\"articleTitle\">Firmware Alternatives</h4>\n    <p class=\"generalText\">\n        Routers have firmware from their manufactures. This firmware is usually basic for the ease of most people. However, some people want more functionality out of their routers. DD-WRT is open source firmware based on Linux for routers and other devices. It provides more functionality than a typical router. Due to a large number of routers out there, not all routers support DD-WRT. To check compatibility, input your device details in the website to see if it can support DD-WRT. Another popular alternative is Tomato. Tomato also uses Linux and there are different versions/mods out there. \n    </p>\n    \n    <h4 class=\"articleTitle\">References</h4>\n    <p class=\"citation\">\n        “About.” <em>DD-WRT</em>, 17 July 2019, dd-wrt.com/.\n    </p>\n    <p class=\"citation\">\n        Gibson, Darril. <em>CompTIA Security+ Get Certified Get Ahead SYO-401 Study Guide</em>. YCDA, LLC, 2014.\n    </p>\n    <p class=\"citation\">\n        Hoffman, Chris. “What Are Dual-Band and Tri-Band Routers?” <em>How-To Geek</em>, How-To Geek, 15 Feb. 2019, www.howtogeek.com/220509/htg-explains-what-is-a-tri-band-router-and-will-it-make-your-wi-fi-faster/.\n    </p>\n    <p class=\"citation\">\n        Hoffman, Chris. “What Is WPA3, and When Will I Get It On My Wi-Fi?” <em>How-To Geek</em>, How-To Geek, 21 Oct. 2018, www.howtogeek.com/339765/what-is-wpa3-and-when-will-i-get-it-on-my-wi-fi/.\n    </p>\n    <p class=\"citation\">\n        Hoffman, Chris. “What Is ‘Beamforming’ on a Wireless Router?” <em>How-To Geek</em>, How-To Geek, 3 Oct. 2018, www.howtogeek.com/220774/htg-explains-what-is-beamforming-on-a-wireless-router/.\n    </p>\n    <p class=\"citation\">\n        Hutcheson, Fiona. “Antennas: The More the Merrier?” <em>D-Link</em>, 29 Dec. 2016, blog.dlink.com/antennas-the-more-the-merrier/.\n    </p>\n    <p class=\"citation\">\n        “IEEE 802.11.” <em>Wikipedia</em>, Wikimedia Foundation, 15 July 2019, en.wikipedia.org/wiki/IEEE_802.11#History.\n    </p>\n    <p class=\"citation\">\n        Jacobs, David B. “Wireless Security -- How WEP Encryption Works.” <em>SearchNetworking</em>, Feb. 2008, searchnetworking.techtarget.com/tip/Wireless-security-How-WEP-encryption-works.\n    </p>\n    <p class=\"citation\">\n        Jacobs, David B. “Wireless Security Protocols -- How WPA and WPA2 Work.” <em>SearchNetworking</em>, Mar. 2008, searchnetworking.techtarget.com/tip/Wireless-security-protocols-How-WPA-and-WPA2-work.\n    </p>\n    <p class=\"citation\">\n        Klein, Matt, and Walter Glenn. “What\'s the Difference Between 2.4 and 5-Ghz Wi-Fi (and Which Should I Use)?” <em>How-To Geek</em>, How-To Geek, 21 Oct. 2018, www.howtogeek.com/222249/whats-the-difference-between-2.4-ghz-and-5-ghz-wi-fi-and-which-should-you-use/.\n    </p>\n    <p class=\"citation\">\n        LearnTomato. “What Is Tomato Firmware, And How Do I Install It?” <em>LearnTomato</em>, 17 July 2014, learntomato.flashrouters.com/what-is-tomato-firmware/.\n    </p>\n    <p class=\"citation\">\n        “List of WLAN Channels.” <em>Wikipedia</em>, Wikimedia Foundation, 14 July 2019, en.wikipedia.org/wiki/List_of_WLAN_channels.\n    </p>\n    <p class=\"citation\">\n        Mitchell, Bradley. “802.11 WiFi Standards Explained.” <em>Lifewire</em>, Lifewire, 1 July 2019, www.lifewire.com/wireless-standards-802-11a-802-11b-g-n-and-802-11ac-816553.\n    </p>\n    <p class=\"citation\">\n        “RF Wireless World.” <em>RF Wireless World</em>, 17 July 2019, www.rfwireless-world.com/Terminology/Advantages-and-Disadvantages-of-MIMO.html.\n    </p>\n    <p class=\"citation\">\n        Stobing, Chris. “What Is MU-MIMO, and Do I Need It on My Router?” <em>How-To Geek</em>, How-To Geek, 12 July 2017, www.howtogeek.com/242793/what-is-mu-mimo-and-do-i-need-it-on-my-router/.\n    </p>\n    <p class=\"citation\">\n        “Tomato (Firmware).” <em>Wikipedia</em>, Wikimedia Foundation, 2 July 2019, en.wikipedia.org/wiki/Tomato_(firmware).\n    </p>\n    <p class=\"citation\">\n        Wexler, Joanie. “MIMO, Antennas and Streams - Oh, My!” <em>Network World</em>, Network World, 30 Apr. 2008, www.networkworld.com/article/2278668/mimo--antennas-and-streams---oh--my-.html.\n    </p>\n    <p class=\"citation\">\n        “What Is WiFi Beamforming & How It Can Improve Your WiFi Signal?” <em>FlashRouters Networking & VPN Blog</em>, 17 Nov. 2016, www.flashrouters.com/blog/2014/05/06/wifi-beamforming-flashrouters-faq/.\n    </p>\n    <p class=\"citation\">\n        “Why Channels 1, 6 and 11?” <em>MetaGeek</em>, 17 July 2019, www.metageek.com/training/resources/why-channels-1-6-11.html.\n    </p>\n    <p class=\"citation\">\n        “Wi-Fi Channels, Frequencies, Bands & Bandwidths.” <em>Electronics Notes</em>, 17 July 2019, www.electronics-notes.com/articles/connectivity/wifi-ieee-802-11/channels-frequencies-bands-bandwidth.php.\n    </p>\n    <p class=\"citation\">\n        “Wi-Fi.” <em>Wikipedia</em>, Wikimedia Foundation, 14 July 2019, en.wikipedia.org/wiki/Wi-Fi.\n    </p>\n    <p class=\"citation\">\n        “Wired Equivalent Privacy.” <em>Wikipedia</em>, Wikimedia Foundation, 16 July 2019, en.wikipedia.org/wiki/Wired_Equivalent_Privacy#Weak_security.\n    </p>\n    <p class=\"citation\">\n        Zak, Robert. “How to Find the Best WiFi Channel for 5Ghz Frequency.” <em>Make Tech Easier</em>, 4 July 2017, www.maketecheasier.com/best-wifi-channel-for-5ghz-frequency/.\n    </p>\n\n    <br>\n</div>\n\n<br>\n<br>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
