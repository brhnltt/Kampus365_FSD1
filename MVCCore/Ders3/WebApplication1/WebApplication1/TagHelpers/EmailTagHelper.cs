using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApplication1.TagHelpers
{
    // <email text="Send email!" mail="abc@abc.com"></email>
    // <a href="mailto:abc@abc.com">Send email!</a>

    [HtmlTargetElement("email", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class EmailTagHelper : TagHelper
    {
        public string Mail { get; set; }
        public string Text { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("href", $"mailto:{Mail}");
            output.Content.SetContent(Text);


        }
    }
}
