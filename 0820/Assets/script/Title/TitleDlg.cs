using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleDlg : MonoBehaviour
{
    public Button m_StartBtn;
    public Button m_OptionBtn;

    private void Start()
    {
        m_StartBtn.onClick.AddListener(OnClick_Start);
        m_OptionBtn.onClick.AddListener(OnClick_Option);
    }

    void OnClick_Start()
    {

    }

    void OnClick_Option()
    {
        TitleMng.Ins.OptionDlg.SFX.isOn = TitleSaveMng.Ins.Load("SFX");
        TitleMng.Ins.OptionDlg.BGM.isOn = TitleSaveMng.Ins.Load("BGM");
        TitleMng.Ins.TitleScene.Option.SetActive(true);
        TitleMng.Ins.TitleScene.Title.SetActive(false);
    }
}
