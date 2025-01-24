using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour
{
    public static UIMgr I;
    public UI_Loading ui_Loading;


    private void Awake()
    {
        I = this;

        ui_Loading.Init();

    }
}
