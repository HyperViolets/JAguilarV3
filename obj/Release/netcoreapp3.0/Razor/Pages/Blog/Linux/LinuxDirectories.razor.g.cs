#pragma checksum "/home/juan/Documents/Projects/JAv3Code/JAguilarV3/Pages/Blog/Linux/LinuxDirectories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15758bb69b3944f048f1c68a22ce12b6b6c0cadc"
// <auto-generated/>
#pragma warning disable 1591
namespace JAguilarV3.Pages.Blog.Linux
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Blog/Linux/LinuxDirectories")]
    public partial class LinuxDirectories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<title>Linux Directories</title>\n\n<br>\n\n");
            __builder.AddMarkupContent(1, "<div class=\"pageFrame\">\n\n    <br>\n\n    <hr>\n    <h2 class=\"articleTitle\">Linux Directories</h2>\n\n    <p class=\"generalText\"><strong>By Juan Aguilar</strong></p>\n    <p class=\"generalText\"><em>September 9, 2019</em></p>\n    <hr>\n\n    <br>\n\n    <img class=\"articleImage\" src=\"/images/Blog/Linux/LinuxDirectories/LinuxFileSystem.jpg\">\n    <p class=\"generalText\">\n        The beginning of the Linux file system starts with root (<strong>/</strong>). \n    </p>\n    <p class=\"generalText\">\n        <strong>/boot</strong> contains the necessary files for the system to boot. Files such as the Linux kernel and GRUB boot loader are stored here. \n    </p>\n    <p class=\"generalText\">\n        <strong>/dev</strong> contains device nodes for physical hardware and virtual devices. The Linux kernel uses these nodes to complete tasks. Nodes can be in Character (raw) or Block format. Nodes can be SATA drives, graphics cards or etc.\n    </p>\n    <p class=\"generalText\">\n        <strong>/etc</strong> holds the configuration files for the system and programs. It stands for etcetera. If <strong>/etc</strong> stores configuration files then why is it called etc? That’s because it was originally a place to store files that didn’t fit into any other directory. Over time it became the dedicated place to store configuration files and the name stayed the same.\n    </p>\n    <p class=\"generalText\">\n        <strong>/home</strong> holds user home directories. Each user account has a home directory to save personal files. Other users, except root, can’t access another user’s files.\n    </p>\n    <p class=\"generalText\">\n        <strong>/media</strong> is used as the mounting point for removable media such as a CD, USB, Kindle or an external hard drive. When removable media is plugged in, a directory is automatically created for it in the media directory. You can access files of the media through this directory.\n    </p>\n    <p class=\"generalText\">\n        <strong>/mnt</strong> is used as a temporary mount point. Mounting is referred to as attaching another file system which can reside on a hard disk or other storage device. For example, you can mount a Windows partition to do some file recovery.\n    </p>\n    <p class=\"generalText\">\n        <strong>/opt</strong> is where additional software installed is located. It stands for Optional Packages. Mainly, proprietary software is stored here.\n    </p>\n    <p class=\"generalText\">\n        <strong>/proc</strong> is the process file system. It maintains info on the current state of the kernel. Specifically info on the CPU, memory, disks, running processes and etc. It is auto-managed by the system. The contents are created in memory on boot and destroyed at reboot. You can run the command <strong>cat /proc/cpuinfo</strong> to show CPU info. Use <strong>cat /proc/meminfo</strong> for memory info. Other commands such as <strong>top</strong> and <strong>ps</strong> also use the proc directory.\n    </p>\n    <p class=\"generalText\">\n        <strong>/root</strong> is the home directory of the root user. It’s stored here instead of being located in <strong>/home/root</strong>.\n    </p>\n    <p class=\"generalText\">\n        <strong>/run</strong> is used for early-starting daemons like PID files and socket endpoints. Late-starting daemons are handled by <strong>/var/run</strong> for things like Apache.\n    </p>\n    <p class=\"generalText\">\n        <strong>/srv</strong> is used to store files for services. For example, Apache HTML files can be stored here.\n    </p>\n    <p class=\"generalText\">\n        <strong>/sys</strong> is used as an interface for the kernel. It’s used to load kernel modules, creating device nodes, and other system functions.\n    </p>\n    <p class=\"generalText\">\n        <strong>/tmp</strong> is used to store temporary files. These files are deleted at system reboot.\n    </p>\n    <p class=\"generalText\">\n        <strong>/usr</strong> is a read-only location for general system files. It stands for UNIX System Resources.\n    </p>\n    <p class=\"generalText\">\n        <strong>/var</strong> contains files that change constantly, hence the name variable. For example, logs, status, spool, lock and other dynamic data is stored here. It’s used in conjunction with <strong>/usr</strong>. <strong>/usr</strong> is for read-only system content while <strong>/var</strong> is used for writable content.\n    </p>\n\n    <br>\n    \n    <h4 class=\"articleTitle\">File Types</h4>\n    <p class=\"generalText\">\n        Regular: Text or binary files that begins with “-”. You can create a regular file with the <strong>touch</strong> command. Example: <strong>touch MyFile.txt</strong>.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Linux/LinuxDirectories/RegularFile.png\">\n    <p class=\"generalText\">\n        Directory: These are logical containers to hold files and sub-directories. They begin with “d”. Create a directory with the <strong>mkdir</strong> command. Example: <strong>mkdir MyVacationImages</strong>.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Linux/LinuxDirectories/DirectoryFile.png\">\n    <p class=\"generalText\">\n        Symbolic Links: Shortcut for another file or directory. Begins with (l) for link. Will have an arrow pointing to the linked file/directory.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Linux/LinuxDirectories/SymbolicLink.png\">\n    <p class=\"generalText\">\n        Device: Device nodes start with “c” for Character or “b” for Block. These files can be found in <strong>/dev</strong>.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Linux/LinuxDirectories/DeviceNodes.png\">\n    <p class=\"generalText\">\n        Local Domain Sockets: Used to communicate between processes. Starts with “s”.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Linux/LinuxDirectories/LocalDomainSocket.png\">\n    <p class=\"generalText\">\n        Named Pipes: Used to communicate between local processes. Starts with “p”.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Linux/LinuxDirectories/NamedPipes.png\">\n\n    <br>\n\n    <h4 class=\"articleTitle\">Absolute & Relative Pathnames</h4>\n    <p class=\"generalText\">\n        Absolute pathnames always start with a forward slash (/). They are the full path name. To get your current pathname, use the command <strong>pwd</strong>. It stands for present working directory.\n    </p>\n    <p class=\"generalText\">\n        Relative pathnames never begin with a forward slash (/). They are in relation to your current location.\n    </p>\n\n    <br>\n\n    <h4 class=\"articleTitle\">File & Directory Permissions</h4>\n    <p class=\"generalText\">\n        Using the <strong>ll</strong> command can show you the permissions of a file/directory including other data.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Linux/LinuxDirectories/llOutput.png\">\n    <p class=\"generalText\">\n        Who the permissions apply to are the file owner (u), the owner’s group (g) and others (o). Others represents everybody else AKA public permissions.\n    </p>\n    <p class=\"generalText\">\n        Permissions are broken up into read permissions (r), write permissions (w) and execute permissions (x). If no permissions is specified then a (-) will be used. The (-) means that they don’t have that permission. Execute permissions dictate whether is person is able to run scripts. In the case of a directory, execute permissions dictate whether they can <strong>cd</strong> into the directory.\n    </p>\n    <img class=\"articleImage\" src=\"/images/Blog/Linux/LinuxDirectories/FilePermissions.png\">\n    <p class=\"generalText\">\n        You can edit permissions through the <strong>chmod</strong> command. You can use <strong>chmod</strong> with octal or symbolic notation. With octal, you specify three numbers. The first number is for the file owner permissions. The second is group and third is others. Example: <strong>chmod 447 MyFile</strong>. The owner and group will only have read permissions while others will have read, write, and execute permissions.\n    </p>\n    <p class=\"generalText\">\n        With symbolic notation you use a combination of [u, g, o], [-, +, =], and [r, w, x]. U, g, and o represent user, group, and others. You can remove (-), add (+), or set (=) permissions. As usual, there are the read (r), write (w), and execute (x) permissions. You can use a combination of these in <strong>chmod</strong>. Example <strong>chmod ug=r MyFile</strong>. This command will set the user and group permission to read-only.\n    </p>\n\n    <br>\n\n    <h4 class=\"articleTitle\">References</h4>\n    <p class=\"citation\">\n        “The /Mnt Directory.” <em>Linfo.org</em>, The Linux Information Project, 13 Feb. 2006, www.linfo.org/mnt.html.\n    </p>\n    <p class=\"citation\">\n        Admin. “Identifying File Types in Linux.” <em>Linux Tutorials - Learn Linux Configuration</em>, 9 June 2016, linuxconfig.org/identifying-file-types-in-linux.\n    </p>\n    <p class=\"citation\">\n        Ghori, Asghar. <em>RHCSA & RHCE Red Hat Enterprise Linux 7: Training and Exam Preparation Guide, Exams EX200 and EX300</em>. Endeavor Technologies, 2015.\n    </p>\n    <p class=\"citation\">\n        Ho, Adrian. “What Is the Significance of the /Run/ Directory in Linux?” <em>Quora</em>, 24 Jan. 2015, www.quora.com/What-is-the-significance-of-the-run-directory-in-Linux.\n    </p>\n    <p class=\"citation\">\n        Hoffman, Chris. “The Linux Directory Structure, Explained.” <em>How-To Geek</em>, How-To Geek, 22 Sept. 2016, www.howtogeek.com/117435/htg-explains-the-linux-directory-structure-explained/.\n    </p>\n    <p class=\"citation\">\n        Surendra, Anne. “Linux Directory Structure:/Etc Explained.” <em>The Linux Juggernaut</em>, 25 Feb. 2016, www.linuxnix.com/linux-directory-structure-explainedetc-folder/.\n    </p>\n\n    <br>\n</div>\n\n<br>\n<br>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
