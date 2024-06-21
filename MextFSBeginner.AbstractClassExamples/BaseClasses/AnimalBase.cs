using MextFSBeginner.AbstractClassExamples.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFSBeginner.AbstractClassExamples.BaseClasses
{
    public abstract class AnimalBase
    {
        public virtual string Name { get; set; }  //override Name = "kedi", "köpek", "kuş", "balık"       
        public virtual string Sound { get; set; }
        public virtual int legCount { get; set; } = 4;
        public virtual bool IsPet { get; set; }
        public virtual AnimalGender Gender { get; set; }

        public string GetFancyName()  
        {
            //Ternary Operator
            return Gender == AnimalGender.Male ? $"Mr.  {Name}" : $"MRs.  {Name}";  


        }

        //abstract method
        public abstract void MakineSound();  //cat=> meow, dog=> bark, bird=> tweet, fish=> blub
    }
}
