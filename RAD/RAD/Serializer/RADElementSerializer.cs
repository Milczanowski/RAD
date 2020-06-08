using System;


namespace RAD.Serializer
{
    [Serializable]
    class RADElementSerializer
    {
        public RADElementType radType;
        public string jsonValue;

        public RADElementSerializer()
        {
        }

        public RADElementSerializer(RADElementType radType, string jsonValue)
        {
            this.radType = radType;
            this.jsonValue = jsonValue;
        }
    }
}
