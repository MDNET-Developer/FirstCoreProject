#pragma checksum "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Shared\Components\CommentList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "703a25a0ca3b935dc59a85f86e890a92b24f029c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CommentList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CommentList/Default.cshtml")]
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
#line 1 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\_ViewImports.cshtml"
using Core_Bloq_Bootcamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\_ViewImports.cshtml"
using Core_Bloq_Bootcamp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"703a25a0ca3b935dc59a85f86e890a92b24f029c", @"/Views/Shared/Components/CommentList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"703b2eb1f754ab18af3276d4403e9c25dc0de1c0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CommentList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\t<div class=\"media\">\r\n\r\n\r\n");
#nullable restore
#line 6 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Shared\Components\CommentList\Default.cshtml"
     if (Model.Count() > 0)
	{
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Shared\Components\CommentList\Default.cshtml"
     foreach (var item in Model)
	{
	



#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<div class=\"media mt-3\">\r\n\t\t\t<a class=\"d-flex pr-3\" href=\"#\">\r\n\t\t\t\t<img src=\"images/t2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 248, "\"", 254, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" />\r\n\t\t\t\t\t</a>\r\n\t\t\t\t\t\t<div class=\"media-body\">\r\n\t\t\t\t\t\t\t<h5 class=\"mt-0\">");
#nullable restore
#line 18 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Shared\Components\CommentList\Default.cshtml"
                                        Write(item.CommentUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5><span> / ");
#nullable restore
#line 18 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Shared\Components\CommentList\Default.cshtml"
                                                                           Write(item.CommentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t<p>");
#nullable restore
#line 19 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Shared\Components\CommentList\Default.cshtml"
                          Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 22 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Shared\Components\CommentList\Default.cshtml"

			
		

		

		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Shared\Components\CommentList\Default.cshtml"
         
	}
	else
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("     <h3 class=\"text-danger\">Hələki bu paylaşımda rəy yoxdur. İlk rəy yazan siz olun :)</h3>\r\n");
#nullable restore
#line 33 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Shared\Components\CommentList\Default.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
