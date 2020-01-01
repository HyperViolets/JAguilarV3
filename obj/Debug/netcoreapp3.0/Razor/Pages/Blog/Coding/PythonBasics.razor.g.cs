#pragma checksum "/home/juan/Documents/Developing/JAguilarV3/Pages/Blog/Coding/PythonBasics.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84ce612a2382ab12a4b77fbbb14cfd55f029aa3a"
// <auto-generated/>
#pragma warning disable 1591
namespace JAguilarV3.Pages.Blog.Coding
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Blog/Coding/PythonBasics")]
    public class PythonBasics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<title>Python Basics</title>\n\n<br>\n\n");
            __builder.AddMarkupContent(1, "<div class=\"pageFrame\">\n\n    <br>\n\n    <hr>\n    <h2 class=\"articleTitle\">Python Basics</h2>\n\n    <p class=\"generalText\"><strong>By Juan Aguilar</strong></p>\n    <p class=\"generalText\"><em>June 5, 2019</em></p>\n    <hr>\n\n    <br>\n\n    <h4 class=\"articleTitle\">Comments</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Coding/PythonBasics/CommentsPython.png\">\n\n    <h4 class=\"articleTitle\">Numbers</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Coding/PythonBasics/NumbersPython.png\">\n    <p class=\"generalText\">\n        There is no long data type.\n    </p>\n\n    <h4 class=\"articleTitle\">Strings</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Coding/PythonBasics/StringsPython.png\">\n    <p class=\"generalText\">\n        With Python, strings are immutable and there is no char data type.\n    </p>\n\n    <h4 class=\"articleTitle\">Formatting</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Coding/PythonBasics/FormattingPython.png\">\n\n    <h4 class=\"articleTitle\">More Formatting</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Coding/PythonBasics/StringManipulate.png\">\n    <p class=\"generalText\">\n        Raw strings can use a lower case \"r\" or an upper one \"R\".\n    </p>\n\n    <h4 class=\"articleTitle\">Operators</h4>\n    <ul>\n        <li class=\"bulletPointGeneralText\">+    Plus</li>\n        <li class=\"bulletPointGeneralText\">- Minus</li>\n        <li class=\"bulletPointGeneralText\">* Multiply</li>\n        <li class=\"bulletPointGeneralText\">** Power Of</li>\n        <li class=\"bulletPointGeneralText\">/ Divide</li>\n        <li class=\"bulletPointGeneralText\">// Divide & Floor (divide and round down)</li>\n        <li class=\"bulletPointGeneralText\">% Modulo (return remainder of division)</li>\n        <li class=\"bulletPointGeneralText\">&#60 Less Than</li>\n        <li class=\"bulletPointGeneralText\">> Greater Than</li>\n        <li class=\"bulletPointGeneralText\">&#60= Less Than or Equal To</li>\n        <li class=\"bulletPointGeneralText\">>= Greater Than or Equal To</li>\n        <li class=\"bulletPointGeneralText\">== Equal To</li>\n        <li class=\"bulletPointGeneralText\">!= Not Equal To</li>\n        <li class=\"bulletPointGeneralText\">not Boolean NOT</li>\n        <li class=\"bulletPointGeneralText\">and Boolean AND</li>\n        <li class=\"bulletPointGeneralText\">or Boolean OR</li>\n    </ul>\n\n    <h4 class=\"articleTitle\">if Statement</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Coding/PythonBasics/ifStatement.png\">\n\n    <h4 class=\"articleTitle\">while Statement</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Coding/PythonBasics/whileLoop.png\">\n\n    <h4 class=\"articleTitle\">for Statement, Break, & Continue</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Coding/PythonBasics/forLoopBreakAndContinue.png\">\n    <p class=\"generalText\">\n        Break is used to completely break out of a loop. Continue is used to stop the current iteration of the loop and move-on to the next iteration.\n    </p>\n\n    <h4 class=\"articleTitle\">Functions</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Coding/PythonBasics/Functions.png\">\n    <p class=\"generalText\">\n        Functions are reusable pieces of code. They can contain arguments and those arguments can have default values. WARNING: if you use default arguments, they have to be the last arguments listed. If you put a normal argument after a default argument then the code will break. Keyword Arguments and Optional Parameters exist so look into them if you want.\n    </p>\n\n    <h4 class=\"articleTitle\">return Statement</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Coding/PythonBasics/returnStatement.png\">\n\n    <h4 class=\"articleTitle\">Modules</h4>\n    <p class=\"generalText\">\n        Modules are a collection of functions in one package. You use a module by typing the keyword \"import\" followed by the module name. Example: import sys\n    </p>\n\n    <h4 class=\"articleTitle\">Packages</h4>\n    <p class=\"generalText\">\n        Packages are a collection of modules.\n    </p>\n\n    <h4 class=\"articleTitle\">List, Tuple, Dictionary, & Sets</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Coding/PythonBasics/ArraysPython.png\">\n    <p class=\"generalText\">\n        Lists are mutable and use square brackets [ ]. Tuples are immutable and are represented by parenthesis ( ). Dictionaries are a key value pair. Sets are an unordered collection of objects. They are more concerned with existence of an object. They are usually represented by the \"set\" keyword.\n    </p>\n\n    <h4 class=\"articleTitle\">Classes & Inheritance</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Coding/PythonBasics/ClassesPython.png\">\n\n    <h4 class=\"articleTitle\">Files</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Coding/PythonBasics/FilesPython.png\">\n    <p class=\"generalText\">\n        The \"with open\" keywords are the preferred way of opening a file. The syntax is more readable and it automatically closes the file for you. The other way is to use \"file = open(\"file.txt\", \"r\")\" and \"file.close()\". You can also open a file in multiple modes such as reading, writing, or binary.\n    </p>\n\n    <h4 class=\"articleTitle\">Try... Except</h4>\n    <img class=\"articleImage\" src=\"/images/Blog/Coding/PythonBasics/TryExceptPython.png\">\n\n    <h4 class=\"articleTitle\">Misc. Notes</h4>\n    <ul>\n        <li class=\"bulletPointGeneralText\">Python was authored by Guido van Rossum</li>\n        <li class=\"bulletPointGeneralText\">Use Python 3 instead of Python 2. Python 3 has more features and security fixes.</li>\n        <li class=\"bulletPointGeneralText\">Look for modules/packages in the Python Standard Library</li>\n        <li class=\"bulletPointGeneralText\">The dir() function returns a list of atributes of the object given.</li>\n        <li class=\"bulletPointGeneralText\">Install Python 3 on Ubuntu: sudo apt-get install python3</li>\n        <li class=\"bulletPointGeneralText\">Check Python 3 version on Ubuntu: python3 -V</li>\n    </ul>\n\n    <h4 class=\"articleTitle\">References</h4>\n    <p class=\"citation\">\n        A Byte of Python by Swaroop CH - Book version 2.1 for Python version 3.0\n    </p>\n\n    <br>\n</div>\n\n<br>\n<br>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
