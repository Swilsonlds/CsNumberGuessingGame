using System;

namespace numberGuessingGame.classes
{
    public class randomNumberGenerator
    {
        public int Draw(){
            Random rnd = new Random();
            return rnd.Next(101);
        }
    }
}
