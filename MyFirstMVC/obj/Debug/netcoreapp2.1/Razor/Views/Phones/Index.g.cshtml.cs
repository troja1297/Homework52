#pragma checksum "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be7a73574bf4a63710bcda8ad07b3a7d83eba889"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phones_Index), @"mvc.1.0.view", @"/Views/Phones/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Phones/Index.cshtml", typeof(AspNetCore.Views_Phones_Index))]
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
#line 1 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
using MyFirstMVC.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be7a73574bf4a63710bcda8ad07b3a7d83eba889", @"/Views/Phones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b2d0ae5ac44d96867875e92a2aaa9c9ab82965c", @"/Views/_ViewImports.cshtml")]
    public class Views_Phones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModelPhone>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Phones", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(57, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
  

    ViewData["Title"] = "Home Page";


#line default
#line hidden
            BeginContext(102, 8, true);
            WriteLiteral("\n<br />\n");
            EndContext();
            BeginContext(110, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e960872ff57849738275eb4a28a47b3f", async() => {
                BeginContext(133, 7, true);
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
            BeginContext(144, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 13 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
 using (Html.BeginForm("Index", "Phones", FormMethod.Get))

{
    

#line default
#line hidden
            BeginContext(212, 29, false);
#line 16 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
Write(Html.Label("Name", "Модель "));

#line default
#line hidden
            EndContext();
            BeginContext(247, 32, false);
#line 17 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
Write(Html.TextBox("name", Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(281, 59, true);
            WriteLiteral("    <select name=\"companyId\" class=\"form-control\">\n        ");
            EndContext();
            BeginContext(340, 17, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "116100b032ae45e1acda0dc63eef1167", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(357, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 21 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
         foreach (Company comp in Model.Companies)
        {
            if (Model.Company != null && Model.Company.Id == comp.Id)
            {

#line default
#line hidden
            BeginContext(503, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(519, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caa84964323841de9e99bb9f62be0270", async() => {
                BeginContext(565, 9, false);
#line 25 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
                                                        Write(comp.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 25 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
                   WriteLiteral(comp.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(583, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 26 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(629, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(645, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3f42352d37447e8a9b331d7a63877ab", async() => {
                BeginContext(671, 9, false);
#line 29 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
                                    Write(comp.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 29 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
                   WriteLiteral(comp.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(689, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 30 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
            }

        }

#line default
#line hidden
            BeginContext(715, 14, true);
            WriteLiteral("    </select>\n");
            EndContext();
            BeginContext(730, 52, true);
            WriteLiteral("    <input type=\"submit\" class=\"btn btn-success\" />\n");
            EndContext();
#line 36 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
}

#line default
#line hidden
            BeginContext(784, 48, true);
            WriteLiteral("\n<br />\n\n\n<table class=\"table table-bordered\">\n\n");
            EndContext();
#line 43 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
     foreach (Phone p in Model.Phones)

    {


#line default
#line hidden
            BeginContext(879, 30, true);
            WriteLiteral("        <tr>\n\n            <td>");
            EndContext();
            BeginContext(910, 6, false);
#line 49 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
           Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(916, 41, true);
            WriteLiteral("</td>\n\n            <td>\n\n                ");
            EndContext();
            BeginContext(957, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41d9729fe02f4749b1395f4bcbcb4b8c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
                                                                           WriteLiteral(p);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("a", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1037, 35, true);
            WriteLiteral("\n            </td>\n            <td>");
            EndContext();
            BeginContext(1073, 7, false);
#line 55 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
           Write(p.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1080, 21, true);
            WriteLiteral("</td>\n\n        </tr>\n");
            EndContext();
#line 58 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"

    }

#line default
#line hidden
            BeginContext(1108, 11, true);
            WriteLiteral("\n</table>\n\n");
            EndContext();
#line 63 "/home/vandreev/RiderProjects/phonesstore52/MyFirstMVC/MyFirstMVC/Views/Phones/Index.cshtml"
   await Html.RenderPartialAsync("_Calendar"); 

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModelPhone> Html { get; private set; }
    }
}
#pragma warning restore 1591
