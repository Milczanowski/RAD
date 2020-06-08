using System;

namespace RAD.Elements.Serializer
{
    [Serializable]
    public class BaseSerialzier
    {
        public int positionX, positionY, width, height;

        public BaseSerialzier()
        {

        }

        public BaseSerialzier(int positionX, int positionY, int width, int height)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.width = width;
            this.height = height;
        }
    }
}
