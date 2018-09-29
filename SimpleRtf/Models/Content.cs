namespace SimpleRtf.Models
{
    using System.Text;

    public abstract class Content
    {
        public string Font { get; set; } = "Calibri (Body)";

        public double FontSize { get; set; } = 12.0;

        internal string FormatRtf()
        {
            StringBuilder stringBuilder = new StringBuilder();

            FormatRtf(stringBuilder);

            return stringBuilder.ToString();
        }

        internal abstract void FormatRtf(StringBuilder stringBuilder);
    }
}