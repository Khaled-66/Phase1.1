public static List<int> reverseArray(List<int> a)
{
    int n = a.Count;
    for (int i = 0; i < n / 2; i++)
    {
        int temp = a[i];
        a[i] = a[n - i - 1];
        a[n - i - 1] = temp;

    }
    return a;
}
