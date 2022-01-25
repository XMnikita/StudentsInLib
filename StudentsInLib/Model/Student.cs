using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInLib.Model
{
    public class Student : ILoadFromFile
    {
        public string name;
        public string surname;
        public string thirdname;
        public string groupNumber;

        public int unicID;

        public void FromFile(StreamReader streamReader)
        {
            var line = streamReader.ReadLine().Split();
            name = line[0];
            surname = line[1];
            thirdname = line[2];
            groupNumber = line[3];
            unicID = int.Parse(line[4]);


        }

        public void ToFile(StreamWriter streamWriter)
        {
            var line = $"{name} {surname} {thirdname} {groupNumber} {unicID}";
            streamWriter.WriteLine(line);
        }
    }
}
