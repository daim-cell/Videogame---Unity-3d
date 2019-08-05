using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    int score;
    Text scoreboard;
    // Start is called before the first frame update
    void Start()
    {
        scoreboard = GetComponent<Text>();
        scoreboard.text = score.ToString();
    }
    public void Hit(int shipscore)
    {
        score += shipscore;
        scoreboard.text = score.ToString();
    }

}
