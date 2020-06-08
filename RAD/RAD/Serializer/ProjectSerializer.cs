using System.Collections.Generic;

namespace RAD.Serializer
{
    class ProjectSerializer
    {
        public List<RADElementSerializer> radElements;

        public ProjectSerializer()
        {
            radElements = new List<RADElementSerializer>();
        }
    }
}
