using System;

namespace LSPLibrary
{
    public class Animal : IAnimal
    {
        public string Noise { get; set; }
        public virtual void MakeNoise()
        {
            Console.WriteLine(Noise);
        }

    }
}
