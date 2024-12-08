using UnityEngine;
using UnityEngine.SceneManagement;
namespace Task25
{

    public class BookController : MonoBehaviour
    {
        private Animator animator;
        private bool isOpen = false;

        void Start()
        {
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) // Change this to your preferred input method
            {
                if (isOpen)
                {
                    animator.Play("CloseCover");
                }
                else
                {
                    animator.Play("OpenCover");
                }
                isOpen = !isOpen;
            }
        }
    }
}