#pragma checksum "C:\Users\HP\Desktop\OneHealth\OneHealth\Views\NewsDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3799a3f00c492e44c2e152aeb5978472e7b62078"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewsDetail_Index), @"mvc.1.0.view", @"/Views/NewsDetail/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Desktop\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3799a3f00c492e44c2e152aeb5978472e7b62078", @"/Views/NewsDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ce4f6b879a80692a0905b672a649dc6b56c5fee", @"/Views/_ViewImports.cshtml")]
    public class Views_NewsDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\HP\Desktop\OneHealth\OneHealth\Views\NewsDetail\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-section pt-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <nav aria-label=""Breadcrumb"">
                    <ol class=""breadcrumb bg-transparent py-0 mb-5"">
                        <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                        <li class=""breadcrumb-item""><a href=""blog.html"">Blog</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">List of Countries without Coronavirus case</li>
                    </ol>
                </nav>
            </div>
        </div> <!-- .row -->

        <div class=""row"">
            <div class=""col-lg-8"">
                <article class=""blog-details"">
                    <div class=""post-thumb"">
                        <img src=""../assets/img/blog/blog_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 912, "\"", 918, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""post-meta"">
                        <div class=""post-author"">
                            <span class=""text-grey"">By</span> <a href=""#"">Admin</a>
                        </div>
                        <span class=""divider"">|</span>
                        <div class=""post-date"">
                            <a href=""#"">22 Jan, 2018</a>
                        </div>
                        <span class=""divider"">|</span>
                        <div>
                            <a href=""#"">StreetStyle</a>, <a href=""#"">Fashion</a>, <a href=""#"">Couple</a>
                        </div>
                        <span class=""divider"">|</span>
                        <div class=""post-comment-count"">
                            <a href=""#"">8 Comments</a>
                        </div>
                    </div>
                    <h2 class=""post-title h1"">List of Countries without Coronavirus case</h2>
                    <div class=""pos");
            WriteLiteral(@"t-content"">
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc sit amet est vel orci luctus sollicitudin. Duis eleifend vestibulum justo, varius semper lacus condimentum dictum. Donec pulvinar a magna ut malesuada. In posuere felis diam, vel sodales metus accumsan in. Duis viverra dui eu pharetra pellentesque. Donec a eros leo. Quisque sed ligula vitae lorem efficitur faucibus. Praesent sit amet imperdiet ante. Nulla id tellus auctor, dictum libero a, malesuada nisi. Nulla in porta nibh, id vestibulum ipsum. Praesent dapibus tempus erat quis aliquet. Donec ac purus id sapien condimentum feugiat.</p>

                        <p>Praesent vel mi bibendum, finibus leo ac, condimentum arcu. Pellentesque sem ex, tristique sit amet suscipit in, mattis imperdiet enim. Integer tempus justo nec velit fringilla, eget eleifend neque blandit. Sed tempor magna sed congue auctor. Mauris eu turpis eget tortor ultricies elementum. Phasellus vel placerat orci, a venenatis justo. Phasell");
            WriteLiteral(@"us faucibus venenatis nisl vitae vestibulum. Praesent id nibh arcu. Vivamus sagittis accumsan felis, quis vulputate</p>
                    </div>
                    <div class=""post-tags"">
                        <a href=""#"" class=""tag-link"">LifeStyle</a>
                        <a href=""#"" class=""tag-link"">Food</a>
                        <a href=""#"" class=""tag-link"">Coronavirus</a>
                    </div>
                </article> <!-- .blog-details -->

                <div class=""comment-form-wrap pt-5"">
                    <h3 class=""mb-5"">Leave a comment</h3>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3799a3f00c492e44c2e152aeb5978472e7b620788969", async() => {
                WriteLiteral(@"
                        <div class=""form-row form-group"">
                            <div class=""col-md-6"">
                                <label for=""name"">Name *</label>
                                <input type=""text"" class=""form-control"" id=""name"">
                            </div>
                            <div class=""col-md-6"">
                                <label for=""email"">Email *</label>
                                <input type=""email"" class=""form-control"" id=""email"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""website"">Website</label>
                            <input type=""url"" class=""form-control"" id=""website"">
                        </div>

                        <div class=""form-group"">
                            <label for=""message"">Message</label>
                            <textarea name=""msg"" id=""message"" cols=""30"" rows=""8"" class=""form-control""><");
                WriteLiteral("/textarea>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"submit\" value=\"Post Comment\" class=\"btn btn-primary\">\r\n                        </div>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            <div class=""col-lg-4"">
                <div class=""sidebar"">
                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Search</h3>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3799a3f00c492e44c2e152aeb5978472e7b6207811994", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" placeholder=""Type a keyword and hit enter"">
                                <button type=""submit"" class=""btn""><span class=""icon mai-search""></span></button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Categories</h3>
                        <ul class=""categories"">
                            <li><a href=""#"">Food <span>12</span></a></li>
                            <li><a href=""#"">Dish <span>22</span></a></li>
                            <li><a href=""#"">Desserts <span>37</span></a></li>
                            <li><a href=""#"">Drinks <span>42</span></a></li>
                            <li><a href=""#"">Ocassion <span>14</span></a></li>
                        </ul>
                    </div>

                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Recent Blog</h3>
                        <div class=""blog-item"">
                            <a class=""post-thumb""");
            BeginWriteAttribute("href", " href=\"", 6381, "\"", 6388, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"../assets/img/blog/blog_1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6464, "\"", 6470, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""content"">
                                <h5 class=""post-title""><a href=""#"">Even the all-powerful Pointing has no control</a></h5>
                                <div class=""meta"">
                                    <a href=""#""><span class=""mai-calendar""></span> July 12, 2018</a>
                                    <a href=""#""><span class=""mai-person""></span> Admin</a>
                                    <a href=""#""><span class=""mai-chatbubbles""></span> 19</a>
                                </div>
                            </div>
                        </div>
                        <div class=""blog-item"">
                            <a class=""post-thumb""");
            BeginWriteAttribute("href", " href=\"", 7228, "\"", 7235, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"../assets/img/blog/blog_2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7311, "\"", 7317, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""content"">
                                <h5 class=""post-title""><a href=""#"">Even the all-powerful Pointing has no control</a></h5>
                                <div class=""meta"">
                                    <a href=""#""><span class=""mai-calendar""></span> July 12, 2018</a>
                                    <a href=""#""><span class=""mai-person""></span> Admin</a>
                                    <a href=""#""><span class=""mai-chatbubbles""></span> 19</a>
                                </div>
                            </div>
                        </div>
                        <div class=""blog-item"">
                            <a class=""post-thumb""");
            BeginWriteAttribute("href", " href=\"", 8075, "\"", 8082, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"../assets/img/blog/blog_3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 8158, "\"", 8164, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""content"">
                                <h5 class=""post-title""><a href=""#"">Even the all-powerful Pointing has no control</a></h5>
                                <div class=""meta"">
                                    <a href=""#""><span class=""mai-calendar""></span> July 12, 2018</a>
                                    <a href=""#""><span class=""mai-person""></span> Admin</a>
                                    <a href=""#""><span class=""mai-chatbubbles""></span> 19</a>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Tag Cloud</h3>
                        <div class=""tagcloud"">
                            <a href=""#"" class=""tag-cloud-link"">dish</a>
                            <a href=""#"" class=""tag-cloud-link"">menu</a>
                          ");
            WriteLiteral(@"  <a href=""#"" class=""tag-cloud-link"">food</a>
                            <a href=""#"" class=""tag-cloud-link"">sweet</a>
                            <a href=""#"" class=""tag-cloud-link"">tasty</a>
                            <a href=""#"" class=""tag-cloud-link"">delicious</a>
                            <a href=""#"" class=""tag-cloud-link"">desserts</a>
                            <a href=""#"" class=""tag-cloud-link"">drinks</a>
                        </div>
                    </div>

                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Paragraph</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ducimus itaque, autem necessitatibus voluptate quod mollitia delectus aut, sunt placeat nam vero culpa sapiente consectetur similique, inventore eos fugit cupiditate numquam!</p>
                    </div>
                </div>
            </div>
        </div> <!-- .row -->
    </div> <!-- .container -->
</div> <!-- .page-secti");
            WriteLiteral(@"on -->

<div class=""page-section banner-home bg-image"" style=""background-image: url(../assets/img/banner-pattern.svg);"">
    <div class=""container py-5 py-lg-0"">
        <div class=""row align-items-center"">
            <div class=""col-lg-4 wow zoomIn"">
                <div class=""img-banner d-none d-lg-block"">
                    <img src=""../assets/img/mobile_app.png""");
            BeginWriteAttribute("alt", " alt=\"", 10591, "\"", 10597, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
            <div class=""col-lg-8 wow fadeInRight"">
                <h1 class=""font-weight-normal mb-3"">Get easy access of all features using One Health Application</h1>
                <a href=""#""><img src=""../assets/img/google_play.svg""");
            BeginWriteAttribute("alt", " alt=\"", 10884, "\"", 10890, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                <a href=\"#\" class=\"ml-2\"><img src=\"../assets/img/app_store.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 10977, "\"", 10983, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n            </div>\r\n        </div> <!-- .row -->\r\n    </div> <!-- .container -->\r\n</div> <!-- .banner-home -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
