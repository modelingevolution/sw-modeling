namespace Starter;

public static class SafeIteratorExtensions
{
    public static IEnumerable<T> SafeIterate<T>(this IReadOnlyList<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            T tmp = default(T);
            try
            {
                tmp = list[i];
            }
            catch
            {
            }

            yield return tmp;
        }
    }
}