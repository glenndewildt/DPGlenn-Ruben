using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaireRekenmachine.Input
{
    class CircuitInputReader
    {
        public string ReadInputFile(String textFile) {

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(textFile))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                    return line;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return "";

        }
    }
}
