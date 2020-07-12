using System;
using System.IO;

namespace LimpaTempFroms
{
    class LocalDatas
    {
        static public string Language()
        {
            return System.Globalization.CultureInfo.CurrentCulture.NativeName;
        }

        static public string TempDirectory()
        {
            return Environment.GetLogicalDrives()[0] + "\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\";
        }

        static public int QtdTempFiles()
        {
            return Directory.GetFiles(TempDirectory()).Length +
                    Directory.GetDirectories(TempDirectory()).Length;
        }
    }
}
