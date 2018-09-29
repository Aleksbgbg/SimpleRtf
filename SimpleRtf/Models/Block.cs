namespace SimpleRtf.Models
{
    using System.Collections.Generic;

    public abstract class Block : Content
    {
        public List<Inline> Inlines { get; } = new List<Inline>();
    }
}