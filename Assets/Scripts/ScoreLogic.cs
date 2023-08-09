using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour
{
    public long playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void addScore ()
    {
        playerScore = playerScore + 3;
        scoreText.text = playerScore.ToString();
    }
}
