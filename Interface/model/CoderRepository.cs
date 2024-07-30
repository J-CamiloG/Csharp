using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interface.Interfaces;

namespace Interface.model
{
    public class CoderRepository : Coder, ICrudCoder<Coder>
    {
        public readonly List<Coder> coders = new List<Coder>();



        public void Create(Coder entity)
        {
            coders.Add(entity);
        }
        public void Read()
        {
            foreach (var i in coders )
            {
                Console.WriteLine($"{i.Nombre}");
            }
        }
        public void Update(Coder entity)
        {
            Console.WriteLine("aca se edita");
        }
        public void Delete(int id)
        {
            Console.WriteLine("aca se elimina");
        }

    }
}