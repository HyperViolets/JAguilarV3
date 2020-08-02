#pragma checksum "/home/juan/Documents/Programming/JAv3Code/JAguilarV3/Pages/Blog/Hardware/DesktopProcessorBuyingGuide.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d998ca424905340da937503b36d21660764fee66"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Blog/Hardware/DesktopProcessorBuyingGuide")]
    public partial class DesktopProcessorBuyingGuide : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<title>Desktop Processor Buying Guide</title>\n\n<br>\n\n");
            __builder.AddMarkupContent(1, "<div class=\"pageFrame\">\n\n    <br>\n\n    <hr>\n    <h2 class=\"articleTitle\">Desktop Processor Buying Guide</h2>\n\n    <p class=\"generalText\"><strong>By Juan Aguilar</strong></p>\n    <p class=\"generalText\"><em>Updated: September 15, 2019</em></p>\n    <hr>\n\n    <br>\n\n    <h4 class=\"articleTitle\">Core Count and Threads</h4>\n    <p class=\"generalText\">\n        These days, CPUs are more reliant on efficiency rather than speed. Using multiple cores are one way to be efficient. Multicore technology is having two or more full CPU cores operating off one CPU package. Having more cores increases performance. That\'s because each core can do a different tasks at the same time. For example, one core is used for Discord while at the same time another core is used by Spotify.\n    </p>\n    <p class=\"generalText\">\n        To further increase efficiency, cores can use hyper-threading/threads. If a CPU supports hyper-threading, then each core has two threads. Basically, a thread is a virtual core. For example, a quad core CPU that supports hyper-threading will have eight threads (eight virtual cores). Cores and threads can work in parallelization. Parallelization is when several tasks are split among threads and cores. This way tasks can be done faster and at the same time. The one drawback is that applications have to be programmed to take advantage of multicore and threads. Luckily more and more apps are taking advantage of this technology. These days, get at least a four core CPU with hyper-threading. Hyper-threading is useful for photo/video editing, streaming, and 3D rendering.\n    </p>\n\n    <h4 class=\"articleTitle\">Cache</h4>\n    <p class=\"generalText\">\n        Another great way to increase efficiency is to increase the amount of cache. CPUs have different levels of cache built into the CPU die. Cache is used to store data that is frequently accessed by the system RAM. The cache tries to predict the data that is most likely going to be used by the CPU and stores it. All this is done to decrease wait time. In a computer system, the CPU is the fastest component. To do its job, the CPU uses cache and system RAM. However, certain levels of cache and system RAM are slower than the CPU. Since they are slower, the CPU has to wait for the other components to catch up. The system RAM has a large wait time that decreases performance. That\'s where the CPU cache comes in. It decreases the number of times the CPU has to access the system RAM. This way, the CPU can run at full speed without having to wait.\n    </p>\n    <p class=\"generalText\">\n        If the CPU doesn\'t have certain data then it looks for it in the Level 1 cache (L1) (Primary Cache). The L1 cache runs at the same speed as the CPU. Since it runs at the same speed, it has zero wait time. The drawback is that L1 cache is limited in size due to the cost. It\'s very expensive to get large amounts of L1 cache. That is why you typically won\'t see L1 cache that is over 1MB. Cache sizes are slowly increasing in size. L1 cache has a hit ratio of over 80%. Meaning that 80% of the time, L1 cache successfully guesses the data the CPU needs. If not guessed correctly then it results in a cache miss. Each core has their own L1 cache. Even if you have four cores, each core will have their own L1 cache.\n    </p>\n    <p class=\"generalText\">\n        If the L1 cache results in a cache miss then the CPU will look in the Level 2 (L2) cache. L2 cache is larger in size but slower than L1 cache. The L2 cache acts as a \"second chance\" to get it right. Like L1 cache, L2 cache is built into the CPU and each core gets their own L2 cache.\n    </p>\n    <p class=\"generalText\">\n        If L2 cache results in a cache miss then the CPU will look in the Level 3 (L3) cache. L3 cache is larger in size but slower than L2 cache. L3 cache acts as a \"third chance\" to get it right. Like L1 and L2 cache, L3 cache is built into the CPU. However, L3 cache is shared among all the cores. By sharing cache, latency is increased and data can be overwritten by another core.\n    </p>\n\n    <h4 class=\"articleTitle\">Clock Speed</h4>\n    <p class=\"generalText\">\n        Clock speed is measured in gigahertz (GHz) which is the number of clock cycles in one second. For example, a 3.0 GHz processor will do three billion clock cycles per second. The higher the clock speed, the better the performance. However, clock speed alone isn\'t too useful these days. Clock speeds haven\'t risen too much the past years due to limitations. To have a higher clock speed you need more power (voltage). Having more voltage will generate more heat. Even if you slightly increase the voltage, heat output will drastically increase. You cannot have high clock speeds without a significant amount of cooling. The performance of clock speed is also influenced by instructions per second and CPU architecture. A CPU can do multiple tasks each cycle which is instructions per second. The CPU also relies on its architecture or how well built it is. A lot of things go into the performance of a CPU and the clock speed shouldn\'t be your number one priority. I recommend looking at core count, hyper-threading support, and the latest generations first.\n    </p>\n    <p class=\"generalText\">\n        To get more performance out of your processor then look into overclocking. Overclocking is increasing the clock speed that goes over the recommended speed. Overclocking is completely safe as long as you have the proper cooling and don\'t go overboard. The one drawback is decreased lifespan. An overclocked CPU will last around seven to ten years instead of the usual ten to fifteen years. Again, that\'s making sure you don\'t go overboard and have the proper amount of cooling. Generally, increasing the clock speed is proportional to the increase in performance. Meaning that if you increase the clock speed by 5% then you\'ll see about a 5% increase in performance. To overclock you need to increase the CPU\'s voltage which generates a lot of heat. Also buy unlocked CPUs that officially supports overclocking.\n    </p>\n\n    <h4 class=\"articleTitle\">Heatsink and Liquid/Water Cooling</h4>\n    <p class=\"generalText\">\n        Every desktop needs to be cooled especially if you overclock. Heating is actually the number one killer for a processor. The two main ways to cool a CPU is using a heatsink or liquid cooling. I\'ll start off by explaining heatsinks. A heatsink uses a thermal conductor to carry heat away from the CPU and into its fins. Airflow from fans then blows the hot air away. The thermal conductor or CPU block is a piece of metal that sits on top of the CPU. Thermal paste is applied between the CPU and CPU block. The CPU block is usually made from copper or aluminum. Copper has about twice the thermal conductivity compared to aluminum. Always buy a CPU block made from copper. The CPU block may have a nickel plating or another kind of plating. Plating is just a thin coat of metal on top of the CPU block. Also, get copper heat pipes as well. The heat pipes transfers heat from the CPU block to the fins. More heat pipes means that more heat is transferred. The fins then dissipate the heat into the air. Then the heatsink fans blow the hot air away. Heatsink fins are generally made out of aluminum.\n    </p>\n    <p class=\"generalText\">\n        Most CPUs will come with a heatsink. These are usually called stock coolers. Stock coolers are designed to keep the CPU cool under stressful situations. If you don\'t plan to overclock then a stock cooler will be fine. Most people tend to buy aftermarket coolers like Noctua. Most aftermarket coolers keep the CPU at cooler temperatures and tend to be less noisy.\n    </p>\n\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/DesktopProcessorBuyingGuide/noctua.png\">\n    \n    <p class=\"generalText\">\n        Now, how do you decide on which heatsink to pick? The CPU will list its TDP (thermal design power) which is the amount of heat generated by the CPU. This is represented in watts. The TDP does not a direct measure of how many watts the CPU draws from the power supply. It\'s more like a good indicator of watt usage. You want to buy a heatsink that has a TDP that goes over the CPU\'s TDP. If you\'re overclocking then get a higher heatsink TDP. Some brands like Noctua won\'t list the TDP. Instead they list heatsinks that are compatible with your CPU. They even take overclocking into consideration. Besides TDP, you can look at the size and materials of the heatsink. Always get copper heat pipes and a copper CPU block. More heat pipes are always better. The larger the fins the more heat is dissipated. If you\'re going to get a heatsink with large fins then make sure it fits in your case.\n    </p>\n    <p class=\"generalText\">\n        Liquid/Water cooling is superior to heatsinks. A liquid cooler essentially works the same as a heatsink. A liquid cooling system is made from several components. The water/CPU block sits over the CPU to transfer heat away. Tubing is used to transport the water. Tubes are connected together using fittings. The radiator and its fans are used to cool the water that was heated from the CPU. The pump pumps water through the loop/cooling system. Additives are also put in the water to keep it from getting contaminated.\n    </p>\n    <p class=\"generalText\">\n        Liquid cooling is quieter and more efficient compared to a heatsink. The larger the radiator, the more heat can be cooled. You can add coloring to the liquid to make the liquid any color you want. You can also buy colored tubing instead of adding coloring to the liquid. It\'s recommended to clean the liquid cooling system every six months. It\'s also recommended to build a fill and drain tube. You want a fill tube at the top of the loop so you can fill the system with liquid all the way to the top. A drain tube is located at the bottom of the system. This way gravity drains most of the water out when the time comes to remove the water. If you hear an excessive amount of noise then it may mean there is air in the loop/tubes. You can buy all-in-one kits for liquid cooling that has all the supplies you need.\n    </p>\n    <p class=\"generalText\">\n        Heatsinks and liquid cooling both need fans to operate well. There are several types of bearings for fans. Sleeve bearings are the most common and cheapest. Only mount sleeve bearing fans vertically for the best performance. Ball bearings have a scientifically longer lifespan compared to sleeve bearings. There are also hydro/fluid bearings. They are the quietest and longest lasting out of sleeve and ball bearings. They are also the most expensive out of the bunch. Hydro bearings are actually a modified version of sleeve bearings. There are other bearing types out there but they\'re not too common. The RPM of the fan can dictate how noisy it is. Generally, an RPM of 1000 or less results in a quiet fan. The fan may also list the noise level. A noise level of 60 decibels (dB) is about a normal conversation. 30 dB is about as loud as a quiet whisper.\n    </p>\n\n    <h4 class=\"articleTitle\">Intel Naming Scheme</h4>\n    <p class=\"generalText\">\n        When it comes to Intel and their naming schemes, there are generations and families. Each generation has a different micro-architecture and performance increase with each new generation. Below are the current generations released:\n    </p>\n    <ul>\n        <li class=\"bulletPointGeneralText\">1st Gen: Nehalem</li>\n        <li class=\"bulletPointGeneralText\">2nd Gen: Sandy Bridge</li>\n        <li class=\"bulletPointGeneralText\">3rd Gen: Ivy Bridge</li>\n        <li class=\"bulletPointGeneralText\">4th Gen: Haswell</li>\n        <li class=\"bulletPointGeneralText\">5th Gen: Broadwell</li>\n        <li class=\"bulletPointGeneralText\">6th Gen: Skylake</li>\n        <li class=\"bulletPointGeneralText\">7th Gen: Kaby Lake</li>\n        <li class=\"bulletPointGeneralText\">8th Gen: Coffee Lake</li>\n        <li class=\"bulletPointGeneralText\">9th Gen: Coffee Lake (refresh)</li>\n    </ul>\n    <p class=\"generalText\">\n        Generations are further divided into families. The most common family for desktop processors is the Core family. The Core family includes i3, i5, i7, and i9. The Xeon family is designed for servers. The Atom family is designed for mobile and energy efficiency. There are other families, but we\'ll focus on the Core family for now. The Intel Core family naming scheme can be summed up in the following picture:\n    </p>\n\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/DesktopProcessorBuyingGuide/IntelNameScheme.png\">\n    \n    <p class=\"generalText\">\n        The brand/family is the Core family which is designed to be used in desktops.\n    </p>\n    <p class=\"generalText\">\n        The brand/family modifier describes the amount of performance to expect. i3 processor are low-end and the cheapest. An i5 offers better performance for a higher price. An i7 again offers better performance for a higher price. An i9 has the best performance you can get with a high price tag to match.\n    </p>\n    <p class=\"generalText\">\n        The generation refers to the generation listed above. Typically you want the latest or a previous generation.\n    </p>\n    <p class=\"generalText\">\n        SKU stands for stock keeping unit. It\'s a number to identify processor versions.\n    </p>\n    <p class=\"generalText\">\n        The product line suffix further categorizes the processor into different use cases. For example, X stands for high-end processors that are overclocking friendly.\n    </p>\n\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/DesktopProcessorBuyingGuide/IntelSuffix.png\">\n\n    <h4 class=\"articleTitle\">AMD Naming Scheme</h4>\n    <p class=\"generalText\">\n        AMD takes a similar naming scheme like Intel. For this section I\'ll stick to the Ryzen naming scheme since it\'s the latest and recommended desktop processors to buy. I won\'t mention Ryzen Threadripper because they\'re meant for server/workstation environments with their high core and thread count. The Ryzen naming scheme can be summed up with the following picture:\n    </p>\n\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/DesktopProcessorBuyingGuide/AMDNameScheme.png\">\n\n    <p class=\"generalText\">\n        The brand/family is Ryzen. There are other brands like Threadripper, Athlon, A-Series, and FX.\n    </p>\n    <p class=\"generalText\">\n        The segment represents the type of performance to expect. 3 is for low-end. 5 is for high performance. 7 is for the highest performance.\n    </p>\n    <p class=\"generalText\">\n        The generation refers to the architecture. Currently there is only the first and second generation available. The second generation is the latest with the best performance.\n    </p>\n    <p class=\"generalText\">\n        The performance level further describes the type of performance to expect. 1, 2, and 3 are low-end. 4, 5, and 6 are high performance. 7 and 8 are the best performing you can buy. As usual the better performing you want, the more expensive they are.\n    </p>\n    <p class=\"generalText\">\n        The model number is the SKU or a similar number. It\'s a number to identify processor versions.\n    </p>\n    <p class=\"generalText\">\n        The power suffix is the same as Intel with some slight differences.\n    </p>\n\n    <img class=\"articleImage\" src=\"/images/Blog/Hardware/DesktopProcessorBuyingGuide/AMDSuffix.png\">\n\n    <h4 class=\"articleTitle\">Benchmarks and Reviews</h4>\n    <p class=\"generalText\">\n        It\'s always a good idea to look at benchmarks and reviews before a purchase. For benchmarks, try looking at <a href=\"https://benchmarks.ul.com\" target=\"_blank\">benchmarks.ul.com</a> and <a href=\"https://bapco.com\" target=\"_blank\">bapco.com</a>. Be aware that each company and processor focuses on different things. AMD tends to focus more on integrated graphics while Intel focuses on performance. Also, look at benchmarks for your specific needs. If you\'re a video editor then look at benchmarks that test on video editing software. After looking at benchmarks, look at reviews for anything out of the ordinary. Like when a specific processor tends to have a driver issue or when a certain processor is highly recommended.\n    </p>\n\n    <h4 class=\"articleTitle\">Processor Limitations</h4>\n    <p class=\"generalText\">\n        One of the biggest limitations for a processor is the size of transistors. Transistors are basically a switch to represent 1s and 0s. Transistor size is represented in nanometers (nm). Having smaller transistors means that you can squeeze more computational power into the same sized CPU. As of this time of writing, AMD has released TSMC 7nm FinFET technology with Zen 2 microarchitecture for their Ryzen 3000 series. Intel on the otherhand is having difficulty rolling out 10nm. The problem with smaller transistors is quantum tunneling. Basically, the transistor has gotten so small that electrons \"teleport\" out of the transistor switch. This causes data corruption and other things to break. Other technologies such as carbon nanotubes are being researched to overcome this issue.\n    </p>\n    <p class=\"generalText\">\n        The other limitation is CPU speed. There is a reason why you don\'t see a 5GHz processor. At those speeds, there is no adequate cooling system for consumers. Those high speeds usually resulted in the processor melting. That\'s why the industry started focusing more on multi core technology.\n    </p>\n\n    <h4 class=\"articleTitle\">Other Points to Take Into Consideration</h4>\n    <ul>\n        <li class=\"bulletPointGeneralText\">Thermal Paste: Always use thermal paste for your heatsink and liquid cooling. The thermal paste is used to make a better heat transfer environment between the processor and CPU block. The thermal past can already be preapplied out of the box.<ul><li>Only apply a little bit of thermal paste. The size of a grain of rice or pea is good enough. Always remember that less is more.</li></ul></li>\n        <li class=\"bulletPointGeneralText\">Virtualization Support: If you want to create Virtual Machines then make sure the processor has virtualization support.</li>\n        <li class=\"bulletPointGeneralText\">CPU Socket: Your motherboard needs the right CPU socket for your processor. For example, Ryzen processors use an AM4 socket and you need a motherboard that supports AM4.<ul><li>No force is needed to install a processor. The CPU is meant to slot into the socket easily.</li></ul></li>\n        <li class=\"bulletPointGeneralText\">Cooling and CPU Socket: Make sure your heatsink or liquid cooling can correctly mount on the CPU socket. Not every cooling block is compatible for your CPU socket.<ul><li>It\'s ok if the heatsink bends the motherboard. The motherboard is designed to bend to accommodate a large heatsink.</li></ul></li>\n        <li class=\"bulletPointGeneralText\">Turbo Boost/Max Boost Clock: Turbo boost is when a single core\'s (or sometimes thread) clock speed is increased for a short amount of time. CPU specifications may list the max GHz a CPU can achieve while boosted. The availability of increased clock speed can depend on cooling, BIOS support, drivers, OS updates, and much more.</li>\n        <li class=\"bulletPointGeneralText\">CPU-Z: You can use software called CPU-Z to scan your computer and give you information about processor. It can be found at: <a href=\"https://www.cpuid.com/softwares/cpu-z.html\" target=\"_blank\">https://www.cpuid.com/softwares/cpu-z.html</a>.</li>\n        <li class=\"bulletPointGeneralText\">\n            Integrated Graphics: The GPU can be built into the processor. This is called integrated graphics. Performance is not as good as a stand-alone graphics card. If you\'re just web browsing then a CPU with integrated graphics will do you fine. Thankfully, integrated graphics are constantly being improved over time. For AMD, their APUs run a generation behind the current generation.\n        </li>\n        <li class=\"bulletPointGeneralText\">\n            PCIe Lanes: CPU specifications will list the PCIe version and number of lanes for a CPU. The CPU uses these lanes to communicate with the motherboard. Your CPU will most likely support 16 lanes with PCIe version 3 or 4.\n        </li>\n    </ul>\n\n    <h4 class=\"articleTitle\">References</h4>\n    <p class=\"citation\">\n        “A Beginner\'s Guide to Water Cooling Your Computer.” <i>YouTube</i>, 4 Sept. 2012, youtu.be/Dk3V64ZSsEI.\n    </p>\n    <p class=\"citation\">\n        “AMD Ryzen 3, 5, and 7 Explained.” <i>YouTube</i>, 19 Sept. 2017, youtu.be/B4kQ-cM_7C0.\n    </p>\n    <p class=\"citation\">\n        Burke, Steve. “The Basics of Case Fan Bearings - Which Bearing Is Best?” <i>GamersNexus</i>, 17 Mar. 2012, 3:46 pm, www.gamersnexus.net/guides/779-computer-case-fan-bearing-differences.\n    </p>\n    <p class=\"citation\">\n        Burke, Steve. “Understanding CPU Heatsinks: Picking the Best CPU Cooler.” <i>GamersNexus</i>, 4 Dec. 2012, 2:54 pm, www.gamersnexus.net/guides/981-how-cpu-coolers-work.\n    </p>\n    <p class=\"citation\">\n        Chu, Wallace. “Deciphering Processor Model Numbers - HardBoiled.” <i>Newegg Business</i>, 30 June 2015, www.neweggbusiness.com/smartbuyer/over-easy/deciphering-amd-intel-processor-model-numbers/.\n    </p>\n    <p class=\"citation\">\n        “CPU Cores for Gaming: How Many Do You Need? - Q1 2015 Update.” <i>YouTube</i>, 13 Apr. 2015, youtu.be/PVl8Eupbr_E.\n    </p>\n    <p class=\"citation\">\n        “Difference Between Intel Processor Generations.” <i>ITechtics</i>, 4 Mar. 2015, www.itechtics.com/processor-generations/.\n    </p>\n    <p class=\"citation\">\n        “Does CPU Clock Speed Actually Matter?” <i>YouTube</i>, 13 Nov. 2018, youtu.be/bVMkbACYLG8.\n    </p>\n    <p class=\"citation\">\n        Ducpham, Thomas. “The Intel CPU Family Explained.” <i>Central Valley Computer Parts</i>, 3 Apr. 2018, centralvalleycomputerparts.com/articles/the-intel-cpu-family-explained/.\n    </p>\n    <p class=\"citation\">\n        “Heading.” <i>CPU Compatibility</i>, noctua.at/en/nh-u9s/cpucomp.\n    </p>\n    <p class=\"citation\">\n        Hoffman, Chris. “Why You Can\'t Use CPU Clock Speed to Compare Computer Performance.” <i>How-To Geek</i>, How-To Geek, 5 July 2017, 9:02 pm EDT, www.howtogeek.com/177790/why-you-cant-use-cpu-clock-speed-to-compare-computer-performance/.\n    </p>\n    <p class=\"citation\">\n        “How Do CPUs Use Multiple Cores?” <i>YouTube</i>, 3 June 2016, youtu.be/S3I5WNHbnJ0.\n    </p>\n    <p class=\"citation\">\n        Hruska, Joel. “How L1 and L2 CPU Caches Work, and Why They\'re an Essential Part of Modern Chips.” <i>ExtremeTech</i>, 30 Aug. 2018, 1:30 pm, www.extremetech.com/extreme/188776-how-l1-and-l2-cpu-caches-work-and-why-theyre-an-essential-part-of-modern-chips.\n    </p>\n    <p class=\"citation\">\n        Hruska, Joel. “L2 Vs. L3 Cache: What\'s the Difference?” <i>ExtremeTech</i>, 18 May 2017, 3:17 pm, www.extremetech.com/computing/55662-top-tip-difference-between-l2-and-l3-cache.\n    </p>\n    <p class=\"citation\">\n        “Intel CPU Letters Explained.” <i>YouTube</i>, 16 Mar. 2018, youtu.be/4a9DBU4sROA.\n    </p>\n    <p class=\"citation\">\n        “Intel® Processor Numbers: Laptop, Desktop, and Mobile Device.” <i>Intel</i>, www.intel.com/content/www/us/en/processors/processor-numbers.html.\n    </p>\n    <p class=\"citation\">\n        “Intel® Processors for Servers, PCs, IoT, and Mobile Devices.” <i>Intel</i>, www.intel.com/content/www/us/en/products/processors.html.\n    </p>\n    <p class=\"citation\">\n        “Is Overclocking Safe?” <i>YouTube</i>, 23 May 2016, youtu.be/kxAiyET_MrE.\n    </p>\n    <p class=\"citation\">\n        Jaras, Samantha. “AMD v. Intel Naming Scheme Mystery Solved.” <i>AVADirect</i>, AVADirect, 23 Sept. 2016, www.avadirect.com/blog/amd-v-intel-naming-scheme-mystery-solved/.\n    </p>\n    <p class=\"citation\">\n        Mueller, Scott. <i>Upgrading and Repairing PCs</i>. Que, 2015.\n    </p>\n    <p class=\"citation\">\n        “PC Fan Bearings - Sleeve vs Ball vs Others as Fast As Possible.” <i>YouTube</i>, 21 June 2014, youtu.be/ORPfV5VC_dU.\n    </p>\n    <p class=\"citation\">\n        Piltch, Avram. “Which Laptop CPU Is Right For You?” <i>Laptop Mag</i>, 7 Feb. 2019, 11:30 am, www.laptopmag.com/articles/cpu-comparison.\n    </p>\n    <p class=\"citation\">\n        “Processors for Desktops.” <i>AMD</i>, www.amd.com/en/products/processors-desktop.\n    </p>\n    <p class=\"citation\">\n        Safford, Matt. “How to Buy the Right CPU: A Guide for 2019.” <i>Tom\'s Hardware</i>, 26 Feb. 2019, 12:32 pm, www.tomshardware.com/reviews/cpu-buying-guide,5643.html.\n    </p>\n    <p class=\"citation\">\n        Sakr, Sharif. “Engadget Primed: Why Nanometers Matter (and Why They Often Don\'t).” <i>Engadget</i>, 15 June 2012, www.engadget.com/2012/06/15/engadget-primed-nanometers/.\n    </p>\n    <p class=\"citation\">\n        “Turbo Boost & Processor Efficiency as Fast As Possible.” <i>YouTube</i>, 12 May 2014, youtu.be/H4ryOzIZvpQ.\n    </p>\n    <p class=\"citation\">\n        “Water Cooling 101: Everything You Need To Know.” <i>MWave</i>, 20 Dec. 2016, www.mwave.com.au/blog/2016/12/20/water-cooling-101-everything-you-need-to-know.\n    </p>\n    <p class=\"citation\">\n        “What Is a Core i3, Core i5, or Core i7 as Fast As Possible.” <i>YouTube</i>, 12 July 2014, youtu.be/GLSPub4ydiM.\n    </p>\n    <p class=\"citation\">\n        “What Is a Transistor?” <i>Computer Hope</i>, Computer Hope, 2 Oct. 2017, www.computerhope.com/jargon/t/transist.htm.\n    </p>\n    <p class=\"citation\">\n        “Why Liquid Cooling?” <i>Ekwb.com</i>, www.ekwb.com/guides/.\n    </p>\n    <p class=\"citation\">\n        Yamada, Kannon. “How to Choose and Mount a CPU Fan: Everything You Need To Know.” <i>MakeUseOf</i>, 28 June 2013, www.makeuseof.com/tag/how-to-choose-and-mount-a-cpu-fan-everything-you-need-to-know/.\n    </p>\n    <p class=\"citation\">\n        http://www.cpu-world.com/Glossary/L/Level_1_cache.html\n    </p>\n    <p class=\"citation\">\n        http://www.cpu-world.com/Glossary/L/Level_2_cache.html\n    </p>\n    <p class=\"citation\">\n        “7 Nanometer.” <em>Wikipedia</em>, Wikimedia Foundation, 15 Sept. 2019, en.wikipedia.org/wiki/7_nanometer.\n    </p>\n    <p class=\"citation\">\n        Edmonds, Rich. “What Is TDP and Why Should You Care about It?” <em>Windows Central</em>, Windows Central, 28 Oct. 2016, www.windowscentral.com/what-tdp-and-why-should-you-care-about-it.\n    </p>\n\n    <br>\n</div>\n\n<br>\n<br>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
