using System.Collections.Generic;
using Ares.Apicalypse.Where;
using Xunit;

namespace Apicalypse.Test {
    public class WhereTest {
        [Fact]
        public void AndTest() {
            const string expectedOutput = "a > b & c = d & e <= f";

            var andStatement = new And {
                Components = new List<IWhereComponent> {
                    new LargerThan("a", "b"),
                    new Equals("c", "d"),
                    new LessThanOrEqualTo("e", "f")
                }
            };

            Assert.Equal(expectedOutput, andStatement.ToString());
        }

        [Fact]
        public void OrTest() {
            const string expectedOutput = "a < b | c != d | e >= f";

            var orStatement = new Or {
                Components = new List<IWhereComponent> {
                    new LessThan("a", "b"),
                    new NotEquals("c", "d"),
                    new LargerThanOrEqualTo("e", "f")
                }
            };

            Assert.Equal(expectedOutput, orStatement.ToString());
        }

        [Fact]
        public void ContainsAllTest() {
            // a = [1,2,3]
            const string expectedOutput = "a = [1,2,3]";
            
            var containsAll = new ContainsAll<int>("a") {
                Components = new List<int> {1, 2, 3}
            };
            
            Assert.Equal(expectedOutput, containsAll.ToString());
        }
        
        [Fact]
        public void DoesNotContainsAllTest() {
            // a != [1,2,3]
            const string expectedOutput = "a != [1,2,3]";
            
            var containsAll = new DoesNotContainAll<int>("a") {
                Components = new List<int> {1, 2, 3}
            };
            
            Assert.Equal(expectedOutput, containsAll.ToString());
        }
        
        [Fact]
        public void ContainsAtLeastOneOfTest() {
            // a = (1,2,3)
            const string expectedOutput = "a = (1,2,3)";
            
            var containsAll = new ContainsAtLeastOne<int>("a") {
                Components = new List<int> {1, 2, 3}
            };
            
            Assert.Equal(expectedOutput, containsAll.ToString());
        }

        [Fact]
        public void ContainsNoneTest() {
            // a != (1,2,3)
            const string expectedOutput = "a != (1,2,3)";
            
            var containsAll = new ContainsNone<int>("a") {
                Components = new List<int> {1, 2, 3}
            };
            
            Assert.Equal(expectedOutput, containsAll.ToString());
        }
        
        [Fact]
        public void ExclusivelyContainsAllTest() {
            // a = {1,2,3}
            const string expectedOutput = "a = {1,2,3}";
            
            var containsAll = new ExclusivelyContains<int>("a") {
                Components = new List<int> {1, 2, 3}
            };
            
            Assert.Equal(expectedOutput, containsAll.ToString());
        }
    }
}