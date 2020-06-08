namespace RAD.Elements.Serializer
{
    public class CheckBoxSerializer: LabelSerializer
    {
        public bool isChecked;

        public CheckBoxSerializer()
        {
        }

        public CheckBoxSerializer(bool isChecked,  string label, int positionX, int positionY, int width, int height) : base(label, positionX, positionY, width, height)
        {
            this.isChecked = isChecked;
        }
    }
}
