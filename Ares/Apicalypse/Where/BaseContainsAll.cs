using System;
using System.Collections.Generic;

namespace Ares.Apicalypse.Where {
    public abstract class BaseContainsAll<T> : BaseMultiComponent<T> {
        private readonly string _fieldName;
        private readonly string _logicalOperator;
        
        protected BaseContainsAll(string fieldName, string logicalOperator) {
            _fieldName = fieldName;
            _logicalOperator = logicalOperator;
        }

        public override string ToString() {
            return $"{_fieldName} {_logicalOperator} [{string.Join(",", Components)}]";
        }
    }
}