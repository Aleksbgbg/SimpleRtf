namespace SimpleRtf.Models
{
    using System.Text;

    public class Hyperlink : Inline
    {
        public Hyperlink(string url)
        {
            Url = url;
        }

        public Hyperlink(string url, string displayText)
        {
            Url = url;
            DisplayText = displayText;
        }

        public string Url { get; }

        public string DisplayText { get; set; }

        internal override void FormatRtf(StringBuilder stringBuilder)
        {
            stringBuilder.AppendFormat(@"{{\field{{\*\fldinst HYPERLINK ""{0}""}}{{\fldrslt {1}}}", Url, DisplayText);
        }
    }
}