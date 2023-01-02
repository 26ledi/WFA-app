using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9WinFormApp
{
    public class ForException:Exception
    {
        public ForException(string message) : base(message){ }
        
    }
}
