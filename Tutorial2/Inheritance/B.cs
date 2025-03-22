namespace Tutorial2.Inheritance;

public class B: A
{
  public int AdditionalValue { get; set; }

  public B(string name, int additionalValue):base(name)
  {
    
    AdditionalValue = additionalValue;
  }
  
  public override int NewMethod()
  {
    return base.NewMethod() + 1; 
  }
  
}