using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUi : MonoBehaviour
{
    public Turret[] m_Turrets;
    public Hero m_Player;

    public void Init()
    {
        for (int i = 0; i < m_Turrets.Length; i++)
        {
            m_Turrets[i].Init();
        }
        m_Player.Init();

        m_Player.OnMyCollision = MyCollision_Enter;
    }



    public void MyCollision_Enter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            m_Player.m_Hp -= other.GetComponent<Bullet>().m_Dmg;
            other.GetComponent<Bullet>().DestoryBullet();
        }
    }
}
