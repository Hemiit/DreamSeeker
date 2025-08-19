using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour
{
    public static UIMgr I;
    public UI_Loading ui_Loading;
    public UI_Opening ui_Opening;
    public SceneChanger ui_SceneChanger;
    public UI_Chatting ui_Chantting;
    public UI_Cave ui_Cave;



    private void Awake()
    {
        I = this;

        
        ui_Loading.Init();
        ui_Opening.Init();
        ui_SceneChanger.Init();
        ui_Chantting.Init();
        ui_Cave.Init();




    }
}
