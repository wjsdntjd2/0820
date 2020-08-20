using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionDlg : MonoBehaviour
{
    public Button OKbtn;
    public Button CANCLEbtn;
    public Toggle SFX;
    public Toggle BGM;

    private void Start()
    {
        OKbtn.onClick.AddListener(OnClick_Ok);
        CANCLEbtn.onClick.AddListener(OnClick_Cancle);
    }

    void OnClick_Ok()
    {
        TitleSaveMng.Ins.Save(SFX.isOn, "SFX");
        TitleSaveMng.Ins.Save(BGM.isOn, "BGM");
        TitleMng.Ins.TitleScene.Option.SetActive(false);
        TitleMng.Ins.TitleScene.Title.SetActive(true);
    }

    void OnClick_Cancle()
    {
        SFX.isOn = TitleSaveMng.Ins.Load("SFX");
        BGM.isOn = TitleSaveMng.Ins.Load("BGM");
        TitleMng.Ins.TitleScene.Option.SetActive(false);
        TitleMng.Ins.TitleScene.Title.SetActive(true);
    }
}
