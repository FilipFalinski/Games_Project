using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 30;
    public bool takingAway = false;
    public int TimePerKill;
    public bool Kill;
    public bool Lose;


    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;


        TimePerKill = 10;
    }

    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            _ = StartCoroutine(TimerTake());
        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        takingAway = false;

        if (Kill == true)
        {
            secondsLeft += TimePerKill;
            //10 seconds added when you got a kill.
            Kill = false;
            //Then, no more seconds are added.
        }

    }
}
