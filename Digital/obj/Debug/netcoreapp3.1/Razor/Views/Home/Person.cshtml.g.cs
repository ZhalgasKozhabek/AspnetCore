#pragma checksum "/Users/zhalgas/Projects/Digital/Digital/Views/Home/Person.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aba63f0c59be88e4571578219da1226d2884fa7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Digital.Pages.Home.Views_Home_Person), @"mvc.1.0.view", @"/Views/Home/Person.cshtml")]
namespace Digital.Pages.Home
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
#line 1 "/Users/zhalgas/Projects/Digital/Digital/Views/_ViewImports.cshtml"
using Digital;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba63f0c59be88e4571578219da1226d2884fa7a", @"/Views/Home/Person.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10fa15eb86aa3dcdce698f5babae291c71b6cc6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Person : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/zhalgas/Projects/Digital/Digital/Views/Home/Person.cshtml"
  
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"wrapper\" style=\"margin-top: 60px; \">\n");
#nullable restore
#line 9 "/Users/zhalgas/Projects/Digital/Digital/Views/Home/Person.cshtml"
     if (Model.ErrorMessage != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\" role=\"alert\" style=\"float:right\">\n            ");
#nullable restore
#line 12 "/Users/zhalgas/Projects/Digital/Digital/Views/Home/Person.cshtml"
       Write(Model.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 14 "/Users/zhalgas/Projects/Digital/Digital/Views/Home/Person.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Регистрация</h2>\n    <div class=\"row\">\n\n        <div class=\"container\">\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aba63f0c59be88e4571578219da1226d2884fa7a4892", async() => {
                WriteLiteral(@"
                <div class=""form-group "">
                    <label class=""control-label requiredField"">
                        First Name

                    </label>
                    <div class=""input-group"">

                        <input class=""form-control"" id=""name"" name=""FirstName"" type=""text"" />

                    </div>
                    <label class=""control-label requiredField"" for=""name"">
                        Last Name

                    </label>
                    <div class=""input-group"">

                        <input class=""form-control"" id=""name"" name=""LastName"" type=""text"" />
                    </div>
                    <label class=""control-label requiredField"" for=""name"">
                        Email

                    </label>
                    <div class=""input-group"">

                        <input class=""form-control"" id=""name"" name=""Email"" type=""text"" />
                    </div>
                    <label class=""control-label requiredField"" for=""name"">
   ");
                WriteLiteral(@"                     Password

                    </label>
                    <div class=""input-group"">

                        <input class=""form-control"" id=""name"" name=""Password"" type=""text"" />
                    </div>
                    <label class=""control-label requiredField"" for=""name"">
                        DateOfBirth

                    </label>
                    <div class=""input-group"">

                        <input class=""form-control"" id=""name"" name=""DateOfBirth"" type=""text"" />
                    </div>
                </div>
                <div class=""form-group"">
                    <div>
                        <button class=""btn btn-primary "" name=""submit"" type=""submit"">
                            Submit
                        </button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>





    <!--<div class=""wrapper"" style=""margin-top: 60px; "">

        <div class=""row"">
            <div style=""padding: 40px;"">
                <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#addTask"">+ ADD Users  </button>-->
    <!-- The Modal -->
    <!--<div class=""modal fade"" id=""addTask"">
        <div class=""modal-dialog modal-xl"">
            <div class=""modal-content "" style=""width: 1000px;"">-->
    <!-- Modal Header -->
    <!--<div class=""modal-header"">
        <h4 class=""modal-title"">Adding User </h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
    </div>-->
    <!-- Modal body -->
    <!--<div class=""modal-body"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-6 col-sm-6 col-xs-12"">
                    <form asp-controller=""Home"" asp-action=""CreateUser"" method=""post"">
                        <div class=""form-group "">
                      ");
            WriteLiteral(@"      <label class=""control-label requiredField"" for=""name"">
                                 First Name

                            </label>
                            <div class=""input-group"">

                                <input class=""form-control"" id=""name"" name=""FirstName"" type=""text"" />
                            </div>
                            <label class=""control-label requiredField"" for=""name"">
                                Last Name

                            </label>
                            <div class=""input-group"">

                                <input class=""form-control"" id=""name"" name=""LastName"" type=""text"" />
                            </div>
                            <label class=""control-label requiredField"" for=""name"">
                                Email

                            </label>
                            <div class=""input-group"">

                                <input class=""form-control"" id=""name"" name=""Email"" type=""text"" />
                       ");
            WriteLiteral(@"     </div>
                            <label class=""control-label requiredField"" for=""name"">
                                Password

                            </label>
                            <div class=""input-group"">

                                <input class=""form-control"" id=""name"" name=""Password"" type=""text"" />
                            </div>
                            <label class=""control-label requiredField"" for=""name"">
                                DateOfBirth

                            </label>
                            <div class=""input-group"">

                                <input class=""form-control"" id=""name"" name=""DateOfBirth"" type=""text"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div>
                                <button class=""btn btn-primary "" name=""submit"" type=""submit"">
                                    Submit
                                </button>
       ");
            WriteLiteral(@"                     </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>-->
    <!-- Modal footer -->
    <!--<div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                            </div>

                        </div>
                    </div>




                </div>



            </div>
            <div class=""col-8 col-m-12 col-sm-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3>
                            User
                        </h3>
                    </div>
                    <div class=""card-content"">
                        <table>
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>First name</th>
                                    <th>La");
            WriteLiteral(@"st Name</th>
                                    <th>Email</th>
                                    <th>Password</th>
                                    <th>Birthday<th>
                                    <th>Resumes</th>

                                    <th>Actions</th>
                                </tr>
                            </thead>
                            <tbody>
        

                            </tbody>
                            </table>
                        </div>
                    </div>
                 </div>

       </div>

    </div>-->
    <!-- DataTables -->
    <!--<script src=""~/bower_components/datatables.net/js/jquery.dataTables.min.js""></script>
    <script src=""~/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js""></script>-->
    <!-- page script -->
    <!--<script>
        $(function () {
            $('#example1').DataTable();
        });
        function Delete(id){
            var txt;
            var r = confirm(""Are you sure you want to ");
            WriteLiteral("Delete?\");\n            if (r == true) {\n\n                $.ajax(\n                {\n                    type: \"POST\",\n                    url: \'");
#nullable restore
#line 220 "/Users/zhalgas/Projects/Digital/Digital/Views/Home/Person.cshtml"
                     Write(Url.Action("DeleteWorkExperince", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                    data: {
                        id: id
                    },
                    error: function (result) {
                        alert(""error"");
                    },
                    success: function (result) {
                        if (result == true) {
                            var baseUrl=""/Home/WorkExperience"";
                            window.location.reload();
                        }
                        else {
                            alert(""There is a problem, Try Later!"");
                        }
                    }
                });
            }
        }
    </script>-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
