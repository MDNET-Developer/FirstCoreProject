#pragma checksum "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Main\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecacce1fc55cd07bb42ff9ac443251a1ce85a149"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_BlogDetail), @"mvc.1.0.view", @"/Views/Main/BlogDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecacce1fc55cd07bb42ff9ac443251a1ce85a149", @"/Views/Main/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"703b2eb1f754ab18af3276d4403e9c25dc0de1c0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Main_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Main\BlogDetail.cshtml"
  
    ViewData["Title"] = "BlogDetail";
    Layout = "~/Views/Shared/_WebSiteMainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<!--//banner-->\r\n\t<section class=\"banner-bottom\">\r\n\t\t<!--/blog-->\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<!--left-->\r\n\t\t\t\t<div class=\"col-lg-8 left-blog-info-w3layouts-agileits text-left\">\r\n\r\n");
#nullable restore
#line 14 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Main\BlogDetail.cshtml"
                     foreach(var item in Model)
					{

					

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"blog-grid-top\">\r\n\t\t\t\t\t\t<div class=\"b-grid-top\">\r\n\t\t\t\t\t\t\t<div class=\"blog_info_left_grid\">\r\n\t\t\t\t\t\t\t\t<a href=\"single.html\">\r\n\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 563, "\"", 584, 1);
#nullable restore
#line 22 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Main\BlogDetail.cshtml"
WriteAttributeValue("", 569, item.BlogImage, 569, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 603, "\"", 609, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"blog-info-middle\">\r\n\t\t\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 29 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Main\BlogDetail.cshtml"
                                                                           Write(item.BloqCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
									</li>
									<li class=""mx-2"">
										<a href=""#"">
											<i class=""far fa-thumbs-up""></i> 201 Likes</a>
									</li>
									<li>
										<a href=""#"">
											<i class=""far fa-comment""></i> 15 Comments</a>
									</li>
									
								</ul>
							</div>
						</div>

						<h3>
							<a href=""single.html"">");
#nullable restore
#line 45 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Main\BlogDetail.cshtml"
                                             Write(item.BloqTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t\t<p>");
#nullable restore
#line 47 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Main\BlogDetail.cshtml"
                      Write(item.BloqContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 50 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Main\BlogDetail.cshtml"
					}	

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"comment-top\">\r\n\t\t\t\t\t\t<h4>Comments</h4>\r\n\r\n\t\t\t\t\t");
#nullable restore
#line 54 "D:\MyProjects\NEW\Core_Bloq_Bootcamp\Core_Bloq_Bootcamp\Views\Main\BlogDetail.cshtml"
               Write(await Component.InvokeAsync("CommentList",new{id=@ViewBag.GetID}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"comment-top\">\r\n\t\t\t\t\t\t<h4>Leave a Comment</h4>\r\n\t\t\t\t\t\t<div class=\"comment-bottom\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecacce1fc55cd07bb42ff9ac443251a1ce85a1497740", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"Name\" placeholder=\"Name\"");
                BeginWriteAttribute("required", " required=\"", 1620, "\"", 1631, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"email\" name=\"Email\" placeholder=\"Email\"");
                BeginWriteAttribute("required", " required=\"", 1716, "\"", 1727, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"Subject\" placeholder=\"Subject\"");
                BeginWriteAttribute("required", " required=\"", 1817, "\"", 1828, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n\t\t\t\t\t\t\t\t<textarea class=\"form-control\" name=\"Message\" placeholder=\"Message...\"");
                BeginWriteAttribute("required", " required=\"", 1912, "\"", 1923, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n\t\t\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-primary submit\">Submit</button>\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
						</div>
					</div>
				</div>

				<!--//left-->
				<!--right-->
				<aside class=""col-lg-4 agileits-w3ls-right-blog-con text-right"">
					<div class=""right-blog-info text-left"">
						<div class=""tech-btm"">
							<img src=""images/banner1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 2310, "\"", 2316, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"tech-btm\">\r\n\t\t\t\t\t\t\t<h4>Sign up to our newsletter</h4>\r\n\t\t\t\t\t\t\t<p>Pellentesque dui, non felis. Maecenas male </p>\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecacce1fc55cd07bb42ff9ac443251a1ce85a14911048", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<input type=\"email\" placeholder=\"Email\"");
                BeginWriteAttribute("required", " required=\"", 2553, "\"", 2564, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<input type=\"submit\" value=\"Subscribe\">\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

						</div>
						<div class=""tech-btm"">
							<h4>Categories</h4>
							<ul class=""list-group single"">
									<li class=""list-group-item d-flex justify-content-between align-items-center"">
									  Cras justo odio
									  <span class=""badge badge-primary badge-pill"">14</span>
									</li>
									<li class=""list-group-item d-flex justify-content-between align-items-center"">
									  Dapibus ac facilisis in
									  <span class=""badge badge-primary badge-pill"">2</span>
									</li>
									<li class=""list-group-item d-flex justify-content-between align-items-center"">
									  Morbi leo risus
									  <span class=""badge badge-primary badge-pill"">1</span>
									</li>
								  </ul>
						</div>
						<div class=""tech-btm"">
							<h4>Top stories of the week</h4>

							<div class=""blog-grids row mb-3"">
								<div class=""col-md-5 blog-grid-left"">
									<a href=""single.html"">
										<img src=""images/1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 3629, "\"", 3635, 0);
            EndWriteAttribute();
            WriteLiteral(@">
									</a>
								</div>
								<div class=""col-md-7 blog-grid-right"">

									<h5>
										<a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
									</h5>
									<div class=""sub-meta"">
										<span>
											<i class=""far fa-clock""></i> 20 Jan, 2018</span>
									</div>
								</div>

							</div>
							<div class=""blog-grids row mb-3"">
								<div class=""col-md-5 blog-grid-left"">
									<a href=""single.html"">
										<img src=""images/6.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 4177, "\"", 4183, 0);
            EndWriteAttribute();
            WriteLiteral(@">
									</a>
								</div>
								<div class=""col-md-7 blog-grid-right"">
									<h5>
										<a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
									</h5>
									<div class=""sub-meta"">
										<span>
											<i class=""far fa-clock""></i> 20 Feb, 2018</span>
									</div>
								</div>

							</div>
						</div>
						<div class=""single-gd my-5 tech-btm"">
							<h4>Our Progress</h4>
							<div class=""progress"">
								<div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0""
								    aria-valuemax=""100""></div>
							</div>
							<div class=""progress"">
								<div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0""
								    aria-valuemax=""100""></div>
							</div>
							<div class=""progress"">
								<div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""widt");
            WriteLiteral(@"h: 50%"" aria-valuenow=""50"" aria-valuemin=""0""
								    aria-valuemax=""100""></div>
							</div>
							<div class=""progress"">
								<div class=""progress-bar progress-bar-striped bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0""
								    aria-valuemax=""100""></div>
							</div>
							<div class=""progress"">
								<div class=""progress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0""
								    aria-valuemax=""100""></div>
							</div>
						</div>
						<div class=""single-gd tech-btm"">
							<h4>Recent Post</h4>
							<div class=""blog-grids"">
								<div class=""blog-grid-left"">
									<a href=""single.html"">
										<img src=""images/b1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 6005, "\"", 6011, 0);
            EndWriteAttribute();
            WriteLiteral(@">
									</a>
								</div>
								<div class=""blog-grid-right"">

									<h5>
										<a href=""single.html"">Pellentesque dui, non felis. Maecenas male</a>
									</h5>
								</div>
								<div class=""clearfix""> </div>
							</div>
						</div>
					</div>

				</aside>
				<!--//right-->
			</div>
		</div>
	</section>
	<!--//main-->

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
