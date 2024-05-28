
using MextFSBeginner.Domain.Entities;
using MextFSBeginner.Domain.Enums;




List<Student> attendees = new List<Student>()
    {
        new Student()
        {
            Id = 1,
            FirstName = "Gamze",
            LastName = "Özdemir",
            Email = "gamze@gmail.com",
            Gender = Gender.Female,
            Lesson = LessonType.Math,
            Score = 100,
        },

        new Student()
        {
            Id = 2,
            FirstName = "Harun",
            LastName = "Ertuğ",
            Email = "hertug@gmail.com",
            Gender = Gender.Male,
            Lesson = LessonType.History,
            Score = 90,
        },

        new Student()
        {
            Id = 3,
            FirstName = "Mehmet",
            LastName = "Yılmaz",
            Email = "mehmet.yilmaz@gmail.com",
            Gender = Gender.Male,
            Lesson = LessonType.Literature,
            Score = 52,
        },


        new Student()
        {
            Id = 4,
            FirstName = "Ayşe",
            LastName = "Yılmaz",
            Email = "ayse.yilmaz@gmail.com",
            Gender = Gender.Female,
            Lesson = LessonType.Geography,
            Score = 47,
        }


    };





//foreach (Student student in attendees)         //Student=tipi, student=değişken adı, attendees=liste
//{

//    if (student.Score >= 39 && student.Score <= 79)      //score 39-79 arasında ise
//    {
       
//        string genderTurkish = "";        //değişken tanımladık ama değer atamadık 

//        if (student.Gender == Gender.Male)
//        {
//            genderTurkish = "Erkek";
//        }

//        else
//        {
//            genderTurkish = "Kadın";
//        }

//        Console.WriteLine($"{student.FirstName} {student.LastName} - {genderTurkish} - {student.Score}");
//    }
   
//}



string userName ="";
bool isUserNameSet = false;

while(isUserNameSet == false)
{
    Console.WriteLine("Kullanıcı adını giriniz: ");
    userName = Console.ReadLine();
    

    if (!string.IsNullOrEmpty(userName))
    {
        isUserNameSet = true;
        break;
    }
    
    
}


Console.ReadKey();



//for (int i = attendees.Count - 1; i >= 0; i++)
//{
//    string fullName = $"{attendees[i].FirstName} {attendees[i].LastName}";

//    if (i % 2 == 0)
//    {
//        Console.WriteLine("-------------");
//    }

//    Console.WriteLine(fullName);

//}






//foreach (Student student in attendees)
//{

//    string studentGender = (student.Gender == Gender.Male) ? "Erkek" : "Kadın";


//    Console.WriteLine($"{student.FirstName} {student.LastName} - {studentGender}");
//}











//foreach (Student attendee in attendees)
//{
//    Console.WriteLine(attendee.Email);
//}

//Console.ReadKey();













//for (int i = attendees.Count-1; i >= 0; i--)
//{
//    Console.WriteLine(attendees[i]);
//}

//Console.ReadKey();



//foreach (var name in attendees)
//{
//    Console.WriteLine(name.ToLower());
//}

