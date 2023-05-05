using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;




namespace introcsharp
{ 
//{class Student  
//{  
//    int rollno;  
//    string name;  
//    public Student(int rollno, string name)  
//    {  
//        this.rollno = rollno;  
//        this.name = name;  
//    }  
//}  
 public delegate int mydel(int num);
    public class Program
{
        private static readonly object Integer;

        //int id;
        //String name;

        //public enum alfa {aa,bbb,cccc}

        //public enum days {sun,mon,tue,wed,thu,fri,sat };



        // public const double pi = 3.14;

        public static void Sum(int[] arr1)
        {
            int total = 0 ;
            for (int i = 0; i < arr1.Length; i++)
            {
                total += arr1[i];
            }

            Console.WriteLine("the sum is :-"+total);
           
        }
        static void Main(string[] args)
    
        {
            int? op = default;


            //Console.WriteLine("command line args" + args.Length);
            //Console.WriteLine("suplied arguments ");

            //foreach (Object item in args)
            //{
            //    Console.WriteLine(item);
            //}


            // console.writeline("helo");

            //string fname=console.readline();
            // string lname = console.readline();
            // console.writeline("name "+ fname+" "+lname);

            // console.writeline(" fname {0} lname {1}",fname,lname);

            //Console.WriteLine("enter your first number");
            //int num1=int.Parse(Console.ReadLine());
            //Console.WriteLine("enter your second number");
            //int num2=int.Parse(Console.ReadLine());

            //int sum = num1 + num2;

            //Console.WriteLine("addition :- {0}", sum);

            //int a = 30;
            //int b = 30;
            //bool c = a > b;

            //Console.WriteLine("c:"+c);

            //string a = "akib";
            //char b = 'a';
            //string c = "\"ksksdadjadaid\"";
            //Console.WriteLine(c);
            //string s = "\t welcome to csharp";
            //Console.WriteLine(s);

            //float a = 20;
            //int b = a;
            //Console.WriteLine(typeof(float));
            //Console.WriteLine(b);
            //checked{
            //    int a = int.MaxValue;
            //    Console.WriteLine(a + 2);
            //}

            // int a = 20;
            // float b = a;
            // Console.WriteLine(b);

            // float c = 20.044f;
            //// int d = (int)c;

            // int d = Convert.ToInt32(c);
            //     Console.WriteLine("d print"+d);

            // string b = "50.84";
            // string c = "60.375";

            //    //int d= Convert.ToInt32(b) + Convert.ToInt32(c);

            // //int d = int.Parse(b)+int.Parse(c);

            //float d=float.Parse(b) + float.Parse(c);

            // Console.WriteLine(d);

            //Console.WriteLine("enter num1");
            //float a=float.Parse(Console.ReadLine());
            //Console.WriteLine("enter num2");
            //float b=float.Parse(Console.ReadLine());

            //float c=a+b;
            //Console.WriteLine("c print" + c);

            //string a = "shw776sg";
            //int c=Convert.ToInt32(a);
            //Console.WriteLine("c print"+c);

            //var integers = new ArrayList();
            //integers.Add(1);
            //integers.Add(2);
            //integers.Add("3");

            //for (int i = 0; i < integers.Count; ++i)
            //{
            //    int integer = (int)integers[i];
            //    // do something
            //}

            //Console.Write("Enter a number:");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("It is even number");
            //}
            //else
            //{
            //    Console.WriteLine("It is odd number");
            //}

            //switch 
            //Console.WriteLine("Enter a number:");
            //int num = Convert.ToInt32(Console.ReadLine());

            //switch (num)
            //{
            //    case 10:
            //        {
            //            Console.WriteLine("It is 10"); break;
            //        }
            //    case 20:
            //        {
            //            Console.WriteLine("It is 20"); break;
            //        }
            //    case 30:
            //        {
            //            Console.WriteLine("It is 30"); break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("call default"); break;
            //        }
            //}
            //     ----------------------------------------------
            //{
            //    int i = 1;

            //    do
            //    {
            //        int j = 1;

            //        do
            //        {
            //            Console.WriteLine("i= {0} j={1}",i, j);
            //            j++;
            //        } while (j <= 3);
            //        i++;
            //    } while (i <= 3);


            //}

            //   -------------------------------------------

            //not_eligible:
            //    Console.WriteLine("You are not eligible to vote!");

            //    Console.WriteLine("Enter your age:\n");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    if (age < 18)
            //    {
            //        goto not_eligible;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are eligible to vote!");
            //    }
            //------------------------------------------------------


            //Class1 c1 = new Class1(101,"akib",1727f);
            //Class1 c2 = new Class1(102, "yax", 33127f);



            //c1.show();
            //------------------------------------------------------

            //int a = 50;
            //Console.WriteLine("value of a:"+a);
            //c1.call_by_ref(ref a);
            //Console.WriteLine("after call value a :" + a);

            //int a = 50;
            //Console.WriteLine("value of a:" + a);
            //c1.call_out(out a);
            //Console.WriteLine("after call value a :" + a);

            //int[] a=new int[3];
            //a[0] = 1;
            //a[1] = 2;
            //a[2] = 3;

            //for(int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            //int[] b=new int[] { 10,20,30,40,50};

            //int[] arr = { 10, 20, 40, 50 };


            //int[] arr = { 10, 20, 30, 40, 50 };//creating and initializing array  


            //foreach (int i in arr)
            //{
            //    Console.WriteLine("arr values: {0}",i);
            //}

            //int[] arr1= new int[] { 0,1,2,3,4,5};
            //int[] arr2 = new int[] { 6, 7, 8, 9, 10, };

            //c1.printArray(arr1);
            //c1.printArray(arr2);    

            //int[,] arr = new int[3, 3];//declaration of 2D array  
            //arr[0, 1] = 10;//initialization  
            //arr[1, 2] = 20;
            //arr[2, 0] = 30;

            ////traversal  
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();//new line at each row  
            //}


            //Console.WriteLine("const:"+ pi);

            //DateTime dt = DateTime.Now;
            //Console.WriteLine("current time D: {0:D}",dt);
            //Console.WriteLine("current time d: {0:d}", dt);
            //Console.WriteLine("current time f: {0:f}", dt);
            //Console.WriteLine("current time F: {0:F}", dt);
            //Console.WriteLine("current time g: {0:g}", dt);
            //Console.WriteLine("current time g: {0:G}", dt);
            //Console.WriteLine("current time g: {0:g}", dt);
            //Console.WriteLine("current time g: {0:ddd}", dt);
            //Console.WriteLine("current time g: {0:FF}", dt);



            //int[][] arr = new int[2][];

            //arr[0]= new int[2] {0,2 };
            //arr[1] = new int[3] { 0, 2, 4 };

            //for (int i = 0; i <arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)

            //    {
            //        Console.Write(arr[i][j] + " ");
            //    }

            //    Console.WriteLine();
            //}



            //c1.parameter(1,'c',"akib",1.33,true,1,2,3,4,5,6,7,8,9);

            //C# Array Example


            //    int[] arr= new int[5] {8,44,10,6,5 };

            //    int[] arr1 = new int[5];

            //    Console.WriteLine("lenght of first array"+arr.Length);

            //    Array.Sort(arr);

            //    foreach (var item in arr)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    PrintArray(arr);
            //    Console.WriteLine("position"+Array.IndexOf(arr,10));

            //    Array.Copy(arr,arr1,arr.Length);
            //    Console.WriteLine("second array elements");

            //    PrintArray(arr1);

            //    Array.Reverse(arr);
            //    Console.WriteLine("first array reverse");

            //    PrintArray(arr);




            //}
            //static void PrintArray(int[] arr)
            //{
            //    foreach (Object elem in arr)
            //    {
            //        Console.Write(elem + " ");
            //    }


            //Program program = new Program();
            //program.id = 101;
            //program.name = "Test";

            //Console.WriteLine("id="+program.id);
            //Console.WriteLine("name=" + program.name);

            //c1.disp();
            //c2.disp();

            //Enum constants has default values which starts from 0 and incremented to one by one. But we can change the default value.
            //int x = (int)alfa.aa;
            //int y = (int)alfa.bbb;
            //int z = (int)alfa.cccc;
            //Console.WriteLine(" x value={0}",x);
            //Console.WriteLine(" y value={0}", y);
            //Console.WriteLine(" z value={0}", z);

            //foreach (var item in Enum.GetNames(typeof(days)))
            //{
            //    Console.WriteLine(item);
            //}

            //Class1 c1 = new Class1();
            //c1.P_Name = "akib";
            //Console.WriteLine("name of emp :-"+c1.P_Name);



            //string s1 = "hello";

            //char[] c1 = { 'c', 's', 'h', 'a', 'r', 'p' };

            //string s2 = new string(c1);

            //Console.WriteLine(s2);

            //string s3 = (String)s1.Clone();

            //Console.WriteLine(s3);

            //int a = 10;
            //int b = 0;

            //try
            //{
            //    int c = a / b;
            //}
            //catch(Exception e) 
            //{
            //    Console.WriteLine(e);
            //}
            //Console.WriteLine("rest of the code ");


            //    try
            //    {
            //        int a = 10;
            //        int b = 0;
            //        int x = a / b;
            //    }
            //    catch (Exception e) { Console.WriteLine(e); }
            //    finally { Console.WriteLine("Finally block is executed"); }
            //    Console.WriteLine("Rest of the code");

            //int a = 20;
            //string b = (a > 10) ? "a is greater" : "a is lessthen";

            //Console.WriteLine(b);


            //string interopolation
            //  string fname = Console.ReadLine();
            //string lname = Console.ReadLine();

            //Console.WriteLine($" your name is {fname} . last name is {lname}");

            // Console.WriteLine(fname[0]);

            //Console.WriteLine(fname.IndexOf("akib"));

            //Console.WriteLine(fname.Substring(5));

            //escape sequence char
            //Console.BackgroundColor = ConsoleColor.Green;
            //string hello = "\"hello\" world ";
            //Console.WriteLine(hello);

            //StringBuilder sb = new StringBuilder("String");
            //sb.Append("Builder");
            //Console.WriteLine(sb);


            //string str = " c# StringfMethod All Are Usable";

            //string[] strarr = str.Split(' ');

            //for (int i = 0; i < strarr.Length; i++)
            //{
            //    Console.WriteLine("{0}",strarr[i]);
            //}    

            //string str1=string.Concat(str," ok");

            //Console.WriteLine(str1);

            //int index=str.IndexOf("String");

            //Console.WriteLine(index);

            //string subsr=str.Substring(4,6);

            //Console.WriteLine("substr:="+subsr);

            //int x = 1234556781;
            //int y = 1234567890;

            //try
            //{
            //    int c = checked(x + y);

            //   // int c = unchecked(x + y); work as default

            //    Console.WriteLine(c);
            //}
            //catch(OverflowException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //------------------------------------------------------------
            //C# FileStream example: writing single byte into file

            //FileStream f1 = new FileStream("C:\\akib07\\test.txt", FileMode.OpenOrCreate);

            //f1.WriteByte(65);
            //f1.Close();


            //C# StreamWriter example

            //FileStream f1 = new FileStream("C:\\akib07\\test.txt",FileMode.Create);

            //StreamWriter streamWriter = new StreamWriter(f1);

            //streamWriter.WriteLine("hello ");
            //streamWriter.Close();
            //f1.Close();

            //Console.WriteLine("file created");

            //C# StreamReader example to read one line

            //FileStream f1 = new FileStream("C:\\akib07\\test.txt", FileMode.OpenOrCreate);
            //StreamReader streamReader = new StreamReader(f1);

            //string s1 = streamReader.ReadLine();    

            //Console.WriteLine(s1);

            //C# TextWriter Example

            //using (TextWriter writer = File.CreateText("C:\\akib07\\test.txt"))
            //{
            //    writer.WriteLine("Hello C#");
            //    writer.WriteLine("C# File Handling");
            //}
            //Console.WriteLine("Data written successfully...");

            //C# BinaryWriter Example

            //string fileName = "C:\\akib07\\binaryfile.dat";
            //using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            //{
            //    writer.Write(27);
            //    writer.Write("this is string data");
            //    writer.Write(true);
            //}
            //Console.WriteLine("Data written successfully... ");


            //string path = @"C:\\akib07\\test.txt";
            //string path1 = @"C:\\akib07\\test1.txt";

            //File.Copy(path,path1);

            //FileStream stream = new FileStream("C:\\akib07\\abc.txt", FileMode.OpenOrCreate);
            //    BinaryFormatter formatter = new BinaryFormatter();

            //    Student st = new Student(101, "sonoo");
            //    formatter.Serialize(stream,st);

            //    stream.Close();

            //var names = new List<string>();
            //names.Add("Jaiswal");
            //names.Add("Ankit");
            //names.Add("Peter");
            //names.Add("Irfan");

            //// Iterate list element using foreach loop  
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);

            //int[] num=new int[3] {4,3,5};
            //Class1.Show(num);

            //string[] str = new string[4] { "akib","kevin","keval","milan"};

            //double[] d = new double[3] { 3.3,3.4,3.6};
            //Class1.Show(num);
            //Class1.Show(str);
            //Class1.Show(d);


            //    ArrayList al = new ArrayList();

            //    al.Add(22);
            //    al.Add("akib");
            //    al.Add('a');
            //    Console.WriteLine(al.Capacity);

            //    al.Insert(2,44.5);

            //    foreach (var item in al)
            //    {
            //        Console.WriteLine("item {0}",item);
            //    }

            //Hashtable ht = new Hashtable();
            //ht.Add("id",112);
            //ht.Add("name","akib");
            //ht.Add("city","jetpur");
            //ht.Add("salary",350000);

            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine("entry {0},{1}", item.Key,item.Value);
            //}

            //Stack<string> s1=new Stack<string>();
            //s1.Push("aaa");
            //s1.Push(22);
            //Stack s2=new Stack();
            //s2.Push(2);
            //s2.Push("aaa");

            //SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            //names.Add("1", "Sonoo");
            //names.Add("4", "Peter");
            //names.Add("5", "James");
            //names.Add("3", "Ratan");
            //names.Add("2", "Irfan");
            //foreach (KeyValuePair<string, string> kv in names)
            //{
            //    Console.WriteLine(kv.Key + " " + kv.Value);
            //}
            //C# Reflection Example: Get Type
            //int a = 10;
            //Type type = a.GetType();
            //Console.WriteLine(type);


            //mydel obj = (a) =>
            //{

            //    a += 5;
            //    Console.WriteLine(a);
            //};

            //    obj.Invoke(10);

            //  mydel obj = (a) => a * a;
            //Console.WriteLine(obj.Invoke(10));

            //Thread T=Thread.CurrentThread;
            //T.Name = "Main";

            //Thread t1 = new Thread(new ThreadStart(Class1.Thread1));
            //Thread t2 = new Thread(new ThreadStart(Class1.Thread2));
            //t1.Start();
            //t2.Start();
            //Console.WriteLine(T.Name);

            //Console.WriteLine("Start of Main");

            //Class1 c1 = new Class1();
            //Thread t1 = new Thread(new ThreadStart(c1.Thread1));
            //Thread t2 = new Thread(new ThreadStart(c1.Thread1));

            //t1.Start();
            //t2.Start();
            //try
            //{
            //    t1.Abort();
            //    t2.Abort();
            //}
            //catch (ThreadAbortException tae)
            //{
            //    Console.WriteLine(tae.ToString());
            //}
            //Console.WriteLine("End of Main");

            // Class1 mt = new Class1();
            // Thread t1 = new Thread(new ThreadStart(mt.Thread3));
            // Thread t2 = new Thread(new ThreadStart(mt.Thread3));
            // Thread t3 = new Thread(new ThreadStart(mt.Thread3));

            // t1.Name = "keval";
            // t2.Name = "yax";
            // t3.Name = "milan";

            // t3.Priority = ThreadPriority.Highest;
            // t1.Priority = ThreadPriority.Normal;
            // t2.Priority = ThreadPriority.Lowest;
            // t1.Start();
            // t2.Start();
            //// t1.Join();
            // t3.Start();

            //int a = 10;
            //int temp = 0;

            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j <a; j++)
            //    {
            //        temp=i+j
            //    }
            //}




            //1.Write a C# Sharp program that takes three letters as input and display them in reverse order.

            //char[] arr = new char[3];
            //char ch;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("enter a character");
            //    arr[i] = Convert.ToChar(Console.ReadLine());

            //    //Console.WriteLine(Array.Reverse(arr).ToArray());
            //}
            //Array.Reverse(arr);
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}




            //Console.WriteLine("enter a first");
            //string first = Console.ReadLine();
            //Console.WriteLine("enter a first");
            //string second = Console.ReadLine();
            //Console.WriteLine("enter a first");
            //string third = Console.ReadLine();

            //Console.WriteLine("{2}{1}{0} ", first, second, third);



            //  3.Write a C# Sharp program to sort a given positive number in descending/ascending order.

            //Console.WriteLine("enter number");
            //string num = Console.ReadLine();

            //char[] charArr = num.ToCharArray();
            //foreach (char ch in charArr)
            //{

            //    Console.WriteLine(ch);
            //}





            //   int[] arr2 = new int[charArr.Length];
            //   for (int i = 0; i < charArr.Length; i++)
            //   {
            //       arr2[i] = (int)Char.GetNumericValue(charArr[i]);


            //   }

            //   Console.Write("Original Number: ");
            //   for (int i = 0; i < arr2.Length; i++)
            //   {
            //       Console.Write(arr2[i]);
            //   }
            //   Array.Sort(arr2);

            //   Console.Write("sort Number: ");
            //   foreach (var item in arr2)
            //   {
            //       Console.Write(item);
            //   }

            //Console.WriteLine("length"+arr2.Length);
            //   int[] ints = new int[arr2.Length];
            //   Console.WriteLine("Descending order of the said number:");
            //   int j = 0;
            //   for (int i = arr2.Length-1; i >=0; i--)
            //   {

            //       ints[j] =arr2[i];
            //       Console.Write(arr2[i]);
            //       j++;
            //   }




            //Write a program in C# Sharp to count the total number of words in a string.

            //Console.WriteLine("enter string");
            //string str = Console.ReadLine();

            //string[] strarr= str.Split(" ");
            //int count = 0;
            //for (int i = 0; i < strarr.Length; i++)
            //{
            //   // Console.WriteLine("strarr" + strarr[i]);
            //    count++;
            //}

            //Console.WriteLine("Total number of words in the string is :"+count);


            //80% array print
            //var list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Length " + "" + list1);

            //float percentComplete = (0.8f) * list1.Count();

            //Console.WriteLine("80% of this " + "" + Math.Round(percentComplete));
            //double jk = list1.Count() - Math.Round(percentComplete);
            //int ok = (int)jk / 2;

            //for (int i = ok; i < list1.Count() - ok; i++)
            //{
            //    Console.Write(list1[i]);
            //}



            // find array  second highest
            //Console.Write("enter array length:-");
            //int user = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[user];
            //for (int i = 0; i < user; i++)
            //{
            //    Console.Write("enter value :-");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //int highest = 0;

            //int second_highest = 0;

            //foreach (int i in arr)
            //{
            //    if (i > highest)
            //    {
            //        second_highest = highest;
            //        highest = i;
            //    }
            //    else if (i > second_highest && i < highest)
            //        second_highest = i;
            //}

            //System.Console.WriteLine("ans" + second_highest);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == second_highest)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine("sort"+item);
            //}


            //Console.Write("enter given number :-");
            //string num = Console.ReadLine();

            //char[] charArr = num.ToCharArray();
            //foreach (char ch in charArr)
            //{

            //    Console.WriteLine(ch);
            //}


            //int[] arr2 = new int[charArr.Length];
            //for (int i = 0; i < charArr.Length; i++)
            //{
            //    arr2[i] = (int)Char.GetNumericValue(charArr[i]);


            //}

            //Program.Sum(arr2);

            //int[] arr = new int[user];
            //for (int i = 0; i < user; i++)
            //{
            //    Console.Write("enter value :-");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}




            //Console.Write("enter given string :-");
            //string s1 = Console.ReadLine();

            //Console.Write("enter given string :-");
            //string s2 = Console.ReadLine();



            //if (s1.Contains(s2))
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            //Write a C# program to read a sentence and replace lowercase characters by uppercase and vice-versa

            //Console.Write("enter given number :-");
            //string upper = Console.ReadLine();

            //string newstr = "";

            //char[] charArr = upper.ToCharArray();

            //for(int i = 0; i < charArr.Length; i++) {
            //    if (Char.IsUpper(charArr[i]))
            //    {
            //       newstr +=  Char.ToLower( charArr[i]);
            //        //Console.WriteLine("upper" + upper.ToUpper());
            //    }
            //    else
            //    {
            //        newstr += Char.ToUpper(charArr[i]);
            //    }
            //}
            //    Console.WriteLine(newstr);




            //Write C# program to count total duplicate elements in an array
            //Console.Write("enter array length:-");
            //int len = Convert.ToInt32(Console.ReadLine());
            //int[] original = new int[len];
            //for (int i = 0; i < len; i++)
            //{
            //    Console.Write("enter value :-");
            //    original[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (var item in original)
            //{
            //    Console.WriteLine(item);
            //}


            //int total = 0;
            //int c = 0;

            //for (int i = 0; i < original.Length; i++)
            //{
            //    for (int j = i+1; j < original.Length; j++)
            //    {
            //        if(original[i] == original[j])
            //        {
            //            total++;
            //            break;
            //        }

            //    }


            //}
            //Console.WriteLine("total:="+ total);


            //int p1 = 65, c1 = 55, m1 = 50,total_sub=180,total_m1_p1=140;

            //Console.Write("Input thr marks obtained in physics:-");
            //int physics = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input thr marks obtained in chem:-");
            //int chem = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input thr marks obtained in Maths:-");
            //int maths = Convert.ToInt32(Console.ReadLine());

            //int total=physics+chem+maths;
            //int tot_m1_p1 = physics + maths;

            //if (p1 <= physics && c1<=chem && m1<=maths && (total_sub<=total || total_m1_p1<=tot_m1_p1))
            //{
            //    Console.WriteLine("the candidate is  eligible for  admission");
            //}
            //else
            //{
            //    Console.WriteLine("the candidate is not  eligible for  admission");
            //}









        }
    }

}







