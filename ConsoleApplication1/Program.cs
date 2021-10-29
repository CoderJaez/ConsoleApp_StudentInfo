using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.ViewModel;

namespace ConsoleApplication1
{
    class Program
    {
        private static StudentViewModel viewModel;
        static void Main(string[] args)
        {
            viewModel = new StudentViewModel();
            viewModel.DisplayMenu();
            Console.ReadKey();   
        }
    }
}
