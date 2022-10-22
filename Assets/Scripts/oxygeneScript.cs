using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxygeneScript : MonoBehaviour
{
    public static float ox = 100;
    Text oxT;

    // Start is called before the first frame update
    void Start()
    {
        oxT = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        oxT.text = "Oxygène: " + (int)ox + "%";
    }
}
