var lobo = new lobo
{   nome = "Lion",
    idade = 16

};

public abstract class animal
{
    string nome { get; set; }
    int idade { get; set; }

    string reino = "animalia";
}

public abstract class mamifero : animal

{
    void mamar()
    {
        Console.WriteLine("Yuuummm, ta gostoso!");
    }
    void amamentar()
    {
        Console.WriteLine("Bebe hora de mamar!");
    }

}


public  abstract class carnivoro : mamifero

{
    public static void printa()
    {
        Console.WriteLine("Eu como plantas!");
    }

}
 
public abstract class herbivoro : mamifero

{
    void printa()
    {
        Console.WriteLine("Eu como carne!");
    }

}


public abstract class lobo : carnivoro

{

    

}

public abstract class rinoceironte : herbivoro

{



}
