#pragma checksum "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/weddingPlanner/weddingPlanner/Views/Home/ShowWeddingInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c02cd6a3e8934d1a60cc49141363b6c4653f7940"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(weddingPlanner.Home.Views_Home_ShowWeddingInfo), @"mvc.1.0.view", @"/Views/Home/ShowWeddingInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowWeddingInfo.cshtml", typeof(weddingPlanner.Home.Views_Home_ShowWeddingInfo))]
namespace weddingPlanner.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/weddingPlanner/weddingPlanner/Views/Home/ShowWeddingInfo.cshtml"
using weddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c02cd6a3e8934d1a60cc49141363b6c4653f7940", @"/Views/Home/ShowWeddingInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"148461db9f07b0e19c8d8f6fab8c82a3ce0e2c0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowWeddingInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c02cd6a3e8934d1a60cc49141363b6c4653f79403902", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(93, 213, true);
            WriteLiteral("\n<link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\n");
            EndContext();
            BeginContext(306, 398, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c02cd6a3e8934d1a60cc49141363b6c4653f79405356", async() => {
                BeginContext(312, 87, true);
                WriteLiteral("\n<nav class=\"navbar navbar-expand-lg navbar-light bg-dark\">\n    <h1 class=\"white col\"> ");
                EndContext();
                BeginContext(400, 14, false);
#line 7 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/weddingPlanner/weddingPlanner/Views/Home/ShowWeddingInfo.cshtml"
                      Write(ViewBag.W.WOne);

#line default
#line hidden
                EndContext();
                BeginContext(414, 5, true);
                WriteLiteral(" and ");
                EndContext();
                BeginContext(420, 14, false);
#line 7 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/weddingPlanner/weddingPlanner/Views/Home/ShowWeddingInfo.cshtml"
                                          Write(ViewBag.W.WTwo);

#line default
#line hidden
                EndContext();
                BeginContext(434, 134, true);
                WriteLiteral("\'s Wedding</h1>\n    <a href=\"/dashboard\" class=\"col-1\">Dashboard</a>\n    <a href=\"/logout\" class=\"col-1\">Logout</a>\n</nav>\n\n<h3>Date: ");
                EndContext();
                BeginContext(569, 14, false);
#line 12 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/weddingPlanner/weddingPlanner/Views/Home/ShowWeddingInfo.cshtml"
     Write(ViewBag.W.When);

#line default
#line hidden
                EndContext();
                BeginContext(583, 23, true);
                WriteLiteral("</h3>\n<h3>Guests:</h3>\n");
                EndContext();
#line 14 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/weddingPlanner/weddingPlanner/Views/Home/ShowWeddingInfo.cshtml"
 foreach (var g in ViewBag.W.RSVPs)
{

#line default
#line hidden
                BeginContext(644, 8, true);
                WriteLiteral("    <h6>");
                EndContext();
                BeginContext(653, 17, false);
#line 16 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/weddingPlanner/weddingPlanner/Views/Home/ShowWeddingInfo.cshtml"
   Write(g.Guest.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(670, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(672, 16, false);
#line 16 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/weddingPlanner/weddingPlanner/Views/Home/ShowWeddingInfo.cshtml"
                      Write(g.Guest.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(688, 6, true);
                WriteLiteral("</h6>\n");
                EndContext();
#line 17 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/weddingPlanner/weddingPlanner/Views/Home/ShowWeddingInfo.cshtml"
}

#line default
#line hidden
                BeginContext(696, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
