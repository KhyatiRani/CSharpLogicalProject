using System.Text;

namespace LogicalPrograms
{
    class PossibleSubstring
    {
        static void Main(string[] args)
        {
           
            string inputString = "hall";
            Console.Write("All possible substring are :");
            for (int i = 0; i < inputString.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(inputString.Length - i);
                for (int j = i; j < inputString.Length; ++j)
                {
                    
                    subString.Append(inputString[j]);
                    Console.Write(subString + " ");
                }
            }
        }
    }
}
        