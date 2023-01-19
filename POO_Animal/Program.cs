using Animais;

class Program
{
    static void Main(string[] args)
    {
        Leao leao = new Leao(DateTime.Now.AddYears(-5), 'M');
        Console.WriteLine($"{leao.Idade}");
    }
}