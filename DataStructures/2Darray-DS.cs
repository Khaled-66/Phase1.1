public static int hourglassSum(List<List<int>> arr)
{
    int s = arr.Count;
    int max = -2147483648;
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            int r = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
            if (r > max)
            {
                max = r;
            }
        }
    }
    return max;
}