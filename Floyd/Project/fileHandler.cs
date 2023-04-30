using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class fileHandler
    {
        static public string[] fileOpen(string filePath)
        {
            StreamReader file;
            var array = Array.Empty<string>();
            if (errorHandler(filePath) != 0) { return array; }
            
            try
            {
                file = new StreamReader(filePath);
                array = fileReader(file);
            }
            catch (Exception)
            {
                return Array.Empty<string>();
            }
            file.Close();
            return array;
        }

        static private int errorHandler(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return 2;
            }
            return 0;
        }
        static private string[] fileReader(StreamReader file)
        {
            var fileContent = new List<string>();
            string fileLine;
            while (true)
            {
                try
                {
                    string line;
                    line = file.ReadLine();
                    if (line != null)
                    {
                        fileContent.Add(line);
                        continue;
                    }
                    break;
                }
                catch (Exception)
                {
                    break;
                }
            }
            if (fileContent.Count == 0)
            {
                return null;
            }

            return convertListToArray(fileContent);
        }

        static private string[] convertListToArray(List<string> fileContent)
        {
            var lines = new string[fileContent.Count];
            for (int i = 0; i < fileContent.Count; i++)
            {
                lines[i] = fileContent[i];
            }
            return lines;
        }

        static public void fileRecorder(string filePath, string[] result)
        {
            using (StreamWriter sw = File.CreateText(filePath))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    sw.WriteLine(result[i]);
                }
            }
        }

    }
}
