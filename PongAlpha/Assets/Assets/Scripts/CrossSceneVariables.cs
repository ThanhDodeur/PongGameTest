using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossSceneVariables : MonoBehaviour {

    public int winnerScore;
    public int loserScore;
    public string winner;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
