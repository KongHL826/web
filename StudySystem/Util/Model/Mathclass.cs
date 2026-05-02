using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Model
{
    public class Mathclass
    {
        private int number1;
        public int Number1
        {
            get { return number1; }
            set { number1 = value; }
        }
        private int number2;
        public int Number2
        {
            get { return number2; }
            set { number2 = value; }
        }
        public Mathclass(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        public int Add()
        {
            return number1 + number2;
        }
        public int Minus()
        {
            return number1 - number2;
        }
        public int Times()
        {
            return number1 * number2;
        }
        public int Devide()
        {
            return number1 / number2;
        }
    }
}
