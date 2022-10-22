using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticScore : MonoBehaviour
{

    public static int finalScore;

    // Start is called before the first frame update
    void Start()
    {
        
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
        
    }
}
