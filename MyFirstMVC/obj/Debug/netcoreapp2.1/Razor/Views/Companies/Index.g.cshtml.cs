#pragma checksum "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Companies/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7580138c7dd505ac43d3688aa21c2d43078493b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Companies_Index), @"mvc.1.0.view", @"/Views/Companies/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Companies/Index.cshtml", typeof(AspNetCore.Views_Companies_Index))]
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
#line 1 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/_ViewImports.cshtml"
using MyFirstMVC;

#line default
#line hidden
#line 2 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/_ViewImports.cshtml"
using MyFirstMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7580138c7dd505ac43d3688aa21c2d43078493b", @"/Views/Companies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b2d0ae5ac44d96867875e92a2aaa9c9ab82965c", @"/Views/_ViewImports.cshtml")]
    public class Views_Companies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Company>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Companies/Index.cshtml"
  

    ViewData["Title"] = "Companies";


#line default
#line hidden
            BeginContext(73, 8, true);
            WriteLiteral("\n<br />\n");
            EndContext();
            BeginContext(81, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df3925433d9b46f4a59ebab23a1fe6de", async() => {
                BeginContext(104, 7, true);
                WriteLiteral("Создать");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(115, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 11 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Companies/Index.cshtml"
 using (Html.BeginForm("Index", "Companies", FormMethod.Get))


{

#line default
#line hidden
            BeginContext(181, 6, true);
            WriteLiteral("<br />");
            EndContext();
#line 14 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Companies/Index.cshtml"
       }

#line default
#line hidden
            BeginContext(189, 39, true);
            WriteLiteral("\n<table class=\"table table-bordered\">\n\n");
            EndContext();
#line 18 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Companies/Index.cshtml"
     foreach (Company p in Model)
    {

#line default
#line hidden
            BeginContext(268, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(298, 6, false);
#line 21 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Companies/Index.cshtml"
           Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(304, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(327, 7, false);
#line 22 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Companies/Index.cshtml"
           Write(p.Email);

#line default
#line hidden
            EndContext();
            BeginContext(334, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(357, 16, false);
#line 23 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Companies/Index.cshtml"
           Write(p.FoundationDate);

#line default
#line hidden
            EndContext();
            BeginContext(373, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(395, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3e3e435233a4e6b899020d43e12dc1e", async() => {
                BeginContext(437, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Companies/Index.cshtml"
                                       WriteLiteral(p.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(445, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 26 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Companies/Index.cshtml"

    }

#line default
#line hidden
            BeginContext(472, 9, true);
            WriteLiteral("\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Company>> Html { get; private set; }
    }
}
#pragma warning restore 1591
