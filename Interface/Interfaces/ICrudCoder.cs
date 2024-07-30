using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interface.model;

namespace Interface.Interfaces
{
    public interface ICrudCoder<T>
    {
        public void Create(T entity);
        public void Read( );
        public void Update(T entity);
        public void Delete(int id);
    }
}