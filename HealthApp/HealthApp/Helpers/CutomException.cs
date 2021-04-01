using System;
using System.Windows.Forms;

namespace HealthApp
{
    public class CustomException : Exception
    {
        public CustomException()
        {
        }

        public CustomException(string message)
            : base(message)
        {
            MessageBox.Show(message);
        }

        public CustomException(string message, Exception inner)
            : base(message, inner)
        {
            Console.WriteLine($"{inner} Exception caught. {message}");
        }
    }
}
