using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    //class Vector
    //{
    //    static public int Count = 0;

    //    double x;
    //    double y;
    //    double z;

    //    double x1;
    //    double y1;
    //    double z1;

    //    double x2;
    //    double y2;
    //    double z2;


    //    public Vector(double x, double y, double z)
    //    {
    //        Count++;
    //        this.x = x;
    //        this.y = y;
    //        this.z = z;

    //        this.x1 = x;
    //        this.y1 = y;
    //        this.z1 = z;

    //        this.x2 = x1;
    //        this.y2 = y1;
    //        this.z2 = z1;
    //    }

    //    public Vector(Vector v)
    //    {
    //        new Vector(v.x1, v.y1, v.z1);
    //        new Vector(v.x2, v.y2, v.z2);
    //    }
    //    public double Length()
    //    {
    //        return Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1);
    //    }
    //    public double Angle()
    //    {
    //        return Math.Acos((this.x1 * this.x2 + this.y1 * this.y2 + this.z1 * this.z2) / (Math.Sqrt(this.x1 * this.x1 + this.y1 * this.y1 + this.z1 * this.z1)));
    //    }
    //    public double additionX()
    //    {
    //        return this.x = this.x1 + this.x2;
    //    }
    //    public double additionY()
    //    {      
    //        return this.y = this.y1 + this.y2;
    //    }
    //    public double additionZ()
    //    {
    //        return this.z = this.z1 + this.z2;
    //    }
    //    public double subtractionX()
    //    {
    //        return this.x = this.x1 - this.x2;
    //    }
    //    public double subtractionY()
    //    {     
    //        return this.y = this.y1 - this.y2;
    //    }
    //    public double subtractionZ()
    //    {       
    //        return this.z = this.z1 - this.z2;
    //    }
    //    public double imul()
    //    {
    //        return (this.x1 * this.x2) + (this.y1 * this.y2) + (this.z1 * this.z2);
    //    }
    //    public double imulint()
    //    {
    //        return x * y * z;
    //    }
    //    public double divInt()
    //    {
    //        return x / y / z;
    //    }

    //}
    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine(Vector.Count);
    //        var v = new Vector(1, 4, 5);
    //        var w = new Vector(1, 2, 4);

    //        var v2 = new Vector(v);
    //        Console.WriteLine("|v|= {0} ", v.Length());
    //        Console.WriteLine("|v|= {0} ", w.Length());
    //        Console.WriteLine("Угол вектор равен {0}", v.Angle());
    //        Console.WriteLine("Угол вектор равен {0}", w.Angle());
    //        Console.WriteLine("скалярного умножения вектора на вектор ={0}", v.imul());
    //        Console.WriteLine("скалярного умножения вектора на вектор ={0}", w.imul());
    //    }
    //}

    //class Number
    //{

    //    public string a;
    //    private string a1;
    //    bool temp = true;
    //    public int S1, i;

    //    public Number(string a)
    //    {
    //        a = a1;
    //    }

    //    public string Show(string a)
    //    {
    //        string fr;
    //        fr = "";
    //        for (int i = 0; i < a1.Length; i++)
    //        {
    //            string str = "";
    //            if (temp)
    //            {
    //                List<int> ost = new List<int>();
    //                S1 += Convert.ToInt32(perevod(a1[i]) * Math.Pow(12, a1.Length - (i + 1)));
    //                while (S1 % 10 >= 0 || S1 > 10)
    //                {
    //                    ost.Add(S1 % 10);
    //                    S1 = S1 / 10;
    //                    if (S1 / 10 == 0)
    //                    {
    //                        ost.Add(S1);
    //                        break;
    //                    }
    //                }
    //                for (i = ost.Count - 1; i >= 0; i--)
    //                {
    //                    str += ost[i];
    //                }
    //                return str;
    //            }
    //            else
    //            {
    //                return str;
    //            }
    //        }
    //        return fr;

    //    }

    //    int perevod(char str)
    //    {
    //        switch (str)
    //        {
    //            case '0':
    //                return 0;
    //            case '1':
    //                return 1;
    //            case '2':
    //                return 2;
    //            case '3':
    //                return 3;
    //            case '4':
    //                return 4;
    //            case '5':
    //                return 5;
    //            case '6':
    //                return 6;
    //            case '7':
    //                return 7;
    //            case '8':
    //                return 8;
    //            case '9':
    //                return 9;
    //            case 'a':
    //            case 'A':
    //                return 10;
    //            case 'b':
    //            case 'B':
    //                return 11;
    //            case 'c':
    //            case 'C':
    //                return 11;
    //            default:
    //                temp = false;
    //                return 0;
    //        }
    //    }

    //}
    //class Program
    //{
    //    public static bool Show { get; private set; }

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Введите чило в тринадцатеричной системе счисления");
    //        string a = Console.ReadLine();
    //        Number test = new Number(a);
    //        Console.WriteLine(a);
    //        Console.WriteLine(Show);

    //        Console.ReadKey();
    //    }
    //}


}
