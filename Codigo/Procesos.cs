using System.Diagnostics.CodeAnalysis;

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

   public static List<Titulo> OrdenamientoporID(List<Titulo> Catalogo)
   {
      List<Titulo> CopiaBiblioteca = new List<Titulo>(Catalogo);


      for(int i = 1; i < CopiaBiblioteca.Count; i++)
      {
         Titulo actual = CopiaBiblioteca[i];
         int j = i - 1;

         while(j >= 0 && 0 < (string.Compare(CopiaBiblioteca[j].ID, actual.ID, StringComparison.Ordinal)))
         {
            CopiaBiblioteca[j + 1] = CopiaBiblioteca[j];
            j--;
         }

         CopiaBiblioteca[j + 1] = actual;
      }

      return CopiaBiblioteca;
   }

   public static Titulo BusquedaBinariaISBN (List<Titulo> Catalogo, string ISBN)
   {
      List<Titulo> CopiaBiblioteca = OrdenamientoporID(Catalogo);

      int inicio = 0;
      int fin = CopiaBiblioteca.Count - 1;

      while(inicio <= fin)
      {
         int medio = inicio + (fin - inicio) / 2;

         int comparacion = string.Compare(CopiaBiblioteca[medio].ID, ISBN, StringComparison.Ordinal);


         if(comparacion == 0)
         {
            return CopiaBiblioteca[medio];
         }
         else if (comparacion < 0)
         {
            inicio = medio + 1;
         }
         else
         {
            fin = medio - 1;
         }
      }
      return null;
   }

   public static Titulo BusquedaSecuencial (List<Titulo> Catalogo, string Nombre)
   {
      foreach(Titulo titulo in Catalogo)
      {
         if(titulo.Nombre.Equals(Nombre, StringComparison.OrdinalIgnoreCase))
         {
            return titulo;
         }
      }

      return null;
   }


}