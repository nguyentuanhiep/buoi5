using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
        //   Console.WriteLine("Nhap ten hoc sinh: ");
        //   string name = Console.ReadLine();
        //   Console.WriteLine("Nhap tuoi:");
        //   int age = Convert.ToInt32(Console.ReadLine());
          
        //   double a;
        //   double b;
        //   double c;
        //   double d;
        //   double f;

        //   Console.WriteLine("Nhap diem mon Toan");
        //   a = Convert.ToDouble(Console.ReadLine());
        //   Console.WriteLine("Nhap diem mon Van");
        //   b = Convert.ToDouble(Console.ReadLine());
        //   Console.WriteLine("Nhap diem mon Anh");
        //   c = Convert.ToDouble(Console.ReadLine());

        //   d = (a+b+c)/3;
        //   f = Math.Round(d,2);

        //   Console.WriteLine("Hoc sinh - {0}, {1} - Tuoi, Diem trung binh - {2}, Lam tron - {3}", name,age,d,f);

            
    // Hoan doi gia tri//

            // Console.WriteLine("Nhap a");
            // int a = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Nhap b");
            // int b = Convert.ToInt32(Console.ReadLine());

            // int temp =a;
            // a = b;
            // b = temp;

            // Console.WriteLine("gia tri cua a la - {0}", a);
            // Console.WriteLine("gia tri cua b la - {0}", b);


    // Chuyen doi 1 so nguyen sang dang nhi phan//
                // Console.WriteLine("Nhap 1 so nguyen duong");
                // int input = Convert.ToInt32(Console.ReadLine());
                // //int b = a;
                // int i = 1;
                // int c = 0;
                // int j;
                // for (j = input; j > 0; j = j/2)
                // {
                //     c = c + (input % 2)*i;
                //     i = i*10;
                //     input = input/2;
                // }
                // Console.WriteLine("He nhi phan cua so {0} la {1}", input, c);
                // // 10/2 -0
                // // 5/2 - 1
                // // 2/2 - 0
                // // 1/2 - 1
                // // 1010

        
        
        // Bai tap buoi 2

            // bai 1
                // Console.WriteLine("Nhap vao 1 chuoi");
                // string str1, str2="";
                // int i;

                // str1 = Console.ReadLine();
                // for (i = str1.Length - 1; i >= 0; i--)
                // {
                //     str2 = str2 + str1[i];
                // }
                // Console.WriteLine("Chuoi dao nguoc cua chuoi {0} la: {1} ", str1, str2);


            // bai 2
                // Console.WriteLine("Nhap vao mot chuoi");
                // int i = 0;
                // string str = Console.ReadLine();
                // foreach (char c in str) {
                //     i++;
                // }
                // Console.WriteLine("Do dai cua chuoi la {0}", i);
                


            // bai 3
                // Console.WriteLine("Nhap vao mot so");
                // int a, b, c = Convert.ToInt32(Console.ReadLine());
                // string tamgiac = "*";
                // for (a = 0; a <= c; a++) {
                //     for (b=0 ; b < a; b++){
                //         Console.Write(tamgiac);
                //     }
                //     Console.WriteLine();
                // } 


            //bai 4
                // Console.WriteLine("Nhap vao mot chuoi");
                // string str1 = Console.ReadLine();
                // string str2 = "";
                // int i;
                // for (i= str1.Length-1; i>=0; i--)
                // {
                //     str2 = str2 + str1[i];
                // }
                // if (str2 == str1) {
                //     Console.WriteLine("giong nhau");
                // } else {
                //     Console.WriteLine("khac nhau");
                // }

            
            //bai 5    
                // int i;
                // for (i=1; i<=100; i++)
                // {
                //    if (i%3==0 && i%5==0) {
                //        Console.Write("FIZZ_BUZZ" + " ");
                //    } else if (i%3==0 || i%5==0) {
                //         if (i%3==0) {
                //             Console.Write("FIZZ" + " ");
                //         }
                //         if (i%5==0) {
                //             Console.Write("BUZZ" + " ");
                //         }
                //    } else {
                //         Console.Write(i + " ");
                //    }
                // }
               
            
            //Bai tap them cua a Cuong
                string le = " ";
                string chan = " ";
                
                for (int i=1; i<=100;  i++) {
                    if(i%2==0){
                        chan += i + " ";
                    }
                }
                for (int k=1; k<=100; k++) {
                   if (k%2==1){
                        le += k + " ";
                   }
                }
                Console.WriteLine(chan + " " + " " + " " + le);
        }
    }
}
