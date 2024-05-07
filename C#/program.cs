using System;
using System.Collections.Generic; // Add this line
using School;
using System.Collections;

namespace part2
{
    class Car
    {
        public Car()
        {
            Console.WriteLine("Car is created");
        }

        string work = "";
        public void workSet(string incoming)
        {
            work = incoming;
        }
        public void workGet()
        {
            Console.WriteLine(work);
        }
    }
  class A{
    public int x=5;
    public void display(){
        Console.WriteLine(x);
      Console.WriteLine("A is working");
    }
  }
  class B:A{
public int y=5;
    public void display(){
        y+=x;
        Console.WriteLine(y);
      Console.WriteLine("B is working");
    }
  }
  abstract class C{
    public abstract void display();
    public void IntroC(){
        Console.WriteLine("This is an abstract class");
    }
  }
  class D:C
  {
    public void IntroD(){
        Console.WriteLine("This is a normal class");
    }
    public override void display(){
      Console.WriteLine("D is working");
    }
  }
  interface face{
    void First();
        void Second();
  }
  class A1{
    public void display(){
      Console.WriteLine("A1 is working");
    }
  }
  class B1{
    public void display(){
      Console.WriteLine("B1 is working");
    }
  }
  class C1:A1,face{
    public void First(){
     Console.WriteLine("First is working");
    } 
    public void Second(){
      Console.WriteLine("Second is working");
    }
    public void Third(){
      Console.WriteLine("C1 is working");
    }
  }
  public static class Extensions{
    public static int MyCount(this string s)
  {
    return s.Length;
  }
  }
    class Program
    {
        readonly int y = 5;
        public Program()
        {
            y = 6;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.y);
            int a = 1;
            a = 3;
            const int x = 4;
            Console.WriteLine(a);
            Console.WriteLine(x);
            int ans = a + x;
            Console.WriteLine(ans);
            if (x < 10)
            {
                Console.WriteLine("x is less than 10");
            }
            else
            {
                Console.WriteLine("x is greater than 10");
            }
            string s = "hello";
            Console.WriteLine(s);
            int len = s.Length;
            Console.WriteLine($"Length of string {s} is {len}");
            Console.WriteLine(s[len - 1]);
            string first = "hello";
            string second = @"
            world
            everyone";
            string concat = first + second;
            Console.WriteLine(concat);
            IEnumerable<char> newStr = first.Concat(second);
            foreach (char c in newStr)
            {
                Console.Write(c);
            }
            Console.WriteLine("Enter any number :");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else if (num == 0)
            {
                Console.WriteLine("Number is zero");
            }
            else
            {
                Console.WriteLine("Number is positive");
            }
            Car car = new Car();
             car.workSet("Car is working");
             car.workGet();
             School.Student student = new School.Student();
                student.Display();
         A obj=new A();
         obj.display();
            B obj1=new B();
            obj1.display();
            D obj2=new D();
            obj2.IntroC();
            obj2.IntroD();
            obj2.display();
             C1 objC1 = new C1();
            objC1.First();
            objC1.Second();
            objC1.display();
            int [] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            int []arr2={34,1,23,4,5,6,7,8,9,10};
            Array.Sort(arr2);
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }
            ArrayList arrList=new ArrayList();
            arrList.Add(1);
            arrList.Add("john");
            arrList.Add(2);
            arrList.Add(true);
            arrList.Add(null);
            int []values={3,2,4};
            arrList.AddRange(values);
            arrList.Insert(1,"john is updated");
            arrList.Remove(true); //remove the first occurence of true
            arrList.RemoveAt(2); //remove the element at index 1
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }
            Hashtable hash = new Hashtable();
            hash.Add(1,"john");
            hash.Add("2",2);
            hash.Add(3.1,3);
            hash.Add(true,23);
            foreach(var item in hash)
            {
                Console.WriteLine(item);
            }
            foreach(DictionaryEntry item in hash)
            {
                Console.WriteLine($"Key : {item.Key} Value : {item.Value}");
            }
            Console.WriteLine(hash.Contains(true));
            Console.WriteLine(hash.ContainsValue(23));
            Console.WriteLine(hash.ContainsKey(1));
            List<string> list=new List<string>();
            list.Add("john");
            list.Add("doe");
            list.Add("everyone");
            list.Add("worldTrip");
            list[3]="WORLD";
            list.ForEach((item)=>
            {
                Console.WriteLine(item);
            });
            Console.WriteLine(list.Contains("john"));
            list.Clear();
            Console.WriteLine(list.Find((item)=>item.ToLower().Contains("world")));
            Dictionary<int,string> dict=new Dictionary<int,string>();
            dict.Add(1,"john");
            dict.Add(2,"doe");
            dict.Add(3,"everyone");
            var item2=new KeyValuePair<int,string>(4,"worldTrip");
            Console.WriteLine(dict.Contains(item2));
            HashSet<int> set=new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Remove(3);
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            string str="jgwejfop ejfop";
            Console.WriteLine(str.MyCount());
        }
    }
}
