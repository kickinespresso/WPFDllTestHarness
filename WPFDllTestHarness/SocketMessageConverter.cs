using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDllTestHarness
{
    class SocketMessageConverter
    {

        public static bool validate(string message)
        {
            return true;
        }
        public static void Convert(string message)
        {
            if (!validate(message)) return;

            //var charsToRemove = new string[] { "!" };
            message = message.Replace("!", string.Empty);

            char[] delimiters = new[] { ',', ';', ' ' };
            var splittedArray = message.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            foreach (string part in splittedArray)
            {
                Console.WriteLine(part);
                char[] partDelimiters = new[] { ':' };
                var messageParts = part.Split(partDelimiters, StringSplitOptions.RemoveEmptyEntries);
                Console.Write(messageParts.First());
                Console.Write("-");
                Console.WriteLine(messageParts.Last());


            }
        }
    }
}
