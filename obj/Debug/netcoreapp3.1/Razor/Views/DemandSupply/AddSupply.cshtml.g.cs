#pragma checksum "C:\Users\himanshu\source\repos\PharmacyMedicineSupplyPortal\Views\DemandSupply\AddSupply.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58ca2fc325ea8abc78be3494d7de301c3b9d3a83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DemandSupply_AddSupply), @"mvc.1.0.view", @"/Views/DemandSupply/AddSupply.cshtml")]
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
#line 1 "C:\Users\himanshu\source\repos\PharmacyMedicineSupplyPortal\Views\_ViewImports.cshtml"
using PharmacyMedicineSupplyPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\himanshu\source\repos\PharmacyMedicineSupplyPortal\Views\_ViewImports.cshtml"
using PharmacyMedicineSupplyPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58ca2fc325ea8abc78be3494d7de301c3b9d3a83", @"/Views/DemandSupply/AddSupply.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9685d027ff493b0e119fe978bfd7137e24be02cc", @"/Views/_ViewImports.cshtml")]
    public class Views_DemandSupply_AddSupply : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PharmacyMedicineSupplyPortal.Models.PharmacyMedicineSupply>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\himanshu\source\repos\PharmacyMedicineSupplyPortal\Views\DemandSupply\AddSupply.cshtml"
      
    ViewData["Title"] = "AddSupply";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>AddSupply</h1>\r\n\r\n    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58ca2fc325ea8abc78be3494d7de301c3b9d3a833852", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead class=\"thead-dark\"\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\himanshu\source\repos\PharmacyMedicineSupplyPortal\Views\DemandSupply\AddSupply.cshtml"
           Write(Html.DisplayNameFor(model => model.PharmacyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\himanshu\source\repos\PharmacyMedicineSupplyPortal\Views\DemandSupply\AddSupply.cshtml"
           Write(Html.DisplayNameFor(model => model.MedicineName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\himanshu\source\repos\PharmacyMedicineSupplyPortal\Views\DemandSupply\AddSupply.cshtml"
           Write(Html.DisplayNameFor(model => model.SupplyCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\himanshu\source\repos\PharmacyMedicineSupplyPortal\Views\DemandSupply\AddSupply.cshtml"
             foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "C:\Users\himanshu\source\repos\PharmacyMedicineSupplyPortal\Views\DemandSupply\AddSupply.cshtml"
               Write(Html.DisplayFor(modelItem => item.PharmacyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "C:\Users\himanshu\source\repos\PharmacyMedicineSupplyPortal\Views\DemandSupply\AddSupply.cshtml"
               Write(Html.DisplayFor(modelItem => item.MedicineName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\himanshu\source\repos\PharmacyMedicineSupplyPortal\Views\DemandSupply\AddSupply.cshtml"
               Write(Html.DisplayFor(modelItem => item.SupplyCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\himanshu\source\repos\PharmacyMedicineSupplyPortal\Views\DemandSupply\AddSupply.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PharmacyMedicineSupplyPortal.Models.PharmacyMedicineSupply>> Html { get; private set; }
    }
}
#pragma warning restore 1591
