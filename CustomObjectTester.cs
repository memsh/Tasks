using UnityEngine;
namespace Task29
{
    public class CustomObjectTester : MonoBehaviour
    {
        void Start()
        {
            CustomObject obj1 = new CustomObject(1, "Safyah (●'◡'●)");
            print(obj1.ToString());

            // Optional - Uncomment to use these methods
            /*
            CustomObject obj2 = new CustomObject(1, "Example");
            print(obj1 == obj2);
            print(obj1 != obj2);
            */
        }
    }
}