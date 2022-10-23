using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class staticScore : MonoBehaviour
{
    public static int finalScore;

    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    public int getFinaleScore(){
        return finalScore;
    }

    public void setFinalScore(int score){
        finalScore = score;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score Final: " + finalScore;
    }
}
