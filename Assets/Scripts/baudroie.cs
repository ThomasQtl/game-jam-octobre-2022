using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baudroie : MonoBehaviour
{
    private float m_speed = 0.5f;
    public bool rotate = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
            m_speed = -m_speed;
        }
        Vector3 force = new Vector3(m_speed, 0f, 0f);
        this.transform.position += force * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("PERDU");
            Destroy(this.gameObject);
        }
    }
}
