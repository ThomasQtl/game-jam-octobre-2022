using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meduse : MonoBehaviour
{
    private float m_speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_speed = Random.Range(0.4f, 2f);
        Vector3 force = new Vector3(0f, m_speed, 0f);
        this.transform.position += force * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player") {
            player.defaite();
            Destroy(this.gameObject);
        }
    }
}
