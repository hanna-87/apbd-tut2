using Tutorial2.Exceptions.Data;

namespace Tutorial2.Exceptions;

public class OrderProcessor
{
 public static void ProcessOrder(List<Order> orders)
 {
  if (orders == null || orders.Count == 0)
  {
   throw new ArgumentNullException("orders");
  }

  foreach (var order in orders)
  {
   if (order.Amount <= 0)
   {
    throw new ArgumentException($"Order {order.Id} has an invalid amount.");
   }
   if (order.Status != "Pending")
   {
    throw new InvalidOperationException($"Order {order.Id} cannot be processed because its status is {order.Status}.");
   }
   
    order.Status = "Processed";
   
   
    
  }
 }
}