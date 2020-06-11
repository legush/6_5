using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList col = new ArrayList() { 1, 2, 3, 4, 5, -6, -7, -8, -9, -10 };
            ArrayList col2 = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                col.Add(0);
            }

            for (int i = (col.Count / 2) - 2; i < 10;)
            {
                if ((int)col[i] == 0) break;
                else
                {
                    col2.Add(col[i]);
                    col.Remove(col[i]);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                col.Add(col2[i]);
            }

            col.RemoveAt(0);
            col.RemoveAt(col.Count - 1);

            Console.Write("col: ");
            for (int i = 0; i < col.Count; i++)
            {
                Console.Write(col[i] + " | ");
            }
        }
    }
}