using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Classes
    {
        public List<Class> classList = new()
        {
            new Class() { Id = 1, ClassName = "A1" },
            new Class() { Id = 2, ClassName = "B2" },
        };
    }
}
