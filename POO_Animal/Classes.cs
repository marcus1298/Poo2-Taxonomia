public abstract class animal
{
    public abstract string Nome { get; set; }
    public abstract DateTime DataDeNascimento { get; set; }
    public abstract char Sexo { get; set; }
    public abstract int Idade { get; set; }
    public bool Carnivoro { get; set; }
    public bool Peconhento { get; set; }
    public  void Movimentar() => Console.WriteLine($"{Nome} se movendo!");
    public  void Comunicar() => Console.WriteLine($"{Nome} se comunicando!");
    public void Alimentar() => Console.WriteLine($"{Nome} se alimentando!");


}

public abstract class mamifero : animal
{
    public abstract int  QtdeMamaas { get; set; }
    public abstract bool Pelos { get; set; }
    public abstract string CorDoPelo { get; set; }
    public void Amamentar() => Console.WriteLine($"{Nome} amamentando!");

}


public abstract class reptil : animal
{
    public abstract bool TemEscamas { get; set; }
    public abstract bool TemCasco { get; set; }
}
public abstract class ave : animal
{
    public abstract bool Rapina { get; set; }
    public abstract bool CorPena { get; set; }
    public void Ciscar() => Console.WriteLine($"{Nome} ciscando!");
}

