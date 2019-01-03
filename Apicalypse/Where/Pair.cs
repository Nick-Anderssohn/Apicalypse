namespace Apicalypse.Where {
    public abstract class Pair : IWhereComponent {
        private readonly string _logicalOperator;
        private readonly object _left;
        private readonly object _right;

        protected Pair(string logicalOperator, object left, object right) {
            _logicalOperator = logicalOperator;
            _left = left;
            _right = right;
        }

        public override string ToString() {
            return $"{_left} {_logicalOperator} {_right}";
        }
    }
}