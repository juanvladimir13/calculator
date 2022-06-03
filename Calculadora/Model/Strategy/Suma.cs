//namespace Calculadora.Web.Model.Strategy;

class Suma : IStrategy
{
  int IStrategy.OperacionAritmetica(int num1, int num2)
  {
    return num1 + num2;
  }
}
