using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl_01 : MonoBehaviour
{
    public GameObject obj_collider_1;
    public GameObject obj_collider_2;


    public void Init() 
    {
        Hide();
        HideCollider();
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
    public void Show() { gameObject.SetActive(true); }
    public void Hide() { gameObject.SetActive(false); }
}
