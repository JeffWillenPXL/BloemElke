using System;
using System.Collections.Generic;
using System.Text;

namespace BloemElke.Domain
{
    public class Bouquet
    {
        public string Name { get; set; }
        public IList<Flower> Flowers { get; set; }
    }
}
