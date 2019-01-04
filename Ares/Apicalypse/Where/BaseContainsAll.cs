using System;
using System.Collections.Generic;

namespace Ares.Apicalypse.Where {
    public abstract class BaseContainsAll<T> : BaseMultiComponent<T> {
        private readonly string _fieldName;
        private readonly string _logicalOperator;
        
        /// <summary>
        /// Values is the same thing as Components. Leaving this here to
        /// keep from breaking the existing API.
        /// </summary>
        [Obsolete("Use Components instead. Values will be removed in the 1.0.0 release.")]
        public IEnumerable<T> Values {
            get => Components;
            set => Components = value;
        }
        
        protected BaseContainsAll(string fieldName, string logicalOperator) {
            _fieldName = fieldName;
            _logicalOperator = logicalOperator;
        }

        public override string ToString() {
            return $"{_fieldName} {_logicalOperator} [{string.Join(",", Components)}]";
        }
    }
}