#pragma checksum "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9115a3088983ef45e9a39e1d2fa3f187ad699c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
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
#line 1 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\_ViewImports.cshtml"
using MotiCv;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\_ViewImports.cshtml"
using MotiCv.AppCode.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\_ViewImports.cshtml"
using MotiCv.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\_ViewImports.cshtml"
using MotiCv.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\_ViewImports.cshtml"
using MotiCv.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\_ViewImports.cshtml"
using MotiCv.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\_ViewImports.cshtml"
using MotiCv.Models.WievBoxModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\_ViewImports.cshtml"
using MotiCv.Models.Entitys;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9115a3088983ef45e9a39e1d2fa3f187ad699c2", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65e6e44d5d54c6cebed0c8191d9e5dd0760be86f", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ForBlogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive margin-top-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/uploads/images/avatar-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Email Addres"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Website"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Subject"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("YOUR MESSAGE"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comment_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/jquery-validate/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- MAIN CONTENT -->\r\n<div class=\"col-md-8\">\r\n    <div class=\"inside-sec blog\">\r\n        <!-- BIO AND SKILLS -->\r\n        <h5 class=\"tittle\">BLOG POST</h5>\r\n\r\n        <article class=\"blog-post width-100 padding-25\">\r\n");
            WriteLiteral("            <div class=\"post-img\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c9115a3088983ef45e9a39e1d2fa3f187ad699c210283", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 424, "~/uploads/images/", 424, 17, true);
#nullable restore
#line 17 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 441, Model.Blogs.ImagePath, 441, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <span class=\"date-in\">");
#nullable restore
#line 18 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
                                 Write(Model.Blogs.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n\r\n            <!-- BLOG DETAIL -->\r\n            <h4 class=\"font-normal\">Faster Response</h4>\r\n            <span class=\"post-bt\">by <span class=\"text-color-primary\">");
#nullable restore
#line 23 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
                                                                 Write(Model.Blogs.MasterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\r\n            <ul class=\"post-info\">\r\n                <li> <i class=\"fa fa-comments-o\"></i>97 </li>\r\n                <li> <i class=\"fa fa-eye\"></i>565 </li>\r\n                <li> <i class=\"fa fa-bookmark-o\"></i>");
#nullable restore
#line 27 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
                                                Write(Model.Blogs.WorkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>  </li>\r\n            </ul>\r\n            <p>\r\n                ");
#nullable restore
#line 31 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
           Write(Html.Raw(Model.Blogs.BestLongDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
            </p>
            <blockquote class=""margin-top-30"">“Sensibus oportere signiferumque id mea. At usu lucilius phaedrum, vix oratio epicurei ne. Eripuit conceptam sea cu, ius minim delectus euripidis cu. Probo nonumy gubergren id nec. In est probo ridens, his laoreet euripidis et.”</blockquote>

            <p>Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source.There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be s");
            WriteLiteral(@"ure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures,</p>
            <div class=""row"">
                <div class=""col-md-6"">

                </div>
                <div class=""col-md-6"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c9115a3088983ef45e9a39e1d2fa3f187ad699c215021", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2655, "~/uploads/images/", 2655, 17, true);
#nullable restore
#line 40 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 2672, Model.Blogs.ImagePath, 2672, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
            </div>

            <div class=""auther-name text-center margin-top-50"">
                <h6 class=""font-12px margin-top-20 margin-bottom-10"">WHITE SHADOW WALKER</h6>
                <span class=""font-16px font-crimson font-italic"">Writer/Personal blog</span>
            </div>



            <div class=""next-prev"">
                <div class=""row"">
                    <div class=""col-md-6 text-left""><a href=""#."" class=""font-16px font-crimson text-uppercase""><i class=""fa fa-long-arrow-left margin-right-15""></i> PREVIOUS Article</a></div>
                    <div class=""col-md-6 text-right""><a href=""#."" class=""font-16px font-crimson text-uppercase"">Next Article<i class=""fa fa-long-arrow-right margin-left-15""></i></a></div>
                </div>
            </div>

");
            WriteLiteral(@"


            <div class=""comments"">

                <!-- Main Heading -->
                <div class=""heading-side-bar margin-bottom-50 margin-top-100"">
                    <h4>Comment (37)</h4>
                </div>
                <ul>

                    <!-- Comments -->
");
#nullable restore
#line 70 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
                     foreach (var item in Model.Comments)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"margin-bottom-30\">\r\n                            <div class=\"media\">\r\n                                <div class=\"media-left\">\r\n                                    <div class=\"avatar\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c9115a3088983ef45e9a39e1d2fa3f187ad699c218348", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"media-body\">\r\n                                    <div class=\"a-com\">\r\n                                        <span class=\"a-name \">");
#nullable restore
#line 79 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><span class=\"date\">24.03.2015 at 10:21</span>\r\n                                        <span class=\"a-name text-color-primary\"> </span><span class=\"date\">");
#nullable restore
#line 80 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
                                                                                                      Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <p class=\"margin-top-20\">\r\n                                            ");
#nullable restore
#line 82 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
                                       Write(item.Massage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                        <a href=""#."" class=""text-right""> REPLAY <i class=""fa fa-reply""></i></a>
                                    </div>
                                </div>
                            </div>
                        </li>
");
#nullable restore
#line 89 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <!-- Comments Replay -->
                    <!--<li class=""com-reply"">
                        <div class=""media"">
                            <div class=""media-left"">
                                <div class=""avatar""><img src=""~/uploads/images/avatar-2.jpg"" alt=""""></div>
                            </div>
                            <div class=""media-body"">
                                <div class=""a-com"">
                                    <span class=""a-name "">JAMMIE LANDING </span><span class=""date"">24.03.2015 at 10:21</span>
                                    <p class=""margin-top-20"">
                                        “Quando feugait duo ei, te erant corpora interpretaris eos. Illud accommodare vituperatoribus an mea. Erat mazim animal
                                        at nam, eam te doctus evertitur, sed decore ornatus”
                                    </p>
                                    <a href=""#."" class=""text-right""> REPLAY <i class=""fa fa");
            WriteLiteral(@"-reply""></i></a>
                                </div>
                            </div>
                        </div>
                    </li>-->
                    <li class=""text-center more-comments""><a href=""#."">MORE COMMENT <i class=""fa fa-angle-down""></i></a></li>
                </ul>

                <!-- Comments Form -->
                <div class=""comment-form"">
                    <!-- Main Heading -->
                    <div class=""heading-side-bar margin-bottom-50 margin-top-80"">
                        <h4>Post to Reply</h4>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9115a3088983ef45e9a39e1d2fa3f187ad699c223062", async() => {
                WriteLiteral("\r\n                        <input");
                BeginWriteAttribute("value", " value=\"", 6763, "\"", 6786, 1);
#nullable restore
#line 119 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
WriteAttributeValue("", 6771, Model.Blogs.Id, 6771, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\" />\r\n                        <ul class=\"row\">\r\n                            <li class=\"col-sm-4\">\r\n\r\n\r\n                                <label>\r\n                                    *NAME\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c9115a3088983ef45e9a39e1d2fa3f187ad699c223984", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 126 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </label>
                            </li>
                            <li class=""col-sm-4"">
                                <label>
                                    *EMAIL ADDRESS
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c9115a3088983ef45e9a39e1d2fa3f187ad699c225898", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 132 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </label>\r\n                            </li>\r\n                            <li class=\"col-sm-4\">\r\n                                <label>\r\n                                    WEBSITE\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c9115a3088983ef45e9a39e1d2fa3f187ad699c227817", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 138 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Website);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </label>\r\n                            </li>\r\n                            <li class=\"col-sm-12\">\r\n                                <label>\r\n                                    SUBJECT\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c9115a3088983ef45e9a39e1d2fa3f187ad699c229739", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 144 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Subject);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </label>\r\n                            </li>\r\n                            <li class=\"col-sm-12\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9115a3088983ef45e9a39e1d2fa3f187ad699c231567", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 148 "C:\Users\Yusif\Desktop\MotiCvLayihe\MotiCv\MotiCv\Views\Blog\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Massage);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </li>
                            <li class=""col-sm-12"">
                                <button type=""submit"" class=""btn btn-dark"">POST COMMENT </button>
                            </li>
                        </ul>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </article>\r\n    </div>\r\n</div>\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            console.log(""test"");
            $('#comment_form').submit(function (e) {
                e.preventDefault();
                const valid = $(e.currentTarget).valid();

                if (valid != true) {
                    return;
                }
                const formdata = new FormData(e.currentTarget);
                console.log(""test1"");

                $.ajax({
                    url: '/Blog/Details',
                    type: 'post',
                    data: formdata,
                    contentType: false,
                    processData: false,
                    success: function (response) {
                        if (response.error == false) {
                            location.reload();
                            alert(response.massage);
                        }
                        else {
                            alert(respose.massage);
                        }
                 ");
                WriteLiteral("   },\r\n                    error: function (response) {\r\n\r\n                    }\r\n                });\r\n\r\n            });\r\n        });\r\n    </script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9115a3088983ef45e9a39e1d2fa3f187ad699c236123", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9115a3088983ef45e9a39e1d2fa3f187ad699c237224", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9115a3088983ef45e9a39e1d2fa3f187ad699c238325", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForBlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591