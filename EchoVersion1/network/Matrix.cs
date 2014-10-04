using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoVersion1.network
{
    public class Matrix
    {

        public static float[,] multply (float[,] A, float[,] B)
        {
            int height = A.GetLength(0);
            int width = B.GetLength(1);

            float[,] C = new float[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    float sum = 0;
                    for (int k = 0; k < width; k++)
                    {
                        sum += A[i, k] * B[k, j];
                    }
                    C[i, j] = sum;
                }
            }
            return C;

        }



      



    }
}
