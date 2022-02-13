using System;


namespace UmodelHelper
{
    public class Juego : IEquatable<Juego>
    {
        //Info of game
        private string name;
        private string exePath;
        private string pakFolderPath;
        private string ueVersion;
        private string aesKey;
        private string version;
        private string customArgs;


        //Public variables
        public string Name { get { return name; } set { name = value; } }
        public string ExePath { get { return exePath; } set { exePath = value; } }
        public string PakFolderPath { get { return pakFolderPath; } set { pakFolderPath = value; } }
        public string UEVersion { get { return ueVersion; } set { ueVersion = value; } }
        public string AESKey { get { return aesKey; } set { aesKey = value; } }
        public string Version { get { return version; } set { version = value; } }
        public string CustomArgs { get { return customArgs; } set { customArgs = value; } }
        //Constructor
        public Juego(string naame = null, string exe = null, string pakfolder = null, string ueversion = null, string keys = null,string customA = null)
        {
          name = naame;
          exePath = exe;
          pakFolderPath = pakfolder;
          ueVersion = ueversion;
          aesKey = keys;
          version = "-1";
          customArgs = customA;
        }
        //Copia
        public Juego(Juego other)
        {
            name = other.Name;
            exePath = other.ExePath;
            pakFolderPath = other.PakFolderPath;
            ueVersion = other.UEVersion;
            aesKey = other.AESKey;
            customArgs=other.CustomArgs;
        }

        public override string ToString()
        {
            return Name;
        }

        public string SaveString()
        {
            return Name + ";" + ExePath + ";" + PakFolderPath + ";" + UEVersion + ";" + AESKey + ";" + CustomArgs;
        }

        public bool Equals(Juego other)
        {
            return other.Name.Equals(Name);
        }
    }
}
