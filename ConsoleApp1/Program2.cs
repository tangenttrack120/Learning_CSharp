class Car
{
    public String red = "Red";
    public String green = "Green";
}
// Fields and methods inside classes are often referred to as "Class Members":
class MyClass
{
    // Class members
    string color = "red";        // field
    int maxSpeed = 200;          // field
    public void fullThrottle()   // method
    {
        Console.WriteLine("The car is going as fast as it can!");
    }
}
// In the previous chapter, you learned that variables inside a class are called fields, and that you can access them by creating an object of the class, and by using the dot syntax (.).
// You can also leave the fields blank, and modify them when creating the object:
class Carl 
{
    public string color;
    public int maxSpeed;
}
/*
class Car 
{
    string model;
    string color;
    int year;

    static void Main(string[] args)
    {
        Car Ford = new Car();
        Ford.model = "Mustang";
        Ford.color = "red";
        Ford.year = 1969;

        Car Opel = new Car();
        Opel.model = "Astra";
        Opel.color = "white";
        Opel.year = 2005;

        Console.WriteLine(Ford.model);
        Console.WriteLine(Opel.model);
    }
}
*/
// Object method
/*
class Car 
   {
     string color;                 // field
     int maxSpeed;                 // field
     public void fullThrottle()    // method
     {
       Console.WriteLine("The car is going as fast as it can!"); 
     }
   
     static void Main(string[] args)
     {
       Car myObj = new Car();
       myObj.fullThrottle();  // Call the method
     }
   }
*/
// A constructor is a special method that is used to initialize objects.
// The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields:
/*
// Create a Car class
   class Car
   {
     public string model;  // Create a field
   
     // Create a class constructor for the Car class
     public Car()
     {
       model = "Mustang"; // Set the initial value for model
     }
   
     static void Main(string[] args)
     {
       Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
       Console.WriteLine(Ford.model);  // Print the value of model
     }
   }
   
   // Outputs "Mustang"
*/
// Constructors can also take parameters, which is used to initialize fields.
// 
// The following example adds a string modelName parameter to the constructor.
// Inside the constructor we set model to modelName (model=modelName).
// When we call the constructor, we pass a parameter to the constructor ("Mustang"), which will set the value of model to "Mustang":
/*
class Car
   {
     public string model;
   
     // Create a class constructor with a parameter
     public Car(string modelName)
     {
       model = modelName;
     }
   
     static void Main(string[] args)
     {
       Car Ford = new Car("Mustang");
       Console.WriteLine(Ford.model);
     }
   }
   
   // Outputs "Mustang"
*/
// Acces modifier
/*
public	The code is accessible for all classes
private	The code is only accessible within the same class
protected	The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
internal The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter
*/
/* private modidfier
class Car {
  private string model = "Mustang";
   
  static void Main(string[] args) {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}
*/
/* Public modifier
class Car {
  public string model = "Mustang";
}
   
class Program {
  static void Main(string[] args) {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}
*/
// By default all member of class are private
/*
class Car{
  string model;  // private
  string year;   // private
}
*/
/*
Properties and Encapsulation
   Before we start to explain properties, you should have a basic understanding of "Encapsulation".
   
   The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:
   
   declare fields/variables as private
   provide public get and set methods, through properties, to access and update the value of a private field
   Properties
   You learned from the previous chapter that private variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties.
   
   A property is like a combination of a variable and a method, and it has two methods: a get and a set method:
   
   ExampleGet your own C# Server
   class Person
   {
     private string name; // field
   
     public string Name   // property
     {
       get { return name; }   // get method
       set { name = value; }  // set method
     }
   } 
    
    
   Example explained
   The Name property is associated with the name field. It is a good practice to use the same name for both the property and the private field, but with an uppercase first letter.
   
   The get method returns the value of the variable name.
   
   The set method assigns a value to the name variable. The value keyword represents the value we assign to the property.
   
   If you don't fully understand it, take a look at the example below.
   
   Now we can use the Name property to access and update the private field of the Person class:
   
   Example
   class Person
   {
     private string name; // field
     public string Name   // property
     {
       get { return name; }
       set { name = value; }
     }
   }
   
   class Program
   {
     static void Main(string[] args)
     {
       Person myObj = new Person();
       myObj.Name = "Liam";
       Console.WriteLine(myObj.Name);
     }
   }
    
    
    
    
    
   The output will be:
   
   Liam
   
   
   Automatic Properties (Short Hand)
   C# also provides a way to use short-hand / automatic properties, where you do not have to define the field for the property, and you only have to write get; and set; inside the property.
   
   The following example will produce the same result as the example above. The only difference is that there is less code:
   
   Example
   Using automatic properties:
   
   class Person
   {
     public string Name  // property
     { get; set; }
   }
   
   class Program
   {
     static void Main(string[] args)
     {
       Person myObj = new Person();
       myObj.Name = "Liam";
       Console.WriteLine(myObj.Name);
     }
   }
    
    
   The output will be:
   
   Liam
   
   Why Encapsulation?
   Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
   Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)
   Flexible: the programmer can change one part of the code without affecting other parts
   Increased security of data
*/
/*
Inheritance (Derived and Base Class)
   In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:
   
   Derived Class (child) - the class that inherits from another class
   Base Class (parent) - the class being inherited from
   To inherit from a class, use the : symbol.
   
   In the example below, the Car class (child) inherits the fields and methods from the Vehicle class (parent):
   
   ExampleGet your own C# Server
   class Vehicle  // base class (parent) 
   {
     public string brand = "Ford";  // Vehicle field
     public void honk()             // Vehicle method 
     {                    
       Console.WriteLine("Tuut, tuut!");
     }
   }
   
   class Car : Vehicle  // derived class (child)
   {
     public string modelName = "Mustang";  // Car field
   }
   
   class Program
   {
     static void Main(string[] args)
     {
       // Create a myCar object
       Car myCar = new Car();
   
       // Call the honk() method (From the Vehicle class) on the myCar object
       myCar.honk();
   
       // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
       Console.WriteLine(myCar.brand + " " + myCar.modelName);
     }
   }
    
   
   Why And When To Use "Inheritance"?
   - It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.
   
   Tip: Also take a look at the next chapter, Polymorphism, which uses inherited methods to perform different tasks.
*/
/*
Polymorphism and Overriding Methods
   Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.
   
   Like we specified in the previous chapter; Inheritance lets us inherit fields and methods from another class. Polymorphism uses those methods to perform different tasks. This allows us to perform a single action in different ways.
   
   For example, think of a base class called Animal that has a method called animalSound(). Derived classes of Animals could be Pigs, Cats, Dogs, Birds - And they also have their own implementation of an animal sound (the pig oinks, and the cat meows, etc.):
   
   ExampleGet your own C# Server
   class Animal  // Base class (parent) 
   {
     public void animalSound() 
     {
       Console.WriteLine("The animal makes a sound");
     }
   }
   
   class Pig : Animal  // Derived class (child) 
   {
     public void animalSound() 
     {
       Console.WriteLine("The pig says: wee wee");
     }
   }
   
   class Dog : Animal  // Derived class (child) 
   {
     public void animalSound() 
     {
       Console.WriteLine("The dog says: bow wow");
     }
   } 
    
    
   Remember from the Inheritance chapter that we use the : symbol to inherit from a class.
   
   Now we can create Pig and Dog objects and call the animalSound() method on both of them:
   
   Example
   class Animal  // Base class (parent) 
   {
     public void animalSound() 
     {
       Console.WriteLine("The animal makes a sound");
     }
   }
   
   class Pig : Animal  // Derived class (child) 
   {
     public void animalSound() 
     {
       Console.WriteLine("The pig says: wee wee");
     }
   }
   
   class Dog : Animal  // Derived class (child) 
   {
     public void animalSound() 
     {
       Console.WriteLine("The dog says: bow wow");
     }
   }
   
   class Program 
   {
     static void Main(string[] args) 
     {
       Animal myAnimal = new Animal();  // Create a Animal object
       Animal myPig = new Pig();  // Create a Pig object
       Animal myDog = new Dog();  // Create a Dog object
   
       myAnimal.animalSound();
       myPig.animalSound();
       myDog.animalSound();
     }
   } 
    
    
   The output will be:
   
   The animal makes a sound
   The animal makes a sound
   The animal makes a sound
   
   Not The Output I Was Looking For
   The output from the example above was probably not what you expected. That is because the base class method overrides the derived class method, when they share the same name.
   
   However, C# provides an option to override the base class method, by adding the virtual keyword to the method inside the base class, and by using the override keyword for each derived class methods:
   
   Example
   class Animal  // Base class (parent) 
   {
     public virtual void animalSound() 
     {
       Console.WriteLine("The animal makes a sound");
     }
   }
   
   class Pig : Animal  // Derived class (child) 
   {
     public override void animalSound() 
     {
       Console.WriteLine("The pig says: wee wee");
     }
   }
   
   class Dog : Animal  // Derived class (child) 
   {
     public override void animalSound() 
     {
       Console.WriteLine("The dog says: bow wow");
     }
   }
   
   class Program 
   {
     static void Main(string[] args) 
     {
       Animal myAnimal = new Animal();  // Create a Animal object
       Animal myPig = new Pig();  // Create a Pig object
       Animal myDog = new Dog();  // Create a Dog object
   
       myAnimal.animalSound();
       myPig.animalSound();
       myDog.animalSound();
     }
   } 
    
    
   The output will be:
   
   The animal makes a sound
   The pig says: wee wee
   The dog says: bow wow
   
   Why And When To Use "Inheritance" and "Polymorphism"?
   - It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.
*/