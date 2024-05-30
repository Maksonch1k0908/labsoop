using System.Collections;

public class Lake<T> : IEnumerable<T>
{
    private List<T> listStones;

    public Lake(T[] values)
    {
        listStones = new List<T>(values);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < listStones.Count; i += 2)
        {
            yield return listStones[i];
        }

        int lastIndex = listStones.Count % 2 == 0 ? listStones.Count - 1 : listStones.Count - 2;

        for (int i = lastIndex; i >= 0; i -= 2)
        {
            yield return listStones[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}