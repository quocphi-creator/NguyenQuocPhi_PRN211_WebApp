#pragma checksum "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb57d11164976b0071406a8eec52fb92895e943d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_List), @"mvc.1.0.view", @"/Views/Order/List.cshtml")]
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
#line 5 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
using Assignment3_SaleManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb57d11164976b0071406a8eec52fb92895e943d", @"/Views/Order/List.cshtml")]
    public class Views_Order_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Order/List"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Order/Insert"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
  
    List<Member> members = (List<Member>)ViewBag.Members;
    int CurMemberId = (int)ViewBag.CurrentMemberId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb57d11164976b0071406a8eec52fb92895e943d4646", async() => {
                WriteLiteral("\r\n    <title>Order List</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb57d11164976b0071406a8eec52fb92895e943d5645", async() => {
                WriteLiteral("\r\n    Hello orders\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb57d11164976b0071406a8eec52fb92895e943d5927", async() => {
                    WriteLiteral("\r\n        <select name=\"id\" onchange=\"this.form.submit()\">\r\n");
                    WriteLiteral("                <option value=\"0\">All Order</option>\r\n");
#nullable restore
#line 24 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                foreach (Member m in members)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <option");
                    BeginWriteAttribute("value", " value=\"", 678, "\"", 697, 1);
#nullable restore
#line 26 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
WriteAttributeValue("", 686, m.MemberId, 686, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" ");
#nullable restore
#line 26 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                                            Write((m.MemberId == CurMemberId) ? "selected" : "");

#line default
#line hidden
#nullable disable
                    WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                                                                                            Write(m.Email);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</option>\r\n");
#nullable restore
#line 27 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                    WriteLiteral("        </select>\r\n    ");
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
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 33 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
      
        if (Model.Count() == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h1>No data to display</h1>\r\n");
#nullable restore
#line 37 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <table border=""1"" style=""margin-top: 20px"">
                <thead>
                    <tr>
                        <th>OrderID</th>
                        <th>Email</th>
                        <th>Country</th>
                        <th>City</th>
                        <th>Company</th>
                        <th>Order Date</th>
                        <th>Require Date</th>
                        <th>Ship Date</th>
                        <th>Freight</th>
                        <th colspan=""3"">Action</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 56 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                      
                        foreach (Order o in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 60 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                               Write(o.OrderId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 61 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                               Write(o.Member.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 62 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                               Write(o.Member.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 63 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                               Write(o.Member.City);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 64 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                               Write(o.Member.CompanyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 65 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                               Write(o.OrderDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 66 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                               Write(o.RequiredDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 67 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                               Write(o.ShippedDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 68 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                               Write(o.Freight);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb57d11164976b0071406a8eec52fb92895e943d14043", async() => {
                    WriteLiteral("Insert");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                                <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb57d11164976b0071406a8eec52fb92895e943d15220", async() => {
                    WriteLiteral("Delte");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2363, "~/Order/Delete/", 2363, 15, true);
#nullable restore
#line 70 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
AddHtmlAttributeValue("", 2378, o.OrderId, 2378, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                                <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb57d11164976b0071406a8eec52fb92895e943d16918", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2451, "~/Order/FormEdit/", 2451, 17, true);
#nullable restore
#line 71 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
AddHtmlAttributeValue("", 2468, o.OrderId, 2468, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                                \r\n\r\n                            </tr>\r\n");
#nullable restore
#line 75 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 79 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Order\List.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
