/*namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}*/
/*
 ? typeof
  var e = 2;
  Console.WriteLine(e.GetType());

 */


#region Variables

/*

int myNum = 5;               // Integer (whole number) //4 bytes
double myDoubleNum = 5.99D;  // Floating point number // 8 byte
char myLetter = 'D';         // Character //2 bytes
bool myBool = true;          // Boolean //1 byte
string myText = "Hello";     // String //2 bytes per character
long myLongNum = 15000000000L; // Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 // 8 bytes
float myFloatNum = 5.75F; // Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits // 4 bytes
//Console.WriteLine(myLetter);
*/

#endregion

#region Conditions

// ?if/else
/*
int age = 49;
age = 12;
age = 23;

if (age > 65)
{
    Console.WriteLine("Older");
}
else if (age <= 65 && age > 35)
{
    Console.WriteLine("Adult");
}
else if (age > 18 && age <= 35)
{
    Console.WriteLine("Young");
}
else
{
    Console.WriteLine("Teenager");
}
*/


/*

 ?switch
int day = 5;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}
*/

#endregion

#region Operators

/*int a = 10;
int b = 20;
int c = a + b;
Console.WriteLine(c);*/

#endregion

#region for/while Loops

/*
 ? for
int sum = 0;
for (int i = 0; i < 10; i++)
{
    sum = i + sum;
}
Console.WriteLine(sum); // burda yazanda en son cavabi gosterir
*/

/*
 ?while
int item = 78;
while (item > 45)
{
    Console.WriteLine(item);
    item--; // -- 78den 45e dogru azaldir
}
*/
/*
 ?do\while
int item = 45;
do
{
    item--;
    Console.WriteLine(item);

} while (item < 45);
*/
/*
 ?continue break
 for (int i = 0; i < 10; i++)
   {
       if (i % 2 == 0)
       {
           break;
       }
       Console.WriteLine(i);
   }

 */
/*
 ?ReadLine
 Console.WriteLine("Write your name: ");
string name = Console.ReadLine();
Console.WriteLine("Write your age: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Name: " + name + " " + "Age: " + age);*/

#endregion

#region tasks

// todo 1.İstifadəçidən bir ədəd alın və 1-dən həmin ədədə qədər olan cüt və tək ədədləri ayrıca ekrana yazın.
/*
 Console.Write("Add a number: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Even number: ");
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
    }
}

Console.WriteLine();

Console.Write("Odd number: ");
for (int i = 1; i <= n; i++)
{
    if (i % 2 ! == 0)
    {
        Console.Write(i + ", ");
    }
}

Console.WriteLine();
*/


/*
Console.Write("add your zodiac: ");
string zodiac = Console.ReadLine();
Console.WriteLine("your zodiac is " + zodiac);
*/


//todo 2.İstifadəçidən şifrə istəyin.
// Əgər şifrə “12345” deyilsə, təkrar istəsin.Doğru yazıldıqda “Giriş uğurludur” yazsın.

/*
string password = "12345";

if (password == "12345")
{
    Console.WriteLine("Giriş uğurludur");
}
else
{
    Console.WriteLine("Şifrə yanlışdır");
}
*/ //! while ile yaz bunu

/*
string correctPassword = "12345";
Console.Write("Enter password: ");
string input = Console.ReadLine();

if (input == correctPassword)
    Console.WriteLine("hi bro:)");
else
    Console.WriteLine("Access denied!");
    */

// todo 3: İstifadəçidən 3 ədəd alın və ən böyüyünü tapın.

/*
int a = 2;
int b = 3;
int c = 4;

if (a > b && a > c)
{
    Console.WriteLine("The biggest number is {0}", a);
}else if (b > c && b > a)
{
    Console.WriteLine("The biggest number is {0}", b);
} else if (c > b && c > a)
{
    Console.WriteLine("The biggest number is {0}", c);
}
*/

//todo 4 İstifadəçidən 0–100 arası bal daxil etməsini istəyin.
// Bu aralıqlara uyğun qiyməti ekrana yazın. 90–100 → “Əla”,70–89 → “Yaxşı”,50-69→ “Kafi”,0–49 → “Zəif”

/*
int score = 98;

if (score == 100)
{
    Console.WriteLine("Legendary score unlocked.");
}
else if (score > 90)
{
    Console.WriteLine("Main character energy.");
}else if (score > 70 && score < 89)
{
    Console.WriteLine("Almost a legend.");
} else if (score > 50 && score < 69)
{
    Console.WriteLine("Low HP, still alive.");
}
else
{
    Console.WriteLine("See you next semester...");
}
*/

#endregion

// * elave 

/*Console.Write("Enter your zodiac sign: ");
string zodiac = Console.ReadLine();
zodiac = zodiac.ToLower();

switch (zodiac)
{
    case "aries":
        Console.WriteLine("Your energy will be high today!");
        break;
    case "taurus":
        Console.WriteLine("A calm day is ahead.");
        break;
    case "gemini":
        Console.WriteLine("New ideas will pop up.");
        break;
    case "cancer":
        Console.WriteLine("Listen to your feelings.");
        break;
    case "leo":
        Console.WriteLine("Success is on your side.");
        break;
    case "virgo":
        Console.WriteLine("Pay attention to details.");
        break;
    case "libra":
        Console.WriteLine("Social connections are important today.");
        break;
    case "scorpio":
        Console.WriteLine("Use your power wisely.");
        break;
    case "sagittarius":
        Console.WriteLine("Be open to new adventures.");
        break;
    case "capricorn":
        Console.WriteLine("Stick to your plans.");
        break;
    case "aquarius":
        Console.WriteLine("Creativity will shine today.");
        break;
    case "pisces":
        Console.WriteLine("Your intuition will guide you.");
        break;
    default:
        Console.WriteLine("Please enter a valid zodiac sign.");
        break;
}*/

#region tasks 8 jan

// todo 1.Faktorial hesablayan metod 

// namespace Program
// {
//     public class MathFactorial
//     {
//         public static long Factorial(int n)
//         {
//             if (n < 0)
//             {
//                 throw new ArgumentException("Negative numbers are not allowed!");
//             }
//
//             long result = 1;
//
//             for (int i = 1; i <= n; i++)
//             {
//                 result *= i;
//             }
//
//             return result;
//         }
//     }
// }


// todo 2.Salamlaşma metodu,Adı daxil etsin və daxi olan şəxsi salamlasın


/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Write Your Name;");
        string name = Console.ReadLine();

        greeting(name);
    }

    static void greeting(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }

}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Adınızı daxil edin:");
        string ad = Console.ReadLine();

        Salamlasma(ad);
    }

    static void Salamlasma(string ad)
    {
        Console.WriteLine($"Salam, {ad}! Xoş gördük!");
    }
}*/


// todo 3.Tək və cüt ədədləri ekrana yazan metod(eded alsın tekdirse yazsin tek ededir,cütdurse cüt)

/*
using System;

class Program
{
    static void EvenOddNumbers(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an even number.");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number.");
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        EvenOddNumbers(n); // Call the method once
    }
}*/


// todo 4.Ədədlərin böyüklüyünü tapan metod(3 eded daxil etsin)

#endregion

#region 2.1

/*using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8};

        TekCutSay(numbers);

    }*/

    // 1. tək və cüt ədədlərin sayını tapan metod
    /*static void TekCutSay(int[] arr)
    {
        int tek = 0, cut = 0;
        foreach (int n in arr)
        {
            if (n % 2 == 0) cut++;
            else tek++;
        }

        Console.WriteLine($"tək: {tek}, cüt: {cut}");
    }
}*/

// // 2. palindrom yoxlayan metod
    // static bool IsPalindrome(string text)
    // {
    //     int left = 0;
    //     int right = text.Length - 1;
    //
    //     while (left < right)
    //     {
    //         if (text[left] != text[right])
    //             return false;
    //         left++;
    //         right--;
    //     }
    //     return true;
    // }
    //
    // // 3. 3 ədədin ardıcıllığını yoxlayan metod
    // static bool IsSequential(int a, int b, int c)
    // {
    //     return (b - a == c - b);
    // }
    //
    // // 4. massiv elementlərinin orta qiymətini tapan metod
    // static double Average(int[] arr)
    // {
    //     int sum = 0;
    //     foreach (int n in arr)
    //         sum += n;
    //
    //     return (double)sum / arr.Length;
    // }
    //
    // // 5. "visionacademy" sözünü tərsinə çevir (hazır metodsuz)
    // static void ReverseWord()
    // {
    //     string word = "VisionAcademy";
    //     char[] reversed = new char[word.Length];
    //
    //     int j = 0;
    //     for (int i = word.Length - 1; i >= 0; i--)
    //     {
    //         reversed[j] = word[i];
    //         j++;
    //     }
    //
    //     Console.WriteLine(new string(reversed));
    // }
    //
    // // 6. ədədin rəqəmlərinin cəmi
    // static int DigitSum(int n)
    // {
    //     int sum = 0;
    //     while (n > 0)
    //     {
    //         sum += n % 10;
    //         n /= 10;
    //     }
    //     return sum;
    // }
    //
    // // 7. login metodu
    // static void Login()
    // {
    //     string username = "admin";
    //     string password = "1234";
    //
    //     Console.Write("username: ");
    //     string u = Console.ReadLine();
    //
    //     Console.Write("password: ");
    //     string p = Console.ReadLine();
    //
    //     if (u == username && p == password)
    //         Console.WriteLine("uğurla daxil oldunuz");
    //     else
    //         Console.WriteLine("yanlış məlumat");
    // }
    //
    // // 8. 3 və 5 bölünmə yoxlanışı
    // static void CheckNumber(int n)
    // {
    //     if (n % 3 == 0 && n % 5 == 0)
    //         Console.WriteLine("hər ikisinə bölünür");
    //     else if (n % 3 == 0)
    //         Console.WriteLine("yalnız 3-ə bölünür");
    //     else if (n % 5 == 0)
    //         Console.WriteLine("yalnız 5-ə bölünür");
    //     else
    //         Console.WriteLine(n);
    // }
    //
    // // 9. iki ədədin rəqəmləri cəmini müqayisə et
    // static void CompareDigitSums(int a, int b)
    // {
    //     int sum1 = DigitSum(a);
    //     int sum2 = DigitSum(b);
    //
    //     if (sum1 > sum2)
    //         Console.WriteLine(a);
    //     else
    //         Console.WriteLine(b);
    // }
    //
    // // 10. aralıqdakı cüt ədədlərin cəmi
    // static int SumOfEvens(int start, int end)
    // {
    //     int sum = 0;
    //     for (int i = start; i <= end; i++)
    //     {
    //         if (i % 2 == 0)
    //             sum += i;
    //     }
    //     return sum;
    // }
    //
    // // 11. üçbucağın növünü tapan metod
    // static string TriangleType(int a, int b, int c)
    // {
    //     if (a == b && b == c)
    //         return "bərabərtərəfli";
    //     else if (a == b || a == c || b == c)
    //         return "bərabəryanlı";
    //     else
    //         return "müxtəliftərəfli";
    // }
// }


#endregion

#region 3.1


// using System;

/*
class Employee
{
    public string FullName;
    public string Position;
    public double Salary;

    // maaş artıran metod
    public void IncreaseSalary()
    {
        if (Position == "HR")
        {
            Salary += Salary * 0.10;
        }
        else if (Position == "Developer")
        {
            Salary += Salary * 0.20;
        }
    }
    */

    // balans qaytaran metod
    /*
    public double GetBalance()
    {
        return Salary;
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        emp.FullName = "Ali Aliyev";
        emp.Position = "Developer";
        emp.Salary = 1000;

        emp.IncreaseSalary();

        Console.WriteLine("yeni maaş: " + emp.GetBalance());

        Console.ReadLine();
    }
}
*/


#endregion

#region 4.1


    /*
    using System;

    class BankAccount
    {
        public string UserName;
        public string Password;
        public double Balance;

        // login metodu
        public void Login()
        {
            while (true)
            {
                Console.Write("username daxil et: ");
                string u = Console.ReadLine();

                Console.Write("password daxil et: ");
                string p = Console.ReadLine();

                if (u == UserName && p == Password)
                {
                    Console.WriteLine("giriş etdiniz ✅");
                    break;
                }
                else
                {
                    Console.WriteLine("yanlış məlumat, yenidən cəhd et ❌");
                }
            }
        }*/

        // balansdan pul çəkmək
        /*
        public void Withdraw()
        {
            Console.Write("çəkmək istədiyin məbləği daxil et: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("əməliyyat uğurludur 💸");
                Console.WriteLine("qalan balans: " + Balance);
            }
            else
            {
                Console.WriteLine("balans kifayət etmir 💀");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount();

            account.UserName = "admin";
            account.Password = "1234";
            account.Balance = 1000;

            account.Login();      // əvvəl login
            account.Withdraw();   // sonra pul çək

            Console.ReadLine();
        }
    }
    */


#endregion

#region 5.1


        /*
        using System;

        class Animal
        {
            public string Name;
            public int Age;

            public virtual void MakeSound()
            {
                Console.WriteLine("heyvan səs çıxarır");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("dog: hav hav 🐶");
            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("cat: miyav 🐱");
            }
        }

        class Program
        {
            static void Main()
            {
                Dog dog = new Dog();
                dog.Name = "rex";
                dog.Age = 3;

                Cat cat = new Cat();
                cat.Name = "luna";
                cat.Age = 2;

                Console.WriteLine(dog.Name + " - " + dog.Age);
                dog.MakeSound();

                Console.WriteLine(cat.Name + " - " + cat.Age);
                cat.MakeSound();

                Console.ReadLine();
            }
        }
        */


#endregion

#region 6.1

/*
using System;

class ATM
{
    string pin = "1234";
    double balance = 1000;

    public void Login()
    {
        int attempts = 3;

        while (attempts > 0)
        {
            Console.Write("pin daxil et: ");
            string inputPin = Console.ReadLine();

            if (inputPin == pin)
            {
                Console.WriteLine("uğurla daxil oldunuz ✅");
                Menu();
                return;
            }
            else
            {
                attempts--;
                Console.WriteLine("yanlış pin ❌ qalan cəhd: " + attempts);
            }
        }

        Console.WriteLine("kart bloklandı 💀");
    }

    void Menu()
    {
        while (true)
        {
            Console.WriteLine("\n1. balansı göstər");
            Console.WriteLine("2. pul çıxar");
            Console.WriteLine("3. pul əlavə et");
            Console.WriteLine("4. çıxış");

            Console.Write("seçim et: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("balans: " + balance);
            }
            else if (choice == 2)
            {
                Console.Write("məbləğ daxil et: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine("pul çıxarıldı 💸");
                }
                else
                {
                    Console.WriteLine("balans kifayət deyil");
                }
            }
            else if (choice == 3)
            {
                Console.Write("məbləğ daxil et: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                balance += amount;
                Console.WriteLine("pul əlavə edildi 💰");
            }
            else if (choice == 4)
            {
                Console.WriteLine("çıxış edildi 👋");
                break;
            }
            else
            {
                Console.WriteLine("yanlış seçim");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        ATM atm = new ATM();
        atm.Login();

        Console.ReadLine();
    }
}
*/


#endregion

#region 7.1

/*
using System;

class Person
{
    private string name;
    private string surname;
    private int age;
    private DateTime birthDay;

    // name set/get
    public void SetName(string value)
    {
        if (value.Length < 2)
            Console.WriteLine("ad çox qısadır ❌");
        else
            name = value;
    }

    public string GetName()
    {
        return name;
    }

    // age set/get
    public void SetAge(int value)
    {
        if (value < 16)
            Console.WriteLine("yaşınız balacadır ❌");
        else
            age = value;
    }

    public int GetAge()
    {
        return age;
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();

        p.SetName("a");     // error
        p.SetName("ali");   // ok

        p.SetAge(12);       // error
        p.SetAge(20);       // ok

        Console.WriteLine(p.GetName());
        Console.WriteLine(p.GetAge());

        Console.ReadLine();
    }
}
*/


#endregion

#region 8.1


#endregion