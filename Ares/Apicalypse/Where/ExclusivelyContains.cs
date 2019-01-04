using System.Collections.Generic;
using System.Text;

namespace Ares.Apicalypse.Where {
    public class ExclusivelyContains<T> : IWhereComponent {
        private readonly string _fieldName;
        private readonly string _logicalOperator;
        public List<T> Values { get; set; } = new List<T>();

        public ExclusivelyContains(string fieldName) {
            _fieldName = fieldName;
        }

        public override string ToString() {
            return new StringBuilder()
                .Append(_fieldName)
                .Append(" = {")
                .Append(string.Join(",", Values))
                .Append("};")
                .ToString();
        }
    }
}