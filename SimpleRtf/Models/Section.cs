namespace SimpleRtf.Models
{
    using System.Collections.Generic;
    using System.Text;

    public class Section : Content
    {
        public List<Block> Blocks { get; } = new List<Block>();

        internal override void FormatRtf(StringBuilder stringBuilder)
        {
            foreach (Block block in Blocks)
            {
                block.FormatRtf(stringBuilder);
            }
        }
    }
}