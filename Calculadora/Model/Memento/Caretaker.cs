//namespace Calculadora.Web.Model.Memento;

public class Caretaker
{
  public List<Memento> operaciones;

  public Caretaker()
  {
    operaciones = new List<Memento>();
  }

  public void Add(Memento memento)
  {
    operaciones.Add(memento);
  }

  public Memento Get(int index)
  {
    return operaciones[index];
  }

  public Memento Atras()
  {
    // Navegacion
    return new Memento();
  }

  public Memento Adelante()
  {
    // Navegacion
    return new Memento();
  }
}
