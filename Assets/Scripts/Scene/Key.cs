using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public BoxCollider2D boxCollider_Key;
    public Transform trans_door;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Seeker") 
        {
            this.gameObject.SetActive(false);
            trans_door.DOLocalMoveY(-7f,2f); 
            GameMgr.I.lvl_01.ShowEntrance();
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
