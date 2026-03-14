using HarmonyLib;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;
using Vintagestory.Client.NoObf;
using Vintagestory.GameContent.Mechanics;

namespace Project1
{
    public class HHSBG : ModSystem
    {

        public override void StartClientSide(ICoreClientAPI api)
        {
            try
            {
                var harmony = new Harmony(Mod.Info.ModID);
                harmony.PatchAll();
            }
            catch (System.Exception ex)
            {
            }
        }
        [HarmonyPatch(typeof(ClientMain), nameof(ClientMain.PlaySoundAt), new Type[] {typeof(AssetLocation), typeof(double), typeof(double), typeof(double), typeof(IPlayer), typeof(Single), typeof(Single), typeof(Single)})]
        public static class patch0
        {
            public static bool Prefix(AssetLocation location)
            {
                try
                {
                    string name = (new System.Diagnostics.StackTrace()).GetFrame(2).GetMethod().Name;
                    if (name == "get_Angle")
                    {
                        return false;
                    }
                }
                catch (System.Exception e)
                {
                }
                return true;

            }
        }
    }
}
