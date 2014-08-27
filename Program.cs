using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HomeworkDay2
{
    class Program
    {
        //http://msdn.microsoft.com/en-us/library/aa287548(v=vs.71).aspx
        static void Main(string[] args)
        {
            string message = "";
            StreamReader myReader = new StreamReader("DecodeThis.txt");

            StreamWriter myWriter = new StreamWriter("WriteThis.txt");

            Console.WriteLine("Started ...");

            while (message != null)
            {
                message = myReader.ReadLine();
                if (message != null)
                {
                    char[] charArray = message.ToCharArray();
                    Array.Reverse(charArray);
                    //Console.WriteLine(charArray);
                    myWriter.WriteLine(charArray);

                }
            }

            myReader.Close();
            myWriter.Close();

            Console.WriteLine("... Finished!");

            Console.ReadLine(); 
        }
    }
}
