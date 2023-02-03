# BarbezDotEu.Generic

## Contents

- [LinqHelper](#T-BarbezDotEu-Generic-LinqHelper 'BarbezDotEu.Generic.LinqHelper')
  - [GenerateRandomList\`\`1(source,numberOfItems)](#M-BarbezDotEu-Generic-LinqHelper-GenerateRandomList``1-System-Collections-Generic-IEnumerable{``0},System-Int32- 'BarbezDotEu.Generic.LinqHelper.GenerateRandomList``1(System.Collections.Generic.IEnumerable{``0},System.Int32)')
  - [PickRandom\`\`1(source)](#M-BarbezDotEu-Generic-LinqHelper-PickRandom``1-System-Collections-Generic-IEnumerable{``0}- 'BarbezDotEu.Generic.LinqHelper.PickRandom``1(System.Collections.Generic.IEnumerable{``0})')
  - [PickRandom\`\`1(source,count)](#M-BarbezDotEu-Generic-LinqHelper-PickRandom``1-System-Collections-Generic-IEnumerable{``0},System-Int32- 'BarbezDotEu.Generic.LinqHelper.PickRandom``1(System.Collections.Generic.IEnumerable{``0},System.Int32)')
  - [Shuffle\`\`1(source)](#M-BarbezDotEu-Generic-LinqHelper-Shuffle``1-System-Collections-Generic-IEnumerable{``0}- 'BarbezDotEu.Generic.LinqHelper.Shuffle``1(System.Collections.Generic.IEnumerable{``0})')
- [ReflectionHelper](#T-BarbezDotEu-Generic-ReflectionHelper 'BarbezDotEu.Generic.ReflectionHelper')
  - [GetPropertyValue\`\`1()](#M-BarbezDotEu-Generic-ReflectionHelper-GetPropertyValue``1-System-Object,System-String- 'BarbezDotEu.Generic.ReflectionHelper.GetPropertyValue``1(System.Object,System.String)')

<a name='T-BarbezDotEu-Generic-LinqHelper'></a>
## LinqHelper `type`

##### Namespace

BarbezDotEu.Generic

##### Summary

Generic helper extension method adapted for Linq
from https://stackoverflow.com/questions/2019417/how-to-access-random-item-in-list, 
http://www.albahari.com/nutshell/predicatebuilder.aspxamongst, and others.

<a name='M-BarbezDotEu-Generic-LinqHelper-GenerateRandomList``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>
### GenerateRandomList\`\`1(source,numberOfItems) `method`

##### Summary

Generates n number of items randomly from a given [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') source,
even if the source list has less items than the number of items to return (as provided by the numberOfThings).

##### Returns

The random list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The source. |
| numberOfItems | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of items to take. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type. |

<a name='M-BarbezDotEu-Generic-LinqHelper-PickRandom``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### PickRandom\`\`1(source) `method`

##### Summary

From a given [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'), selects a random single item.

##### Returns

One item, randomly chosen from the given collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The source collection to pick one item out of. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to pick one of. |

<a name='M-BarbezDotEu-Generic-LinqHelper-PickRandom``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>
### PickRandom\`\`1(source,count) `method`

##### Summary

Picks an n number of items randomly from the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'). If n is larger than the number of items in the list, returns all items in the list only (which in this case is less than the number of items given to return).

##### Returns

The random list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The source. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of items to take. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type. |

<a name='M-BarbezDotEu-Generic-LinqHelper-Shuffle``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### Shuffle\`\`1(source) `method`

##### Summary

Randomly shuffles the given source collection.

##### Returns

A shuffled version of the given collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The collection to shuffle. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The types to be found in the collection to shuffle. |

<a name='T-BarbezDotEu-Generic-ReflectionHelper'></a>
## ReflectionHelper `type`

##### Namespace

BarbezDotEu.Generic

##### Summary

Generic helper extension method adapted for Reflection from https://stackoverflow.com/a/1954663, amongst others.

<a name='M-BarbezDotEu-Generic-ReflectionHelper-GetPropertyValue``1-System-Object,System-String-'></a>
### GetPropertyValue\`\`1() `method`

##### Summary

Example use: DateTime now = DateTime.Now;
int min = GetPropertyValue<int>(now, "TimeOfDay.Minutes");
int hrs = now.GetPropertyValue<int>("TimeOfDay.Hours");

##### Parameters

This method has no parameters.
