using System;
using System.Collections.Generic;
using UnityEngine;

namespace Task26
{

    // Demonstrate Polymorphism (Manager Class)
    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            List<Creature> creatures = new List<Creature>
            {
                new Kangaroo(),
                new Duck()
            };

            List<IRunnable> runnableCreatures = new List<IRunnable>();
            List<IJumpable> jumpableCreatures = new List<IJumpable>();
            List<ISwimmable> swimmableCreatures = new List<ISwimmable>();

            foreach (var creature in creatures)
            {
                if (creature is IRunnable)
                    runnableCreatures.Add((IRunnable)creature);
                if (creature is IJumpable)
                    jumpableCreatures.Add((IJumpable)creature);
                if (creature is ISwimmable)
                    swimmableCreatures.Add((ISwimmable)creature);
            }

            // Call Speak() for each creature
            foreach (var creature in creatures)
            {
                creature.Speak();
            }

            // Call Run() for each runnable creature
            foreach (var runnable in runnableCreatures)
            {
                runnable.Run();
            }

            // Call Jump() for each jumpable creature
            foreach (var jumpable in jumpableCreatures)
            {
                jumpable.Jump();
            }

            // Call Swim() for each swimmable creature
            foreach (var swimmable in swimmableCreatures)
            {
                swimmable.Swim();
            }
        }
    }
}
