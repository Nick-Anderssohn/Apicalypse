# ares.apicalypse
This is an Apicalypse library that offers a convenient builder for [Apicalypse](https://apicalypse.io/) queries.
The easiest way to learn it is to check out the Apicalypse syntax at [their website](https://apicalypse.io/) and look
at the examples below.

## Examples 

## Simple example
Here is simple example of an Apicalypse query:
```
fields id;
where id = 12;
```

Here is the equivalent C# code:
```
string yourQuery = new ApicalypseBuilder {
    Fields = new List<string> {"id"},
    Where = new Equals("id", 12)
}.build();
```

### Somewhat complicated example
Here is an example query from Apicalypse's website:
```
fields a,b,c;
exclude d,e,f;
where b.count >= 14 & a != n;
limit 8;
offset 2;
sort b.count desc;
search "test";
```

Here is some example C# code to build the equivalent query:
```
string yourApicalypseQuery = new ApicalypseBuilder {
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
}.Build();
```
Note that you can leave out any part of the builder if you don't want it in the query (i.e. Search or Sort).
The most complicated part of building queries is usually the Where statement. I recommend checking out the 
WhereTest.cs file for more examples.