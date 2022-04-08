using System;
using Models;
namespace IndexerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Alphabet english = new Alphabet("english");
            english[0] = 'a';
            english[1] = 'v';
        }
    }
}
