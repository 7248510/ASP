using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;    // [ViewContext] attribute
using Microsoft.AspNetCore.Mvc.Rendering;       // ViewContext data type
using Microsoft.AspNetCore.Routing;             // LinkGenerator

namespace ClassSchedule.TagHelpers
{
    public class MyLinkButtonTagHelper : TagHelper
    {
        private LinkGenerator linkBuilder;
        public MyLinkButtonTagHelper(LinkGenerator lg) => linkBuilder = lg;
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewCtx { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Id { get; set; }
        public bool IsActive { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string action = Action ?? ViewCtx.RouteData.Values["action"].ToString(); //627
            string controller = Controller ?? ViewCtx.RouteData.Values["controller"].ToString(); //Same as action
            var segment = (string.IsNullOrEmpty(Id)) ?null:new { Id }; //Anon method
            string url = linkBuilder.GetPathByAction(action, controller, segment); //627
            string css = (IsActive) ? "btn btn-dark" : "btn btn-outline-dark"; //Style the buttons Assign bootstrap to the string variable
            output.BuildLink(url, css);
        }
    }
}
