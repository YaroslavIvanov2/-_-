using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronirovanie_Diplom.DB
{
    public class DataBase
    {
        private static Entities2 _context;
        public static Entities2 GetContext()
        {
            if (_context == null)
                _context = new Entities2();
            return _context;
        }
    }
}
