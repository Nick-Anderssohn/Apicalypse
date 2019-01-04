using System.Collections.Generic;
using System.Text;
using Ares.Apicalypse.Where;

namespace Ares.Apicalypse {
    /// <summary>
    /// A builder for Apicalypse queries: https://apicalypse.io
    /// </summary>
    public class ApicalypseBuilder {
        public IList<string> Fields { get; set; }
        public IList<string> Exclude { get; set; }
        public IWhereComponent Where { get; set; }
        public int? Limit { get; set; }
        public int? Offset { get; set; }
        public string Sort { get; set; }
        public string Search { get; set; }

        public string Build() {
            var builder = new StringBuilder();

            if (Fields != null && Fields.Count > 0) {
                builder.AppendLine($"fields {string.Join(",", Fields)};");
            }

            if (Exclude != null && Exclude.Count > 0) {
                builder.AppendLine($"exclude {string.Join(",", Exclude)};");
            }

            if (Where != null) {
                builder.AppendLine($"where {Where};");
            }

            if (Limit != null) {
                builder.AppendLine($"limit {Limit};");
            }

            if (Offset != null) {
                builder.AppendLine($"offset {Offset};");
            }

            if (Sort != null) {
                builder.AppendLine($"sort {Sort};");
            }

            if (Search != null) {
                builder.AppendLine($"search \"{Search}\";");
            }

            return builder.ToString();
        }
    }
}