using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class GameMgr : MonoBehaviour
{
    public static GameMgr I;


    private void Awake()
    {
        I = this;

   

    }


}
