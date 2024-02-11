//1) n - ededinin faktorialini hesablayin.


//int n = 8;
//int multiply = 1;

//if (n != 0 && n != 1)
//{
//    for (int i = n; i >= 1; i--)
//    {
//        multiply *= i;
//    }
//}

//Console.WriteLine(multiply);


//2) Verilmis arrayin icerisinde cut ededlerin ceminin kvadratini hesablayin.


//int[] arr = { 6, 5, 14, 3, 20 };
//int sum = 0;
//int square = 1;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        sum += arr[i];
//    }
//}
//square = sum * sum;

//Console.WriteLine(square);


//3) n ededi gelir. n - ededinin 2-ni hansisa quvvete yukseltdikde alinan edede beraber olub-olmadigini tapin. Meselen : n ededi 4,8,16 ve s. gelirse yazilsin ki, 2-nin quvettidir. Eks halda quvveti deil yazilsin.


//int n = 64;

//for (int i = n; i >= 2; i=i/2)
//{
//    if (i%2==0)
//    {
//        if (i/2==1)
//        {
//            Console.WriteLine("2-nin qüvvət üstüdür");
//            break;
//        }
//    }
//    else
//    {
//        Console.WriteLine("2-nin qüvvət üstü deyil");
//        break;
//    }
//}



//TASKSATCLASS

//int[] arr = {2,4,78,3,45,3,6 };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i]==3)
//    {
//        Console.WriteLine("3 reqemi movcuddur");
//        break;
//    }
//}

//int[] arr = { 2, 4, 2, 78, 3, 45, 3, 6 };
//int count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i]==2)
//    {
//        count++;

//        if (count==2)
//        {
//            Console.WriteLine("minimum 2 defe tapildi");
//            break;
//        }
//    }
//}




//int n = 6;

//int count = 0;

//if (n<2)
//{
//    Console.WriteLine("Something Went Wrong");
//}
//else
//{
//    for (int i = 1; i <= n; i++)
//    {
//        if (n%i==0)
//        {
//            count++;

//            if (count==3)
//            {
//                break;
//            }
//        }
//    }

//    if (count==2)
//    {
//        Console.WriteLine("Sade");
//    }
//    else
//    {
//        Console.WriteLine("murekkeb");
//    }
//}


//int a = 5;
//int b = a;
//b = 100;

//Console.WriteLine(a);
//Console.WriteLine(b);

//int[] arr1 = {1,2,3,4 };
//int[] arr2 = arr1;
//arr2[0] = 200;


//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);

//string name1 = "test";
//string name2 = name1;

//name2 = "Salam";

//Console.WriteLine(name1);
//Console.WriteLine(name2);

//int[] arr = {1,2,3,4,5 };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i]==2)
//    {
//        continue;
//    }

//    if (arr[i]==4)
//    {
//        break;
//    }

//    Console.WriteLine(arr[i]);
//}

//int a = 15;
//int b = --a;
//int c = ++b;
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);