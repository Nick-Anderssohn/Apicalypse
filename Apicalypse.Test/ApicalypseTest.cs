using System.Collections.Generic;
using Apicalypse.Where;
using Xunit;

namespace Apicalypse.Test {
    public class ApicalypseTest {
        [Fact]
        public void TestBuildsSuccessfully() {
            var desiredOutput = @"fields a,b,c;
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