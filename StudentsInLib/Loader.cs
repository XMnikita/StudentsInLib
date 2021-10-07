using System;
using System.Collections.Generic;
using System.IO;
using StudentsInLib.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInLib
{
    class Loader
    {
        public static T[] LoadFromFile<T>(string filename) where T : ILoadFromFile, new()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filename))
                {
                    int recordsCount = int.Parse(streamReader.ReadLine());
                    T[] students = new T[recordsCount];

                    for (int i = 0; i < recordsCount; i++)
                    {
                        students[i] = new T();
                        students[i].FromFile(streamReader);
                    }

                    return students;
                }
            }
            catch (Exception)
            {

            }

            return null;
        }

    }
}
