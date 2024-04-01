using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLException : Exception
    {
        public BLLException(string message) :base(message) 
        {
            
        }

        public override string ToString()
        {
            return $"BLLException: {Message}. Additional information...";
        }
    }
}
