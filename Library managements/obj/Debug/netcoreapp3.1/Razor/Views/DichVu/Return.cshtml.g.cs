#pragma checksum "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\DichVu\Return.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fccfa22092cc599738511859ab21f38a579692a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DichVu_Return), @"mvc.1.0.view", @"/Views/DichVu/Return.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccfa22092cc599738511859ab21f38a579692a5", @"/Views/DichVu/Return.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7e07fb3a4083369c879e2f4e40a124d9857544", @"/Views/_ViewImports.cshtml")]
    public class Views_DichVu_Return : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\DichVu\Return.cshtml"
  
    ViewData["Title"] = "Return Book";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">

            <h1>Borrowing List</h1>
            <table id=""example2"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Reader ID</th>
                        <th>Book</th>
                        <th>Reader Name</th>
                        <th>Borrow Date</th>
                        <th>Return</th>

                    </tr>
                </thead>
            </table>
        </div>
    </div>
</div>



");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>


    <link href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"" rel=""stylesheet"" />
    <link href=""https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css"" rel=""stylesheet"" />

    <script src=""https://cdn.datatables.net/1.10.15/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.15/js/dataTables.bootstrap4.min.js ""></script>
    <script>


        $(document).ready(function ()
        {



            $(""#example2"").DataTable({
                ""processing"": true, // for show progress bar
                ""serverSide"": true, // for process server side
                ""filter"": true, // this is for disable filter (search box)
                ""orderMulti"": false, // for disable multiple column at once
               
                ""ajax"": {
                    ""url"": ""/DichVu/LoadBorrowBook"",
                    ");
                WriteLiteral(@"""type"": ""POST"",
                    ""datatype"": ""json""
                },
                ""columnDefs"":
                    [{
                        ""targets"": [0],
                        ""visible"": true,
                        ""searchable"": true
                    },],
                ""columns"": [
                    { ""data"": ""maDocGia"", ""name"": ""maDocGia"", ""autoWidth"": true },
                    { ""data"": ""tenSach"", ""name"": ""tenSach"", ""autoWidth"": true },
                    { ""data"": ""tenDocGia"", ""name"": ""tenDocGia"", ""autoWidth"": true },
                    { ""data"": ""ngayMuon"", ""name"": ""ngayMuon"", ""autoWidth"": true },     
     
                    {
                        data: null, render: function (data, type, row)
                        {
                            return ""<a href='#' class='btn btn-danger' onclick=DeleteData('"" + row.maPhieuMuon + ""'); >Trả</a>"";
                        }
                    },
                ]

            });
        });


   ");
                WriteLiteral(@"     function DeleteData(maPhieuMuon)
        {
            if (confirm(""Are you sure you want to delete ...?""))
            {
                Delete(maPhieuMuon);
            }
            else
            {
                return false;
            }
        }


        function Delete(maPhieuMuon)
    {
        var url = '");
#nullable restore
#line 98 "C:\Users\mynam\source\repos\Library\Lib\Library managements\Views\DichVu\Return.cshtml"
              Write(Url.Content("~/"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + ""DichVu/Send"";

            $.post(url, { ID: maPhieuMuon }, function (data)
                {
                    if (data)
                    {
                        oTable = $('#example2').DataTable();
                        oTable.draw();
                    }
                    else
                    {
                        alert(""Something Went Wrong!"");
                    }
                });
    }

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
