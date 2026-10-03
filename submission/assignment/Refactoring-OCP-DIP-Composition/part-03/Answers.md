# Part 03 — answers

---

## BlockedUsers

- Time complexity before:

`O(n × m)`, where `n` is the number of requests and `m` is the number of blocked IDs.

- Time (ms) before:

`17 ms`

- What did you change?

Changed `blockedIds` from `List<int>` to `HashSet<int>` to make membership checks faster.

- Time complexity after:

`O(n)` average case, because `HashSet.Contains()` is O(1) on average.

- Time (ms) after:

`0 ms`

---

## Students

- What was the problem?

`GetAllStudents()` created all 1,000,000 students and stored them in memory before returning the collection, even though the caller might only need a few students.

- What did you change?

Changed `GetAllStudents()` to return `IEnumerable<Student>` and used `yield return` to generate students lazily. This allows students to be created only when requested and stops generating them when the caller uses `break`.
