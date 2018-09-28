namespace SimpleRtf.Models
{
    public abstract class Inline : Content
    {
        public string Content { get; private protected set; }
    }
}