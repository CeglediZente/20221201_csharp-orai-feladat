using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20221201_Csharp_seban
{
    internal class Program
    {


        public static void matrixLetrehozas(Random r)
        {
            Console.Write("Add meg a mátrix sorainak számát: ");
            int sorHossz = int.Parse(Console.ReadLine());
            Console.Write("Add meg a mátrix oszlopainak számát: ");
            int oszlopHossz = int.Parse(Console.ReadLine());
            double[,] matrix = new double[sorHossz, oszlopHossz];
            List<double> matrixOszlop = new List<double>(oszlopHossz);


            for (int i = 0; i < sorHossz; i++)
            {
                for (int j = 0; j < oszlopHossz; j++)
                {
                    matrix[i, j] = -1;
                }


            }

            for (int i = 0; i < sorHossz; i++)
            {
                for (int j = 0; j < oszlopHossz; j++)
                {
                    for (int k = 0; k < sorHossz; k++)
                    {
                        for (int l = 0; l < oszlopHossz; l++)
                        {
                            Console.Write(matrix[k, l] + "      ");
                        }
                        Console.WriteLine();

                    }

                    Console.Write("Add meg a következő elem értékét: ");
                    double ujElem = double.Parse(Console.ReadLine());
                    matrix[i, j] = ujElem;





                }

            }
            int muv = -1;
            while (muv != 0)
            {
                Console.WriteLine("Művelet választása");
                Console.Write("0 - Kilépés\n1 - Minimum elem keresése\n2 - Maximum elem keresése\n3 - Elemek átlaga\n4 - Benne van-e a 12?\n5 - Sorbarendezés (kisebbtől a nagyobbig)\n6 - Sorbarendezés (nagyobbtól a kisebbig)\n7 - Szétválogatás páros és páratlan elemekre\nMűvelet: ");
                muv = int.Parse(Console.ReadLine());
                if (muv == 1)
                {
                    minimum(matrix, sorHossz, oszlopHossz);
                }
                else if (muv == 2)
                {
                    maximum(matrix, sorHossz, oszlopHossz);
                }

                else if (muv == 3)
                {
                    atlag(matrix, sorHossz, oszlopHossz);
                }
                else if (muv == 4)
                {
                    vanBenne(matrix, sorHossz, oszlopHossz);
                }

                else if (muv == 5)
                {

                    sorbaNov(matrix, sorHossz, oszlopHossz);
                }
                else if (muv == 6)
                {
                    sorbaCsokk(matrix, sorHossz, oszlopHossz);
                }
                else if (muv == 7)
                {
                    parosParatlan(matrix, sorHossz, oszlopHossz);
                }
                else
                {
                    Console.WriteLine("A művelet nem értelmezhető. Próbáld újra!");
                }


            }
        }
        public static void minimum(double[,] matrix, int sorHossz, int oszlopHossz)
        {
            double min = matrix[0, 0];
            for (int i = 0; i < sorHossz; i++)
            {
                for (int j = 0; j < oszlopHossz; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }


            }
            Console.WriteLine("\n\nA minimum elem: " + min + "\n\n");
        }

        public static void maximum(double[,] matrix, int sorHossz, int oszlopHossz)
        {
            double max = matrix[0, 0];
            for (int i = 0; i < sorHossz; i++)
            {
                for (int j = 0; j < oszlopHossz; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }


            }
            Console.WriteLine("\n\nA maximum elem: " + max + "\n\n");
        }

        public static void atlag(double[,] matrix, int sorHossz, int oszlopHossz)
        {
            double ossz = 0;
            for (int i = 0; i < sorHossz; i++)
            {
                for (int j = 0; j < oszlopHossz; j++)
                {
                    ossz += matrix[i, j];
                }

            }
            Console.WriteLine("\n\nAz elemek áltaga: " + (double)ossz / (sorHossz * oszlopHossz) + "\n\n");
        }

        public static void vanBenne(double[,] matrix, int sorHossz, int oszlopHossz)
        {
            bool vanBenne12 = false;
            for (int i = 0; i < sorHossz; i++)
            {
                for (int j = 0; j < oszlopHossz; j++)
                {
                    if (matrix[i, j] == 12)
                    {
                        vanBenne12 = true;
                    }
                }


            }
            if (vanBenne12)
            {
                Console.WriteLine("\n\nA mátrix elemei között megtalálható a 12.\n\n");
            }
            else
            {
                Console.WriteLine("\n\nA mátrix elemei között nem található meg a 12.");
            }
        }

        public static void sorbaNov(double[,] matrix, int sorHossz, int oszlopHossz)
        {
            for (int i = 0; i < sorHossz; i++)
            {
                for (int j = 0; j < oszlopHossz; j++)
                {
                    for (int k = 0; k < sorHossz; k++)
                    {
                        for (int l = 0; l < oszlopHossz; l++)
                        {
                            if (matrix[i, j] < matrix[k, l])
                            {
                                double temp = matrix[i, j];
                                matrix[i, j] = matrix[k, l];
                                matrix[k, l] = temp;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < sorHossz; i++)
            {
                for (int j = 0; j < oszlopHossz; j++)
                {
                    Console.Write(matrix[i, j] + "      ");
                }
                Console.WriteLine();
            }
        }

        public static void sorbaCsokk(double[,] matrix, int sorHossz, int oszlopHossz)
        {
            for (int i = 0; i < sorHossz; i++)
            {
                for (int j = 0; j < oszlopHossz; j++)
                {
                    for (int k = 0; k < sorHossz; k++)
                    {
                        for (int l = 0; l < oszlopHossz; l++)
                        {
                            if (matrix[i, j] > matrix[k, l])
                            {
                                double temp = matrix[i, j];
                                matrix[i, j] = matrix[k, l];
                                matrix[k, l] = temp;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < sorHossz; i++)
            {
                for (int j = 0; j < oszlopHossz; j++)
                {
                    Console.Write(matrix[i, j] + "      ");
                }
                Console.WriteLine();
            }
        }

        public static void parosParatlan(double[,] matrix, int sorHossz, int oszlopHossz)
        {
            int parosSorHossz = 0;
            int paratlanSorHossz = 0;
            for (int i = 0; i < sorHossz; i++)
            {
                for (int j = 0; j < oszlopHossz; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        parosSorHossz++;
                    }
                    else
                    {
                        paratlanSorHossz++;
                    }
                }
            }
            double[] parosVektor = new double[parosSorHossz];
            double[] paratlanVektor = new double[paratlanSorHossz];
            int parosIndex = 0;
            int paratlanIndex = 0;
            for (int i = 0; i < sorHossz; i++)
            {
                for (int j = 0; j < oszlopHossz; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        parosVektor[parosIndex] = matrix[i, j];
                        parosIndex++;
                    }
                    else
                    {
                        paratlanVektor[paratlanIndex] = matrix[i, j];
                        paratlanIndex++;
                    }
                }
            }
            Console.WriteLine("\n\nPáros számok mennyisége: " + parosSorHossz);
            Console.WriteLine("Páros számok: ");
            for (int i = 0; i < parosVektor.Length; i++)
            {
                Console.Write((double)parosVektor[i] + " ");
            }
            Console.WriteLine("\n\nPáratlan számok mennyisége: " + paratlanSorHossz);
            Console.WriteLine("Páratlan számok: ");
            for (int i = 0; i < paratlanVektor.Length; i++)
            {
                Console.Write((double)paratlanVektor[i] + " ");
            }
            Console.WriteLine("\n\n");
        }

        static void Main(string[] args)
        {
            Random r = new Random();

            Console.WriteLine("Ebben a programban mátrixokat rakhatsz össze és adhatod meg a különböző adatait.\nVerzió: 2022.12.01.");
            while (true)
            {
                Console.Write("0 - Kilépés\n1 - Mátrix készítése\nMilyen műveletet szeretnél elvégezni?\nMűvelet: ");
                string muvelet = Console.ReadLine();
                if (muvelet == "0")
                {
                    break;
                }
                else if (muvelet == "1")
                {
                    matrixLetrehozas(r);
                }
                else
                {
                    Console.WriteLine("A művelet nem értelmezhető! Próbáld újra.");
                }


            }
            Console.WriteLine("Viszlát!");


        }



    }
}
