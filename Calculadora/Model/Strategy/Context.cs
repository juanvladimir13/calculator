//namespace Calculadora.Web.Model.Strategy;
public class Context
{
  private IStrategy? strategy;
  public void SetStrategy(IStrategy strategy)
  {
    this.strategy = strategy;
  }
  public int RealizarOperacion(int num1, int num2)
  {
    return strategy!.OperacionAritmetica(num1, num2);
  }
}
