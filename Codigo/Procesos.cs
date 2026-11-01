public static class Procesos
{
   public static bool  disponibilidad(Titulo titulo)
   {
      if (titulo.Cantidad > 0)
      {
         return true;
      }
      else
      {
         return false;
      }
   }

   public static void Realizarprestamo(Titulo titulo)
   {
      if (disponibilidad(titulo))
      {
         titulo.Cantidad = titulo.Cantidad - 1;
         titulo.HistorialP++;
         Console.WriteLine($"Su prestamo del titulo {titulo.Nombre} a sido realizado correctamente, quedan {titulo.Cantidad} ejemplares");
      }
      else
      {
         Console.WriteLine("El prestamo no se pudo realizar, por falta de ejemplares");
      }
   }
}