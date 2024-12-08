using UnityEngine;
namespace Task24
{

    public class RacingGame : MonoBehaviour
    {
        public RaceState currentState;

        void Update()
        {
            SimulateRace();
        }

        void SimulateRace()
        {
            switch (currentState)
            {
                case RaceState.Start:
                    Debug.Log("The race is about to begin. Get ready! ^_^");
                    break;
                case RaceState.Accelerate:
                    Debug.Log("You press the gas pedal. The car speeds up! ^_____^");
                    break;
                case RaceState.Turn:
                    Debug.Log("You approach a sharp turn. Be careful not to crash! ~_~");
                    break;
                case RaceState.Crash:
                    Debug.Log("You hit a barrier. The race is over. ^o^");
                    break;
                case RaceState.Finish:
                    Debug.Log("You crossed the finish line. Well done! (❁´◡`❁)");
                    break;
                default:
                    Debug.Log("This state is not defined. Something is wrong. ¬_¬");
                    break;
            }
        }
    }


}
