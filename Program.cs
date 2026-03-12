using System;

class Program
{
    // ================================
    // MÉTODO PRINCIPAL (PUNTO DE ENTRADA)
    // ================================
    static void Main()
    {
        ShowMainMenu();
    }

    // ================================
    // MENÚ PRINCIPAL
    // ================================
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

    // ================================
    // MENÚ LIBROS
    // ================================
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

    // ================================
    // FUNCIONES LIBROS
    // ================================
    static void RegisterBook()
    {
        Console.WriteLine("Simulación: registrar libro.");
        Console.ReadKey();
    }

    static void ListBooksMenu()
    {
        Console.WriteLine("Simulación: listar libros.");
        Console.ReadKey();
    }

    static void ViewBookDetail()
    {
        Console.WriteLine("Simulación: ver detalle del libro.");
        Console.ReadKey();
    }

    static void UpdateBookMenu()
    {
        Console.WriteLine("Simulación: actualizar libro.");
        Console.ReadKey();
    }

    static void DeleteBook()
    {
        Console.WriteLine("Simulación: eliminar libro.");
        Console.ReadKey();
    }

    // ================================
    // MENÚ USUARIOS
    // ================================
    static void ShowUsersMenu()
    {
        Console.WriteLine("===== MENÚ DE USUARIOS =====");
        Console.ReadKey();
    }

    // ================================
    // MENÚ PRÉSTAMOS
    // ================================
    static void ShowLoansMenu()
    {
        int option = 0;

        while (option != 6)
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ PRÉSTAMOS ===");
            Console.WriteLine("1. Crear préstamo");
            Console.WriteLine("2. Listar préstamos");
            Console.WriteLine("3. Ver detalle");
            Console.WriteLine("4. Registrar devolución");
            Console.WriteLine("5. Eliminar préstamo");
            Console.WriteLine("6. Volver");

            Console.Write("Seleccione una opción: ");
            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    CreateLoan();
                    break;

                case 2:
                    ListLoansMenu();
                    break;

                case 3:
                    ViewLoanDetail();
                    break;

                case 4:
                    RegisterReturn();
                    break;

                case 5:
                    DeleteLoan();
                    break;
            }
        }
    }

    // ================================
    // FUNCIONES PRÉSTAMOS
    // ================================
    static void CreateLoan()
    {
        Console.WriteLine("Simulación: crear préstamo.");
        Console.ReadKey();
    }

    static void ListLoansMenu()
    {
        Console.WriteLine("Simulación: listar préstamos.");
        Console.ReadKey();
    }

    static void ViewLoanDetail()
    {
        Console.WriteLine("Simulación: ver detalle del préstamo.");
        Console.ReadKey();
    }

    static void RegisterReturn()
    {
        Console.WriteLine("Simulación: registrar devolución.");
        Console.ReadKey();
    }

    static void DeleteLoan()
    {
        Console.WriteLine("Simulación: eliminar préstamo.");
        Console.ReadKey();
    }

    // ================================
    // BÚSQUEDAS Y REPORTES
    // ================================
    static void ShowSearchReportsMenu()
    {
        Console.WriteLine("Simulación: menú de búsquedas.");
        Console.ReadKey();
    }

    // ================================
    // PERSISTENCIA
    // ================================
    static void ShowPersistenceMenu()
    {
        Console.WriteLine("Simulación: guardar o cargar datos.");
        Console.ReadKey();
    }

    // ================================
    // SALIDA DEL SISTEMA
    // ================================
    static void ConfirmExitAndSave()
    {
        Console.WriteLine("¿Desea guardar antes de salir? (S/N)");

        string response = Console.ReadLine() ?? ""; // ✓ Nunca será null

        if(response.ToUpper() == "S")
        {
            SaveData();
        }

        Environment.Exit(0);
    }

    static void SaveData()
    {
        Console.WriteLine("Simulación: guardando datos...");
        Console.ReadKey();
    }
}