using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StateMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter run parameters: ");
            string runParams = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("You entered: {0}", runParams);
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}