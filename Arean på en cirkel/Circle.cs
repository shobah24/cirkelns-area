namespace Arean_på_en_cirkel
{
    internal class Circle
    {
        
        float _pi = 3.141f;
        int _Radius;

        public Circle (int Radius)
        {
            _Radius = Radius;
        }
        public float GetArea() // float för att avrunda decimalerna
        {
            return _Radius * _Radius * _pi;
           
        }
    }
}
