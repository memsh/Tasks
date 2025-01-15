using System.Collections.Generic;
using UnityEngine;
using Task29;
public class TypeChecker : MonoBehaviour
{
    void Start()
    {
        // Create GameObjects and add components
        GameObject catObject = new GameObject("CatObject");
        Cat cat = catObject.AddComponent<Cat>();

        GameObject warriorObject = new GameObject("WarriorObject");
        Warrior warrior = warriorObject.AddComponent<Warrior>();

        // Make the cat meow
        cat.Meow();

        // Create a list of ICanFight objects
        List<ICanFight> fighters = new List<ICanFight>
        {
            cat,
            warrior
        };

        // Iterate through the list and call Attack on each object
        foreach (ICanFight fighter in fighters)
        {
            fighter.Attack();

            // Use the is keyword to check the object type
            if (fighter is Cat)
            {
                Debug.Log("The object is a Cat.");
            }
            else if (fighter is Warrior)
            {
                Debug.Log("The object is a Warrior.");
            }
        }
    }
}
