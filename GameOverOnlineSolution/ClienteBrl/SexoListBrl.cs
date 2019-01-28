using Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteBrl
{
    public class SexoListBrl
    {
        public static SexoList Get()
        {
            return ClienteDal.SexoListDal.Get();
        }
    }
}
