namespace SimpleRtf.Models
{
    using System.Collections.Generic;

    public sealed class Document : Content
    {
        private readonly List<Block> _blocks = new List<Block>();
    }
}