using System;

namespace TiendaDeBarrio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* DATOS ACCESO */
            string usuario = "admin";
            string contrasena = "admin1234";
            string usuarioIngresado = " ";
            string contrasenaIngresada = " ";
            int opcionSeleccionada = 0;
            /* USUARIOS */
            string usuario1 = " ";
            string documento1 = " ";
            string usuario2 = " ";
            string documento2 = " ";
            string usuario3 = " ";
            string documento3 = " ";
            string usuario4 = " ";
            string documento4 = " ";
            string usuario5 = " ";
            string documento5 = " ";
            /* NUEVOS USUARIOS */
            string usuario6 = " ";
            string documento6 = " ";
            string usuario7 = " ";
            string documento7 = " ";
            /* ARTÍCULOS */
            string articulo1 = " ";
            float precio1 = 0;
            string articulo2 = " ";
            float precio2 = 0;
            string articulo3 = " ";
            float precio3 = 0;
            string articulo4 = " ";
            float precio4 = 0;
            string articulo5 = " ";
            float precio5 = 0;
            /* NUEVOS ARTÍCULOS */
            string articulo6 = " ";
            float precio6 = 0;
            string articulo7 = " ";
            float precio7 = 0;
            /* INVENTARIO */
            string producto1 = " ";
            int cantidad1 = 0;

            Console.WriteLine("Bienvenido a su Tienda!");
            Console.WriteLine("Ingrese su usuario:");
            usuarioIngresado = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña:");
            contrasenaIngresada = Console.ReadLine();
            if (usuarioIngresado == usuario && contrasenaIngresada == contrasena)
            {
                Console.WriteLine("Menú Principal:");

                Console.WriteLine("1. Gestión de Usuarios.");
                Console.WriteLine("2. Gestión de Artículos.");
                Console.WriteLine("3. Gestión de Ventas.");
                Console.WriteLine("4. Salir.");
            }
            else
            {
                Console.WriteLine("Usuario o contraseña incorrectos. Intente nuevamente.");
            }
            Console.WriteLine("Seleccione una opción del menú:");
            opcionSeleccionada = int.Parse(Console.ReadLine());
            switch (opcionSeleccionada)
            {
                case 1:
                    Console.WriteLine("Bienvenido al módulo de Gestión de Usuarios.");
                    Console.WriteLine("Ingrese el nombre del usuario 1:");
                    usuario1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el documento del usuario 1:");
                    documento1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre del usuario 2:");
                    usuario2 = Console.ReadLine();
                    Console.WriteLine("Ingrese el documento del usuario 2:");
                    documento2 = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre del usuario 3:");
                    usuario3 = Console.ReadLine();
                    Console.WriteLine("Ingrese el documento del usuario 3:");
                    documento3 = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre del usuario 4:");
                    usuario4 = Console.ReadLine();
                    Console.WriteLine("Ingrese el documento del usuario 4:");
                    documento4 = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre del usuario 5:");
                    usuario5 = Console.ReadLine();
                    Console.WriteLine("Ingrese el documento del usuario 5:");
                    documento5 = Console.ReadLine();
                    
                    Console.WriteLine("Menú de Gestión de Usuarios:");
                    Console.WriteLine("1. Ver lista de usuarios.");
                    Console.WriteLine("2. Agregar nuevo usuario.");
                    Console.WriteLine("3. Editar información de usuario.");
                    Console.WriteLine("4. Salir de gestión de usuarios.");

                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                        Console.WriteLine("Lista de usuarios:");
                        Console.WriteLine( documento1 + "  " + usuario1 );
                        Console.WriteLine( documento2 + "  " + usuario2 );
                        Console.WriteLine( documento3 + "  " + usuario3 );
                        Console.WriteLine( documento4 + "  " + usuario4 );
                        Console.WriteLine( documento5 + "  " + usuario5 );
                            break;
                        case 2:
                        Console.WriteLine("Ingrese el nombre del usuario nuevo:");
                        usuario6 = Console.ReadLine();
                        Console.WriteLine("Ingrese el documento del usuario nuevo:");
                        documento6 = Console.ReadLine();
                        Console.WriteLine("¿Desea agregar otro usuario? 1. Sí 2. No");
                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            Console.WriteLine("Ingrese el nombre del usuario nuevo:");
                            usuario7 = Console.ReadLine();
                            Console.WriteLine("Ingrese el documento del usuario nuevo:");
                            documento7 = Console.ReadLine();
                        }
                        else {
                            Console.WriteLine("El usuario ha sido agregado correctamente.");
                        }
                            break;
                        case 3:
                        Console.WriteLine("Ingrese el documento del usuario:");
                        string documentoIngresado = Console.ReadLine();
                        if (documentoIngresado == documento1)
                        {
                            Console.WriteLine("Usuario encontrado.");
                            Console.WriteLine(documento1 + "  " + usuario1);
                        }
                        else if (documentoIngresado == documento2)
                        {
                            Console.WriteLine("Usuario encontrado.");
                            Console.WriteLine(documento2 + "  " + usuario2);
                        }
                        else if (documentoIngresado == documento3)
                        {
                            Console.WriteLine("Usuario encontrado.");
                            Console.WriteLine(documento3 + "  " + usuario3);
                        }
                        else if (documentoIngresado == documento4)
                        {
                            Console.WriteLine("Usuario encontrado.");
                            Console.WriteLine(documento4 + "  " + usuario4);
                        }
                        else if (documentoIngresado == documento5)
                        {
                            Console.WriteLine("Usuario encontrado.");
                            Console.WriteLine(documento5 + "  " + usuario5);
                        }
                        else if (documentoIngresado == documento6)
                        {
                            Console.WriteLine("Usuario encontrado.");
                            Console.WriteLine(documento6 + "  " + usuario6);
                        }
                        else if (documentoIngresado == documento7)
                        {
                            Console.WriteLine("Usuario encontrado.");
                            Console.WriteLine(documento7 + "  " + usuario7);
                        }
                        else
                        {
                            Console.WriteLine("Usuario no encontrado.");
                        }
                            break;
                        case 4:
                             Console.WriteLine("Menú Principal:");

                             Console.WriteLine("1. Gestión de Usuarios.");
                             Console.WriteLine("2. Gestión de Artículos.");
                             Console.WriteLine("3. Gestión de Ventas.");
                             Console.WriteLine("4. Salir.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Bienvenido al módulo de Gestión de Artículos.");
                    Console.WriteLine("Ingrese el nombre del artículo 1:");
                    articulo1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el precio del artículo 1:");
                    precio1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del artículo 2:");
                    articulo2 = Console.ReadLine();
                    Console.WriteLine("Ingrese el precio del artículo 2:");
                    precio2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del artículo 3:");
                    articulo3 = Console.ReadLine();
                    Console.WriteLine("Ingrese el precio del artículo 3:");
                    precio3 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del artículo 4:");
                    articulo4 = Console.ReadLine();
                    Console.WriteLine("Ingrese el precio del artículo 4:");
                    precio4 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del artículo 5:");
                    articulo5 = Console.ReadLine();
                    Console.WriteLine("Ingrese el precio del artículo 5:");
                    precio5 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Menú de Gestión de Artículos:");
                    Console.WriteLine("1. Ver lista de artículos.");
                    Console.WriteLine("2. Nuevo artículo.");
                    Console.WriteLine("3. Editar información del artículo.");
                    Console.WriteLine("4. Salir de gestión de artículos.");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                        Console.WriteLine("Lista de artículos:");
                        Console.WriteLine( articulo1 + "  " + precio1 );
                        Console.WriteLine( articulo2 + "  " + precio2 );
                        Console.WriteLine( articulo3 + "  " + precio3 );
                        Console.WriteLine( articulo4 + "  " + precio4 );
                        Console.WriteLine( articulo5 + "  " + precio5 );
                        break;
                        case 2:
                        Console.WriteLine("Ingrese el nombre del artículo nuevo:");
                        articulo6 = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio del artículo nuevo:");
                        precio6 = float.Parse(Console.ReadLine());
                        Console.WriteLine("¿Desea agregar otro artículo? 1. Sí 2. No");
                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            Console.WriteLine("Ingrese el nombre del artículo nuevo:");
                            articulo7 = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio del artículo nuevo:");
                            precio7 = float.Parse(Console.ReadLine());
                        }
                        else {
                            Console.WriteLine("El artículo ha sido agregado correctamente.");
                        }   
                        break;
                        case 3:
                        Console.WriteLine("Ingrese el nombre del artículo:");
                        string articuloIngresado = Console.ReadLine();
                        if (articuloIngresado == articulo1)
                        {
                            Console.WriteLine("Artículo encontrado.");
                            Console.WriteLine(articulo1 + "  " + precio1);
                        }
                        else if (articuloIngresado == articulo2)
                        {
                            Console.WriteLine("Artículo encontrado.");
                            Console.WriteLine(articulo2 + "  " + precio2);
                        }
                        else if (articuloIngresado == articulo3)
                        {
                            Console.WriteLine("Artículo encontrado.");
                            Console.WriteLine(articulo3 + "  " + precio3);
                        }
                        else if (articuloIngresado == articulo4)
                        {
                            Console.WriteLine("Artículo encontrado.");
                            Console.WriteLine(articulo4 + "  " + precio4);
                        }
                        else if (articuloIngresado == articulo5)
                        {
                            Console.WriteLine("Artículo encontrado.");
                            Console.WriteLine(articulo5 + "  " + precio5);
                        }
                        else if (articuloIngresado == articulo6)
                        {
                            Console.WriteLine("Artículo encontrado.");
                            Console.WriteLine(articulo6 + "  " + precio6);
                        }
                        else if (articuloIngresado == articulo7)
                        {
                            Console.WriteLine("Artículo encontrado.");
                            Console.WriteLine(articulo7 + "  " + precio7);
                        }
                        else
                        {
                            Console.WriteLine("Artículo no encontrado.");
                        }
                        break;
                        case 4:
                             Console.WriteLine("Menú Principal:");

                             Console.WriteLine("1. Gestión de Usuarios.");
                             Console.WriteLine("2. Gestión de Artículos.");
                             Console.WriteLine("3. Gestión de Ventas.");
                             Console.WriteLine("4. Salir.");
                        break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Bienvenido al módulo de Gestión de Ventas.");
                    Console.WriteLine("Ingrese el nombre del producto:");
                    producto1 = Console.ReadLine();
                    Console.WriteLine("Ingrese la cantidad de unidades que hay del producto:");
                    cantidad1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Menú de Gestión de Ventas:");
                    Console.WriteLine("1. Registrar venta.");
                    Console.WriteLine("2. Salir de Gestión de Ventas.");
                    if (int.Parse(Console.ReadLine()) == 1)
                    {
                        Console.WriteLine($"El producto que desea comprar es: {producto1}.");
                        Console.WriteLine("¿Cuántas unidades desea comprar?");
                        int unidades = int.Parse(Console.ReadLine());
                        if (unidades <= cantidad1)
                        {
                            Console.WriteLine("Usted puede comprar el producto");
                        }
                        else
                        {
                            Console.WriteLine("No hay cantidad suficiente del producto.");
                    }
                    }
                    else
                    {
                        Console.WriteLine("Menu Principal.");
                        Console.WriteLine("1. Gestión de Usuarios.");
                        Console.WriteLine("2. Gestión de Artículos.");
                        Console.WriteLine("3. Gestión de Ventas.");
                        Console.WriteLine("4. Salir.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Ha cerrado sesión. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }

            
        }
    }
}
