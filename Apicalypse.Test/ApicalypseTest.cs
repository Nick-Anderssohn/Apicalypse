using System.Collections.Generic;
using Ares;
using Ares.Apicalypse;
using Ares.Apicalypse.Where;
using Xunit;

namespace Apicalypse.Test {
    public class ApicalypseTest {
        [Fact]
        public void TestSimpleExample() {
            /*
             * fields id;
             * where id = 12;
             */
            const string desiredOutput = @"fields id;
where id = 12;
";
            var builder = new ApicalypseBuilder {
                Fields = new List<string> {"id"},
                Where = new Equals("id", 12)
            };
            
            Assert.Equal(desiredOutput, builder.Build());
        }
        
        [Fact]
        public void TestExampleQueryBuildsSuccessfully() {
            /*
             * fields a,b,c;
             * exclude d,e,f;
             * where b.count >= 14 & a != n;
             * limit 8;
             * offset 2;
             * sort b.count desc;
             * search "test";
             */
            const string desiredOutput = @"fields a,b,c;
exclude d,e,f;
where b.count >= 14 & a != n;
limit 8;
offset 2;
sort b.count desc;
search ""test"";
";

            var builder = new ApicalypseBuilder {
                Fields = new List<string> {"a", "b", "c"},
                Exclude = new List<string> {"d", "e", "f"},
                Where = new And {Components = new List<IWhereComponent> {
                    new LargerThanOrEqualTo("b.count", 14),
                    new NotEquals("a", "n")
                }},
                Limit = 8,
                Offset = 2,
                Sort = $"b.count {Sort.Desc}",
                Search = "test"
            };
            
            Assert.Equal(desiredOutput, builder.Build());
        }
    }
}