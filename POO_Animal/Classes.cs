abstract class BaseAnimal
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public char Sexo { get; set; }
    public abstract bool Carnivoro { get; }

    public int Idade()
    {
        return (DateTime.Now - DataNascimento).Days / 365;
    }
    public abstract void Movimentar();
    public abstract void Comunicar();
    public abstract void Alimentar();
}

abstract class Mamifero : BaseAnimal
{
    public int QtdMamas { get; set; }
    public bool Pelos { get; set; }
    public string CorPelo { get; set; }
    public void Amamentar()
    {

    }
}

abstract class Reptil : BaseAnimal
{
    public bool TemEscamas
    {
        get; set;
    }
    public bool TemCasco { get; set; }


}

abstract class Ave : BaseAnimal
{
    public abstract bool Rapina { get; }
    public string CorPena { get; }

}