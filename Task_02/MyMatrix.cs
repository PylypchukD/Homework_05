using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class MyMatrix
    {
        int[,] matrix;
        Random rand = new Random();
        private uint row, col;
        public MyMatrix(uint row, uint col)
        {
            this.row = row;
            this.col = col;
            GeneratMatrix();
        }

        private void GeneratMatrix()
        {
            matrix = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rand.Next(10, 99);
                }
            }
        }

        public void Show()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Change(uint newRow, uint newCol)
        {
            int[,] newMatrix = new int[newRow, newCol];
            for (int i = 0; i < newRow; i++)
            {
                for (int j = 0; j < newCol; j++)
                {
                    if (i > row-1 || j > col-1) 
                    {
                        newMatrix[i, j] = rand.Next(10, 99);
                    }
                    else
                    {
                        newMatrix[i, j] = matrix[i,j];
                    }
                }
            }
            matrix = newMatrix;
            row = newRow;
            col = newCol;
        }

    }
}
