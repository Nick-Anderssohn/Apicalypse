using System.Collections.Generic;

namespace Ares.Apicalypse.Where {
    public class Or : IWhereComponent {
        public List<IWhereComponent> Components { get; set; } = new List<IWhereComponent>();
        
        public Or Add(IWhereComponent component) {
            Components.Add(component);
            return this;
        }

        public Or AddRange(IEnumerable<IWhereComponent> components) {
            Components.AddRange(components);
            return this;
        }
        
        public override string ToString() {
            return string.Join(" | ", Components);
        }
    }
}