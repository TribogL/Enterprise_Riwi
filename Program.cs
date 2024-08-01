using Enterprise_Riwi.Models;

bool Enterprise_Riwi = true;

while (Enterprise_Riwi)
{
    Console.Clear();
    Console.WriteLine(@"///////////////Bienvenido a Enterprise Riwi\\\\\\\\\\\\\\\\\\\");
    Console.WriteLine(@"Menu principal
1)Menu de empleados
2)Menu de clientes.
3)salir.");
    int selection7 = int.Parse(Console.ReadLine());
    switch (selection7)
    {
        case 1:
            Console.Clear();
            Console.WriteLine(@"Menu para empleados
1)Registrar un empleado.
2)ver Lista de empleados.
3)Actualizar lista de un empleado.
4)Eliminar un empleado de un empleado del sistema.
5)Buscar empleado por cargo.
6)Salir al menu principal.");
            int Selection2 = int.Parse(Console.ReadLine());
            switch (Selection2)
            {
                case 1:
                    Console.Clear();
                    Enterprise.CreateEmployee();
                    Continue();
                    break;
                case 2:
                    Console.Clear();
                    Enterprise.ReadEmployees();
                    Continue();
                    break;
                case 3:
                    Console.Clear();
                    Enterprise.UpdateEmployee();
                    Continue();
                    break;
                case 4:
                    Console.Clear();
                    Enterprise.DeleteEmployee();
                    Continue();
                    break;
                case 5:
                    Console.Clear();
                    Enterprise.ShowEmployeeByPosition();
                    Continue();
                    break;
            }
            break;
        case 2:
            Console.Clear();
            Console.WriteLine(@"Menu para empleados
1)Registrar un cliente.
2)ver Lista de clientes.
3)Actualizar información de un cliente.
4)Eliminar un cliente del sistema.
5)Salir al menu principal.");
            int Selection8 = int.Parse(Console.ReadLine());
            switch (Selection8)
            {
                case 1:
                    Console.Clear();
                    Enterprise.CreateClient();
                    Continue();
                    break;
                case 2:
                    Console.Clear();
                    Enterprise.ReadClient();
                    Continue();
                    break;
                case 3:
                    Console.Clear();
                    Enterprise.UpdateClient();
                    Continue();
                    break;
                case 4:
                    Console.Clear();
                    Enterprise.DeleteClient();
                    Continue();
                    break;

            }
            break;
        case 3:
            Console.Clear();
            Console.WriteLine(@"/////////// Salida del programa \\\\\\\\\\\\");
            Console.WriteLine("¿Está seguro que desea salir del programa?");
            Console.WriteLine(@"
1)Sí
2)No");
            int programExit = int.Parse(Console.ReadLine());
            if (programExit == 1)
            {
                Console.WriteLine(@"///////// vuelva pronto \\\\\\\\\\");
                Enterprise_Riwi = false;
            }
            else
            {
                Continue();
            }
            break;
    }


}




void Continue()
{
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
}