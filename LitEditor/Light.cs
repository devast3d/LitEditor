using System;

namespace LitEditor
{
    struct Vector3
    {
        public int X;
        public int Y;
        public int Z;
    }

    class Light
    {
        public bool Enabled;
        public Vector3 Position;
        public int Unknown1;
        public int Unknown2;
        public Vector3 Color;
    }
}
