# csharp
explore micro structure

# Formate
```c#

```
###### Just main() funcion use the add() function means void main() function call the void add() function

```c#
  static void Main(string[] args) => add(50, 60);
  
        static void add()
        {
            int a = 50, b = 60;
            int result = a + b;
            Console.WriteLine(value: result);
            
        }
````
###### main() function call the add() function and add() returen the result value to main()
```c#
  static void Main(string[] args) => Console.WriteLine(value: add(50, 60));
  
        static int add(int a, int b)
        {
            var result = a + b;
            return result;
        }
```
###### pass by value and pass by reference
```c#
 static void Main(string[] args)
        {
            //pass by value
            var studentGrade = 75;
            Console.WriteLine("student grade before extra credit {0}", studentGrade);
            giveExtracredit(studentGrade);
            Console.WriteLine("student grade after extra credit {0}", studentGrade);

            
            //pass by reference
            int[] grade = new int[] { 10 };
            Console.WriteLine("Student grade before extra credit {0}", grade[0]);
            giveExtragrade(grade);
            Console.WriteLine("Student grade after extra credit {0}", grade[0]);
            
            
            //ref keyword use to create force to reference
            int studentGrade2 = 75;
            Console.WriteLine("Student grade before extra credit {0}", studentGrade2);
            giveExtracredit2(ref studentGrade2);
            Console.WriteLine("Student grade after exra credit {0}", studentGrade2);


        }
        public static void giveExtracredit(int studentGrade) => studentGrade += 3;

        public static void giveExtragrade(int[] grade) => grade[0] += 3;
        
        public static void giveExtracredit2(ref int studentGrade2) => studentGrade2 += 3;
    }

```
