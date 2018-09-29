namespace SimpleRtf.Models
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class Block : Content
    {
        public List<Inline> Inlines { get; } = new List<Inline>();

        internal override void FormatRtf(StringBuilder stringBuilder)
        {
            foreach (Inline inline in Inlines)
            {
                inline.FormatRtf(stringBuilder);
            }
        }
    }
}