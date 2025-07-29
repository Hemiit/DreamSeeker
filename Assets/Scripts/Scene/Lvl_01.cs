using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Lvl_01 : MonoBehaviour
{
    public GameObject obj_collider_1;
    public GameObject obj_collider_2;
    public BoxCollider2D entrance;

    public Vector2 spwanPoint;

    public void Init()
    {
        Hide();
        HideCollider();
        HideEntrance();
    }

    public void ShowCollider()
    {
        obj_collider_1.SetActive(true);
        obj_collider_2.SetActive(true);
    }
    public void HideCollider()
    {
        obj_collider_1.SetActive(false);
        obj_collider_2.SetActive(false);
    }
    public void Show() 
    { 
        gameObject.SetActive(true);
        GameMgr.I.player.SetPosition(spwanPoint);
        GameMgr.I.player.gameObject.SetActive(true);
    }
    public void Hide() { gameObject.SetActive(false); }

    public void ShowEntrance() { entrance.gameObject.SetActive(true); }
    public void HideEntrance() { entrance.gameObject.SetActive(false); }
}
