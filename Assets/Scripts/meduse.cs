using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meduse : MonoBehaviour
{
    private float m_speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force = new Vector3(0f, m_speed, 0f);
        this.transform.position += force * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player") {
            Debug.Log("PERDU");
            Destroy(this.gameObject);
        }
    }
}
