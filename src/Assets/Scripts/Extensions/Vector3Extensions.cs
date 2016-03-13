using UnityEngine;

namespace Assets.Scripts.Extensions
{
    public static class Vector3Extensions
    {
        public static Vector3 MoveTowards(this Vector3 source, Vector3 destination, float speed)
        {
            return Vector3.MoveTowards(source, destination, speed);
        }
    }
}
