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
        if (!rotate)
        {
            transform.Rotate(0f, 180f, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        m_speed = Random.Range(0.4f, 2f);
        Vector3 force = new Vector3(m_speed, 0f, 0f);
        this.transform.position += force * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.defaite();
            Destroy(this.gameObject);
        }
    }
}
