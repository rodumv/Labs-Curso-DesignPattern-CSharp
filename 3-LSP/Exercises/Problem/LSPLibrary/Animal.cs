using System;

namespace LSPLibrary
{
    public class Animal
    {
        public string noise;
        public virtual void MakeNoise()
        {
            Console.WriteLine(noise);
        }

        public virtual void Fly()
        {
            Console.WriteLine("Estoy volando");
        }

    }
}
