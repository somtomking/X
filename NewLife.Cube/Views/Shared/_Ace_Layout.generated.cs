﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 1 "..\..\Views\Shared\_Ace_Layout.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Ace_Layout.cshtml")]
    public partial class _Views_Shared__Ace_Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Ace_Layout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_Ace_Layout.cshtml"
  
    var menu = ManageProvider.Menu.Current;

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" lang=\"zh-CN\"");

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1\"");

WriteLiteral(" />\r\n    <!-- 上述3个meta标签*必须*放在最前面，任何其他内容都*必须*跟随其后！ -->\r\n\r\n    <title>");

            
            #line 13 "..\..\Views\Shared\_Ace_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 13 "..\..\Views\Shared\_Ace_Layout.cshtml"
                       Write(SysConfig.Current.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 417), Tuple.Create("\"", 437)
, Tuple.Create(Tuple.Create("", 424), Tuple.Create<System.Object, System.Int32>(Href("~/favicon.ico")
, 424), false)
);

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(" />\r\n\r\n    <!-- 页面内联样式 -->\r\n");

WriteLiteral("    ");

            
            #line 17 "..\..\Views\Shared\_Ace_Layout.cshtml"
Write(RenderSection("css", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <!-- 文本字体 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 597), Tuple.Create("\"", 639)
, Tuple.Create(Tuple.Create("", 604), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace-fonts.min.css")
, 604), false)
);

WriteLiteral(" />\r\n    <!-- ace 样式 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 692), Tuple.Create("\"", 728)
, Tuple.Create(Tuple.Create("", 699), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace.min.css")
, 699), false)
);

WriteLiteral(" class=\"ace-main-stylesheet\"");

WriteLiteral(" id=\"main-ace-style\"");

WriteLiteral(" />\r\n\r\n    <!--[if lte IE 9]>\r\n        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 838), Tuple.Create("\"", 880)
, Tuple.Create(Tuple.Create("", 845), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace-part2.min.css")
, 845), false)
);

WriteLiteral(" class=\"ace-main-stylesheet\"");

WriteLiteral(" />\r\n    <![endif]-->\r\n    <!--[if lte IE 9]>\r\n        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 986), Tuple.Create("\"", 1025)
, Tuple.Create(Tuple.Create("", 993), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace-ie.min.css")
, 993), false)
);

WriteLiteral(" />\r\n    <![endif]-->\r\n\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1077), Tuple.Create("\"", 1141)
, Tuple.Create(Tuple.Create("", 1084), Tuple.Create<System.Object, System.Int32>(Href("~/Content/DateTimePicker/bootstrap-datetimepicker.min.css")
, 1084), false)
);

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n\r\n    ");

WriteLiteral("\r\n\r\n    <!-- 最后引入基本样式 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1321), Tuple.Create("\"", 1369)
, Tuple.Create(Tuple.Create("", 1328), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap.min.css")
, 1328), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1401), Tuple.Create("\"", 1452)
, Tuple.Create(Tuple.Create("", 1408), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/font-awesome.min.css")
, 1408), false)
);

WriteLiteral(" />\r\n\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1486), Tuple.Create("\"", 1540)
, Tuple.Create(Tuple.Create("", 1493), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap-theme.min.css")
, 1493), false)
);

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1588), Tuple.Create("\"", 1647)
, Tuple.Create(Tuple.Create("", 1595), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap-responsive.min.css")
, 1595), false)
);

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n\r\n    <!-- JQuery作为一等公民，页面内部随时可能使用 -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1720), Tuple.Create("\"", 1758)
, Tuple.Create(Tuple.Create("", 1726), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery-2.1.3.min.js")
, 1726), false)
);

WriteLiteral("></script>\r\n</head>\r\n<body>\r\n    <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"ace-icon fa fa-home home-icon\"");

WriteLiteral("></i>\r\n");

            
            #line 49 "..\..\Views\Shared\_Ace_Layout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Shared\_Ace_Layout.cshtml"
             if (menu != null)
            {
                foreach (IMenu item in menu.AllParents)
                {
                    if (item.ID != 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2122), Tuple.Create("\"", 2173)
            
            #line 55 "..\..\Views\Shared\_Ace_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2129), Tuple.Create<System.Object, System.Int32>(item.Url!=null? Url.Content(item.Url):"#"
            
            #line default
            #line hidden
, 2129), false)
);

WriteLiteral(" class=\"h4\"");

WriteLiteral(">");

            
            #line 55 "..\..\Views\Shared\_Ace_Layout.cshtml"
                                                                         Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

WriteLiteral("            ");

WriteLiteral("&nbsp;/&nbsp;");

WriteLiteral("\r\n");

            
            #line 57 "..\..\Views\Shared\_Ace_Layout.cshtml"
                    }
                }
            }

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2320), Tuple.Create("\"", 2347)
            
            #line 60 "..\..\Views\Shared\_Ace_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2327), Tuple.Create<System.Object, System.Int32>(Url.Action("Index")
            
            #line default
            #line hidden
, 2327), false)
);

WriteLiteral(" class=\"h4\"");

WriteLiteral("><strong>");

            
            #line 60 "..\..\Views\Shared\_Ace_Layout.cshtml"
                                                          Write(menu != null ? menu.DisplayName : ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong></a>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n            <section");

WriteLiteral(" class=\"content-wrapper main-content clear-fix\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 64 "..\..\Views\Shared\_Ace_Layout.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </section>\r\n        </div>\r\n    </div>\r\n    <!-- 最早引入基本脚本 -->\r\n    " +
"<script");

WriteAttribute("src", Tuple.Create(" src=\"", 2670), Tuple.Create("\"", 2715)
, Tuple.Create(Tuple.Create("", 2676), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/js/bootstrap.min.js")
, 2676), false)
);

WriteLiteral("></script>\r\n    ");

WriteLiteral("\r\n\r\n    <!-- ace 设置 -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2903), Tuple.Create("\"", 2936)
, Tuple.Create(Tuple.Create("", 2909), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/js/ace.min.js")
, 2909), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2960), Tuple.Create("\"", 3002)
, Tuple.Create(Tuple.Create("", 2966), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/js/ace-elements.min.js")
, 2966), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3026), Tuple.Create("\"", 3065)
, Tuple.Create(Tuple.Create("", 3032), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/js/ace-extra.min.js")
, 3032), false)
);

WriteLiteral("></script>\r\n\r\n    <!-- HTML5shiv and Respond.js for IE8 to support HTML5 elements" +
" and media queries -->\r\n    <!--[if lte IE 8]>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3206), Tuple.Create("\"", 3241)
, Tuple.Create(Tuple.Create("", 3212), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/html5shiv.min.js")
, 3212), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3265), Tuple.Create("\"", 3298)
, Tuple.Create(Tuple.Create("", 3271), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/respond.min.js")
, 3271), false)
);

WriteLiteral("></script>\r\n    <![endif]-->\r\n\r\n    ");

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 85 "..\..\Views\Shared\_Ace_Layout.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <!--日历控件支持-->\r\n    ");

WriteLiteral("\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3527), Tuple.Create("\"", 3589)
, Tuple.Create(Tuple.Create("", 3533), Tuple.Create<System.Object, System.Int32>(Href("~/Content/DateTimePicker/bootstrap-datetimepicker.min.js")
, 3533), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3613), Tuple.Create("\"", 3685)
, Tuple.Create(Tuple.Create("", 3619), Tuple.Create<System.Object, System.Int32>(Href("~/Content/DateTimePicker/locales/bootstrap-datetimepicker.zh-CN.js")
, 3619), false)
);

WriteLiteral("></script>\r\n    <script>\r\n        //$(function () {\r\n        //    // 给所有type=dat" +
"e的input加上事件\r\n        //    var dt = $(\'input[type=date]\');\r\n        //    if (!d" +
"t.data(\'datd-date-format\')) {\r\n        //        dt.data(\'datd-date-format\', \'yy" +
"yy-MM-dd HH:mm:ss\');\r\n        //    }\r\n        //    if (!dt.data(\'click\')) {\r\n " +
"       //        dt.click(function () { WdatePicker({ skin: \'whyGreen\', dateFmt:" +
" dt.data(\'datd-date-format\') }); });\r\n        //    }\r\n        //});\r\n        $(" +
"function () {\r\n            $(\'input[type=date]\').each(function () {\r\n           " +
"     var df = $(this).attr(\'dateformat\');\r\n                if (!df) {\r\n         " +
"           $(this).attr(\'dateformat\', \'yyyy-mm-dd hh:ii:ss\');\r\n                }" +
"\r\n                else {\r\n                    // 把C#标准格式化替换为控件格式\r\n              " +
"      df = df.replace(\'mm\', \'ii\').replace(\'MM\', \'mm\').replace(\'HH\', \'hh\');\r\n    " +
"                $(this).attr(\'dateformat\', df);\r\n                }\r\n            " +
"});\r\n            $(\"[dateformat]\").each(function () {\r\n                $(this).d" +
"atetimepicker({\r\n                    format: $(this).attr(\"dateformat\"),\r\n      " +
"              autoclose: true,\r\n                    language: \"zh-CN\",\r\n        " +
"            forceParse: false,\r\n                    startView: 2,\r\n             " +
"       minView: 2,\r\n                })\r\n                //console.trace($(this))" +
";\r\n            })\r\n            $(\'input[role=number]\').each(function () {\r\n     " +
"           $(this).removeAttr(\'class\');\r\n                $(this).addClass(\'spinb" +
"ox-input form-control text-center\');\r\n                $(this).ace_spinner({ on_s" +
"ides: true, icon_up: \'ace-icon fa fa-plus bigger-110\', icon_down: \'ace-icon fa f" +
"a-minus bigger-110\', btn_up_class: \'btn-success\', btn_down_class: \'btn-danger\' }" +
");\r\n            });\r\n        });\r\n    </script>\r\n\r\n    <!--开关插件-->\r\n    ");

WriteLiteral("\r\n\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 5731), Tuple.Create("\"", 5775)
, Tuple.Create(Tuple.Create("", 5737), Tuple.Create<System.Object, System.Int32>(Href("~/Content/fuelux/fuelux.spinner.min.js")
, 5737), false)
);

WriteLiteral("></script>\r\n</body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591
