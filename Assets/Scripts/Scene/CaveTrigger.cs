using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveTrigger : MonoBehaviour
{
    public Cave cave;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Seeker")
        {
            print("Trggering stone breaking.");
            GameMgr.I.player.SetMove(false);//Stop the Seeker.

            //play the animation(stone breaking and show the brush).
            cave.AnimShowCollapseGirlStatuary();
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
