// See https://aka.ms/new-console-template for more information
//Ha en variabel med datatypen int og gi den en value med et tall mellom1 og 7. 
//Bruk en switch for å finne ut hvilken dag i uken det tallet er, og print ut dagen med Console.WriteLine();
//Eksempel: 1 er mandag, 2 er tirsdag, osv. 

int randomNum = 0;
Run();
void Run()
{
    Console.WriteLine("What day is it?");
    var randomNum = Console.ReadLine();



    switch (randomNum)
    {
       case "1":
            Console.WriteLine("Monday");
           break;
       case "2":
            Console.WriteLine("Tuesday");
            break;
       case "3":
            Console.WriteLine("Wednesday");
            break;
       case "4":
            Console.WriteLine("Thursday");
            break;
       case "5":
            Console.WriteLine("Friday");
            break;
       case "6":
            Console.WriteLine("Saturday");
            break;
       case "7":
            Console.WriteLine("Sunday");
            break;
    }  
} 