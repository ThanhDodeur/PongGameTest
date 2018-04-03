using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour {

    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;
    private GameObject crossScenesVariables;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;
   
    public int goalToWin;

    private void Awake()
    {
        crossScenesVariables = GameObject.Find("crossScenesVariables");
    }
    void Update ()
    {
         
        if (this.scorePlayer1 >= this.goalToWin || this.scorePlayer2 >= this.goalToWin)
        {
            if (this.scorePlayer1 > this.scorePlayer2) 
            {
                // sauve le score et le nom pour l'ecran GameOver;
                crossScenesVariables.GetComponent<CrossSceneVariables>().winner = "Player 1";
                crossScenesVariables.GetComponent<CrossSceneVariables>().winnerScore = this.scorePlayer1;
                crossScenesVariables.GetComponent<CrossSceneVariables>().loserScore = this.scorePlayer2;
            }
            else
            {
                crossScenesVariables.GetComponent<CrossSceneVariables>().winner = "Player 2";
                crossScenesVariables.GetComponent<CrossSceneVariables>().winnerScore = this.scorePlayer2;
                crossScenesVariables.GetComponent<CrossSceneVariables>().loserScore = this.scorePlayer1;
            }
            SceneManager.LoadScene("GameOver");
        }
       
    }

    private void FixedUpdate()
    {
        Text uiScorePlayer1 = this.scoreTextPlayer1.GetComponent<Text>();
        uiScorePlayer1.text = this.scorePlayer1.ToString();

        Text uiScorePlayer2 = this.scoreTextPlayer2.GetComponent<Text>();
        uiScorePlayer2.text = this.scorePlayer2.ToString();

    }

    public void GoalPlayer1()
    {
        this.scorePlayer1++;
    }

    public void GoalPlayer2()
    {
        this.scorePlayer2++;
    }
}
