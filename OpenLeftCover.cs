using UnityEngine;

namespace Task25
{
    public class OpenLeftCover : MonoBehaviour
    {
        public Transform leftCoverPivot; // Reference to the empty object at the edge
        public Transform leftCover; // Reference to the actual left cover

        public float openAngle = -120.0f; // Angle to open the cover (negative for left side)
        public float openDuration = 1.0f; // Duration for opening

        private bool isCoverOpen = false;

        void Start()
        {
            // Ensure the leftCover is a child of the leftCoverPivot
            leftCover.SetParent(leftCoverPivot);
            Debug.Log("Left cover pivot and cover set up correctly.");
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0)) // Check for mouse click
            {
                if (!isCoverOpen)
                {
                    Debug.Log("Mouse clicked, initiating cover opening sequence...");
                    StartCoroutine(OpenCover());
                }
            }
        }

        System.Collections.IEnumerator OpenCover()
        {
            Quaternion originalRotation = leftCoverPivot.localRotation;
            Quaternion targetRotation = Quaternion.Euler(0, 0, openAngle);
            float elapsedTime = 0;

            while (elapsedTime < openDuration)
            {
                leftCoverPivot.localRotation = Quaternion.Slerp(originalRotation, targetRotation, (elapsedTime / openDuration));
                elapsedTime += Time.deltaTime;
                Debug.Log($"Rotating cover: {leftCoverPivot.localRotation.eulerAngles}");
                yield return null;
            }

            leftCoverPivot.localRotation = targetRotation;
            isCoverOpen = true;
            Debug.Log("Left cover opened successfully.");
        }
    }
}
