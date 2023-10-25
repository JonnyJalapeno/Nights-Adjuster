using Mutagen.Bethesda.WPF.Reflection.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightsAdjuster
{
    public class PatcherConfig
    {
        [Tooltip("Ambient RGB values multiplier")]
        public double ambient = 1.0;

        [Tooltip("Sunlight RGB values multiplier")]
        public double sunlight = 1.0;

        [Tooltip("DALC RGB values multiplier")]
        public double dalc = 1.0;
    }
}
