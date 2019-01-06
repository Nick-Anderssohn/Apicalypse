namespace Ares.Apicalypse.Where {
    public class And : BaseMultiComponent<IWhereComponent> {
        public override string ToString() {
            return string.Join(" & ", Components);
        }
    }
}