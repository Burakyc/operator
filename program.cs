using System;

namespace operatorler
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            //Atama ve işlemeli atama
            int x= 3;
            int y=3;
            y=y+2;
            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x +=2;
            Console.WriteLine(x);

            //mantıksal operatorler
            // || && !

            bool isSucces = true;
            bool isCompleted = false;

            if(isSucces && isCompleted)
            Console.WriteLine("Perfect");

            if(isSucces|| isCompleted)
            Console.WriteLine("Great");

            if(isSucces && !isCompleted)
            Console.WriteLine("Fine!");

            Console.WriteLine("***** ilişkisel operatorler *****");
            // ilişkisel operatorler
            // < > <= >= == !=

            int a = 3;
            int b=4 ;
            bool sonuc = a<b ;
            Console.WriteLine(sonuc);
            sonuc= a>b;
             Console.WriteLine(sonuc);
            sonuc= a>=b;
             Console.WriteLine(sonuc);
            sonuc= a<=b;
             Console.WriteLine(sonuc);
            sonuc= a==b;
             Console.WriteLine(sonuc);
            sonuc= a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("****** aritmetik operatorler ******");

            // / * + -

            int sayı1 = 10;
            int sayı2 = 5;
            int sonuc1 = sayı1/sayı2;
            Console.WriteLine(sonuc1);
            sonuc1= sayı1+sayı2;
            Console.WriteLine(sonuc1);
            sonuc1= sayı1+sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayı1 ++;
            Console.WriteLine(sonuc1);


                // % : mod alır

                int sonuc2 = 20%3;
                Console.WriteLine(sonuc2);



        }

    }
}
