using System;
using System.Collections.Generic;
using System.Text;

namespace DoorsLocksKeys.Locks
{
    public class MortiseLock
    {
        public void InsertKey()
        {
            Console.WriteLine("Key is inserted into the lock");
        }

        public void RotateKey()
        {
            Console.WriteLine("Key is rotated in the lock");
            Console.WriteLine("Door is opened");
        }
    }
}
