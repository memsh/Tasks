using UnityEngine;

namespace Task27
{
    public class Task27Script : MonoBehaviour
    {
        private void Start()
        {
            int a = 10;
            int b = 20;
            int c;

            Print($"Before Call by Value: a = {a}");
            CallByValue(a);
            Print($"After Call by Value: a = {a}");

            Print($"Before Call by Reference: b = {b}");
            CallByReference(ref b);
            Print($"After Call by Reference: b = {b}");

            CallByOut(out c);
            Print($"After Using out Keyword: c = {c}");
        }

        private void CallByValue(int number)
        {
            number += 10;
            Print($"Inside Call by Value: number = {number}");
        }

        private void CallByReference(ref int number)
        {
            number += 10;
            Print($"Inside Call by Reference: number = {number}");
        }

        private void CallByOut(out int number)
        {
            number = 30;
            Print($"Inside Using out Keyword: number = {number}");
        }

        private void Print(string message)
        {
            Debug.Log(message);
        }
    }
}
