using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform m_Body;
    public Transform m_Target;
    [HideInInspector] public bool m_isOn;
    public GameObject m_Bullet;
    public Transform m_Muzzel;
    public Transform m_BulletParent;
    public Vector2 m_MinMax;

    IEnumerator Shoot()
    {
        while (m_isOn)
        {
            float Rand = Random.Range(m_MinMax.x, m_MinMax.y);
            GameObject go = Instantiate(m_Bullet, m_Muzzel);
            go.transform.parent = m_BulletParent;
            yield return new WaitForSeconds(Rand);
        }
    }

    public void Init()
    {
        m_isOn = true;
        StartCoroutine(Shoot());
    }

    private void Update()
    {
        if (m_isOn)
            LookTarget();
    }

    void LookTarget()
    {
        Vector3 dir = m_Target.transform.position - m_Body.position;
        dir = new Vector3(dir.x, 0, dir.z);
        Quaternion rot = Quaternion.LookRotation(dir);
        m_Body.rotation = Quaternion.Lerp(m_Body.rotation, rot, 0.15f);
    }
}
