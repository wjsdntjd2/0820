using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody m_rb;
    public float m_Speed;
    public int m_Dmg;

    private void Start()
    {
        m_rb = GetComponent<Rigidbody>();
        m_rb.AddForce(transform.forward * m_Speed);
        Invoke("DestoryBullet", 5.0f);
    }

    public void DestoryBullet()
    {
        Destroy(gameObject);
    }
}
