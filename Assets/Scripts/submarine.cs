using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submarine : MonoBehaviour
{

    private float subSpeed = 0.5f;
    public bool rotate = false;

    // Start is called before the first frame update
    void Start()
    {
        if (!rotate)
        {
            transform.Rotate(0f, 180f, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        subSpeed = Random.Range(0.4f, 2f);
        Vector3 force = new Vector3(subSpeed, 0f, 0f);
        this.transform.position += force * Time.deltaTime;
    }

    // // Start is called before the first frame update
    // void Start()
    // {
    //     float subScale = 0.2f+1/subSpeed;
    //     transform.localScale = new Vector3(subScale*1f, subScale*1f, subScale*1f);
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     float subScale = 0.2f+1/subSpeed;
    //     transform.localScale = new Vector3(subScale*0.75f, subScale*1f, subScale*1f);

    //     if(transform.position.x<13.0f) transform.position += new Vector3(subSpeed*Time.fixedDeltaTime, 0f, 0f);
    //     else transform.position = new Vector3(-13, transform.position.y, transform.position.z);
    // }
}
