#pragma checksum "D:\minhhoang.github.io-main\minhhoang.github.io-main\Webtt\Areas\Admin\Views\HomeAd\ViewRecord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ca86e91d9665cf168b018fd03a4919ab0d8dccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HomeAd_ViewRecord), @"mvc.1.0.view", @"/Areas/Admin/Views/HomeAd/ViewRecord.cshtml")]
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
#line 1 "D:\minhhoang.github.io-main\minhhoang.github.io-main\Webtt\Areas\Admin\Views\_ViewImports.cshtml"
using Webtt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\minhhoang.github.io-main\minhhoang.github.io-main\Webtt\Areas\Admin\Views\_ViewImports.cshtml"
using Webtt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca86e91d9665cf168b018fd03a4919ab0d8dccd", @"/Areas/Admin/Views/HomeAd/ViewRecord.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02615380522d494fe8502c6b604fce5221ef8e34", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HomeAd_ViewRecord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Webtt.Models.Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRecord", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HomeAd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\minhhoang.github.io-main\minhhoang.github.io-main\Webtt\Areas\Admin\Views\HomeAd\ViewRecord.cshtml"
   ViewData["Title"] = "Thư liên hệ";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"Add\">\n    <div class=\"Add-product\">\n        <h2>Thư liên hệ : ");
#nullable restore
#line 9 "D:\minhhoang.github.io-main\minhhoang.github.io-main\Webtt\Areas\Admin\Views\HomeAd\ViewRecord.cshtml"
                     Write(ViewBag.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
    </div>
</div>
<div class=""details-product"">
    <div class=""products"">
        
        <table>
            <thead>
                <tr>
                    <td>Tên người liên hệ</td>
                    <td>Số điện thoại</td>
                    <td>Email</td>
                    <td>Nội dung</td>
                    <td>Tùy chọn</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 26 "D:\minhhoang.github.io-main\minhhoang.github.io-main\Webtt\Areas\Admin\Views\HomeAd\ViewRecord.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 29 "D:\minhhoang.github.io-main\minhhoang.github.io-main\Webtt\Areas\Admin\Views\HomeAd\ViewRecord.cshtml"
                   Write(item.ContactName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 30 "D:\minhhoang.github.io-main\minhhoang.github.io-main\Webtt\Areas\Admin\Views\HomeAd\ViewRecord.cshtml"
                   Write(item.ContactNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 31 "D:\minhhoang.github.io-main\minhhoang.github.io-main\Webtt\Areas\Admin\Views\HomeAd\ViewRecord.cshtml"
                   Write(item.ContactEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 32 "D:\minhhoang.github.io-main\minhhoang.github.io-main\Webtt\Areas\Admin\Views\HomeAd\ViewRecord.cshtml"
                   Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ca86e91d9665cf168b018fd03a4919ab0d8dccd6409", async() => {
                WriteLiteral("\n                            <i class=\" delete fa fa-trash\" aria-hidden=\"true\"></i>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "D:\minhhoang.github.io-main\minhhoang.github.io-main\Webtt\Areas\Admin\Views\HomeAd\ViewRecord.cshtml"
                                                                               WriteLiteral(item.ContactId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 39 "D:\minhhoang.github.io-main\minhhoang.github.io-main\Webtt\Areas\Admin\Views\HomeAd\ViewRecord.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Webtt.Models.Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
