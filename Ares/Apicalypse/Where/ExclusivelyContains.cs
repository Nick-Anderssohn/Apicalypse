using System.Text;

namespace Ares.Apicalypse.Where {
    public class ExclusivelyContains<T> : BaseMultiComponent<T> {
        private readonly string _fieldName;

        public ExclusivelyContains(string fieldName) {
            _fieldName = fieldName;
        }

        public override string ToString() {
            return new StringBuilder()
                .Append(_fieldName)
                .Append(" = {")
                .Append(string.Join(",", Components))
                .Append("}")
                .ToString();
        }
    }
}