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
