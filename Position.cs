using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCSharpBTLINQ2
{
    class Position
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Position> getPositions()
        {
            return new List<Position>()
            {
                new Position { ID = 1, Name = "Truong phong" },
                new Position { ID = 2, Name = "Truong ban" },
                new Position { ID = 3, Name = "Nhan vien" }
            };
        }
    }
}
