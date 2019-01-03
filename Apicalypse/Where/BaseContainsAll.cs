using System.Collections.Generic;

namespace Apicalypse.Where {
    public abstract class BaseContainsAll<T> : IWhereComponent {
        private readonly string _fieldName;
        private readonly string _logicalOperator;
        public List<T> Values { get; set; } = new List<T>();
        
        protected BaseContainsAll(string fieldName, string logicalOperator) {
            _fieldName = fieldName;
            _logicalOperator = logicalOperator;
        }

        public override string ToString() {
            return $"{_fieldName} {_logicalOperator} [{string.Join(",", Values)}]";
        }
    }
}