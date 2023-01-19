
class Leao : Mamifero
{
    public override bool Carnivoro => true;
    public override void Alimentar()
    {
        Console.WriteLine("Comendo Carne");
    }

    public override void Comunicar()
    {
        Console.WriteLine("Rugindo");
    }

    public override void Movimentar()
    {

        Console.WriteLine("Caminhada");
    }
}

class Chacal : Mamifero
{
    public override bool Carnivoro => true;
    public override void Alimentar()
    {
        Console.WriteLine("Comendo Carne e fruta");
    }
    public override void Comunicar()
    {
        Console.WriteLine("Regougar");
    }
    public override void Movimentar()
    {
        Console.WriteLine("Caminhando");
    }
}

class Morcego : Mamifero, IVoar
{
    public override bool Carnivoro => false;

    public int AltitudeMaximaMetros => 10;
    public double VelocidadeVoo => 50;

    public override void Alimentar()
    {
        Console.WriteLine("Comendo fruta");
    }
    public override void Comunicar()
    {
        Console.WriteLine("Farfalhando");
    }
    public override void Movimentar()
    {
        Console.WriteLine("Voando");
    }

    public void Voar()
    {
        Console.WriteLine($"Voando a {VelocidadeVoo} km/h");
    }
}

class Cisne : Ave, IVoar
{
    public override bool Rapina => false;
    public override bool Carnivoro => false;
    public bool ViveEmTerra => true;
    public bool Mergulho => true;
    public bool AguaDoce => true;
    public int AltitudeMaximaMetros => 5;
    public double VelocidadeVoo => 10;

    public override void Alimentar()
    {
        Console.WriteLine("Comendo fruta");
    }
    public override void Comunicar()
    {
        Console.WriteLine("Assobiando");
    }
    public override void Movimentar()
    {
        Console.WriteLine("Caminhando");
    }
    public void Voar()
    {
        Console.WriteLine($"Voando a {VelocidadeVoo} km/h");
    }
}

class Arara : Ave, IVoar
{
    public override bool Rapina => true;
    public override bool Carnivoro => false;
    public int AltitudeMaximaMetros => 50;
    public double VelocidadeVoo => 20;

    public override void Alimentar()
    {
        Console.WriteLine("Comendo fruta");
    }
    public override void Comunicar()
    {
        Console.WriteLine("Palrarando");
    }
    public override void Movimentar()
    {
        Console.WriteLine("Voando");
    }
    public void Voar()
    {
        Console.WriteLine($"Voando a {VelocidadeVoo} km/h");
    }
}

class DragaoDeComodo : Reptil, IOviparo
{
    public override bool Carnivoro => true;
    public int QuantidadeDeChifres { get; set; }
    public double ComprimentoCauda { get; set; }
    public string CorDaEscama { get; set; }
    public bool TemAsas { get; set; }

    public override void Alimentar()
    {
        Console.WriteLine("Comendo carne");
    }
    public void AlimentarComFogo()
    {
        Console.WriteLine("Queimando a comida com fogo");
    }
    public void Botar()
    {
        Console.WriteLine("Botando ovos");
    }

    public void Chocar()
    {
        Console.WriteLine("Chocando ovos");
    }

    public override void Comunicar()
    {
        Console.WriteLine("Silvando");
    }
    public override void Movimentar()
    {
        Console.WriteLine("Voando e caminhando");
    }
}

class Lontra : Mamifero, IAquatico
{
    public override bool Carnivoro => true;
    public bool ViveEmTerra => true;
    public bool Mergulho => true;
    public bool AguaDoce => false;

    public override void Alimentar()
    {
        Console.WriteLine("Comendo peixes e crustáceos");
    }

    public override void Comunicar()
    {
        Console.WriteLine("Grunhidos");
    }

    public override void Movimentar()
    {
        Console.WriteLine("Nadando e andando");
    }
}

class Pinguim : Ave, IAquatico
{
    public override bool Rapina => false;
    public override bool Carnivoro => true;
    public bool ViveEmTerra => true;
    public bool Mergulho => true;
    public bool AguaDoce => false;

    public override void Alimentar()
    {
        Console.WriteLine("Comendo peixes e crustáceos");
    }

    public override void Comunicar()
    {
        Console.WriteLine("Gritando");
    }

    public override void Movimentar()
    {
        Console.WriteLine("Andando e nadando");
    }
}

class Coruja : Ave, IVoar, ICisca
{
    public override bool Rapina => true;
    public override bool Carnivoro => true;
    public int AltitudeMaximaMetros => 15;
    public double VelocidadeVoo => 30;

    public override void Alimentar()
    {
        Console.WriteLine("Comendo ratos e insetos");
    }

    public override void Comunicar()
    {
        Console.WriteLine("Assoviando");
    }

    public override void Movimentar()
    {
        Console.WriteLine("Voando e caminhando");
    }

    public void Voar()
    {
        Console.WriteLine($"Voando a {VelocidadeVoo} km/h");
    }

    public void Ciscar()
    {
        Console.WriteLine("Ciscando");
    }
}

class Elefante : Mamifero
{
    public override bool Carnivoro => false;
    public int TamanhoTromba { get; set; }

    public override void Alimentar()
    {
        Console.WriteLine("Comendo folhas e frutas");
    }

    public override void Comunicar()
    {
        Console.WriteLine("Barulho com tromba");
    }

    public override void Movimentar()
    {
        Console.WriteLine("Caminhando");
    }
}

class Jacare : Reptil, IAquatico
{
    public override bool Carnivoro => true;
    public bool ViveEmTerra => true;
    public bool Mergulho => true;
    public bool AguaDoce => true;
    public bool AguaSalgada => false;
    public bool TemMandíbulas { get; set; }
    public bool TemCauda { get; set; }

    public override void Alimentar()
    {
        Console.WriteLine("Comendo peixes, aves e mamíferos");
    }

    public override void Comunicar()
    {
        Console.WriteLine("Rugindo");
    }

    public override void Movimentar()
    {
        Console.WriteLine("Nadando e andando");
    }
}

class Ornitorinco : Mamifero, IAquatico, IOviparo
{
    public override bool Carnivoro => true;
    public bool ViveEmTerra => true;
    public bool Mergulho => true;
    public bool AguaDoce => true;
    public int QtdMamas { get; set; }
    public bool Pelos { get; set; }
    public string CorPelo { get; set; }
    public int TamanhoBico { get; set; }

    public override void Alimentar()
    {
        Console.WriteLine("Comendo insetos e peixes");
    }

    public override void Comunicar()
    {
        Console.WriteLine("Grunhidos");
    }

    public override void Movimentar()
    {
        Console.WriteLine("Nadando e andando");
    }

    public void Botar()
    {
        Console.WriteLine("Botando ovos");
    }
    public void Chocar()
    {
        Console.WriteLine("Chocando ovos");
    }
}