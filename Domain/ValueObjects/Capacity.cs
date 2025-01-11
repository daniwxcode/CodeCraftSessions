using Domain.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Capacity : IValueObject<Capacity>
    {
        public int Value { get; private set; }
        public static Capacity Default => new Capacity(10);
        private Capacity() {
        
        }
        private Capacity(int value) => new Capacity
        {
            Value = value
        };


    }
}
