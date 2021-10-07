using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInLib.Model
{
    interface ILoadFromFile
    {
        void FromFile(System.IO.StreamReader streamReader);
    }
}
