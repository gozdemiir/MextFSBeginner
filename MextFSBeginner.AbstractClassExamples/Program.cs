using MextFSBeginner.AbstractClassExamples.Animals;



var dog = new Dog();  //Dog classından bir instance oluşturduk.
dog.MakineSound();   //Dog class'ında override edilen MakineSound methodunu çağırdık.

Console.WriteLine("\n-------------------------");

var cat = new Cat();
cat.MakineSound();

Console.WriteLine("\n-------------------------");

var bird = new Bird();
bird.MakineSound();

Console.WriteLine("\n-------------------------");

var rabbit = new Rabbit();
rabbit.MakineSound();


Console.ReadLine();
