using Microsoft.AspNetCore.Razor.TagHelpers;

namespace GS_GreenCycle.TagHelpers
{
    public class SuporteTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string email = context.AllAttributes["mailTo"].Value.ToString();
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailTo:" + email);
            output.Content.SetContent("Suporte");
        }
    }
}
