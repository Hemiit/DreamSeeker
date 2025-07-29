using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceToCave : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Seeker")
        {
            print("Enter Cave.");
            SceneChanger.I.ChangeScene(
                () => { GameMgr.I.lvl_01.Hide(); },
                () => { GameMgr.I.cave.Show(); },
                0.5f,
                0.1f
                );
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

