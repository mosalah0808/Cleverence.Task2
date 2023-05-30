using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cleverence.Task2
{
    public static class SpiralMatrixCompute
    {
        public static int[] ReverseSpiralOrder(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int[] result = new int[m * n];
            int index = 0;

            for (int layer = 0; layer < Math.Min(m, n) / 2; layer++)
            {
                // Добавляем левый столбец матрицы
                for (int i = layer; i <= m - layer - 1; i++)
                {
                    result[index++] = matrix[i, layer];
                }

                // Добавляем нижнюю строку матрицы
                for (int i = layer + 1; i < n - layer; i++) 
                {
                    result[index++] = matrix[m - layer - 1, i];
                }

                // Добавляем правый столбец матрицы
                for (int i = m - layer - 2; i >= layer; i--)
                {
                    result[index++] = matrix[i, n - layer - 1];
                }

                // Добавляем верхнюю строку матрицы
                for (int i = n - layer - 2; i > layer; i--)
                {
                    result[index++] = matrix[layer, i];
                }
            }

            // Добавляем центральный элемент, если матрица имеет нечетные размеры
            if (Math.Min(m, n) % 2 == 1) 
            {
                int mid = Math.Min(m, n) / 2;
                 if (m<n) 
                    {                        
                        for (int i = mid; i<n - mid; i++) 
                        {
                            result[index++] = matrix[mid, i];
                        }
                 }
                else 
                {
                    for (int i = mid; i < m - mid; i++)
                    {
                        result[index++] = matrix[i, mid];
                    }
                }
            }

            return result;
        }
    }
}
