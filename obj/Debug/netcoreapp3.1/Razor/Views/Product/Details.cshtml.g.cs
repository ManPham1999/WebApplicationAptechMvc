#pragma checksum "/Users/macintoshhd/WebApplicationAptechMvc/Views/Product/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f1eff28c707057d7e64d80a194933177e76d171"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "/Users/macintoshhd/WebApplicationAptechMvc/Views/_ViewImports.cshtml"
using AptechMVCProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/macintoshhd/WebApplicationAptechMvc/Views/_ViewImports.cshtml"
using AptechMVCProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f1eff28c707057d7e64d80a194933177e76d171", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce4c99dfb5392536171e3e89051d8f1b8523d018", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AptechMVCProject.Entity.ModelView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("featured"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/detail-product/img01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/macintoshhd/WebApplicationAptechMvc/Views/Product/Details.cshtml"
  
    ViewBag.Title = "Detail Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"p-detail__sc1\">\n    <div class=\"l-container\">\n        <div class=\"c-detail c-flexblock\">\n            <div class=\"c-detail_img c-col5\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f1eff28c707057d7e64d80a194933177e76d1714870", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4f1eff28c707057d7e64d80a194933177e76d1715085", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "/Users/macintoshhd/WebApplicationAptechMvc/Views/Product/Details.cshtml"
                                                                  WriteLiteral(Model.product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""c-detail_inner c-col5"">
                <h3 class=""c-detail_name"">Cà Phê Arabica Cầu Đất DalatFarm - Túi 250gr (Dạng Bột)</h3>
                <div class=""c-detail_price"">
                    <span class=""c-price_text1"">Giá: </span>
                    <span class=""c-price_text2"">100000</span>
                    <span class=""c-price_text3"">vnd</span>
                </div>
                <div class=""selector-actions"">
                    <div class=""buttons_added"">
                        <input class=""minus is-form"" type=""button"" value=""-"">
                        <input aria-label=""quantity"" class=""input-qty"" max=""50"" min=""1""");
            BeginWriteAttribute("name", " name=\"", 1071, "\"", 1078, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" value=""1"">
                        <input class=""plus is-form"" type=""button"" value=""+"">
                    </div>
                    <div class=""wrap-addcart clearfix"">
                        <button type=""button"" id=""add-to-cart"" class=""add-to-cartProduct button dark btn-addtocart addtocart-modal"" name=""add"">Thêm vào giỏ</button>
                        <button type=""button"" id=""buy-now"" class=""add-to-cartProduct button dark btn-addtocart addtocart-modal hidden"" name=""add"" style=""display: inline-block;"">Mua ngay</button>
                    </div>
                </div>

            </div>
            <script>
    //<![CDATA[
                $('input.input-qty').each(function () {
                    var $this = $(this),
                        qty = $this.parent().find('.is-form'),
                        min = Number($this.attr('min')),
                        max = Number($this.attr('max'))
                    if (min == 0) {
                        var d = 0
                    } else d");
            WriteLiteral(@" = min
                    $(qty).on('click', function () {
                        if ($(this).hasClass('minus')) {
                            if (d > min) d += -1
                        } else if ($(this).hasClass('plus')) {
                            var x = Number($this.val()) + 1
                            if (x <= max) d += 1
                        }
                        $this.attr('value', d).val(d)
                    })
                })
//]]></script>
        </div>
        <div class=""c-description"">
            <span class=""c-description__title1"">Nguồn gốc sản phẩm</span>
            • Cà phê Arabica Cầu Đất được trồng từ vùng nguyên liệu cà phê Cầu Đất - Đà Lạt, nơi được mệnh danh là thủ phủ Arabica, cho chất lượng lâu đời tại Việt Nam. Nằm trên độ cao hơn 1600m so với mực nước biển, Cầu Đất có khí hậu ôn hoà quanh năm, thổ nhưỡng Bazan màu mỡ đã tạo nên những đồi cà phê có hương thơm và phẩm chất rất riêng biệt.
            <br/>
            • 100% cà phê Arabica chín cây, được tuyển ch");
            WriteLiteral(@"ọn kỹ càng, hạt to, chín đỏ mọng, phơi vòm, ngon tuyệt hảo. Quy trình chế biến được kiểm soát chặt chẽ, rang xay mộc nguyên chất theo phương pháp truyền thống.
            <br/>
            • Cà phê Arabica mang hương thơm ngất ngây, vị chua để lại hậu vị ngòn ngọt sau uống làm say lòng những người thưởng thức khó tính nhất. Thích hợp gu sành cà phê, ưu thích sự độc đáo và uống được vị chua. Dùng pha máy Espresso hoặc pha phin đều được.
            <span class=""c-description__title1""> Thông tin chi tiết sản phẩm:</span>
            <br/>
            • Thành phần: 100% từ những trái cà phê Arabica chín cây thượng hạng từ vùng nguyên liệu cà phê Cầu Đất - Đà Lạt tốt nhất Việt Nam.
            <br/>• Hương vị: vị chua thanh xen lẫn đắng nhẹ cùng hương thơm nhẹ nhàng.
            <br/> • Hướng dẫn sử dụng: tráng nhẹ phin, cho lượng cà phê khoảng 10-15gr, thêm vào 20ml nước sôi và chờ 20-25 giây. Rót nhẹ nhàng thêm nước vào phin đến khi lượng nước đạt vừa sở thích. Lấy phin ra, có thể thêm đường / sữa và đá tuỳ th");
            WriteLiteral(@"ích.
            <br/>• Thông tin cảnh báo an toàn vệ sinh: không sử dụng khi sản phẩm có hiện tượng nấm mốc, mùi lạ.
            <br/>• Quy cách đóng gói: túi Kraft mộc tráng thiếc bên trong giúp giữ hương vị cà phê được lâu, thân thiện với môi trường.
            <br/>
            <br/>• Ngày sản xuất: xem trên bao bì.
            <br/>• Hạn sử dụng: 12 tháng kể từ ngày sản xuất.
            <br/>• Nguồn gốc: sản phẩm DalatFarm - Việt Nam.
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AptechMVCProject.Entity.ModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591
