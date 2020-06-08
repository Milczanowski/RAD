using System;

namespace RAD.Elements.Serializer
{
    [Serializable]
    public class LabelSerializer: BaseSerialzier
    {
        public string label;
        public int fontSize;

        public LabelSerializer()
        {
        }

        public LabelSerializer(string label, int positionX, int positionY, int width, int height) :base(positionX, positionY, width, height)
        {
            this.label = label;
        }

        public LabelSerializer(string label, int fontSize, int positionX, int positionY, int width, int height) : base(positionX, positionY, width, height)
        {
            this.label = label;
            this.fontSize = fontSize;
        }
    }
}
