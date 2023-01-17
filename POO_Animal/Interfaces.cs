public interface IOviparo
{
    void Botar();
    void Chocar();
}

public interface IVoar
{
    void Voar();
    int AltitudeMaximaEmMetros { get; set; }
    double VelocidadeDoVoo { get; set; }
}

public interface IAquatico
{
    bool ViveEmTerra { get; set; }
    bool Mergulho { get; set; }
    bool AguaDoce { get; set; }
}

