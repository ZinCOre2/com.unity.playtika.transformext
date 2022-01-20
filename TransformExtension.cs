using UnityEngine;

namespace Playtika
{
    
    public static class TransformExtension
    {
        public static void SetPosX(this Transform t, float x)
        {
            Vector3 newPos = new Vector3(x, t.position.y, t.position.z);
            t.position = newPos;
        }

        public static void SetPosY(this Transform t, float y)
        {
            Vector3 newPos = new Vector3(t.position.x, y, t.position.z);
            t.position = newPos;
        }

        public static void AddPosX(this Transform t, float x)
        {
            t.position += Vector3.right * x;
        }

        public static void AddPosY(this Transform t, float y)
        {
            t.position += Vector3.up * y;
        }
    }

}