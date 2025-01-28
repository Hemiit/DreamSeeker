using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class GameMgr : MonoBehaviour
{
    public static GameMgr I;
    public Lvl_01 lvl_01;

    private void Awake()
    {
        I = this;
        lvl_01.Init();
   

    }


}
