#pragma checksum "H:\Work\Sadin.ir\Articles\003-FormGenerator\FormGenerator\Views\ManageForms\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "744075e13ba5fdf80cb92480c197dd49c69b04ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageForms_Form), @"mvc.1.0.view", @"/Views/ManageForms/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ManageForms/Form.cshtml", typeof(AspNetCore.Views_ManageForms_Form))]
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
#line 1 "H:\Work\Sadin.ir\Articles\003-FormGenerator\FormGenerator\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#line 2 "H:\Work\Sadin.ir\Articles\003-FormGenerator\FormGenerator\Views\_ViewImports.cshtml"
using Project.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"744075e13ba5fdf80cb92480c197dd49c69b04ba", @"/Views/ManageForms/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"306452c499e30af805671bff6227738d83c4eec9", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageForms_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Form>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/ManageForms/Form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(13, 48, true);
            WriteLiteral("\r\n<input id=\"formId\" name=\"formId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 61, "\"", 78, 1);
#line 3 "H:\Work\Sadin.ir\Articles\003-FormGenerator\FormGenerator\Views\ManageForms\Form.cshtml"
WriteAttributeValue("", 69, Model.Id, 69, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(79, 4, true);
            WriteLiteral("/>\r\n");
            EndContext();
            BeginContext(83, 310, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7195eed5f9354dbd8614735204d37cdf", async() => {
                BeginContext(166, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "H:\Work\Sadin.ir\Articles\003-FormGenerator\FormGenerator\Views\ManageForms\Form.cshtml"
     foreach(var item in Model.Fields)
    {
        

#line default
#line hidden
                BeginContext(225, 14, true);
                WriteLiteral("        <input");
                EndContext();
                BeginWriteAttribute("type", " type=\"", 239, "\"", 256, 1);
#line 8 "H:\Work\Sadin.ir\Articles\003-FormGenerator\FormGenerator\Views\ManageForms\Form.cshtml"
WriteAttributeValue("", 246, item.Type, 246, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 257, "\"", 275, 1);
#line 8 "H:\Work\Sadin.ir\Articles\003-FormGenerator\FormGenerator\Views\ManageForms\Form.cshtml"
WriteAttributeValue("", 264, item.Title, 264, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 276, "\"", 292, 1);
#line 8 "H:\Work\Sadin.ir\Articles\003-FormGenerator\FormGenerator\Views\ManageForms\Form.cshtml"
WriteAttributeValue("", 281, item.Title, 281, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(293, 19, true);
                WriteLiteral("/>\r\n        <br/>\r\n");
                EndContext();
#line 10 "H:\Work\Sadin.ir\Articles\003-FormGenerator\FormGenerator\Views\ManageForms\Form.cshtml"
    }

#line default
#line hidden
                BeginContext(319, 67, true);
                WriteLiteral("    <input type=\"button\" onclick=\"submitForm()\" value=\"ثبت فرم\"/>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 4 "H:\Work\Sadin.ir\Articles\003-FormGenerator\FormGenerator\Views\ManageForms\Form.cshtml"
AddHtmlAttributeValue("", 93, Model.Name, 93, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 4 "H:\Work\Sadin.ir\Articles\003-FormGenerator\FormGenerator\Views\ManageForms\Form.cshtml"
AddHtmlAttributeValue("", 112, Model.Name, 112, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(393, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(416, 120, true);
                WriteLiteral("\r\n    <script>\r\n        function submitForm()\r\n        {\r\n            \r\n            var form = document.getElementById(\'");
                EndContext();
                BeginContext(537, 10, false);
#line 20 "H:\Work\Sadin.ir\Articles\003-FormGenerator\FormGenerator\Views\ManageForms\Form.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(547, 41, true);
                WriteLiteral("\') || document.querySelector(\'form[name=\"");
                EndContext();
                BeginContext(589, 10, false);
#line 20 "H:\Work\Sadin.ir\Articles\003-FormGenerator\FormGenerator\Views\ManageForms\Form.cshtml"
                                                                                               Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(599, 1420, true);
                WriteLiteral(@"""]');
            var json = Array.from(new FormData(form)).map(function(e,i) {
                if(typeof(e[1]) != ""object"")
                {
                    this[e[0]]=e[1];
                    return this;
                }
            }.bind({}))[0];

            console.log(json);

            
            
            var fdata = new FormData();
            
            var frmId = $('#formId').val();
            fdata.append(""FormId"",frmId);

            var names = """";
            $('input[type=""file""]').each(function(a, b) {
                var fileInput = $('input[type=""file""]')[a];
                if (fileInput.files.length > 0) {
                    var file = fileInput.files[0];
                    names += fileInput.name + ""|"" + file.name + ""="";
                    fdata.append(""Files"", file);
                }
            });
            fdata.append(""FilesName"",names);
           
            
            var str = JSON.stringify(json);

            fdata.ap");
                WriteLiteral(@"pend(""FormValues"",str);
            
            $.ajax({
            url: '/ManageForms/Form/' + frmId,
            type : 'POST',
            processData : false,
            contentType : false,
            
            data: fdata
            
            })
            .done(function(result) {
                console.log(result);
            })
        }
    </script>    
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Form> Html { get; private set; }
    }
}
#pragma warning restore 1591