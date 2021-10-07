using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInLib.Model
{
    public class Book : ILoadFromFile
    {
        public string caption;
        public string author;
        public int year;

        public int currentOwner;

        public int unicID;

        public void FromFile(StreamReader streamReader)
        {
            caption = streamReader.ReadLine();
            author = streamReader.ReadLine();

            unicID = int.Parse(streamReader.ReadLine());
            currentOwner = int.Parse(streamReader.ReadLine());

        }

        public void ToFile(StreamWriter streamWriter)
        {
            streamWriter.WriteLine(caption);
            streamWriter.WriteLine(author);

            streamWriter.WriteLine(unicID);
            streamWriter.WriteLine(currentOwner);
        }
    }
}
