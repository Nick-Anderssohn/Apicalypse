namespace Ares.Apicalypse.Where {
    public abstract class BaseContainsAtLeastOne<T> : BaseMultiComponent<T> {
        private readonly string _fieldName;
        private readonly string _logicalOperator;

        protected BaseContainsAtLeastOne(string fieldName, string logicalOperator) {
            _fieldName = fieldName;
            _logicalOperator = logicalOperator;
        }

        public override string ToString() {
            return $"{_fieldName} {_logicalOperator} ({string.Join(",", Components)})";
        }
    }
}