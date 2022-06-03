//namespace Calculadora.Web.Model.Memento;
using Calculadora.Web.Model.Strategy;
public class Originator
{
  private Operacion operacion;

  public Originator()
  {
    operacion = new Operacion();
  }
  public void SetOperacion(Operacion operacion)
  {
    this.operacion = operacion;
  }

  public Operacion GetOperacion()
  {
    return operacion;
  }

  public void SetMemento(Memento memento)
  {
    operacion.Num1 = memento.Num1;
    operacion.Num2 = memento.Num2;
    operacion.Signo = memento.Signo;
    operacion.Resultado = memento.Resultado;
  }

  public Memento CreateMemento()
  {
    Memento memento = new Memento();

    memento.Num1 = operacion.Num1;
    memento.Num2 = operacion.Num2;
    memento.Signo = operacion.Signo;
    memento.Resultado = operacion.Resultado;

    return memento;
  }
}
