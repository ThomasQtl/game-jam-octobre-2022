using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulleEn : MonoBehaviour
{

    private float m_speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_speed = Random.Range(1f, 2.5f);
        Vector3 force = new Vector3(0f, m_speed, 0f);
        this.transform.position += force * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player") {
            GameObject go = GameObject.Find("player");
            go.GetComponent<player>().AddOx(-5f); 
            Destroy(this.gameObject);
        }
    }
}
