#pragma checksum "G:\Program Files (x86)\Web\Web\UI\Views\Home\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f82217229a23dc8f3e8f6c08b0c2f6efcb701b7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Main.cshtml", typeof(AspNetCore.Views_Home_Main))]
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
#line 1 "G:\Program Files (x86)\Web\Web\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#line 2 "G:\Program Files (x86)\Web\Web\UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f82217229a23dc8f3e8f6c08b0c2f6efcb701b7f", @"/Views/Home/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-layout-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\Program Files (x86)\Web\Web\UI\Views\Home\Main.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 31, true);
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(60, 506, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f82217229a23dc8f3e8f6c08b0c2f6efcb701b7f3851", async() => {
                BeginContext(66, 493, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>layuiAdmin std - 通用后台管理模板系统（iframe标准版）</title>
    <meta name=""renderer"" content=""webkit"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=0"">
    <link rel=""stylesheet"" href=""../layuiadmin/layui/css/layui.css"" media=""all"">
    <link rel=""stylesheet"" href=""../layuiadmin/style/admin.css"" media=""all"">
");
                EndContext();
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
            EndContext();
            BeginContext(566, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(568, 8892, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f82217229a23dc8f3e8f6c08b0c2f6efcb701b7f5550", async() => {
                BeginContext(600, 2938, true);
                WriteLiteral(@"

    <div id=""LAY_app"">
        <div class=""layui-layout layui-layout-admin"">
            <div class=""layui-header"">
                <!-- 头部区域 -->
                <ul class=""layui-nav layui-layout-left"">
                    <li class=""layui-nav-item layadmin-flexible"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""flexible"" title=""侧边伸缩"">
                            <i class=""layui-icon layui-icon-shrink-right"" id=""LAY_app_flexible""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                        <a href=""http://www.layui.com/admin/"" target=""_blank"" title=""前台"">
                            <i class=""layui-icon layui-icon-website""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""refresh"" title=""刷新"">
                            <i class=""l");
                WriteLiteral(@"ayui-icon layui-icon-refresh-3""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                        <input type=""text"" placeholder=""搜索..."" autocomplete=""off"" class=""layui-input layui-input-search"" layadmin-event=""serach"" lay-action=""template/search.html?keywords="">
                    </li>
                </ul>
                <ul class=""layui-nav layui-layout-right"" lay-filter=""layadmin-layout-right"">

                    <li class=""layui-nav-item"" lay-unselect>
                        <a lay-href=""app/message/index.html"" layadmin-event=""message"" lay-text=""消息中心"">
                            <i class=""layui-icon layui-icon-notice""></i>

                            <!-- 如果有新消息，则显示小圆点 -->
                            <span class=""layui-badge-dot""></span>
                        </a>
                    </li>
                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                      ");
                WriteLiteral(@"  <a href=""javascript:;"" layadmin-event=""theme"">
                            <i class=""layui-icon layui-icon-theme""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""note"">
                            <i class=""layui-icon layui-icon-note""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""fullscreen"">
                            <i class=""layui-icon layui-icon-screen-full""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item"" lay-unselect>
                        <a href=""javascript:;"">
                            <cite>");
                EndContext();
                BeginContext(3539, 20, false);
#line 72 "G:\Program Files (x86)\Web\Web\UI\Views\Home\Main.cshtml"
                             Write(ViewData["UserName"]);

#line default
#line hidden
                EndContext();
                BeginContext(3559, 5894, true);
                WriteLiteral(@"</cite>
                        </a>
                        <dl class=""layui-nav-child"">
                            <dd><a lay-href=""set/user/info.html"">基本资料</a></dd>
                            <dd><a lay-href=""set/user/password.html"">修改密码</a></dd>
                            <hr>
                            <dd layadmin-event=""logout"" style=""text-align: center;""><a>退出</a></dd>
                        </dl>
                    </li>

                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""about""><i class=""layui-icon layui-icon-more-vertical""></i></a>
                    </li>
                    <li class=""layui-nav-item layui-show-xs-inline-block layui-hide-sm"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""more""><i class=""layui-icon layui-icon-more-vertical""></i></a>
                    </li>
                </ul>
            </div>

            <!-- 侧边菜单 -->
            <di");
                WriteLiteral(@"v class=""layui-side layui-side-menu"">
                <div class=""layui-side-scroll"">
                    <div class=""layui-logo"" lay-href=""home/console.html"">
                        <span>layuiAdmin</span>
                    </div>
                    <ul class=""layui-nav layui-nav-tree"" id=""LoadSysList"">
                        <!-- 侧边导航: <ul class=""layui-nav layui-nav-tree layui-nav-side""> -->

                    </ul>
                </div>
            </div>
            <!-- 页面标签 -->
            <div class=""layadmin-pagetabs"" id=""LAY_app_tabs"">
                <div class=""layui-icon layadmin-tabs-control layui-icon-prev"" layadmin-event=""leftPage""></div>
                <div class=""layui-icon layadmin-tabs-control layui-icon-next"" layadmin-event=""rightPage""></div>
                <div class=""layui-icon layadmin-tabs-control layui-icon-down"">
                    <ul class=""layui-nav layadmin-tabs-select"" lay-filter=""layadmin-pagetabs-nav"">
                        <li class=""layui-nav-it");
                WriteLiteral(@"em"" lay-unselect>
                            <a href=""javascript:;""></a>
                            <dl class=""layui-nav-child layui-anim-fadein"">
                                <dd layadmin-event=""closeThisTabs""><a href=""javascript:;"">关闭当前标签页</a></dd>
                                <dd layadmin-event=""closeOtherTabs""><a href=""javascript:;"">关闭其它标签页</a></dd>
                                <dd layadmin-event=""closeAllTabs""><a href=""javascript:;"">关闭全部标签页</a></dd>
                            </dl>
                        </li>
                    </ul>
                </div>
                <div class=""layui-tab"" lay-unauto lay-allowClose=""true"" lay-filter=""layadmin-layout-tabs"">
                    <ul class=""layui-tab-title"" id=""LAY_app_tabsheader""></ul>
                </div>
            </div>


            <!-- 主体内容 -->
            <div class=""layui-body"" id=""LAY_app_body"">
               
            </div>

            <!-- 辅助元素，一般用于移动设备下遮罩 -->
            <div class=""layadmin-bo");
                WriteLiteral(@"dy-shade"" layadmin-event=""shade""></div>
        </div>
    </div>
    <script src=""../layuiadmin/layui/layui.js""></script>
    <script>
        layui.use('element', function () {
            var element = layui.element;
            $ = layui.jquery;
            layer = layui.layer;
            //加载好友列表
            $.ajax({
                url: 'http://127.0.0.1:5001/api/Main/LoadSysList',
                type: 'get',
                xhrFields: { withCredentials: true },
                datatype: 'json',
                success: function (data) {
                    for (var i = 0; i < data.data.table.length; i++) {
                        var html = '<li data-name=""home"" class=""layui-nav-item "">';
                        html += ' <a href=""javascript:;"" lay-tips=""' + data.data.table[i].modularNametext + '"" lay-direction=""2"">';
                        html += '<i class=""layui-icon layui-icon-home"" ></i>';
                        html += '<cite>' + data.data.table[i].modularNametext + '</cit");
                WriteLiteral(@"e></a>';
                        for (var j = 0; j < data.data.table1.length; j++) {
                            if (data.data.table1[j].modularid == data.data.table[i].modularid) {
                                html += '<dl class=""layui-nav-child"">';
                                html += '<dd>';
                                html += '<a lay-href = ""' + data.data.table1[j].modularInfoulr + '?BillNo=' + data.data.table1[j].id + '"" >' + data.data.table1[j].modulardtnametext + '</a>';
                                html += '<dl class=""layui-nav-item"" id = ""' + data.data.table1[j].modularinfoid + '"" ></dl>'
                                html += '</dd></dl>';
                            }
                        }
                        html += ""</li>"";
                        $(""#LoadSysList"").append(html)
                    }
                    element.render('nav');
                    //$.each(data.data, function (i, e) {
                    //    $(""#TableList"").append('<dd data-nam");
                WriteLiteral(@"e=""console""><a onClick=""openPlane(this)"" name=""' + e.tablE_NAME + '"" id=""' + e.tablE_NAME + '"" href=""javascript:;"">' + e.tablE_NAME + '</a></dd>')
                    //})
                },
                error: function (data) {
                    console.info(data.responseJSON)
                    if (data.responseJSON.code == ""401"") {

                        window.parent.location.href = ""http://127.0.0.1:44303/Login/Login""
                    } else {
                        alert(data.responseJSON.message)
                    }
                }
            })
        })
        layui.config({
            base: '../layuiadmin/' //静态资源所在路径
        }).extend({
            index: 'lib/index' //主入口模块
        }).use('index');
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9460, 15, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
