using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz3
{
    public class InputInfo
    {
        public string Input(string option)
        {
            Console.Write($"Type a new {option}: ");
            string UserInput = Console.ReadLine();
            return UserInput;
        }
    }
}
