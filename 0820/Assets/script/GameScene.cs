using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    [HideInInspector] public BattleFSM Battle = new BattleFSM();
    public GameUi m_GameUi;
    public HudUi m_HudUi;

    private void Awake()
    {
        Battle.Init(CallBack_Ready, CallBack_Game, CallBack_Wave, CallBack_Result);
    }

    private void Start()
    {
        Battle.SetReady();
    }

    private void Update()
    {
        Battle.OnUpdate();
        Debug.Log(Battle.curState);
    }

    void CallBack_Ready()
    {

    }

    void CallBack_Game()
    {
        m_GameUi.Init();
    }

    void CallBack_Wave()
    {

    }

    void CallBack_Result()
    {

    }

}
