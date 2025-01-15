using UnityEngine;
using Task29;

public class Cat : MonoBehaviour, ICanFight
{
    public void Meow()
    {
        Debug.Log("Meow!");
    }

    public void Attack()
    {
        Debug.Log("Cat attacks with claws!");
    }
}
