#pragma checksum "D:\PROGRAMSHERE\c#\c-Selenium_Testing_Practice\TestWebApp\TestWebApp\Pages\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fd7a49b5ba2b73f9138e5082cf492bad2dd1566"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TestWebApp.Pages.Pages_Form), @"mvc.1.0.razor-page", @"/Pages/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Form.cshtml", typeof(TestWebApp.Pages.Pages_Form), null)]
namespace TestWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\PROGRAMSHERE\c#\c-Selenium_Testing_Practice\TestWebApp\TestWebApp\Pages\_ViewImports.cshtml"
using TestWebApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fd7a49b5ba2b73f9138e5082cf492bad2dd1566", @"/Pages/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b4e2886bc862492e74d3eb373119b462d17fb81", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Form : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("frm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\PROGRAMSHERE\c#\c-Selenium_Testing_Practice\TestWebApp\TestWebApp\Pages\Form.cshtml"
  
    ViewData["Title"] = "FormTest";

#line default
#line hidden
            BeginContext(69, 1621, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ea4c4a1522c4f12b932247a554da77f", async() => {
                BeginContext(86, 1597, true);
                WriteLiteral(@"
    <div class=""form-row"">
        <div class=""form-group col-md-6"">
            <label for=""inputEmail4"">Email</label>
            <input type=""email"" class=""form-control"" id=""inputEmail4"" placeholder="""">
        </div>
        <div class=""form-group col-md-6"">
            <label for=""inputPassword4"">Password</label>
            <input type=""password"" class=""form-control"" id=""inputPassword4"" placeholder="""">
        </div>
    </div>
    <div class=""form-group"">
        <label for=""inputAddress"">Address</label>
        <input type=""text"" class=""form-control"" id=""inputAddress"" placeholder="""">
    </div>
    <div class=""form-group"">
        <label for=""inputAddress2"">Address 2</label>
        <input type=""text"" class=""form-control"" id=""inputAddress2"" placeholder="""">
    </div>
    <div class=""form-row"">
        <div class=""form-group col-md-6"">
            <label for=""inputCity"">City</label>
            <input type=""text"" class=""form-control"" id=""inputCity"">
        </div>
       
    ");
                WriteLiteral(@"    <div class=""form-group col-md-2"">
            <label for=""inputZip"">Zip</label>
            <input type=""text"" class=""form-control"" id=""inputZip"">
        </div>
    </div>
    <div class=""form-group"">
        <div class=""form-check"">
            <input class=""form-check-input"" type=""checkbox"" id=""gridCheck"">
            <label class=""form-check-label"" for=""gridCheck"">
                Check me out
            </label>
        </div>
    </div>
    <button type=""submit"" class=""btn btn-primary"" id =""btnSubmit"" onclick=""checkBlanks()"">Sign in</button>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1690, 979, true);
            WriteLiteral(@"


<script>
    function submitted() {
        alert(""Submited Form"");
    }

    function checkBlanks() {
        if (document.frm.inputEmail4.value == """") {
            alert(""Email is blank"");
        }
        else if (document.frm.inputPassword4.value == """") {
            alert(""password is blank"");
        }
        else if (document.frm.inputAddress.value == """") {
            alert(""address is blank"");
        }
        /*
    else if (document.getElementById(""inputAddress2"").innerHTML == """") {
        alert(""checkbox is blank"");
    }
    */

        else if (document.frm.inputCity.value == """") {
            alert(""city is blank"");
        }
        else if (document.frm.inputZip.value == """") {
            alert(""zip is blank"");
        }
        else if (!document.getElementById(""gridCheck"").checked) {
            alert(""checkbox is blank"");
        }
        else {
            submitted();
        }
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FormModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FormModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FormModel>)PageContext?.ViewData;
        public FormModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
