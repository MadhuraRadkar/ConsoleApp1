using ConsoleApp1.AbstractClass.cs;
using ConsoleApp1.ConstructorOverloading.cs;
using ConsoleApp1.Inheritance.cs;
using ConsoleApp1.Interface.cs;
using ConsoleApp1.Writtentest3.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Date dateObj1 = new Date();
            //dateObj1.AcceptDate(4, "AUG", 2023);
            //string res = dateObj1.PrintDate();
            //Console.WriteLine(res);

            //----------------------------------------------------------------------

            //Student studentObj1 = new Student();
            //studentObj1.AcceptStudentData(1, "madhura","bsc",88,75,85);
            //studentObj1.CalculatePercentage();
            //Console.WriteLine(studentObj1.PrintStudentData());
            //studentObj1.AssignGrade();

            //----------------------------------------------------------------------------


            //Employee employeeObj1 = new Employee();
            //employeeObj1.AcceptEmployeeData(5, "madhura", 50000, "software developer");
            //employeeObj1.CalculateSalary();
            //Console.WriteLine(employeeObj1.PrintEmployeeData());


            //Book bookObj1 = new Book();
            //bookObj1.AcceptBookData(86, "Shyamchi aai", 250, "sane guruji");
            //string res = bookObj1.PrintBookData();
            //Console.WriteLine(res);

            //--------------------------------------------------------------------------------------


            //Employee employee = new Employee();
            //Employee employee2 = new Employee( "shreya", 25000);
            //Employee employee3 = new Employee( "raj", 30000);
            //employee2.CalculateSalary();
            //employee3.CalculateSalary();
            //Console.WriteLine(employee2.Print());
            //Console.WriteLine(employee3.Print());





            //Student student = new Student();
            //Student student2 = new Student(10, "Priti", "bsc", 70,65,80) ;
            //Student student3 = new Student(23,"sai","bsc",60,74,82);
            //student2.CalculatePercentage();
            //student3.CalculatePercentage();
            //Console.WriteLine(student2.Print());
            //student2.AssignGrade();
            //Console.WriteLine(student3.Print());
            //student3.AssignGrade();



            //Book book = new Book();
            //Book book1 = new Book(21, 500, "english grammer", "Madhav jadhav");
            //Console.WriteLine(book1.Print());



            //Bankaccount b1 = new Bankaccount(30321, "Devansh", 30000);
            //Console.WriteLine(b1.Print());
            //b1.Credit(1500);

            //Console.WriteLine(b1.Print());

            //string msg = b1.Debit(3000);
            //Console.WriteLine(msg);
            //Console.WriteLine(b1.Print());





            // Product discount
            //Product product1 = new Product(23, "Tv", 20000);
            //product1.DiscountedPrice(10);
            //Console.WriteLine(product1.print());
            //Product product2 = new Product(5, "Tab", 10000);
            //product2.DiscountedPrice(40);
            //Console.WriteLine(product2.print());





            // student2
            // property initializer syntex.
            //Student2 stud = new Student2();
            //stud.Rollno = 1;// it calls the set accesor.
            //stud.Name = "kirti";
            //stud.Percentage = 85.86;
            //// it calls the get accessor.
            //Console.WriteLine($"{stud.Rollno},{stud.Name},{stud.Percentage}");
            //Console.WriteLine(stud.Print());

            //// object initializer syntax.
            //Student2 stud2 = new Student2() { Rollno = 2, Name = "pooja", Percentage = 75.34 };
            //Console.WriteLine($" {stud2.Rollno},{stud2.Name},{stud2.Percentage}");




            // product2
            //Product2 prod = new Product2();
            //prod.Code = 1;
            //prod.Name = "Tv";
            //prod.Price = 25000;
            //Console.WriteLine($"{prod.Code},{prod.Name},{prod.Price}");
            //Console.WriteLine(prod.Print());

            //Product2 prod2 = new Product2() { Code = 2, Name = "fan", Price = 800 };
            //Console.WriteLine($"{prod2.Code} ,{prod2.Name},{prod2.Price}");




            // MovieTicket
            //MovieTicket m1 = new MovieTicket(1, "Harry potter", 200, 20);
            //m1.DisplayMovie();
            //Console.WriteLine("Enter the no of ticket you want to book");
            //int num = Convert.ToInt32(Console.ReadLine());
            //m1.FindAvailableTickets();
            //Console.WriteLine("Enter type of ticket 1.silver 2.Gold 3.Platinum");
            //int choice = Convert.ToInt32(Console.ReadLine());
            //m1.CalculateTicketCost();




            //Calculation c = new Calculation();
            //Console.WriteLine(c.Addition(10, 20, 30));
            //Console.WriteLine(c.Addition(12.3, 10.5));




            // Car
            //Car car1 = new Car() { Model = "Toyota Camry" };
            //Car car2 = new Car() { Model = "audi" };
            //Console.WriteLine(car1.GetCarDetails());
            //Console.WriteLine(car2.GetCarDetails());
            //car1.TotalCarSold += 2;
            //Console.WriteLine($"TotalCarSold : {car1.TotalCarSold}");


            // car
            //Car.TotalCarSold = 5;
            //Console.WriteLine($"Total cars sold : {Car.TotalCarSold}");



            // Student3
            //Student3 stud = new Student3(2, "priti");
            //stud.DisplayData();

            //int customid = 3;
            //string customname = "Tom";
            //stud.setCustomData(customid, customname);
            //stud.DisplayData();




            // Default parameter Car
            // companyname parameter is optional
            //Car2 c1 = new Car2("i20", 670000);
            // Car2 c2 = new Car2("Ameze", 7700000, "Honda");

            // Console.WriteLine(c1.Print());
            // Console.WriteLine(c2.Print());




            // Emplloyee2
            //Employee2 e1 = new Employee2(1, "rohan", 25000);
            //Employee2 e2 = new Employee2(2, "rajesh", 15000);
            //Employee2 e3 = new Employee2(3, "riya", 20000);
            //Employee2 e4 = new Employee2(4, "rutuja", 10000);
            //Employee2 e5 = new Employee2(5, "siya", 30000);

            //e1.Display();
            //e2.Display();
            //e3.Display();
            //e4.Display();
            //e5.Display();

            //Console.WriteLine("Total number of employees:" +Employee2.TotalEmp());




            // child class Manager , parent class Employee
            //Manager m1 = new Manager(2000, "Rohan", 25000);
            //m1.CalculateSalary();
            //Console.WriteLine(m1.Print());

            //Employee e1 = new Employee("Tushar", 15000);
            //e1.CalculateSalary();
            //Console.WriteLine(e1.Print());

            //Employee e2 = new Manager(3000, "pooja", 30000);
            //e2.CalculateSalary();

            //Console.WriteLine(e2.Print());




            // Child class Patient , Parent class Person
            //Patient p1 = new Patient("A+","male",300,"Rajesh",25,122344558765);
            //p1.Display();
            //Console.WriteLine(p1.Display());

            //Person p2 = new Person("mona", 18, 765428945298);
            //p2.Display();
            //Console.WriteLine(p2.Display());

            //Person p3 = new Patient("B+", "female", 500, "priya", 26, 327539054132);
            //p3.Display();
            //Console.WriteLine(p3.Display());



            // Constructor overloading Person class

            //Person3 p1 = new Person3();
            //Person3 p2 = new Person3("Pooja", 24);
            //Console.WriteLine(p1.Print());
            //Console.WriteLine(p2.Print());




            // Abstract Class , Shape
            //Rectangle r = new Rectangle(5, 4);
            //Console.WriteLine(r.Display());
            //r.Area();
            //Console.WriteLine(r.Draw("It is rectangle"));
            //Console.WriteLine(r.print());



            // Abstract Class , Shape1
            //Circle c = new Circle(5);
            //Console.WriteLine(c.Display());
            //c.Area();
            //Console.WriteLine(c.Draw("It is circle"));
            //Console.WriteLine(c.Print());





            // Interface printtable






            // Inheritance Animal
            //Dog dog1 = new Dog();
            //dog1.Name = "Goldy";
            //dog1.Display();



            // Vehicle
            //Bike b1 = new Bike();
            //b1.StartEngine();
            //b1.Drive();



            // Laptop
            //Laptop laptop = new Laptop();
            //laptop.NoOfUSBPort = 4;
            //laptop.ProcessorSpeed = 2.5;
            //Console.WriteLine("Number of USB ports " +laptop.NoOfUSBPort);
            //Console.WriteLine("Processor Speed is " + laptop.ProcessorSpeed + "GHz");


            // Written test 3 : Employee
            //Employeees empl = new Employeees(2, "suhas", 50000);
            //Console.WriteLine(empl);




            // ICustomer , IOrder 
            //ICustomer c1 = new Transaction();
            //Console.WriteLine(c1.Display());

            //IOrders o1 = new Transaction();
            //Console.WriteLine(o1.Display());




            // Partial class & partial method
            //Calc c1 = new Calc();
            //Console.WriteLine(c1.Add(15 ,10));
            //Calc c2 = new Calc();
            //Console.WriteLine(c2.Square(8));






            // Reference Swap.
            // int a = 200, b = 500;
            //SWp.Swap(ref a, ref b);
            // Console.WriteLine($"a={a} , b={b}");






            // overriding 
            //Employee3 emp1 = new Employee3();
            //emp1.Id = 1;
            //emp1.Name = "shri";

            //Employee3 emp2 = new Manager1();
            //emp2.Id = 2;
            //emp2.Name = "rahul";

            //Employee3 emp3 = new RegualrEmployee();
            //emp3.Id = 3;
            //emp3.Name = "priti";

            //Console.WriteLine("Employee 1 : ID={0} , Name = {1}", emp1.Id, emp1.Name);
            //Console.WriteLine("Employee 2 : Id={0} , Name={1}", emp2.Id , emp2.Name);
            //Console.WriteLine("Employee 3 : Id={0} , Name={1}", emp3.Id, emp3.Name);





            // Use of base keyword : Mobile
            //Smartphone smartphone = new Smartphone("Apple", "iphone12", "iOS");
            //smartphone.DisplayInfo();



            // child class acess 2 interface.
            //Teacher1 teacher1 = new Teacher1();
            //teacher1.Teach();
            //teacher1.study();
            //teacher1.Manage();



            //Console.WriteLine(Animal1.animalType); // Access static variable
            //Animal1.MakeSound(); // static method
            //Animal1.StaticClass.Staticmethod();   //static method in static  class






        }








    }
}
