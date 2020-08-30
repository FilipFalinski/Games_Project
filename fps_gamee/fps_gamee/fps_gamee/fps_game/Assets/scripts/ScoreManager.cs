using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int playerScore = 500;
    public int curScore;

    private void Start()
    {
        curScore = playerScore;
    }

    public void addScore(int MoneyToAdd)
    {
        curScore += MoneyToAdd;
        Debug.Log("Added " + MoneyToAdd.ToString());
    }

    public void subtractScore(int MoneyToSubtract)
    {
        curScore -= MoneyToSubtract;
        Debug.Log("Subtracted " + MoneyToSubtract.ToString());
    }
}
