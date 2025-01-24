using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public static GameMgr I;



    private void Awake()
    {
        I = this;



    }


}
