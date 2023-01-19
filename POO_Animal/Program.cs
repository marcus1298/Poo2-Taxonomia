class Program
{
    static void Main(string[] args)
    {
        Ornitorinco ornitorinco = new Ornitorinco();
        ornitorinco.Nome = "Bob";
        ornitorinco.DataNascimento = new DateTime(2010, 5, 10);
        ornitorinco.Sexo = 'M';
        ornitorinco.QtdMamas = 2;
        ornitorinco.Pelos = true;
        ornitorinco.CorPelo = "Marrom";
        ornitorinco.TamanhoBico = 12;

        Console.WriteLine("Ornitorinco cadastrado com sucesso!");
        Console.WriteLine("Nome: " + ornitorinco.Nome);
        Console.WriteLine("Data de Nascimento: " + ornitorinco.DataNascimento);
        Console.WriteLine("Sexo: " + ornitorinco.Sexo);
        Console.WriteLine("Idade: " + ornitorinco.Idade() + " anos");
        Console.WriteLine("Quantidade de mamas: " + ornitorinco.QtdMamas);
        Console.WriteLine("Tem pelos: " + ornitorinco.Pelos);
        Console.WriteLine("Cor do pelo: " + ornitorinco.CorPelo);
        Console.WriteLine("Tamanho do Bico: " + ornitorinco.TamanhoBico);
        Console.WriteLine("Vive em terra: " + ornitorinco.ViveEmTerra);
        Console.WriteLine("Tem capacidade de mergulho: " + ornitorinco.Mergulho);
        Console.WriteLine("Vive em agua doce: " + ornitorinco.AguaDoce);
    }
}