using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMng : MonoBehaviour
{
    #region SingleTon
    // Start is called before the first frame update
    private static TitleMng Instance;
    public static TitleMng Ins
    {
        get
        {
            if (Instance == null)
            {
                Instance = FindObjectOfType<TitleMng>();
                if (Instance == null)
                {
                    GameObject MngGame = new GameObject();
                    Instance = MngGame.AddComponent<TitleMng>();
                    MngGame.name = "TitleMng";
                }
            }
            return Instance;
        }
    }
    #endregion
    public TitleScene TitleScene;
    public OptionDlg OptionDlg;
}
