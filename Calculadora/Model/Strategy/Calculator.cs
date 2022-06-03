//namespace Calculadora.Web.Model.Strategy;
using Calculadora.Web.Model.Memento;
public class Calculator
{
  private IStrategy strategy;

  private Context context;

  public Operacion operacion;

  private Originator originator;
  private Caretaker caretaker;

  public int Index;

  public Calculator()
  {
    context = new Context();
    strategy = new Suma();
    operacion = new Operacion();
    operacion.Signo = '+';

    originator = new Originator();
    caretaker = new Caretaker();
  }

  public void SetSuma()
  {
    strategy = new Suma();
    operacion.Signo = '+';
  }

  public void SetResta()
  {
    strategy = new Resta();
    operacion.Signo = '-';
  }

  public void SetMultiplicacion()
  {
    strategy = new Multiplicacion();
    operacion.Signo = '*';
  }

  public void SetDivision()
  {
    strategy = new Division();
    operacion.Signo = '/';
  }

  public void ProcesarDatos()
  {
    context.SetStrategy(strategy);
    int resultado = context.RealizarOperacion(operacion.Num1, operacion.Num2);
    operacion.Resultado = resultado;

    originator.SetOperacion(operacion);
    Memento memento = originator.CreateMemento();
    caretaker.Add(memento);
  }

  public void Adelante()
  {
    Memento memento = caretaker.Get(Index);
    originator.SetMemento(memento);
    this.operacion = originator.GetOperacion();
  }

  public void Atras()
  {
    Memento memento = caretaker.Get(Index);
    originator.SetMemento(memento);
    this.operacion = originator.GetOperacion();
  }

  public List<Memento> GetHistory()
  {
    return caretaker.operaciones;
  }
}
