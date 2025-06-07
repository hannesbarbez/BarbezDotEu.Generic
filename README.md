# BarbezDotEu.Generic

## Contents

- [LinqHelper](#T-BarbezDotEu-Generic-LinqHelper 'BarbezDotEu.Generic.LinqHelper')
  - [GenerateRandomList\`\`1(source,numberOfItems)](#M-BarbezDotEu-Generic-LinqHelper-GenerateRandomList``1-System-Collections-Generic-IEnumerable{``0},System-Int32- 'BarbezDotEu.Generic.LinqHelper.GenerateRandomList``1(System.Collections.Generic.IEnumerable{``0},System.Int32)')
  - [PickRandom\`\`1(source)](#M-BarbezDotEu-Generic-LinqHelper-PickRandom``1-System-Collections-Generic-IEnumerable{``0}- 'BarbezDotEu.Generic.LinqHelper.PickRandom``1(System.Collections.Generic.IEnumerable{``0})')
  - [PickRandom\`\`1(source,count)](#M-BarbezDotEu-Generic-LinqHelper-PickRandom``1-System-Collections-Generic-IEnumerable{``0},System-Int32- 'BarbezDotEu.Generic.LinqHelper.PickRandom``1(System.Collections.Generic.IEnumerable{``0},System.Int32)')
  - [Shuffle\`\`1(source)](#M-BarbezDotEu-Generic-LinqHelper-Shuffle``1-System-Collections-Generic-IEnumerable{``0}- 'BarbezDotEu.Generic.LinqHelper.Shuffle``1(System.Collections.Generic.IEnumerable{``0})')
  - [True\`\`1()](#M-BarbezDotEu-Generic-LinqHelper-True``1 'BarbezDotEu.Generic.LinqHelper.True``1')
  - [False\`\`1()](#M-BarbezDotEu-Generic-LinqHelper-False``1 'BarbezDotEu.Generic.LinqHelper.False``1')
  - [Or\`\`1(expr1,expr2)](#M-BarbezDotEu-Generic-LinqHelper-Or``1-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}- 'BarbezDotEu.Generic.LinqHelper.Or``1')
  - [And\`\`1(expr1,expr2)](#M-BarbezDotEu-Generic-LinqHelper-And``1-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}- 'BarbezDotEu.Generic.LinqHelper.And``1')
- [ReflectionHelper](#T-BarbezDotEu-Generic-ReflectionHelper 'BarbezDotEu.Generic.ReflectionHelper')
  - [GetPropertyValue\`\`1(object,propertyName)](#M-BarbezDotEu-Generic-ReflectionHelper-GetPropertyValue``1-System-Object,System-String- 'BarbezDotEu.Generic.ReflectionHelper.GetPropertyValue``1(System.Object,System.String)')

<a name='T-BarbezDotEu-Generic-LinqHelper'></a>
## LinqHelper `type`

##### Namespace

BarbezDotEu.Generic

##### Summary

Generic helper extension method adapted for Linq from multiple sources, including:
https://stackoverflow.com/questions/2019417/how-to-access-random-item-in-list and 
http://www.albahari.com/nutshell/predicatebuilder.aspx.

<a name='M-BarbezDotEu-Generic-LinqHelper-GenerateRandomList``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>
### GenerateRandomList\`\`1(source,numberOfItems) `method`

##### Summary

Generates a randomized list of a specified length from a given [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1').
If the required size exceeds the collection, elements are repeatedly selected.

##### Returns

A randomized list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The source collection. |
| numberOfItems | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of items required. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements. |

<a name='M-BarbezDotEu-Generic-LinqHelper-PickRandom``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### PickRandom\`\`1(source) `method`

##### Summary

Selects a random single item from a given [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1').

##### Returns

A randomly chosen item from the collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The source collection. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the collection. |

##### Exceptions

[System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException'): Thrown if the source collection is empty.

<a name='M-BarbezDotEu-Generic-LinqHelper-PickRandom``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>
### PickRandom\`\`1(source,count) `method`

##### Summary

Picks a specified number of random items from a given [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'). 
If the requested count is larger than the collection size, all available items are returned.

##### Returns

A random subset of items.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The source collection. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of items to retrieve. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the collection. |

<a name='M-BarbezDotEu-Generic-LinqHelper-Shuffle``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### Shuffle\`\`1(source) `method`

##### Summary

Randomly shuffles a given collection.

##### Returns

A shuffled version of the original collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The collection to shuffle. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the collection. |

<a name='M-BarbezDotEu-Generic-LinqHelper-True``1'></a>
### True\`\`1() `method`

##### Summary

Returns an expression that always evaluates to true.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the expression. |

<a name='M-BarbezDotEu-Generic-LinqHelper-False``1'></a>
### False\`\`1() `method`

##### Summary

Returns an expression that always evaluates to false.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the expression. |

<a name='M-BarbezDotEu-Generic-LinqHelper-Or``1-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}-'></a>
### Or\`\`1(expr1,expr2) `method`

##### Summary

Combines two boolean expressions using a logical OR operation.

##### Returns

A combined expression that evaluates to true if either input expression evaluates to true.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expr1 | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}') | The first expression. |
| expr2 | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}') | The second expression. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the expressions. |

<a name='M-BarbezDotEu-Generic-LinqHelper-And``1-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}-'></a>
### And\`\`1(expr1,expr2) `method`

##### Summary

Combines two boolean expressions using a logical AND operation.

##### Returns

A combined expression that evaluates to true only if both input expressions evaluate to true.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expr1 | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}') | The first expression. |
| expr2 | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}') | The second expression. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the expressions. |

<a name='T-BarbezDotEu-Generic-ReflectionHelper'></a>
## ReflectionHelper `type`

##### Namespace

BarbezDotEu.Generic

##### Summary

Provides reflection-based helper extension methods.
Adapted from https://stackoverflow.com/a/1954663 and other sources.

<a name='M-BarbezDotEu-Generic-ReflectionHelper-GetPropertyValue``1-System-Object,System-String-'></a>
### GetPropertyValue\`\`1(object,propertyName) `method`

##### Summary

Retrieves the value of a specified property from an object.
Example usage:

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| object | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source object. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the property, supporting nested properties. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The expected type of the property value. |

##### Returns

The property value if found; otherwise, the default value of `T`.