using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    public TextMesh text;
    public float ox = 100f;
    public float respirationSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(ox <= 0) {
            defaite();
        }
        ox -= respirationSpeed*Time.fixedDeltaTime;
        UpdateText();
    }

    void UpdateText(){
        text.text = "Oxygene: "+(int)ox+"%";
    }

    public void AddOx(float q){
        if(ox+q<100f)ox+=q;
        else ox = 100f;
    }


    public void SetRespirationSpeed(float speed){
        respirationSpeed = speed;
    }

    public void AddRespirationSpeed(float q){
        respirationSpeed+=q;
    }

    public void defaite(){
        GameObject.Find("player").GetComponent<staticScore>().setFinalScore(GameObject.Find("GameController").GetComponent<GameController>().score);
        SceneManager.LoadScene("gameOver");            
    }

}
