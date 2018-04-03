using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerDisplay : MonoBehaviour {

    public Text winnerDisplay;

    
    // Use this for initialization
    void Start()
    {
        GameObject crossScenesVariables = GameObject.Find("crossScenesVariables");
        string winner = crossScenesVariables.GetComponent<CrossSceneVariables>().winner;
        int winnerScore = crossScenesVariables.GetComponent<CrossSceneVariables>().winnerScore;
        int loserScore = crossScenesVariables.GetComponent<CrossSceneVariables>().loserScore;
        winnerDisplay.text = string.Format("Winner:\n {0} \n({1} - {2})", winner, winnerScore, loserScore);
}
     

	}	


