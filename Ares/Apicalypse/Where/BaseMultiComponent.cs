using System;
using System.Collections.Generic;

namespace Ares.Apicalypse.Where {
    public class BaseMultiComponent<T> : IWhereComponent {
        public IEnumerable<T> Components { get; set; } = new List<T>();
        
        /// <summary>
        /// Only call if this object's Components property implements ICollection.
        /// </summary>
        public BaseMultiComponent<T> Add(T component) {
            if (Components is ICollection<T> collection) {
                collection.Add(component);
            } else {
                throw new ArgumentException("Components must implement ICollection to use the Add function");
            }

            return this;
        }
        
        /// <summary>
        /// Only call if this object's Components property is a List.
        /// </summary>
        public BaseMultiComponent<T> AddRange(IEnumerable<T> components) {
            if (Components is List<T> list) {
                list.AddRange(components);
            } else {
                throw new ArgumentException("Components must be a List to use the AddRange function");
            }
            
            return this;
        }
    }
}