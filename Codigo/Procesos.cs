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

   public static void OrdenamientoInsersion(List<Titulo> Catalogo)
   {
      for(int i = 1; i < Catalogo.Count; i++)
      {
         Titulo actual = Catalogo[i];
         int j = i - 1;

         while(j >= 0 && Catalogo[j].HistorialP < actual.HistorialP)
         {
            Catalogo[j + 1] = Catalogo[j];
            j--;
         }

         while(j >= 0 && Catalogo[j].HistorialP == actual.HistorialP && 0 < (string.Compare(Catalogo[j].Nombre, actual.Nombre)))
         {
            Catalogo[j + 1] = Catalogo[j];
            j--;
         }

         Catalogo[j + 1] = actual;
      }
   }
}