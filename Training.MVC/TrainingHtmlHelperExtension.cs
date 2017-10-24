using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Training.MVC
{
    public static class TrainingHtmlHelperExtension
    {
        public static MvcHtmlString CustomTextBox(this HtmlHelper htmlHelper, string name, string value)
        {
            var builder = new TagBuilder("input");
            builder.MergeAttribute("type", "text");
            builder.MergeAttribute("name", name);
            builder.MergeAttribute("value", value);
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }

        public static MvcHtmlString DisableIf(this MvcHtmlString htmlString, Func<bool> expression)
        {
            if (expression.Invoke())
            {
                var html = htmlString.ToString();
                const string disabled = "\"disabled\"";
                html = html.Insert(html.IndexOf(">",
                  StringComparison.Ordinal), " disabled= " + disabled);
                return new MvcHtmlString(html);
            }
            return htmlString;
        }
    }
}