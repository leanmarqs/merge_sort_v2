class MergeSort
{
    public static void Merge(int[] A, int p, int q, int r)
    {
        int n1 = q - p + 1;
        int n2 = r - q;
        int[] L = new int[n1 + 1];
        int[] R = new int[n2 + 1];
        int i = 0, j = 0;

        for(i = 0; i < n1; i++)
            L[i] = A[p + i];

        for(j = 0; j < n2; j++)
            R[j] = A[q + j + 1];

        L[n1] = int.MaxValue;
        R[n2] = int.MaxValue;

        int k = i = j = 0;

        for (k = p; k <= r; k++)
        {
            if(L[i] <= R[j])
            {
                A[k] = L[i];
                i++;
            }
            else
            {
                A[k] = R[j];
                j++;
            }
        }

    }

    public static void Sort(int[]A, int p, int r)
    {
        if(p < r)
        {
            int q = (p + r) / 2;
            Sort(A, p, q);
            Sort(A, q + 1, r);
            Merge(A, p, q, r);
            
        }
    }

    public static void Main(string[] args)
    {
        int[] A = { 7, 3, 1, 5, 6, 4, 2 };

        Sort(A, 0, A.Length - 1);

        for (int i = 0; i < A.Length; i++)
            Console.Write(A[i] + " ");
    }
}
