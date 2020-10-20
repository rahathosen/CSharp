# csharp
explore micro structure

# Formate
```c#

```
###### Just main() funcion use the add() function means void main() function call the void add() function

```c#
  static void Main(string[] args)
        {
            add(50,60);
        }
        static void add()
        {
            int a = 50, b = 60;
            int result = a + b;
            Console.WriteLine(value: result);
            
        }
````
###### main() function call the add() function and add() returen the result value to main()
```c#
static void Main(string[] args)
        {
            add(50,60);
            Console.WriteLine();
        }
        static int add(int a,int b)
        {
            
            int result = a + b;
            return result;
        }
```
