using System;

namespace Animais
{
    public abstract class Leao : mamifero
    {
        public bool Carnivoro => true;
        public  bool Peconhento => false;

        public void Comunicar() => Console.WriteLine($"{Nome} rugindo");
        public void Movimentar() => Console.WriteLine($"{Nome} correndo");

        public override int QtdeMamaas => 4;
        public override bool Pelos => true;
        public override string CorDoPelo => "amarelo";
    }
}