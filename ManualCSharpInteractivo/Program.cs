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
            Console.WriteLine("Elija una opción:\n1. Español\n2. English\n\n--------\nX. Exit\n");
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
                            SelectMenuEnglish();
                            exit = true;
                            break;
                        case "x":
                        case "exit":
                        case "salir":
                            exit = true;
                            Console.WriteLine("\nPulse intro para salir");
                            Console.ReadLine();
                            break;
                        default:
                            Show();
                            Console.WriteLine("Elija una opción:\n1. Español\n2. English\n\n--------\nX. Exit\n");
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
            Console.WriteLine("Elija una opción:\n1. Imperativo\n2. POO - Orientado a Objeto\n\n--------\n0. Atrás\nX. Salir\n");
            do
            {
                try
                {
                    string select = Console.ReadLine().ToLower().Trim();

                    switch (select)
                    {
                        case "1":
                        case "imperativo":
                            Show();
                            Console.WriteLine("Imperativo");
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
                        case "0":
                        case "atras":
                        case "atrás":
                            SelectLanguage();
                            exit = true;
                            break;
                        case "x":
                        case "exit":
                        case "salir":
                            exit = true;
                            Console.WriteLine("\nPulse intro para salir");
                            Console.ReadLine();
                            break;
                        default:
                            Show();
                            Console.WriteLine("Elija una opción:\n1. Imperativo\n2. POO - Orientado a Objeto\n\n--------\n0. Atrás\nX. Salir\n");
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

        ///////////////////////////////////////////////////////// - English - ///////////////////////////////////////////////////////////////////////////

        static void SelectMenuEnglish()
        {
            bool exit = false;
            Show();
            Console.WriteLine("Choose option:\n1. Imperative\n2. POO - Object Oriented\n\n--------\n0. Back\nX. Exit\n");
            do
            {
                try
                {
                    string select = Console.ReadLine().ToLower().Trim();

                    switch (select)
                    {
                        case "1":
                        case "imperative":
                            Show();
                            Console.WriteLine("Imperative");
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
                        case "0":
                        case "back":
                            SelectLanguage();
                            exit = true;
                            break;
                        case "x":
                        case "exit":
                        case "salir":
                            exit = true;
                            Console.WriteLine("\nPress enter to exit");
                            Console.ReadLine();
                            break;
                        default:
                            Show();
                            Console.WriteLine("Choose option:\n1. Imperative\n2. POO - Object Oriented\n\n--------\n0. Back\nX. Exit\n");
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