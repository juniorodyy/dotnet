using System;

namespace console_dotnet
{
    class Humano 
    {
        public int randomicos(int min, int max)
        {
          Random random = new Random();
          return random.Next(min, max);   
        }
    }
}