namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Millist kujundit soovid? (ruut, teemant, ristkülik, kolmnurk)");
            string valik = Console.ReadLine().ToLower();

            switch (valik)
            {
                case "ruut":
                    Console.WriteLine("Sisesta ruudu külje pikkus:");
                    int ruuduKylg = Convert.ToInt32(Console.ReadLine());
                    RuuduFunktsioon(ruuduKylg);
                    break;


                case "teemant":
                    Console.WriteLine("Sisesta teemandi diagonaalide pikkus :");
                    int teemandiDiagonaal = Convert.ToInt32(Console.ReadLine());
                    TeemandiFunktsioon(teemandiDiagonaal);
                    break;


                case "ristkülik":
                    Console.WriteLine("Sisesta ristküliku laius:");
                    int ristkulikuLaius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sisesta ristküliku kõrgus:");
                    int ristkulikuKorgus = Convert.ToInt32(Console.ReadLine());
                    RistkulikuFunktsioon(ristkulikuLaius, ristkulikuKorgus);
                    break;


                case "kolmnurk":
                    Console.WriteLine("Sisesta kolmnurga alus:");
                    int kolmnurgaAlus = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sisesta kolmnurga kõrgus:");
                    int kolmnurgaKorgus = Convert.ToInt32(Console.ReadLine());
                    KolmnurgaFunktsioon(kolmnurgaAlus, kolmnurgaKorgus);
                    break;


                default:
                    Console.WriteLine("Sellist kujundit ei ole valikus.");
                    break;
            }
        }
        static void RuuduFunktsioon(int kylg)
        {
            Console.WriteLine("Ruut");
            for (int i = 0; i < kylg; i++)
            {
                for (int j = 0; j < kylg; j++) 
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
            int ümbermõõt = 4 * kylg;
            int pindala = kylg * kylg;
            Console.WriteLine($"Ruudu ümbermõõt on {ümbermõõt} ja pindala on {pindala} ühikut.");
        }

        static void TeemandiFunktsioon(int diagonaal)
        {
            Console.WriteLine("Teemant:");

            for (int i = 0; i < diagonaal; i++)
            {
                for (int j = 0; j < diagonaal; j++)
                {
                    if (i <= diagonaal / 2)
                    {
                        if (j >= diagonaal / 2 - i && j <= diagonaal / 2 + i)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        if (j >= i - diagonaal / 2 && j <= diagonaal - 1 - (i - diagonaal / 2))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void RistkulikuFunktsioon(int Laius, int korgus)
        {
            Console.WriteLine("Ristkülik:");

            for (int i = 0; i < korgus; i++)
            {
                for (int j = 0; j < Laius; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            int ümbermõõt = 2 * (Laius + korgus);
            int pindala = Laius * korgus;
            Console.WriteLine($"Ristküliku ümbermõõt on {ümbermõõt} ja pindala on {pindala} ühikut.");
        }
        static void KolmnurgaFunktsioon(int alus, int korgus)
        {
            Console.WriteLine("Kolmnurk:");

            for (int i = 1; i <= korgus; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            double pindala = 0.5 * alus * korgus;
            Console.WriteLine($"Kolmnurga pindala on {pindala} ühikut.");
        }
    }
}





