#pragma checksum "C:\Users\Serkan\Desktop\Bitirme Projem\BilgeHotel\BilgeHotel.WebUI\Views\Reservation\ReservationComplete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d298a4d491767df44ec6eaaab5e99be5ba56a929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_ReservationComplete), @"mvc.1.0.view", @"/Views/Reservation/ReservationComplete.cshtml")]
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
#line 1 "C:\Users\Serkan\Desktop\Bitirme Projem\BilgeHotel\BilgeHotel.WebUI\Views\_ViewImports.cshtml"
using BilgeHotel.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Serkan\Desktop\Bitirme Projem\BilgeHotel\BilgeHotel.WebUI\Views\_ViewImports.cshtml"
using BilgeHotel.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Serkan\Desktop\Bitirme Projem\BilgeHotel\BilgeHotel.WebUI\Views\_ViewImports.cshtml"
using BilgeHotel.ViewModels.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Serkan\Desktop\Bitirme Projem\BilgeHotel\BilgeHotel.WebUI\Views\_ViewImports.cshtml"
using BilgeHotel.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Serkan\Desktop\Bitirme Projem\BilgeHotel\BilgeHotel.WebUI\Views\_ViewImports.cshtml"
using BilgeHotel.WebUI.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Serkan\Desktop\Bitirme Projem\BilgeHotel\BilgeHotel.WebUI\Views\_ViewImports.cshtml"
using BilgeHotel.WebUI.Models.ViewModels.APIPostVM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d298a4d491767df44ec6eaaab5e99be5ba56a929", @"/Views/Reservation/ReservationComplete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09f4e7a0f308b9eefaa9a2ad7e9f403c944fe4e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_ReservationComplete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
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
#nullable restore
#line 2 "C:\Users\Serkan\Desktop\Bitirme Projem\BilgeHotel\BilgeHotel.WebUI\Views\Reservation\ReservationComplete.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d298a4d491767df44ec6eaaab5e99be5ba56a9294479", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ReservationComplete</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d298a4d491767df44ec6eaaab5e99be5ba56a9295552", async() => {
                WriteLiteral("\r\n    <h2>Ödeme Tamamlandı. Rezervasyon Oluşturuldu.</h2>\r\n    ");
#nullable restore
#line 15 "C:\Users\Serkan\Desktop\Bitirme Projem\BilgeHotel\BilgeHotel.WebUI\Views\Reservation\ReservationComplete.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <a href=\"/\" class=\"btn btn-primary\">Anasayfaya Dön.</a>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
