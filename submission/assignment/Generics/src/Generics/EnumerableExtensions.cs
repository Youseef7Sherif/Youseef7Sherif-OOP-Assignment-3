namespace Generics;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Page<T>(
        this IEnumerable<T> source,
        int pageNumber,
        int pageSize)
    {
        if (pageNumber <= 0)
            throw new ArgumentException("Page number must be greater than 0.");

        if (pageSize <= 0)
            throw new ArgumentException("Page size must be greater than 0.");

        var startIndex = (pageNumber - 1) * pageSize;
        var index = 0;

        foreach (var item in source)
        {
            if (index >= startIndex + pageSize)
                yield break;

            if (index >= startIndex)
                yield return item;

            index++;
        }
    }
    public static T? FindById<T>(
    this IEnumerable<T> source,
    int id)
    where T : IHasId
    {
        foreach (var item in source)
        {
            if (item.Id == id)
                return item;
        }

        return default;
    }
    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(
    this IEnumerable<T> source)
    where T : IHasId
    {
        var dictionary = new Dictionary<int, T>();

        foreach (var item in source)
        {
            if (dictionary.ContainsKey(item.Id))
                throw new InvalidOperationException(
                    $"Duplicate Id: {item.Id}");

            dictionary.Add(item.Id, item);
        }

        return dictionary;
    }
}