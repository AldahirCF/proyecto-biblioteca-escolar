List<Titulo> biblioteca = new List<Titulo>();

biblioteca.Add(new Titulo("Don Quijote de la Mancha","S_01V1",5,0));
biblioteca.Add(new Titulo("Cien años de soledad","RM01V1",7,1));
biblioteca.Add(new Titulo("La Odisea","PE01V1",7,5));
biblioteca.Add(new Titulo("Orgullo y prejuicio","Ro01V1",9,3));
biblioteca.Add(new Titulo("El señor de los anillos","AF01V1",1,5));
biblioteca.Add(new Titulo("Crimen y castigo","P_01V1",2,8));
biblioteca.Add(new Titulo("Frankenstein","CF01V1",4,5));
biblioteca.Add(new Titulo("Moby Dick","EM01V1",7,2));


foreach(Titulo titulo in biblioteca)
{
   if(string.IsNullOrWhiteSpace(titulo.Nombre) || string.IsNullOrWhiteSpace(titulo.ID) || titulo.Cantidad < 0 || titulo.HistorialP < 0)
   {
      Console.WriteLine("Faltan valores o estan mal asignados");
   }
   else
   {
      Console.WriteLine($"Los elementos del titulo {titulo.Nombre} estan completos");
   }

}

Console.WriteLine();

List<Titulo> biblioteca2 = new List<Titulo>();

biblioteca2.Add(new Titulo("Don Quijote de la Mancha","S_01V1",5,0));
biblioteca2.Add(new Titulo("Cien años de soledad","RM01V1",0,1));
biblioteca2.Add(new Titulo("Orgullo y prejuicio","Ro01V1",9,3));

foreach(Titulo titulo in biblioteca2)
{
   Console.WriteLine($"El titulo {titulo.Nombre}, tiene {titulo.Cantidad} ejemplares");
   Console.WriteLine("Empezar prestamo");
   Procesos.Realizarprestamo(titulo);
   Console.WriteLine();
}

foreach(Titulo titulo in biblioteca2)
{
   Console.WriteLine($"El titulo {titulo.Nombre}, tiene {titulo.Cantidad} ejemplares");
   Console.WriteLine();
}

biblioteca.Add(new Titulo("El mago de oz libro","NI01V1",7,5));
Procesos.OrdenamientoInsersion(biblioteca);

foreach(Titulo titulo in biblioteca)
{
   Console.WriteLine($"El titulo {titulo.Nombre}, tiene {titulo.HistorialP} de prestamos hechos");
}
