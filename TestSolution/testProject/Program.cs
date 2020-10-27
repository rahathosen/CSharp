using System;

namespace testProject
{
    public class Program
    {
        public enum Gender
        { Male, Female, Unknown }

        public static void Main(string[] args)
        {
            #region test git

            Console.WriteLine("Hello git!");

            #endregion test git

            #region Enum

            /*
            string name;
            Gender gender;

            Console.Write("Please Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("0 for Male 1 for Female and 2 for Unknown");

            int index = int.Parse(Console.ReadLine());
            gender = (Gender)index;

            Console.WriteLine("Name :{0} Gender {1}", name, gender);
            */

            #endregion Enum

            #region Enum and switchcase

            /*
            Console.Write("Enter Your Gender :");
            int index = int.Parse(Console.ReadLine());

            Gender gender = (Gender)index;

            switch (gender)
            {
                case Gender.Male:
                    Console.WriteLine("You are Male");
                    break;

                case Gender.Female:
                    Console.WriteLine("Your are Female");
                    break;

                case Gender.Unknown:
                    Console.WriteLine("You are Unknown");
                    break;

                default:
                    break;
            }
            */

            #endregion Enum and switchcase

            /*test1 obj = new test1();
            obj.switch_();*/
            //switch fucntion calling
            /*
            New_8 obj2 = new New_8();
            double result = obj2.DoMatch(3.0, 4.0, New_8.MathType.Add);
            Console.WriteLine(result);
            */

            #region Person class object/instance

            Person rahat = new Person();
            rahat.Name = "Rhaat";
            rahat.height = 5.8;
            rahat.weight = 56.0;
            rahat.walk();

            Person hasan = new Person();
            hasan.Name = "Hansan";
            hasan.height = 5.6;
            hasan.weight = 50.5;
            hasan.walk();

            #endregion Person class object/instance

            var product = new Product[10];

            var aBook = new Book();
            aBook.Name = "C# Programming";
            aBook.Description = "Something";
            aBook.Price = -50;
            aBook.Atuthor = "M. Stive";

            var anElectronics = new Electronics();
            anElectronics.Name = "Camera";
            anElectronics.Description = "Smart  DSLR";
            anElectronics.Price = 50000;
            anElectronics.BrandName = "Cannon";

            product[0] = aBook;
            product[1] = anElectronics;

            /*var bookconvert = (Book)product[0];
            Console.WriteLine(bookconvert.Atuthor);*/

            Print(aBook);
            Console.WriteLine();
            Print(anElectronics);
        }

        private static void Print(Product product)
        {
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Description: {product.Description}");
            Console.WriteLine($"Price: {product.Price}");

            if (product is Book)
            {
                var book = product as Book; //"as" type cust = var book = (Book)product;
                Console.WriteLine($"Author: {book.Atuthor}");
            }
            else if (product is Electronics)
            {
                var electornics = product as Electronics; // type cust
                Console.WriteLine($"BrandName: {electornics.BrandName}");
            }
        }
    }
}