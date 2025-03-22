namespace Tutorial2.Classes;

public class Product
{
  
   public int Id {
      get { return _id; }
      private set
      {
         _id = value;
         GenerateSerialNumber(); 
      }
   }
   public string Name { get; set; }
   public double Price { get; set; }
   public bool IsActive { get; set; }
   public DateTime CreatedAt { get; } = DateTime.Now;
   private int _id; 
   private string _type;
   public static int _counter = 1;
 public string SerialNumber { get; set; }
   public string Type
   {
      get
      {
         return _type;
      }
     
      set
      {
         _type = value;
         SerialNumber = GenerateSerialNumber();
         
      }
   }

  
  
   public Product()
   {
      Id = _counter++;
      
   }
   
   private string GenerateSerialNumber()
   {
      return $"PROD-{Type}-{Id}";
   }
}