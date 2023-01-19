interface IOviparo
{
    void Botar();
    void Chocar();

}
interface IVoar
{
    public int AltitudeMaximaMetros { get; }
    double VelocidadeVoo { get; }

    public void Voar();

}
interface ICisca
{
    void Ciscar();
}

interface IAquatico
{
    bool ViveEmTerra { get; }
    bool Mergulho { get; }
    bool AguaDoce { get; }
}