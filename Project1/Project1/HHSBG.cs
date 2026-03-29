using HarmonyLib;
using System;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.Client.NoObf;

namespace Project1
{
    public class HHSBG : ModSystem
    {
        /*public void cheese(string thing)
        {
            Mod.Logger.Chat(thing);
        }
        static HHSBG nomnom;*/
       
        public override void StartClientSide(ICoreClientAPI api)
        {
            //nomnom = this;
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
                    //nomnom.cheese(name);
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
