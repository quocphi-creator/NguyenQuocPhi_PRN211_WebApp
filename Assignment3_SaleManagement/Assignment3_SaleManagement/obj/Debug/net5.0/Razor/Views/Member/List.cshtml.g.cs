#pragma checksum "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5afff63fad04a06a32c66a1fcd3d8c428241de73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_List), @"mvc.1.0.view", @"/Views/Member/List.cshtml")]
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
#line 4 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml"
using Assignment3_SaleManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5afff63fad04a06a32c66a1fcd3d8c428241de73", @"/Views/Member/List.cshtml")]
    public class Views_Member_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Member>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml"
  
    List<Member> members = (List<Member>)ViewBag.Members;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5afff63fad04a06a32c66a1fcd3d8c428241de733363", async() => {
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5afff63fad04a06a32c66a1fcd3d8c428241de734337", async() => {
                WriteLiteral("\r\n    <h1>Hello Member view</h1>\r\n    <select>\r\n");
#nullable restore
#line 21 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml"
          
            foreach (Member m in members)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <option");
                BeginWriteAttribute("value", " value=\"", 455, "\"", 474, 1);
#nullable restore
#line 24 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml"
WriteAttributeValue("", 463, m.MemberId, 463, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\r\n                    ");
#nullable restore
#line 25 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml"
               Write(m.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </option>\r\n");
#nullable restore
#line 27 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </select>


    <table border=""1"" style=""margin-top: 20px"">
        <thead>
            <tr>
                <th>Member ID</th>
                <th>Password</th>
                <th>Member Email</th>
                <th>Member Company</th>
                <th>Member City</th>
                <th>Member Country</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 44 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml"
              
                foreach (Member m in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml"
                       Write(m.MemberId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml"
                       Write(m.Password);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml"
                       Write(m.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml"
                       Write(m.CompanyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml"
                       Write(m.City);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml"
                       Write(m.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 55 "C:\Users\ADMIN\Documents\GitHub\NguyenQuocPhi_PRN211_WebApp\Assignment3_SaleManagement\Assignment3_SaleManagement\Views\Member\List.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591
