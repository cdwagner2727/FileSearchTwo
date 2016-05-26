using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSearchTwo
{
    class Finder
    {
        DirectoryInfo _dir;
        long _count = 0;

        public string Find(DirectoryInfo startDir, string toFind)
        {
            _count++;
            _dir = startDir;
            try
            {
                foreach (var file in _dir.GetFiles())
                {
                    if (file.Name == toFind)
                    {
                        return file.FullName;
                    }
                }

                foreach (var dir in _dir.GetDirectories())
                {
                    _dir = dir;
                    if (Find(_dir, toFind) != "not found")
                    {
                        return Find(_dir, toFind);
                    }
                }
            }
            catch { }
            return "not found";
        }

        internal long getCount()
        {
            return _count;
        }
    }
}
