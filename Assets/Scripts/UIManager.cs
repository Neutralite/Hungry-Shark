using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public TextMeshProUGUI scoreUI;
    int score;
    public GameObject[] lives = new GameObject[3];
    int livesScore = 3;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void updateScore(int scoreChange)
    {
        score += scoreChange;
        if (score < 10) {
            scoreUI.text = "Score: 000" + score.ToString();
        } 
        else if (score <100)
        {
            scoreUI.text = "Score: 00" + score.ToString();
        }
        else if (score <1000)
        {
            scoreUI.text = "Score: 0" + score.ToString();
        } 
        else
        {
            scoreUI.text = "Score: " + score.ToString();
        } 
    }

    public void updateLives(int livesChange)
    {
        livesScore += livesChange;
        lives[livesScore].SetActive(!lives[livesScore].active);
    }

}
