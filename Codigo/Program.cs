List<Titulo> biblioteca = new List<Titulo>();

biblioteca.Add(new Titulo("Don Quijote de la Mancha","S_01V1",5,0));
biblioteca.Add(new Titulo("Cien años de soledad","RM01V1",7,1));
biblioteca.Add(new Titulo("La Odisea","PE01V1",7,5));
biblioteca.Add(new Titulo("Orgullo y prejuicio","Ro01V1",9,3));
biblioteca.Add(new Titulo("El señor de los anillos","AF01V1",1,5));
biblioteca.Add(new Titulo("Crimen y castigo","P_01V1",2,8));
biblioteca.Add(new Titulo("Frankenstein","CF01V1",4,5));
biblioteca.Add(new Titulo("Moby Dick","EM01V1",7,2));
biblioteca.Add(new Titulo("El mago de oz libro","NI01V1",7,5));

bool Salir = false;
do
{
   Procesos.OrdenamientoInsersion(biblioteca);

foreach(Titulo titulo in biblioteca)
{
   Console.WriteLine($"Libro: {titulo.Nombre}, de ID {titulo.ID}");
}

string Resultado;
do
{
   Console.WriteLine("Elija su accion:");
    Console.WriteLine("1: Seleccionar por nombre");
    Console.WriteLine("2: Seleccionar por ID ");
    Console.WriteLine("3: Agregar libro");
    Console.WriteLine("4: Salir");

   Resultado = Console.ReadLine();
   Console.Clear();
}while(Resultado != "1" && Resultado != "2" && Resultado != "3" && Resultado != "4");

foreach(Titulo titulo in biblioteca)
{
   Console.WriteLine($"Libro: {titulo.Nombre}, de ID {titulo.ID}");
}
string Nombre;
string ID;
string Resultado2;
int Cantidad;
bool prueba = true;
Titulo Libro = null;
switch (Resultado)
{
   case "1":
    Console.WriteLine("Introducir el nombre del libro:");
    Nombre = Console.ReadLine();
    Libro = Procesos.BusquedaSecuencial(biblioteca, Nombre);
    Console.Clear();
   break;
   case "2":
    Console.WriteLine("Introducir el ID del libro:");
    ID = Console.ReadLine();
    Libro = Procesos.BusquedaBinariaISBN(biblioteca, ID);     
    Console.Clear();
   break;
   case "3":
    do
    {
      Console.WriteLine("Introducir el nombre del libro:");
      Nombre = Console.ReadLine();
    }while(string.IsNullOrWhiteSpace(Nombre));
    
    do
    {
      prueba = true;
      Console.WriteLine("Introducir el ID del libro:");
      ID = Console.ReadLine();
      if (Procesos.BusquedaBinariaISBN(biblioteca, ID) != null)
      {
         Console.WriteLine("Ya existe un libro con ese ID");
         prueba = false;
      }
    }while(string.IsNullOrWhiteSpace(ID) || !prueba);
    
    do
    {
      Console.WriteLine("Introducir el numero de ejemplares:");
      Resultado2 = Console.ReadLine();
    }while(!int.TryParse(Resultado2, out Cantidad) || Cantidad < 0);

    biblioteca.Add(new Titulo(Nombre, ID, Cantidad,0));
    Console.WriteLine("Libro agregado correctamente");
    Console.ReadKey();
    Console.Clear();

      
   break;
   case "4":
      Salir = true;
   break;
}

   if (Libro != null)
   {
      do
      {   
         Console.WriteLine($"Libro: {Libro.Nombre}, con {Libro.Cantidad} Ejemplares y prestados {Libro.HistorialP}");
         Console.WriteLine("Elija su accion:");
         Console.WriteLine("1: Solicitar prestamo");
         Console.WriteLine("2: Salir ");
         Resultado = Console.ReadLine();
         Console.Clear();
      }while(Resultado != "1" && Resultado != "2");


      switch (Resultado)
      {
         case "1":
         Procesos.Realizarprestamo(Libro);
         Console.ReadKey();
         break;
         case "2":

         break;
      }
      
   }
   else if (Resultado == "1" || Resultado == "2")
   {
   Console.WriteLine("Titulo no  encontrado");  
   Console.ReadKey();   
   }

}while(!Salir);


