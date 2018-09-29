namespace SimpleRtf.Models
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;

    using SimpleRtf.Constants;

    public sealed class Document : Content
    {
        public List<Section> Sections { get; } = new List<Section>();

        public async Task SaveAsync(Stream stream)
        {
            using (StreamWriter streamWriter = new StreamWriter(stream, Encoding.ASCII, 1024, true))
            {
                await streamWriter.WriteAsync(FormatRtf());
            }

            stream.Position = 0;
        }

        internal override void FormatRtf(StringBuilder stringBuilder)
        {
            stringBuilder.Append('{');

            // Header
            stringBuilder.AppendFormat(@"\rtf1{0}", CharacterSet.Ansi);

            // Document
            foreach (Section section in Sections)
            {
                section.FormatRtf(stringBuilder);
            }

            stringBuilder.Append('}');
        }
    }
}