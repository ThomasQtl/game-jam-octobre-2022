using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public TextMesh txt;
    // Start is called before the first frame update
    void Start()
    {
        txt.text = "Score Final : "+GameObject.Find("sceneControl").GetComponent<staticScore>().getFinaleScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
