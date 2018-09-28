namespace SimpleRtf.Models
{
    public abstract class Content
    {
        public string Font { get; set; } = "Calibri (Body)";

        public double FontSize { get; set; } = 12.0;
    }
}