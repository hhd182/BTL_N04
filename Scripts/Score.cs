using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public int score;
    public Text text;

    public void addScore1()
    {
        score += 1;
        text.text = score.ToString();
    }
    public void addScore2()
    {
        score += 3;
        text.text = score.ToString();
    }
}
