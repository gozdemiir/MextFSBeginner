using MextFSBeginner.AbstractClassExamples.BaseClasses;
using MextFSBeginner.AbstractClassExamples.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFSBeginner.AbstractClassExamples.Animals
{

    public class Cat : AnimalBase
    {
        public override string Name { get; set; } = "Meow";

        public override string Sound { get; set; } = "Meow";

        

        public override void MakineSound()
        {
            string[] catArt = new string[]
            {
            " /\\_/\\  ",
            "( o.o ) ",
            " > ^ <  "
            };

            var catArtText = string.Join("\n", catArt);

            Console.WriteLine($"{catArtText}\n\n{Sound}");
        }
    }
}
