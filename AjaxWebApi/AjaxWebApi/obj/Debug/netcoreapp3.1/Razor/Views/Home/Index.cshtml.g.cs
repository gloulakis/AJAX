#pragma checksum "\\Mac\Home\Desktop\AjaxApi\AjaxWebApi\AjaxWebApi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8717b96ca86cf97c3de060c06a39efa7bb84fb68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "\\Mac\Home\Desktop\AjaxApi\AjaxWebApi\AjaxWebApi\Views\_ViewImports.cshtml"
using AjaxWebApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Desktop\AjaxApi\AjaxWebApi\AjaxWebApi\Views\_ViewImports.cshtml"
using AjaxWebApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8717b96ca86cf97c3de060c06a39efa7bb84fb68", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03570f2984175c6a307055ce23cec2837ab732c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ChessFiguresViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "\\Mac\Home\Desktop\AjaxApi\AjaxWebApi\AjaxWebApi\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    int rowId = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <table>
        <tr>
            <th><button onclick=""getOrder()"" class=""table-btn"">Name</button></th>
            <th><button class=""table-btn"">Power</button></th>
            <th><button class=""table-btn"">Max range</button></th>
            <th><button class=""table-btn"">Min range</button></th>
            <th>Picture</th>
        </tr>

");
#nullable restore
#line 18 "\\Mac\Home\Desktop\AjaxApi\AjaxWebApi\AjaxWebApi\Views\Home\Index.cshtml"
         foreach (var figure in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 559, "\"", 574, 1);
#nullable restore
#line 20 "\\Mac\Home\Desktop\AjaxApi\AjaxWebApi\AjaxWebApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 564, rowId++, 564, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td class=\"info-cell\">");
#nullable restore
#line 21 "\\Mac\Home\Desktop\AjaxApi\AjaxWebApi\AjaxWebApi\Views\Home\Index.cshtml"
                                 Write(figure.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"info-cell\">");
#nullable restore
#line 22 "\\Mac\Home\Desktop\AjaxApi\AjaxWebApi\AjaxWebApi\Views\Home\Index.cshtml"
                                 Write(figure.Power);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"info-cell\">");
#nullable restore
#line 23 "\\Mac\Home\Desktop\AjaxApi\AjaxWebApi\AjaxWebApi\Views\Home\Index.cshtml"
                                 Write(figure.MaxRange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"info-cell\">");
#nullable restore
#line 24 "\\Mac\Home\Desktop\AjaxApi\AjaxWebApi\AjaxWebApi\Views\Home\Index.cshtml"
                                 Write(figure.MinRange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"info-cell\"><img");
            BeginWriteAttribute("src", " src=\"", 857, "\"", 879, 1);
#nullable restore
#line 25 "\\Mac\Home\Desktop\AjaxApi\AjaxWebApi\AjaxWebApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 863, figure.ImageUrl, 863, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "\\Mac\Home\Desktop\AjaxApi\AjaxWebApi\AjaxWebApi\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>

<script>
    const getOrder = () => {
        fetch(""api/ChessSorter/name"")
            .then(data => data.json())
            .then((data) => {
                console.log(data);
                reorder(data);
            });
    };

    const reorder = (data) => {
        data.forEach(prop => {
            let row = document.getElementById(prop.order);
            let cells = row.children;
            cells[0].innerHTML = prop.name;
            cells[1].innerHTML = prop.power;
            cells[2].innerHTML = prop.maxRange;
            cells[3].innerHTML = prop.minRange;
            cells[4].children[0].src = prop.imageUrl;
        });
        
    };
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ChessFiguresViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
