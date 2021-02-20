using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01
{
    class Pensao
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public Pensao(string nome, string email)
        {
            Name = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
