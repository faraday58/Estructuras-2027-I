
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Estructuras_2027_I;

    Cliente miCliente = new Cliente();

    miCliente.nombre = "Armando";
    miCliente.edad = 20;
    miCliente.correo = "micorreo@correo.com";


    Cliente miCliente2;
    miCliente2 = miCliente;
    //Referencia a la misma dirección de memoria cuando se trabaja con clases,
    //por lo que si se cambia un valor en miCliente2 también se verá reflejado en miCliente

    miCliente2.nombre = "Juan";


    /*Console.WriteLine(miCliente.nombre);
    Console.WriteLine(miCliente.edad);
    Console.WriteLine(miCliente.correo);


    Console.WriteLine(miCliente2.nombre);
    Console.WriteLine(miCliente2.edad);
    Console.WriteLine(miCliente2.correo);


    Console.WriteLine($"{Semana.Lunes}  {(int)Semana.Lunes}  " );
    */

    List<Cliente> listaClientes = new List<Cliente>();


    listaClientes.Add(miCliente);
    listaClientes.Add(miCliente2);

    Cliente clienteTemp = new Cliente("Luis",25,"luis@correo.com");
    listaClientes[1] = clienteTemp;

    /*foreach (Cliente cliente in listaClientes)
    {
        Console.WriteLine($"Nombre: {cliente.nombre} \n " +
            $" Edad: {cliente.edad} \n " +
            $" Correo: {cliente.correo} ");

    }*/

    for(int i =0; i < listaClientes.Count; i++) {
        Console.WriteLine($"Nombre: {listaClientes[i].nombre} \n " +
           $" Edad: {listaClientes[i].edad} \n " +
           $" Correo: {listaClientes[i].correo} ");
}
