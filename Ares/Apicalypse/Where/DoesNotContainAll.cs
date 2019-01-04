namespace Ares.Apicalypse.Where {
    public class DoesNotContainAll<T> : BaseContainsAll<T> {
        public DoesNotContainAll(string fieldName) : base(fieldName, "!=") { }
    }
}