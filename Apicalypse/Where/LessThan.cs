namespace Apicalypse.Where {
    public class LessThan : Pair {
        public LessThan(object left, object right) : base("<", left, right) { }
    }
}