using DoorsLocksKeys.Interfaces;
using System;

namespace DoorsLocksKeys.Locks
{
    public class CodeLock : ICodeLock
    {
        public void EnterCode()
        {
            Console.WriteLine("Code is entered into the lock");
            Console.WriteLine("Door is opened");
        }
    }
}
