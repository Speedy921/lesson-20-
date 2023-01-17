using lesson_20;

Console.WriteLine("****** Simple Exception Example****");
Console.WriteLine("=> Creating a car and stepping on it!");
Car myCar = new Car("Zippy", 20);
myCar.CrankTunes(true);

for (int i = 0; i < 10; i++)
{
    myCar.Accelerate(10);
}
Console.ReadLine();

//обработка сгенерированого исключния 
Console.WriteLine("*******Simple Exception Example****");
Console.WriteLine("=> Creating a car and steping on it!");
Car myCar2 = new Car("Zippy", 20);
myCar2.CrankTunes(true);

//Разогнатся до скорости превышеющей максимальный
//предел автомобиля с целью выдачи исключения 

try
{
    for(int i = 0; i < 10; i++)
    {
        myCar2.Accelerate(10);
    }    
}
catch(Exception e)
{
    Console.WriteLine("\n***Error!***"); //ошибка
    Console.WriteLine("Method:{0}", e.TargetSite); //метод
    Console.WriteLine("Message: {0}", e.Message); //сообщение
    Console.WriteLine("Source {0}", e.Source); //источник
}

//ошибка была обработана выполнение со след оператора 
Console.WriteLine("\n***** Out of exception logic****");
Console.ReadLine();