//namespace Calculadora.Web.Model.Strategy;
public class Multiplicacion : IStrategy
{
  int IStrategy.OperacionAritmetica(int num1, int num2)
  {
    return num1 * num2;
  }
}
