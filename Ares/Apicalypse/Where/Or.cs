using System;
using System.Collections.Generic;

namespace Ares.Apicalypse.Where {
    public class Or : BaseMultiComponent<IWhereComponent> {
        
        public override string ToString() {
            return string.Join(" | ", Components);
        }
    }
}