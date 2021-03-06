﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    [Serializable]
    public class Matrix
    {
        public int[,] matrix1 { get; set; }
        public int[,] matrix2 { get; set; }
        public int[,] matrix3 { get; set; }
        public int[,] matrix4 { get; set; }
        public int[,] matrix5 { get; set; }
        public int[,] matrix6 { get; set; }
        public int[,] matrix7 { get; set; }
        public int[,] matrix8 { get; set; }
        public int[,] matrix9 { get; set; }
        public int[,] matrix10 { get; set; }
        public int[,] matrix11 { get; set; }
        public int[,] matrix12 { get; set; }
        public int[,] matrix13 { get; set; }
        public int[,] matrix14 { get; set; }
        public int[,] matrix15 { get; set; }
        public int[,] matrix16 { get; set; }

        public List<int[,]> List;

        public Matrix()
        {
            List = new List<int[,]>();

            matrix1 = new int[9, 9] { { 1, 4, 5, 3, 2, 7, 6, 9, 8 }, 
                                      { 8, 3, 9, 6, 5, 4, 1, 2, 7 }, 
                                      { 6, 7, 2, 9, 1, 8, 5, 4, 3 }, 
                                      { 4, 9, 6, 1, 8, 5, 3, 7, 2 }, 
                                      { 2, 1, 8, 4, 7, 3, 9, 5, 6 }, 
                                      { 7, 5, 3, 2, 9, 6, 4, 8, 1 }, 
                                      { 3, 6, 7, 5, 4, 2, 8, 1, 9 }, 
                                      { 9, 8, 4, 7, 6, 1, 2, 3, 5 }, 
                                      { 5, 2, 1, 8, 3, 9, 7, 6, 4, } 
                                    };

            matrix2 = new int[9, 9] { { 2, 9, 5, 7, 4, 3, 8, 6, 1 }, 
                                      { 4, 3, 1, 8, 6, 5, 9, 2, 7 }, 
                                      { 8, 7, 6, 1, 9, 2, 5, 4, 3 }, 
                                      { 3, 8, 7, 4, 5, 9, 2, 1, 6 },
                                      { 6, 1, 2, 3, 8, 7, 4, 9, 5 },
                                      { 5, 4, 9, 2, 1, 6, 7, 3, 8 }, 
                                      { 7, 6, 3, 5, 2, 4, 1, 8, 9 },
                                      { 9, 2, 8, 6, 7, 1, 3, 5, 4 },
                                      { 1, 5, 4, 9, 3, 8, 6, 7, 2 }
                                    };

            matrix3 = new int[9, 9] { { 8, 2, 7, 1, 5, 4, 3, 9, 6 }, 
                                      { 9, 6, 5, 3, 2, 7, 1, 4, 8 }, 
                                      { 3, 4, 1, 6, 8, 9, 7, 5, 2 },
                                      { 5, 9, 3, 4, 6, 8, 2, 7, 1 }, 
                                      { 4, 7, 2, 5, 1, 3, 6, 8, 9 },
                                      { 6, 1, 8, 9, 7, 2, 4, 3, 5 },
                                      { 7, 8, 6, 2, 3, 5, 9, 1, 4 }, 
                                      { 1, 5, 4, 7, 9, 6, 8, 2, 3 }, 
                                      { 2, 3, 9, 8, 4, 1, 5, 6, 7 } 
                                    };

            matrix4 = new int[9, 9] { { 2, 4, 8, 3, 9, 5, 7, 1, 6 }, 
                                      { 5, 7, 1, 6, 2, 8, 3, 4, 9 }, 
                                      { 9, 3, 6, 7, 4, 1, 5, 8, 2 }, 
                                      { 6, 8, 2, 5, 3, 9, 1, 7, 4 },
                                      { 3, 5, 9, 1, 7, 4, 6, 2, 8 },
                                      { 7, 1, 4, 8, 6, 2, 9, 5, 3 },
                                      { 8, 6, 3, 4, 1, 7, 2, 9, 5 }, 
                                      { 1, 9, 5, 2, 8, 6, 4, 3, 7 },
                                      { 4, 2, 7, 9, 5, 3, 8, 6, 1 } 
                                    };

            matrix5 = new int[9, 9] { { 2, 9, 6, 3, 1, 8, 5, 7, 4 },
                                      { 5, 8, 4, 9, 7, 2, 6, 1, 3 }, 
                                      { 7, 1, 3, 6, 4, 5, 2, 8, 9 }, 
                                      { 6, 2, 5, 8, 9, 7, 3, 4, 1 }, 
                                      { 9, 3, 1, 4, 2, 6, 8, 5, 7 }, 
                                      { 4, 7, 8, 5, 3, 1, 9, 2, 6 },
                                      { 1, 6, 7, 2, 5, 3, 4, 9, 8 },
                                      { 8, 5, 9, 7, 6, 4, 1, 3, 2 },
                                      { 3, 4, 2, 1, 8, 9, 7, 6, 5 }
                                    };

            matrix6 = new int[9, 9] { { 1, 8, 4, 9, 6, 3, 7, 2, 5 },
                                      { 5, 6, 2, 7, 4, 8, 3, 1, 9 }, 
                                      { 3, 9, 7, 5, 1, 2, 8, 6, 4 },
                                      { 2, 3, 9, 6, 5, 7, 1, 4, 8 }, 
                                      { 7, 5, 6, 1, 8, 4, 2, 9, 3 },
                                      { 4, 1, 8, 2, 3, 9, 6, 5, 7 },
                                      { 9, 4, 1, 3, 7, 6, 5, 8, 2 }, 
                                      { 6, 2, 3, 8, 9, 5, 4, 7, 1 },
                                      { 8, 7, 5, 4, 2, 1, 9, 3, 6 } 
                                    };

            matrix7 = new int[9, 9] { { 9, 6, 3, 1, 7, 4, 2, 5, 8 }, 
                                      { 1, 7, 8, 3, 2, 5, 6, 4, 9 }, 
                                      { 2, 5, 4, 6, 8, 9, 7, 3, 1 }, 
                                      { 8, 2, 1, 4, 3, 7, 5, 9, 6 }, 
                                      { 4, 9, 6, 8, 5, 2, 3, 1, 7 }, 
                                      { 7, 3, 5, 9, 6, 1, 8, 2, 4 }, 
                                      { 5, 8, 9, 7, 1, 3, 4, 6, 2 }, 
                                      { 3, 1, 7, 2, 4, 6, 9, 8, 5 }, 
                                      { 6, 4, 2, 5, 9, 8, 1, 7, 3, } 
                                    };

            matrix8 = new int[9, 9] { { 1, 2, 3, 5, 6, 7, 8, 9, 4 },
                                      { 4, 5, 6, 1, 8, 9, 2, 3, 7 }, 
                                      { 7, 8, 9, 2, 3, 4, 1, 5, 6 },
                                      { 2, 1, 4, 3, 5, 6, 7, 8, 9 }, 
                                      { 3, 6, 5, 7, 9, 8, 4, 1, 2 }, 
                                      { 8, 9, 7, 4, 1, 2, 3, 6, 5 }, 
                                      { 5, 3, 2, 6, 4, 1, 9, 7, 8 }, 
                                      { 6, 4, 8, 9, 7, 3, 5, 2, 1 }, 
                                      { 9, 7, 1, 8, 2, 5, 6, 4, 3 } 
                                    };

            matrix9 = new int[9, 9] { { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                                      { 6, 7, 2, 1, 9, 5, 3, 4, 8 }, 
                                      { 1, 9, 8, 3, 4, 2, 5, 6, 7 }, 
                                      { 8, 5, 9, 7, 6, 1, 4, 2, 3 }, 
                                      { 4, 2, 6, 8, 5, 3, 7, 9, 1 }, 
                                      { 7, 1, 3, 9, 2, 4, 8, 5, 6 }, 
                                      { 9, 6, 1, 5, 3, 7, 2, 8, 4 }, 
                                      { 2, 8, 7, 4, 1, 9, 6, 3, 5 }, 
                                      { 3, 4, 5, 2, 8, 6, 1, 7, 9 } 
                                    };

            matrix10 = new int[9, 9] { { 2, 8, 6, 9, 4, 5, 1, 7, 3 }, 
                                       { 7, 1, 4, 6, 3, 2, 9, 5, 8 }, 
                                       { 9, 3, 5, 7, 8, 1, 4, 2, 6 }, 
                                       { 4, 2, 7, 3, 5, 6, 8, 1, 9 },
                                       { 6, 5, 8, 1, 9, 7, 3, 4, 2 }, 
                                       { 1, 9, 3, 4, 2, 8, 7, 6, 5 },
                                       { 3, 6, 1, 5, 7, 9, 2, 8, 4 }, 
                                       { 5, 4, 2, 8, 1, 3, 6, 9, 7 }, 
                                       { 8, 7, 9, 2, 6, 4, 5, 3, 1 } 
                                    };

            matrix11 = new int[9, 9] { { 1, 5, 4, 8, 7, 3, 2, 9, 6 },
                                       { 3, 8, 6, 5, 9, 2, 7, 1, 4 }, 
                                       { 7, 2, 9, 6, 4, 1, 8, 3, 5 }, 
                                       { 8, 6, 3, 7, 2, 5, 1, 4, 9 }, 
                                       { 9, 7, 5, 3, 1, 4, 6, 2, 8 },
                                       { 4, 1, 2, 9, 6, 8, 3, 5, 7 },
                                       { 6, 3, 1, 4, 5, 7, 9, 8, 2 }, 
                                       { 5, 9, 8, 2, 3, 6, 4, 7, 1 },
                                       { 2, 4, 7, 1, 8, 9, 5, 6, 3 } 
                                    };

            matrix12 = new int[9, 9] { { 4, 5, 7, 3, 8, 1, 2, 6, 9 }, 
                                       { 1, 6, 2, 5, 4, 9, 8, 7, 3 }, 
                                       { 9, 3, 8, 2, 7, 6, 4, 5, 1 }, 
                                       { 3, 7, 4, 8, 6, 2, 1, 9, 5 }, 
                                       { 8, 2, 5, 9, 1, 7, 3, 4, 6 }, 
                                       { 6, 1, 9, 4, 3, 5, 7, 2, 8 },
                                       { 2, 4, 1, 6, 5, 8, 9, 3, 7 },
                                       { 5, 8, 3, 7, 9, 4, 6, 1, 2 },
                                       { 7, 9, 6, 1, 2, 3, 5, 8, 4 } 
                                    };

            matrix13 = new int[9, 9] { { 2, 1, 5, 6, 4, 7, 3, 9, 8 },
                                       { 3, 6, 8, 9, 5, 2, 1, 7, 4 },
                                       { 7, 9, 4, 3, 8, 1, 6, 5, 2 }, 
                                       { 5, 8, 6, 2, 7, 4, 9, 3, 1 },
                                       { 1, 4, 2, 5, 9, 3, 8, 6, 7 }, 
                                       { 9, 7, 3, 8, 1, 6, 4, 2, 5 },
                                       { 8, 2, 1, 7, 3, 9, 5, 4, 6 },
                                       { 6, 5, 9, 4, 2, 8, 7, 1, 3 }, 
                                       { 4, 3, 7, 1, 6, 5, 2, 8, 9 } 
                                    };

            matrix14 = new int[9, 9] { { 6, 7, 3, 1, 5, 8, 4, 9, 2 }, 
                                       { 9, 2, 4, 6, 7, 3, 1, 5, 8 }, 
                                       { 8, 1, 5, 9, 2, 4, 7, 3, 6 }, 
                                       { 3, 8, 6, 5, 4, 2, 9, 1, 7 },
                                       { 7, 4, 9, 3, 1, 6, 8, 2, 5 }, 
                                       { 1, 5, 2, 7, 8, 9, 6, 4, 3 }, 
                                       { 5, 3, 1, 4, 6, 7, 2, 8, 9 }, 
                                       { 2, 9, 7, 8, 3, 1, 5, 6, 4 }, 
                                       { 4, 6, 8, 2, 9, 5, 3, 7, 1 }
                                    };

            matrix15 = new int[9, 9] { { 9, 5, 4, 8, 7, 2, 3, 1, 6 }, 
                                       { 8, 6, 1, 9, 4, 3, 7, 2, 5 },
                                       { 3, 2, 7, 6, 5, 1, 4, 9, 8 }, 
                                       { 1, 3, 2, 5, 9, 7, 8, 6, 4 },
                                       { 7, 4, 9, 2, 8, 6, 5, 3, 1 },
                                       { 5, 8, 6, 1, 3, 4, 2, 7, 9 }, 
                                       { 2, 9, 8, 7, 6, 5, 1, 4, 3 }, 
                                       { 4, 1, 5, 3, 2, 9, 6, 8, 7 },
                                       { 6, 7, 3, 4, 1, 8, 9, 5, 2 } 
                                    };

            matrix16 = new int[9, 9] { { 6, 1, 5, 4, 2, 9, 3, 8, 7 }, 
                                       { 4, 7, 2, 8, 5, 3, 1, 6, 9 }, 
                                       { 3, 9, 8, 1, 7, 6, 2, 4, 5 },
                                       { 7, 4, 6, 2, 3, 1, 5, 9, 8 }, 
                                       { 5, 2, 1, 9, 8, 4, 6, 7, 3 },
                                       { 9, 8, 3, 7, 6, 5, 4, 1, 2 }, 
                                       { 8, 6, 7, 5, 4, 2, 9, 3, 1 }, 
                                       { 1, 5, 4, 3, 9, 7, 8, 2, 6 }, 
                                       { 2, 3, 9, 6, 1, 8, 7, 5, 4 } };          

        }

        public void easyMatrix()
        {
            List.Clear();
            List.Add(matrix1);
            List.Add(matrix2);
            List.Add(matrix3);
            List.Add(matrix4);
        }

        public void normalMatrix()
        {
            List.Clear();
            List.Add(matrix5);
            List.Add(matrix6);
            List.Add(matrix7);
            List.Add(matrix8);
        }

        public void hardMatrix()
        {
            List.Clear();
            List.Add(matrix9);
            List.Add(matrix10);
            List.Add(matrix11);
            List.Add(matrix12);
        }

        public void expertMatrix()
        {
            List.Clear();
            List.Add(matrix13);
            List.Add(matrix14);
            List.Add(matrix15);
            List.Add(matrix16);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sb.Append(matrix1[i, j]);
                    sb.Append(" ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
