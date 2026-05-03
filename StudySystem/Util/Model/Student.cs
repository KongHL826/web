using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Model
{
    public class Student
    {
        private string nmuber;
        public string Nmuber
        {
            get { return nmuber; }
            set { nmuber = value; }
        }
        private string name;    
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;    
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int chinesegrade;
        public int Chinesegrade
        {
            get { return chinesegrade; }
            set { chinesegrade = value; }
        }
        private int mathgrade;
        public int Mathgrade
        {
            get { return mathgrade; }
            set { mathgrade = value; }
        }
        private int englishgrade;
        public int Englishgrade
        {
            get { return englishgrade; }
            set { englishgrade = value; }
        }
        public Student(string nmuber, string name, int age, int chinesegrade, int mathgrade, int englishgrade)
        {
            this.nmuber = nmuber;
            this.name = name;
            this.age = age;
            this.chinesegrade = chinesegrade;
            this.mathgrade = mathgrade;
            this.englishgrade = englishgrade;
        }
        public int Study()
        {
            return (chinesegrade + mathgrade + englishgrade) / 3; 
        }
        public bool Jige()
        {
            return  Study() >= 60;
        }
        public string Chengji()
        {
            return "该学生的学号是" + nmuber + "该学生的姓名是" + name + "该学生的年龄是" + age + "该学生的语文成绩是" + chinesegrade + "该学生的数学成绩是" + mathgrade + "该学生的英语成绩是" + englishgrade;
        }
    }

}
