using Task29;
using UnityEngine;

public class Warrior : MonoBehaviour, ICanFight
{
    public void Attack()
    {
        Debug.Log("Warrior attacks with a sword!");
    }
}
