public class NComparacion : IComparer<string>
{
    public int Comparaciones = 0;

    public int Compare(string x, string y)
    {
        Comparaciones++;
        return StringComparer.Ordinal.Compare(x, y);
    }
}