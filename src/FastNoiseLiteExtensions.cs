using System;
using Stride.Core.Mathematics;

namespace FastNoiseLite
{
    public enum GeneralFractalType
    {
        None = FractalType.None,
        FBm = FractalType.FBm,
        Ridged = FractalType.Ridged,
        PingPong = FractalType.PingPong,
    };

    public enum DomainWarpFractalType
    {
        None = FractalType.None,
        DomainWarpProgressive = FractalType.DomainWarpProgressive,
        DomainWarpIndependent = FractalType.DomainWarpIndependent
    };


    public static class FastNoiseLiteExtension
    {
        public static float GetNoise(this FastNoiseLite fnl, Vector2 xy)
        {
            float x = xy.X;
            float y = xy.Y;

            return fnl.GetNoise(x, y);
        }

        public static float GetNoise(this FastNoiseLite fnl, Vector3 xyz)
        {
            float x = xyz.X;
            float y = xyz.Y;
            float z = xyz.Z;

            return fnl.GetNoise(x, y, z);
        }


        public static Vector2 DomainWarp(this FastNoiseLite fnl, Vector2 xy)
        {
            fnl.DomainWarp(ref xy.X, ref xy.Y);

            return xy;
        }


        public static Vector3 DomainWarp(this FastNoiseLite fnl, Vector3 xyz)
        {
            fnl.DomainWarp(ref xyz.X, ref xyz.Y, ref xyz.Z);

            return xyz;
        }
    }

}
