public static List<int> rotateLeft(int d, List<int> arr)
{
    for (int i = 0; i < d; i++)
    {
        arr.Add(arr[0]);
        arr.RemoveAt(0);
    }
    return arr;
}