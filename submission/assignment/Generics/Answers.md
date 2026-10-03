# Generics — Answers

---

## Step 2 — Course Store

### What is the same between StudentStore and CourseStore?

Both stores have the same basic operations:

- Add an item.
- Get an item by ID.
- Get all items.
- Remove an item by ID.

Both use a `List<T>` internally and use the item's `Id` to find or remove it.

### What is different?

The main difference is the type of object stored.

`StudentStore` stores `Student` objects, while `CourseStore` stores `Course` objects.

The `Student` class has:

- `Id`
- `Name`

The `Course` class has:

- `Id`
- `Title`
- `Price`

---

## Step 3 — Generic Store

### Compiler Error

`'T' does not contain a definition for 'Id'`

Another error appears because `T` can be a value type:

`Cannot convert null to type parameter 'T' because it could be a non-nullable value type.`

### Why does this happen?

`Store<T>` can work with any type, so the compiler cannot assume that `T` has an `Id` property.

For example, `T` could be `string` or `int`, and neither type has an `Id` property.

The `return null` statement also causes an error because `T` could be a non-nullable value type such as `int`, which cannot be assigned `null`.

This shows that the generic store needs a constraint that guarantees the stored type has an `Id`.

---

## Step 7 — Generic Constraints and Reuse

### Why can we use `Store<Student>` and `Store<Course>`?

Both `Student` and `Course` implement `IHasId`.

The constraint:

```csharp
where T : IHasId
```
