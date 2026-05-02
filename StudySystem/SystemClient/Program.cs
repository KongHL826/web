// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using Util.Model;

Console.WriteLine("Hello, World!");



int number = 12;
long largeNumber = 13;
float abc = 12;
double abcd = 0.34;
string abcddd = "this is dfsdfoex";
bool tt = true;
char c = '1';
int a = 1;

String aaa = new String("sssssss");
Book book = new Book();
Book book1 = new Book("AAA");
Book bookA = new Book("Study", true, 50);

string result = bookA.BookDetail();

Console.ReadLine();



Mathclass mathclass1 = new Mathclass(10, 3);
//result = mathclass1.Jian();
//Console.WriteLine(mathclass1.Add);
Console.WriteLine(mathclass1.Add());
Console.WriteLine(mathclass1.Minus());
Console.WriteLine(mathclass1.Times());
Console.WriteLine(mathclass1.Devide());
