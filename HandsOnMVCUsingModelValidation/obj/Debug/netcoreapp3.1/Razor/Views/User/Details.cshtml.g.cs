#pragma checksum "D:\Asp.net\HandsOnMVCUsingModelValidation\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c6589806e126078dd9ca7548ab3ba4b2194ed4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Details), @"mvc.1.0.view", @"/Views/User/Details.cshtml")]
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
#line 1 "D:\Asp.net\HandsOnMVCUsingModelValidation\Views\_ViewImports.cshtml"
using HandsOnMVCUsingModelValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp.net\HandsOnMVCUsingModelValidation\Views\_ViewImports.cshtml"
using HandsOnMVCUsingModelValidation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c6589806e126078dd9ca7548ab3ba4b2194ed4a", @"/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee81383daee2a42233f8742c22b790cb82301137", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HandsOnMVCUsingModelValidation.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Asp.net\HandsOnMVCUsingModelValidation\Views\User\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome ");
#nullable restore
#line 7 "D:\Asp.net\HandsOnMVCUsingModelValidation\Views\User\Details.cshtml"
       Write(Html.DisplayFor(m=>m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h6>Pwd:");
#nullable restore
#line 8 "D:\Asp.net\HandsOnMVCUsingModelValidation\Views\User\Details.cshtml"
   Write(Html.DisplayFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 9 "D:\Asp.net\HandsOnMVCUsingModelValidation\Views\User\Details.cshtml"
Write(Html.ActionLink("LogOut","Login","User"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandsOnMVCUsingModelValidation.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
