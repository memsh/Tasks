using UnityEngine;
namespace Task25
{


    public class ScaleItems : MonoBehaviour
    {
        public Transform[] items; // Array of items inside the book
        public float scaleDuration = 1.0f; // Duration for scaling

        private bool isBookOpen = false;

        void Update()
        {
            if (Input.GetMouseButtonDown(0)) // Check for mouse click
            {
                if (!isBookOpen)
                {
                    OpenBook();
                }
            }
        }

        void OpenBook()
        {
            foreach (Transform item in items)
            {
                StartCoroutine(ScaleUp(item));
            }
            isBookOpen = true;
        }

        System.Collections.IEnumerator ScaleUp(Transform item)
        {
            Vector3 originalScale = item.localScale;
            item.localScale = Vector3.zero;
            float elapsedTime = 0;

            while (elapsedTime < scaleDuration)
            {
                item.localScale = Vector3.Lerp(Vector3.zero, originalScale, (elapsedTime / scaleDuration));
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            item.localScale = originalScale;
        }
    }
}
