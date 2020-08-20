using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudUi : MonoBehaviour
{
    public Text m_CountText;
    public GameObject m_ReadyDlg;
    int m_Count;

    IEnumerator StartCount()
    {
        m_Count = 0;
        while (m_Count < 5)
        {
            m_Count++;
            switch (m_Count)
            {
                case 1:
                    m_CountText.text = "3";
                    break;
                case 2:
                    m_CountText.text = "2";
                    break;
                case 3:
                    m_CountText.text = "1";
                    break;
                case 4:
                    m_CountText.text = "START";
                    break;
                case 5:
                    m_ReadyDlg.SetActive(false);
                    GameMng.Ins.GameScene.Battle.SetGame();
                    break;
                default:
                    break;
            }
            yield return new WaitForSeconds(1.0f);
        }
    }

    private void Start()
    {
        StartCoroutine(StartCount());
    }
}
