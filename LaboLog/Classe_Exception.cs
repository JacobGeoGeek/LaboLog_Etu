using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboLog
{
   public class AnimalException : Exception
    {
       public AnimalException(string message) :base(message)
        {

        }
  
    }
    public class FelideException: Exception
    {
        public FelideException(string message): base(message)
        {

        }
    }
    public class ChatException : Exception
    {
        public ChatException(string message): base(message)
        {

        }
    }
    public class CanideException : Exception
    {
        public CanideException(string message): base(message)
        {

        }
    }
    public class ChienException : Exception
    {
        public ChienException(string message): base(message)
        {

        }
    }
}
