using MextFSBeginner.AbstractClassExamples.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFSBeginner.AbstractClassExamples.Animals
{
    public class Rabbit : AnimalBase
    {
        public override string Name { get; set; } = "Bugs Bunny";
        public override string Sound { get; set; } = "What's up doc?";

        

        public override void MakineSound()
        {
            string[] rabbitArt = new string[]
            {
            "  (\\(\\  ",
            "  (-.-)",
            " o_(\")(\")"
            };

            var rabbitArtText = string.Join("\n", rabbitArt);

            Console.WriteLine($"{rabbitArtText}\n\n{Sound}");
        }
    }
}
