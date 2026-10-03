# Part 02 — answers

---

## Task 2.1 — Research

### IReadOnlyDictionary<TKey, TValue>

`IReadOnlyDictionary<TKey, TValue>` is an interface that represents a collection of key/value pairs that can be read but does not expose methods for adding or removing entries. It supports accessing values by key and enumerating the collection. It does not guarantee a particular sort order.

### IReadOnlyDictionary vs Dictionary

`Dictionary<TKey, TValue>` is a mutable collection, so code that has a `Dictionary` reference can add, remove, or update entries.

`IReadOnlyDictionary<TKey, TValue>` exposes only read-oriented operations. This makes it useful when a method should allow callers to read the data without giving them an API for modifying the dictionary.

### Why return IReadOnlyDictionary instead of Dictionary?

A public method may return `IReadOnlyDictionary<TKey, TValue>` when the caller only needs to read the data. This hides mutation operations such as `Add` and `Remove` and communicates that the returned collection is intended to be consumed as read-only.

It also avoids exposing the concrete collection type as part of the method's public API.

### SortedDictionary vs Dictionary

`Dictionary<TKey, TValue>` is optimized for fast key-based lookup and does not provide sorted-key ordering.

`SortedDictionary<TKey, TValue>` stores key/value pairs sorted by their keys. Its lookup is generally slower than `Dictionary<TKey, TValue>`, but it is useful when the collection must always be traversed in key order.

### When would you choose each?

- **Dictionary<TKey, TValue>** — when fast lookup by key is the main requirement and sorted ordering is not needed.

- **IReadOnlyDictionary<TKey, TValue>** — when callers should be able to read key/value data but should not modify the collection through the returned API.

- **SortedDictionary<TKey, TValue>** — when the data must remain sorted by key while items are added or removed.

### Sources

- [Microsoft Learn — IReadOnlyDictionary<TKey, TValue>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)
- [Microsoft Learn — Selecting a Collection Class](https://learn.microsoft.com/en-us/dotnet/standard/collections/selecting-a-collection-class)
- [Microsoft Learn — SortedDictionary<TKey, TValue>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2)

---

## Task 2.2 — Pick the Collection

- **S1 — Dictionary<int, Student>** — Fast lookup by key using the national ID.

- **S2 — HashSet<string>** — Prevents duplicate tags and provides fast membership checks.

- **S3 — List<Grade>** — Preserves insertion order and allows duplicate values.

- **S4 — IReadOnlyDictionary<int, decimal>** — Allows reading key/value pairs without exposing mutation methods.

- **S5 — SortedDictionary<DateTime, Session>** — Keeps entries sorted by their keys automatically.

- **S6 — IEnumerable<Result>** — Supports deferred iteration and allows the caller to stop early.
