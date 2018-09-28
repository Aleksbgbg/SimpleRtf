namespace SimpleRtf.Models
{
    using System.Collections.Generic;

    public abstract class Block
    {
        private protected List<Inline> Inlines { get; } = new List<Inline>();
    }
}