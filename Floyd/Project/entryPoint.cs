using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Floyd;

namespace Project
{
    partial class entryPoint
    {
        private string filePathInp;
        private string filePathOut;
        private string[] fileContent;
        private ProgressBar pgValue;
        public entryPoint(string filePathInp, string filePathOut, ref ProgressBar pgValue )
        {
            this.filePathInp = filePathInp;
            this.filePathOut = filePathOut;
            this.pgValue= pgValue;
        }

        public int start()
        {
            fileContent = fileHandler.fileOpen(filePathInp);

            Thread.Sleep(50);
            pgValue.Value++;
            
            if (fileContent == null)
            {
                return 1;
            }
            if (fileContent.Length == 0)
            {
                return 2;
            }
             
            fileContent = Class1.Floyd(fileContent);

            Thread.Sleep(50);
            pgValue.Value++;

            fileHandler.fileRecorder(filePathOut, fileContent);

            Thread.Sleep(50);
            pgValue.Value++;
            return 0;
        }
    }
}
