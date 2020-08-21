using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Hero : MonoBehaviour
{
    Rigidbody m_rb;
    public float m_Speed;
    public int m_Hp;
    [HideInInspector] public bool m_isOn;

    public Action<Collider> OnMyCollision = null; 

    public void Init()
    {
        m_isOn = true;
    }

    private void Start()
    {
        m_rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (m_Hp > 0 && m_isOn)
            PlayerMove();
        else
        {
            m_rb.velocity = Vector3.zero;
        }
    }


    void PlayerMove()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 playerMove = new Vector3(hor, 0, ver) * m_Speed;
        m_rb.velocity = playerMove;

        if (hor > 0.2f)
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), 0.1f);
        if (hor < -0.2f)
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -90, 0), 0.1f);
        if (ver > 0.2f)
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), 0.1f);
        if (ver < -0.2f)
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 180, 0), 0.1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (OnMyCollision != null)
            OnMyCollision(other);
    }
}
