using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBall : MonoBehaviour
{
    public Vector2 position;    //Input on the Unity_Inspector_pnl.
    public GameObject pnlImg;


    // Start is called before the first frame update
    void Start()
    {
        SetInitPos();
        HidePnlImg();
    }
    private void SetInitPos()
    {
        this.transform.localPosition = position;
    }
    public void Show() { this.gameObject.SetActive(true); }
    public void Hide() { this.gameObject.SetActive(false); }

    public void ShowPnlImg()
    { 
        pnlImg.SetActive(true);

    }
    public void HidePnlImg() 
    {
        pnlImg.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
