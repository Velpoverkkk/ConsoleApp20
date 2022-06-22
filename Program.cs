using System;
class Program
{   //Определить является ли заданная квадратная матрица n-го порядка симметричной относительно побочной диагонали.
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int N, M,n=0;
        System.Console.WriteLine("Razmer massiva NxM");
        N = System.Convert.ToInt32(Console.ReadLine());
        M = System.Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[N, M];
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M; k++)
            {
                array[j, k] = rnd.Next(0, 2);
                Console.Write(array[j, k] + " ");
            }
            Console.WriteLine();
        }
        System.Console.WriteLine();
        int l = 2;
        for (int i = 0; i < N ; i++)
        {
            Console.WriteLine(array[i, i] + "  " + array[i, l]);
           if (array[i, i] == array[i,l])
           {
                n++;
           }
           l--;
        }
        if (n==N) Console.WriteLine("simetria");
        else Console.WriteLine("ups");
       /* for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M; k++)
            {
                Console.Write(array[j, k] + " ");
            }
            Console.WriteLine();
        }*/
    }
    
}
