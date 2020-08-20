using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSaveMng
{
    static TitleSaveMng _ins = null;
    public static TitleSaveMng Ins
    {
        get
        {
            if (_ins == null)
                _ins = new TitleSaveMng();
            return _ins;
        }
    }

    public void Save(bool isOn,string a)
    {
        int Val = 0;
        if (isOn)
            Val = 1;
        else
            Val = 0;
        PlayerPrefs.SetInt(a, Val);
    }

    public bool Load(string a)
    {
        int Val = PlayerPrefs.GetInt(a);
        bool isOn;
        if (Val == 0)
            isOn = false;
        else
            isOn = true;
        return isOn;
    }
}
