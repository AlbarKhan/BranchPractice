// See https://aka.ms/new-console-template for more information
using System.Globalization;

class Circle
{
    private int radius = 0;


    public int Radius
    {
        get { return radius; } 
        set { radius = value; }
    }
   public int  GetRadius()
    {
        return radius;
    }
    public void SetRadius(int radius)
    {
        this.radius = radius;
    }

    public double Area()
    {
        return 3.14159 * radius * radius;
    }
    public double circumference()
    {
        return  2 * 3.14159 * radius;

    }
}

class DataTypeSize
{
    public void SizeOfInt()
    {
        Console.WriteLine(sizeof(int));
    }

    public void SizeOfBool()
    {
        Console.WriteLine(sizeof(bool));
    }
    public void SizeOfChar()
    {
        Console.WriteLine(sizeof(char));    
    }
    public void SizeOfDecimal()
    {
        Console.WriteLine(sizeof(decimal));
    }

     public void SizeOfUnit()
    {
        Console.WriteLine(sizeof(uint));
    }

    public void SizeOfUshort()
    {
        Console.WriteLine(sizeof(ushort));
    }
}

class Employee
{
    private string _name ;
    private DateTime _joiningDate;
    private int _salary;
    private string _designation;
    private bool _completedSixMonths;

    public string Name {
        get { return  _name; }
        set { _name = value; }
    }
    public DateTime JoiningDate
    {
        get { return _joiningDate;}
        set { _joiningDate = value; }
    }
    public int Salary
    {
        get { return _salary;}
        set { _salary = value; }
    }
    public string Designation
    {
        get { return _designation;}
        set { _designation = value; } 
    }
    /*public bool CompletedSixMonths
    {
        get { return _completedSixMonths; }
        set { _completedSixMonths = value;}
    }*/
    public void Data()
    {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Joining Date : " + _joiningDate.ToString("MMMM d yyyy"));
        Console.WriteLine("Salary INR:" + _salary );
        Console.WriteLine("Designation : " + _designation);
        DateTime sixMonthLater = _joiningDate.AddMonths(6);
        _completedSixMonths =  DateTime.Now >= sixMonthLater ? true : false;
        if(_completedSixMonths)
        {
            Console.WriteLine("Completed 6 months: Yes");
        }
        else
        {
            Console.WriteLine("Completed 6 months: No");
        }
    }


}
 interface Shape
{
    int Sides
    {
        get;
        set;
    }
    int Area
    {
        get;
    }   
}

public class Rectangle : Shape
{
    private int _sides;
    private int _area;
    public int Sides
    {
        get { return _sides; }
        set { _sides = value; }
    }

    public int Area
    {
        get { return _area; }
    }
}

class SetOne()
{
    public static void CheckUnit(int num)
    {
        string strNum = Convert.ToString(num);
        int strNumLen = strNum.Length;

        string result = strNumLen switch
        {
            1 => "Units",
            2 => "Tens",
            3=> "Hundreds",
            4=> "Thousands",
            5 => "Thousand",
            6 => "Thousands",
            7 => "million",
            8 => "millions",
            9=> "millions",
            _ => "Units out of bound"
        }
        ;
        
        Console.WriteLine(result);
    }
    public static void Main(String[] args)
    {
       Circle c = new Circle();
       DataTypeSize size = new DataTypeSize();
        Employee employe = new Employee();

        /*   Console.WriteLine("Enter Name : ");
           employe.Name = Console.ReadLine();
           Console.WriteLine("Enter joining date (MMMM dd, yyyy):");
           string myDate = Console.ReadLine();
           DateTime parsedDate = DateTime.Parse(myDate);
           employe.JoiningDate = parsedDate;
           Console.WriteLine("Enter Salary");
           employe.Salary = Int32.Parse(Console.ReadLine());
           Console.WriteLine("Enter Designation");
           employe.Designation = Console.ReadLine();
           Console.WriteLine("--------Employe Data-------");

           employe.Data();
        */
        CheckUnit(12611111);






        // c.Radius = 1;
        //Console.WriteLine( c.circumference() );
        //Console.WriteLine(sizeof(bool));
        //size.SizeOfDecimal();
    }
}
