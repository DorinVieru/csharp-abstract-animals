namespace csharp_abstract_animals
{
    internal class Program
    {
        public static void FaiVolare(IVolante animale)
        {
            animale.Vola();
        }

        public static void FaiNuotare(INuotante animale)
        {
            animale.Nuota();
        }

        static void Main(string[] args)
        {
            List<Animale> animali = new List<Animale>
            {
                new Cane(),
                new Passerotto(),
                new Aquila(),
                new Delfino(),
            };

            Console.WriteLine("-------------\nSe desideri uscire dal programma, digita il tasto 9\n-------------");
            string input = "";
            while (input != "9")
            {

                Console.WriteLine("\nScegli un animale (digita il numero corrispondende all'animale): \n 1. Cane, \n 2. Passerotto, \n 3. Aquila, \n 4. Delfino");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var cane = (Cane)animali[0];
                        Console.WriteLine("--------\nHai scelto il Cane\n--------");
                        cane.Verso();
                        cane.Mangia();
                        break;
                    case "2":
                        var passerotto = (Passerotto)animali[1];
                        Console.WriteLine("--------\nHai scelto il Passerotto\n--------");
                        passerotto.Dormi();
                        passerotto.Verso();
                        passerotto.Mangia();
                        break;
                    case "3":
                        var aquila = (Aquila)animali[2];
                        Console.WriteLine("--------\nHai scelto l'Aquila\n--------");
                        aquila.Dormi();
                        aquila.Verso();
                        aquila.Mangia();
                        FaiVolare(aquila);
                        break;
                    case "4":
                        var delfino = (Delfino)animali[3];
                        Console.WriteLine("--------\nHai scelto il Delfino\n--------");
                        delfino.Dormi();
                        delfino.Verso();
                        delfino.Mangia();
                        FaiNuotare(delfino);
                        break;
                    default:
                        Console.WriteLine("--------\nAnimale non riconosciuto.\n--------");
                        break;
                }
            }
        }
    }
}
