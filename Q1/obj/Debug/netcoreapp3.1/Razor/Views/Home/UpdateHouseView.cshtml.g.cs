#pragma checksum "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16d9bb28cf57d6b10cd96f81cd0cd3cf99d6dff3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UpdateHouseView), @"mvc.1.0.view", @"/Views/Home/UpdateHouseView.cshtml")]
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
#line 1 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\_ViewImports.cshtml"
using Q1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\_ViewImports.cshtml"
using Q1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16d9bb28cf57d6b10cd96f81cd0cd3cf99d6dff3", @"/Views/Home/UpdateHouseView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f42f2eb4340d2d1de0e2b1a31479cbdb983dbf07", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UpdateHouseView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Q1.Models.Model>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
  
    ViewBag.Title = "UpdateHouseView"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Realtor Portal: Update House Information</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("<fieldset>\r\n    <div class=\"editor-field\">\r\n        Price\r\n    </div>\r\n\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 19 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.EditorFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 20 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.ValidationMessageFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"editor-label\">\r\n        Address\r\n    </div>\r\n\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 28 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.EditorFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 29 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.ValidationMessageFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"editor-label\">\r\n        City\r\n    </div>\r\n\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 37 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.EditorFor(model => model.city));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 38 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.ValidationMessageFor(model => model.city));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"editor-label\">\r\n        Zip Code\r\n    </div>\r\n\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 46 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.EditorFor(model => model.zipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 47 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.ValidationMessageFor(model => model.zipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"editor-label\">\r\n        Year Built\r\n    </div>\r\n\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 55 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.EditorFor(model => model.yearBuilt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 56 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.ValidationMessageFor(model => model.yearBuilt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"editor-label\">\r\n        Property Type\r\n    </div>\r\n\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 64 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.EditorFor(model => model.propertyType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 65 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.ValidationMessageFor(model => model.propertyType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"editor-label\">\r\n        Square Feet\r\n    </div>\r\n\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 73 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.EditorFor(model => model.squareFeet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 74 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.ValidationMessageFor(model => model.squareFeet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"editor-label\">\r\n        Bedrooms\r\n    </div>\r\n\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 82 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.EditorFor(model => model.numberOfBedrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 83 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.ValidationMessageFor(model => model.numberOfBedrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"editor-label\">\r\n        Bathrooms\r\n    </div>\r\n\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 91 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.EditorFor(model => model.numberOfBathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 92 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.ValidationMessageFor(model => model.numberOfBathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"editor-label\">\r\n        Garage Size\r\n    </div>\r\n\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 100 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.EditorFor(model => model.numberOfCarGarage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 101 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
   Write(Html.ValidationMessageFor(model => model.numberOfCarGarage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div><br>\r\n\r\n    <p>\r\n        <input type=\"submit\" value=\"Create\" />\r\n    </p>\r\n</fieldset>\r\n");
#nullable restore
#line 108 "C:\Users\matth\Documents\UM-Dearborn Classes\CIS 476 Architecture\Final Exam Stuff\Q1\Q1\Views\Home\UpdateHouseView.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Q1.Models.Model> Html { get; private set; }
    }
}
#pragma warning restore 1591