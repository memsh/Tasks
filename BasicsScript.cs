using System;
using UnityEngine;

namespace Task29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            // Declare variables
            var myInt = 5;
            var myString = "Hello, Meshmesh ¬_¬!";
            var myBool = true;

            // Use ternary operator to check if the integer is even or odd
            var result = (myInt % 2 == 0) ? "even" : "odd";

            // Use string interpolation to create a message
            string message = $"The number {myInt} is {result}.";
            Debug.Log(message);

            // Log the current date, time, and day
            Debug.Log($"Current date: {DateTime.Now.ToString("yyyy-MM-dd")}");
            Debug.Log($"Current time: {DateTime.Now.ToString("HH:mm:ss")}");
            Debug.Log($"Current day: {DateTime.Now.DayOfWeek}");
        }
    }
}
