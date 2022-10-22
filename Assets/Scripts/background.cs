using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    
    public float depth = 0f;
    public float intensity = 0.1f;

    public void setDepth(float depth){
        this.depth = depth;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        Color t = renderer.color;
        t.a = 1-intensity*depth;
        renderer.color=t;
    }
}
