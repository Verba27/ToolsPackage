using UnityEngine;

namespace Playtica
{
    public static class ToolsPackage
    {
        public static void AddXPosition(this Transform t, float x)
        {
            t.position += new Vector3(x, 0, 0);
        }
    }
}

