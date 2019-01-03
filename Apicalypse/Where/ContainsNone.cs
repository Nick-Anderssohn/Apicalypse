namespace Apicalypse.Where {
    public class ContainsNone<T> : BaseContainsAtLeastOne<T> {
        public ContainsNone(string fieldName) : base(fieldName, "!=") { }
    }
}