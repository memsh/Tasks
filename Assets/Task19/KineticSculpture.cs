using UnityEngine;
namespace Task19
{
    using UnityEngine;

    public class KineticSculpture : MonoBehaviour
    {
        public float amplitude = 1.0f; // The distance from the starting position
        public float speed = 1.0f;     // The speed of the oscillation

        private Vector3 startPosition;

        void Start()
        {
            startPosition = transform.position;
        }

        void Update()
        {
            // Calculate the new position using sine wave for smooth oscillation
            float x = startPosition.x + Mathf.Sin(Time.time * speed) * amplitude;
            float y = startPosition.y + Mathf.Cos(Time.time * speed) * amplitude; // Optional: add vertical movement
            float z = startPosition.z;

            transform.position = new Vector3(x, y, z);
        }
    }

}