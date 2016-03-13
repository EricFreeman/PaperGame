using System;

namespace Assets.Scripts.Extensions
{
    public static class FloatExtensions
    {
        public static float Clamp(this float source, float min, float max)
        {
            if (source < min) return min;
            if (source > max) return max;
            return source;
        }

        public static float MoveTowards(this float source, float destination, float speed)
        {
            if (Math.Abs(source) < Math.Abs(speed))
            {
                return 0;
            }

            if (source > 0)
            {
                return source - speed;
            }

            return source + speed;
        }
    }
}