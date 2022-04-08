using System;
using System.Collections.Generic;
using System.Text;


namespace Models
{
    public class Alphabet
    {
        public Alphabet(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        private char[] letter = new char[100];

        public char this[int index]{
            get=>letter[index];
            set{
                letter[index] = value;
            } 
}
    }
}
