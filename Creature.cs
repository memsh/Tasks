using System;
using System.Collections.Generic;
using UnityEngine;

namespace Task26
{
    // Base Class
    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound.");
        }
    }

}

