using System;
using System.Text;
namespace consdest{
    struct customer{
        public static int numbers(){
        int age=35;
        string name = "John Wick";
        Console.WriteLine(age);
        return 0;
        }
    }  
    
    class pract2{
        static void Main(string[] args){
            consdest.customer.numbers();
        }
    }
}

































// {
//    class pract{
//     static void Main(string[] args){
//         int a=10;
//         int b=20;
//         Console.WriteLine(a);
//         Console.WriteLine(b);

        // Addition add1 = new Addition();
        // add1.Name = 56;
        // Console.WriteLine(add1.Name);
        // consdest.Addition.add( a, b);

        // consdest.makeone.makingone();
//     }
//    }

//    class Addition{
//     private int x=30;
//     private int y =40;
//     public int Name{
//         get{return x;}
//         set{x = value;}
//     }
//     public static void add(int p,int q){
//         Console.WriteLine("call");
//         Console.WriteLine("\n"+(p+q)+" \n");
//     }
//    }

//    class makeone{
//     public static void makingone(){
//         StringBuilder addword = new StringBuilder(" I am Working in Sureprep. ");
//         addword.Append(" I am working as a Trainee Software Engineer. ");
//         addword.Append("I am currently  working on C# ");
//         Console.WriteLine(addword);
//     }
//    }
// }



    
    