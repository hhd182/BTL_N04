using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreAdd : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "PowerUp")
        {
            FindObjectOfType<Score>().addScore2();
            Destroy(gameObject);
        }
        else
        {
            FindObjectOfType<Score>().addScore1();
        }
    }
}
