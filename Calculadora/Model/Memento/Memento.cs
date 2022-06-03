//namespace Calculadora.Web.Model.Memento;
public class Memento
{
  public int Num1 { get; set; }

  public int Num2 { get; set; }

  public int Resultado { get; set; }
  public char Signo { get; set; }

  public override string ToString()
  {
    return Convert.ToString(Num1) + " " +
    Signo + " " +
    Convert.ToString(Num2) +
    " = " +
    Convert.ToString(Resultado);
  }
}
