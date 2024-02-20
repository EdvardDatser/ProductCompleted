using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tooded
{
        public class ToodeItems
        {
            public string Nimetus { get; set; }
            public int Kogus { get; set; }
            public decimal Hind { get; set; }

            public ToodeItems(string nimetus, int kogus, decimal hind)
            {
                Nimetus = nimetus;
                Kogus = kogus;
                Hind = hind;
            }

            public override string ToString()
            {
                return $"{Nimetus} {Kogus} {Hind} {Kogus * Hind}";
            }
        }
}
