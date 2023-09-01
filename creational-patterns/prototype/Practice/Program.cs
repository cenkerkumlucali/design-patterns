
Person person = new Person("Cenker","Kumlucalı",Department.A,25000,1);

Person person2 = person.Clone();
person2.Name = "Ahmet";
Console.WriteLine(person.Name);
Console.WriteLine(person2.Name);