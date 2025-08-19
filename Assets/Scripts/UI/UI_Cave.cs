using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Cave : MonoBehaviour
{
    public Button btn_smallBrush;


    public void Init()
    {
        Hide();
        
        btn_smallBrush.onClick.AddListener(() => 
        {
            GameMgr.I.cave.Anim_PickUpBrush();
            //TODO:shrinp the brush and shut off the particle.
        });
    }



    public void Show()
    {
        this.gameObject.SetActive(true);
    }
    public void Hide()
    {
        this.gameObject.SetActive(false);
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
