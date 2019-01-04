using System;
using System.Collections.Generic;
using System.Text;

namespace Ares.Apicalypse.Where {
    public class ExclusivelyContains<T> : BaseMultiComponent<T> {
        private readonly string _fieldName;

        /// <summary>
        /// Values is the same thing as Components. Leaving this here to
        /// keep from breaking the existing API.
        /// </summary>
        [Obsolete("Use Components instead. Values will be removed in the 1.0.0 release.")]
        public IEnumerable<T> Values {
            get => Components;
            set => Components = value;
        }

        public ExclusivelyContains(string fieldName) {
            _fieldName = fieldName;
        }

        public override string ToString() {
            return new StringBuilder()
                .Append(_fieldName)
                .Append(" = {")
                .Append(string.Join(",", Components))
                .Append("};")
                .ToString();
        }
    }
}