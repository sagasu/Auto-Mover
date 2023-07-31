using System.Runtime.InteropServices;

namespace Auto_Mover
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PointWrap
    {
        public int X;
        public int Y;

        public static implicit operator Point(PointWrap point)
        {
            return new Point(point.X, point.Y);
        }
    }

}
