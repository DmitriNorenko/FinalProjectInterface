using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectInterface;
using static FinalProjectInterface.Program;

namespace FinalProjectInterface
{
    public class Calculator2 : IOperation
    {
        IOperationNum operationNum { get; }
        internal Calculator2(IOperationNum operation)
        {
            operationNum = operation;
        }
        public void OperationWithNum(int x, int y)
        {
            Console.WriteLine(operationNum.Operation(x, y));
        }
    }
    public class Calculator3 : IOperation
    {
        IOperationNum operationNum { get; }
        internal Calculator3(IOperationNum operation)
        {
            operationNum = operation;
        }
        public void OperationWithNum(int x, int y)
        {
            Console.WriteLine(operationNum.Operation(x, y));
        }
    }
    public class Calculator4 : IOperation
    {
        IOperationNum operationNum { get; }
        internal Calculator4(IOperationNum operation)
        {
            operationNum = operation;
        }
        public void OperationWithNum(int x, int y)
        {
            Console.WriteLine(operationNum.Operation(x, y));
        }
    }
}
