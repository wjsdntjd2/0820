using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMng : MonoBehaviour
{
    #region SingleTon
    // Start is called before the first frame update
    private static GameMng Instance;
    public static GameMng Ins
    {
        get
        {
            if (Instance == null)
            {
                Instance = FindObjectOfType<GameMng>();
                if (Instance == null)
                {
                    GameObject MngGame = new GameObject();
                    Instance = MngGame.AddComponent<GameMng>();
                    MngGame.name = "GameMng";
                }
            }
            return Instance;
        }
    }
    #endregion
    public GameScene GameScene;
}
