﻿using System.IO;

namespace SoundGenerator
{
    class Preset
    {
        public string Name { get; private set; }
        public string FullName { get; private set; }

        public Preset(string path)
        {
            FullName = path;
            Name = Path.GetFileNameWithoutExtension(path);
        }
    }
}
