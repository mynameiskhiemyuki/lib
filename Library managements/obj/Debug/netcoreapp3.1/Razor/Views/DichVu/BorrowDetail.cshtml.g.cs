#pragma checksum "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\DichVu\BorrowDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ac094e2169f7774a30511d85525d3e1d07b8764"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DichVu_BorrowDetail), @"mvc.1.0.view", @"/Views/DichVu/BorrowDetail.cshtml")]
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
#line 1 "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\_ViewImports.cshtml"
using Library_managements;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\_ViewImports.cshtml"
using Library_managements.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ac094e2169f7774a30511d85525d3e1d07b8764", @"/Views/DichVu/BorrowDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7e07fb3a4083369c879e2f4e40a124d9857544", @"/Views/_ViewImports.cshtml")]
    public class Views_DichVu_BorrowDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library_managements.Models.LichSuMuon>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n");
#nullable restore
#line 5 "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\DichVu\BorrowDetail.cshtml"
   ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">


            <div class=""row"">


                <div class=""col-lg-6"">
                    <div class=""card"">
                        <div class=""card-header"">Borrow Book</div>
                        <div class=""card-body"">
                            <div class=""card-title"">
                                <h3 class=""text-center title-2"">Borrow</h3>
                            </div>
                            <hr>
");
#nullable restore
#line 24 "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\DichVu\BorrowDetail.cshtml"
                             using (Html.BeginForm("Save", "DichVu", FormMethod.Post))
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group\">\n                            <label class=\"control-label mb-1\">Mã Sách:  </label>\n                            ");
#nullable restore
#line 29 "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\DichVu\BorrowDetail.cshtml"
                       Write(Html.TextBoxFor(s => s.maSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n");
            WriteLiteral(@"                                        <div class=""form-group"">
                                            <label for=""maDocGia"" class=""control-label mb-1"">Tên sách</label>
                                            <input id=""maDocGia"" name=""maDocGia"" type=""tel"" class=""form-control"">
                                            <span class=""help-block"" data-valmsg-for=""cc-number"" data-valmsg-replace=""true""></span>
                                        </div>
                                                        <div class=""form-group"">
                                                            <label for=""tenDocGia"" class=""control-label mb-1"">Tên độc giả</label>
                                                            <input id=""tenDocGia"" name=""tenDocGia"" class=""form-control"" disabled>
                                                            <span class=""help-block"" data-valmsg-for=""cc-number"" data-valmsg-replace=""true""></span>
                                                        </div>
");
            WriteLiteral(@"                                                                                        <div class=""form-group"">
                                                                                            <label for=""ngayMuon"" class=""control-label mb-1"">Ngày mượn</label>
                                                                                            <input type=""date"" id=""ngayMuon"" name=""ngayMuon"" class=""form-control"">
                                                                                            <span class=""help-block"" data-valmsg-for=""cc-number"" data-valmsg-replace=""true""></span>
                                                                                        </div>
");
            WriteLiteral(@"                                                                                                        <div class=""form-group"">

                                                                                                            <input type=""submit"" id=""rdate"" class=""btn btn-success"" value=""Save"">

                                                                                                        </div>");
#nullable restore
#line 53 "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\DichVu\BorrowDetail.cshtml"
                                                                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\n   \n");
#nullable restore
#line 66 "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\DichVu\BorrowDetail.cshtml"
          await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"  
    <script src=""//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>

    <link href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"" rel=""stylesheet"" />
    <link href=""https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css"" rel=""stylesheet"" />

    <script src=""https://cdn.datatables.net/1.10.15/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.15/js/dataTables.bootstrap4.min.js ""></script>

    <script>
        getReaderId();
        function getReaderId() {

            $('#maDocGia').keyup(function () {
                var txt = $(this).val();
                if ((txt) != '') {
                    $.ajax({
                        url: '/DichVu/GetReaderId?rId=' + $('#maDocGia').val(),
                        method: 'post',
                        dataType: 'JSON',
                        success: function (data) {
                            $('#tenDocGia').val(data);

                        }
       ");
                WriteLiteral("             });\n                } else {\n                    $(\'#tenDocGia\').val(\'\');\n\n                }\n            });\n        }\n    </script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library_managements.Models.LichSuMuon> Html { get; private set; }
    }
}
#pragma warning restore 1591
