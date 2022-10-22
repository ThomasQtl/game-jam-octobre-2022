using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cachalot : MonoBehaviour
{
    // Start is called before the first frame update
    private float m_speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force = new Vector3(-m_speed, 0f, 0f);
        this.transform.position += force * Time.deltaTime;
    }
}
