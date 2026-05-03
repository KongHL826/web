// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using Util.Model;


Console.WriteLine("Hello, World!");

Console.WriteLine("请输入学生的学号");
string number = Console.ReadLine();
Console.WriteLine("请输入学生的姓名");
string name = Console.ReadLine();
Console.WriteLine("请输入学生的年龄");
string age = Console.ReadLine();
Console.WriteLine("请输入学生的语文成绩");
string chinesegrade = Console.ReadLine();
Console.WriteLine("请输入学生的数学成绩");
string mathgrade = Console.ReadLine();
Console.WriteLine("请输入学生的英语成绩");
string engliashgrade = Console.ReadLine();
int sage = int.Parse(age);
int schinesegrade = int.Parse(chinesegrade);
int smathgrade = int.Parse(mathgrade);
int senglishgrade = int.Parse(engliashgrade);



Student student1 = new Student(number, name, sage, schinesegrade, smathgrade, senglishgrade);

string studentInformation = student1.Chengji();

Console.WriteLine("stduent information is: " + studentInformation);

int grade = student1.Study();
Console.WriteLine("学生的平均成绩是"+grade);
bool pingjun = student1.Jige();
 //bool Jige()

//bool pingjunchengji = student1.Jige();
Console.WriteLine("学生的成绩及格"+pingjun);
Console.WriteLine("学生的成绩不及格"+!pingjun);




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

