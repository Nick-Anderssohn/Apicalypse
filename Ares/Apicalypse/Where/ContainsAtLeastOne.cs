namespace Ares.Apicalypse.Where {
    public class ContainsAtLeastOne<T> : BaseContainsAtLeastOne<T> {
        public ContainsAtLeastOne(string fieldName) : base(fieldName, "=") { }
    }
}