namespace Ares.Apicalypse.Where {
    public class ContainsAll<T> : BaseContainsAll<T> {
        public ContainsAll(string fieldName) : base(fieldName, "=") { }
    }
}