using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    public float respirationSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(oxygeneScript.ox <= 0) {
            defaite();
        }
        oxygeneScript.ox -= respirationSpeed*Time.fixedDeltaTime;
    }

    public void AddOx(float q){
        if(oxygeneScript.ox+q<100f)oxygeneScript.ox+=q;
        else oxygeneScript.ox = 100f;
    }


    public void SetRespirationSpeed(float speed){
        respirationSpeed = speed;
    }

    public void AddRespirationSpeed(float q){
        respirationSpeed+=q;
    }

    public void defaite(){
        staticScore.finalScore = scoreScript.scoreValue;
        SceneManager.LoadScene("gameOver");         
    }

}
