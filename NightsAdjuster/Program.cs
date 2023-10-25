using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;

namespace NightsAdjuster
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            return await SynthesisPipeline.Instance
                .AddPatch<ISkyrimMod, ISkyrimModGetter>(RunPatch)
                .SetTypicalOpen(GameRelease.SkyrimSE, "YourPatcher.esp")
                .Run(args);
        }

        public static void RunPatch(IPatcherState<ISkyrimMod, ISkyrimModGetter> state)
        {
            //these values are multiplier of original values, set these values between 0.01 and 100 to achieve desired result
            var AmbientNight = new[] { 1, 1, 1 }; //vegetation brightness modifier, higher is brighter
            var SunlightNight = new[] { 1, 1, 1 }; //overall brightness modifier, higher is brighter
            var DALCNight = new[] { 1, 1, 1 }; //direct lighting modifier, higher is brighter




        }
    }
}
