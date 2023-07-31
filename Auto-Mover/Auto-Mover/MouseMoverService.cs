using System.Runtime.InteropServices;

namespace Auto_Mover
{
    internal class MouseMoverService
    {
        private const int Distance = 15;
        private int _direction = 1;

        /// <returns>1 if success, 0 if failure</returns>
        [DllImport("User32.Dll")]
        public static extern int GetCursorPos(ref PointWrap point);
        
        [DllImport("User32.Dll")]
        public static extern int SetCursorPos(int x, int y);

        public void MoveMouse()
        {
            var position = new PointWrap();
            GetCursorPos(ref position);
            SetCursorPos(position.X + Distance * _direction, position.Y + Distance * _direction);
            _direction *= -1;
        }
    }
}
