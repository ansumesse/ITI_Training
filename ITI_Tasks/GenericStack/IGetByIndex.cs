using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    internal interface IGetByIndex<T>
    {
        public T GetByIndex(int index);
    }
}
