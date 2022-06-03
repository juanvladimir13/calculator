//namespace Calculadora.Web.Model.Strategy;
public class Division : IStrategy
{
  int IStrategy.OperacionAritmetica(int num1, int num2)
  {
    return num1 / num2;
  }
}
