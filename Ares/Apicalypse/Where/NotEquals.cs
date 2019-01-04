namespace Ares.Apicalypse.Where {
    public class NotEquals : Pair {
        public NotEquals(object left, object right) : base("!=", left, right) { }
    }
}