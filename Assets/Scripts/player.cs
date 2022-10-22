using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

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
        ox -= respirationSpeed*Time.fixedDeltaTime;
        UpdateText();
    }

    void UpdateText(){
        text.text = "Oxygene: "+(int)ox+"%";
    }

    public void AddOx(float q){
        if(ox<100f)ox+=q;
    }


    public void SetRespirationSpeed(float speed){
        respirationSpeed = speed;
    }

    public void AddRespirationSpeed(float q){
        respirationSpeed+=q;
    }

}
