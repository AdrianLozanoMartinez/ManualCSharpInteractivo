namespace ManualCSharpInteractivo
{
    internal class Program
    {
        static void Main()
        {
            SelectLanguage();
        }
        static void Show()
        {
            Console.Clear();
            Console.WriteLine("Manual C# Interactivo - Adrián Lozano Martínez\n----------------------------------------------\n");
        }
        static void SelectLanguage()
        {
            bool exit = false;
            Show();
            Console.WriteLine("Elija una opción:\n1. Español\n2. English\n\n--------\n0. Exit\n");
            do
            {
                try
                {
                    string select = Console.ReadLine().ToLower().Trim();

                    switch (select)
                    {
                        case "1":
                        case "español":
                        case "espanol":
                            SelectMenu();
                            exit = true;
                            break;
                        case "2":
                        case "ingles":
                        case "inglés":
                        case "english":
                            Show();
                            SelectMenuEnglish();
                            exit = true;
                            break;
                        default:
                            Show();
                            Console.WriteLine("Elija una opción:\n1. Español\n2. English\n");
                            Console.WriteLine("\"Introduzca una opción correcta\"");
                            exit = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }


            } while (exit == false);
        }
        static void SelectMenu()
        {
            bool exit = false;
            Show();
            Console.WriteLine("Elija una opción:\n1. Interactivo\n2. POO - Orientado a Objeto\n");
            do
            {
                try
                {
                    string select = Console.ReadLine().ToLower().Trim();

                    switch (select)
                    {
                        case "1":
                        case "interactivo":
                            Show();
                            Console.WriteLine("Interactivo");
                            exit = true;
                            break;
                        case "2":
                        case "poo":
                        case "orientado":
                        case "objeto":
                        case "orientado a objeto":
                            Show();
                            Console.WriteLine("POO - Orientado a Objeto");
                            exit = true;
                            break;
                        case "8":
                        case "atras":
                        case "atrás":
                            SelectLanguage();
                            break;
                        default:
                            Show();
                            Console.WriteLine("Elija una opción:\n1. Interactivo\n2. POO - Orientado a Objeto\n");
                            Console.WriteLine("\"Introduzca una opción correcta\"");
                            exit = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }


            } while (exit == false);
        }
        static void SelectMenuEnglish()
        {
            bool exit = false;
            Show();
            Console.WriteLine("Choose option:\n1. Interactive\n2. POO - Object Oriented\n");
            do
            {
                try
                {
                    string select = Console.ReadLine().ToLower().Trim();

                    switch (select)
                    {
                        case "1":
                        case "interactive":
                            Show();
                            Console.WriteLine("Interactive");
                            exit = true;
                            break;
                        case "2":
                        case "poo":
                        case "object":
                        case "oriented":
                        case "object oriented":
                            Show();
                            Console.WriteLine("POO - Object Oriented");
                            exit = true;
                            break;
                        case "8":
                        case "back":
                            SelectLanguage();
                            break;
                        default:
                            Show();
                            Console.WriteLine("Choose option:\n1. Interactive\n2. POO - Object Oriented\n");
                            Console.WriteLine("\"Enter a correct option\"");
                            exit = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }


            } while (exit == false);
        }
    }
}