using System;

class Program
{
    static void Main()
    {
        ShowMainMenu();
    }

    static void ShowMainMenu()
    {
        int option = 0;

        while (option != 6)
        {
            Console.Clear();
            Console.WriteLine("===== MENÚ PRINCIPAL =====");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Salir");

            Console.Write("Seleccione una opción: ");

            int.TryParse(Console.ReadLine(), out option);

            switch(option)
            {
                case 1:
                    ShowBooksMenu();
                    break;
                case 2:
                    ShowUsersMenu();
                    break;
                case 3:
                    ShowLoansMenu();
                    break;
                case 4:
                    ShowSearchReportsMenu();
                    break;
                case 5:
                    ShowPersistenceMenu();
                    break;
                case 6:
                    ConfirmExitAndSave();
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void ShowBooksMenu()
    {
        int option = 0;

        while(option != 6)
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ LIBROS ===");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Ver detalle");
            Console.WriteLine("4. Actualizar libro");
            Console.WriteLine("5. Eliminar libro");
            Console.WriteLine("6. Volver");

            Console.Write("Seleccione una opción: ");
            int.TryParse(Console.ReadLine(), out option);

            switch(option)
            {
                case 1:
                    RegisterBook();
                    break;
                case 2:
                    ListBooksMenu();
                    break;
                case 3:
                    ViewBookDetail();
                    break;
                case 4:
                    UpdateBookMenu();
                    break;
                case 5:
                    DeleteBook();
                    break;
            }
        }
    }

    static void ShowUsersMenu()
    {
        Console.WriteLine("===== MENÚ DE USUARIOS =====");
        Console.ReadKey();
    }

    static void ShowLoansMenu()
    {
        Console.WriteLine("===== MENÚ DE PRÉSTAMOS =====");
        Console.ReadKey();
    }

    static void ShowSearchReportsMenu()
    {
        Console.WriteLine("===== MENÚ DE BÚSQUEDAS Y REPORTES =====");
        Console.ReadKey();
    }

    static void ShowPersistenceMenu()
    {
        Console.WriteLine("===== MENÚ DE GUARDAR / CARGAR DATOS =====");
        Console.ReadKey();
    }

    static void ConfirmExitAndSave()
    {
        Console.WriteLine("¿Desea guardar los datos antes de salir? (S/N)");
        Console.ReadKey();
    }

    // =========================
    // MÉTODOS FALTANTES
    // =========================

    static void RegisterBook()
    {
        Console.Clear();
        Console.WriteLine("Registrar libro (función en desarrollo)");
        Console.ReadKey();
    }

    static void ListBooksMenu()
    {
        Console.Clear();
        Console.WriteLine("Listar libros (función en desarrollo)");
        Console.ReadKey();
    }

    static void ViewBookDetail()
    {
        Console.Clear();
        Console.WriteLine("Ver detalle del libro (función en desarrollo)");
        Console.ReadKey();
    }

    static void UpdateBookMenu()
    {
        Console.Clear();
        Console.WriteLine("Actualizar libro (función en desarrollo)");
        Console.ReadKey();
    }

    static void DeleteBook()
    {
        Console.Clear();
        Console.WriteLine("Eliminar libro (función en desarrollo)");
        Console.ReadKey();
    }
}