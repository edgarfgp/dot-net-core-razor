using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
using System.Linq.Expressions;
using System.Text.Encodings.Web;

namespace OrderingApplication.Helpers
{
    public static class CustomHtmlHelpers
    {
        public static IHtmlContent LabeledTextboxFor<TModel, TResult>(
            this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression, string labelText)
        {
            var label = htmlHelper.LabelFor(expression, labelText);
            var textBox =  htmlHelper.TextBoxFor(expression, new { @class = "form-control" });

            var writer = new StringWriter();
            label.WriteTo(writer, HtmlEncoder.Default);
            textBox.WriteTo(writer, HtmlEncoder.Default);

            return new HtmlString(writer.GetStringBuilder().ToString());
        }
    }
}
