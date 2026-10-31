public class Titulo
{
   public string Nombre { get; set; }
   public string ID { get; set; }
   public int Cantidad { get; set; }
   public int HistorialP { get; set; }
   public Titulo(string nombre, string id, int cantidad, int historialP)
   {
      Nombre = nombre;
      ID =  id;
      Cantidad = cantidad;
      HistorialP = historialP; 
   }
}