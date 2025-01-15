using UnityEngine;
namespace Task29
{
    public class CustomObject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public CustomObject(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Object [ID: {ID}, Name: {Name}]";
        }

        // Optional - Uncomment to use these methods
        /*
        public override bool Equals(object obj)
        {
            if (obj is CustomObject customObj)
            {
                return this.ID == customObj.ID && this.Name == customObj.Name;
            }
            return false;
        }

        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {
            if (ReferenceEquals(obj1, null) || ReferenceEquals(obj2, null))
            {
                return ReferenceEquals(obj1, obj2);
            }
            return obj1.Equals(obj2);
        }

        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            return !(obj1 == obj2);
        }
        */
    }
}
