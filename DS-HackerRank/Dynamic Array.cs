public static List<int> dynamicArray(int n, List<List<int>> queries)
{
    int lastans = 0;
    List<List<int>> arr = new List<List<int>>(n);
    for (int i = 0; i < n; i++)
    {
        arr.Add(new List<int>());
    }
    List<int> answers = new List<int>();
    foreach (var query in queries)
    {
        int t = query[0]; int x = query[1]; int y = query[2];
        if (t == 1)
        {
            int idx = (x ^ lastans) % n;
            arr[idx].Add(y);
        }
        else if (t == 2)
        {
            int idx = (x ^ lastans) % n;
            lastans = arr[idx][y % arr[idx].Count];
            answers.Add(lastans);
        }
    }

    return answers;
}