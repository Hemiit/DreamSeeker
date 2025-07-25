using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmallBall : MonoBehaviour
{
    public Vector2 position;    //Input on the Unity_Inspector_pnl.
    public GameObject pnlImg;
    public Transform flashingVFX;

    // Start is called before the first frame update
    void Start()
    {
        SetInitPos();
        HidePnlImg();
        AnimFlashing();
    }
    private void SetInitPos()
    {
        this.transform.localPosition = position;
    }
    public void Show() { this.gameObject.SetActive(true); }
    public void Hide() { this.gameObject.SetActive(false); }

    public void AnimFlashing()
    {
        flashingVFX.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        //DOTween.Sequence()
        //    .Append(Img_flashing.DOScale(1f, 1f))
        //    .Append(Img_flashing.DOScale(0.5f, 1f))
        //    .SetLoops(-1, LoopType.Restart);

        var imgFlashing=flashingVFX.GetComponent<SpriteRenderer>();
            
        DOTween.Sequence()
            .Append(flashingVFX.DOScale(1.5f, 1.5f))
            .Join(imgFlashing.DOFade(0f,1f))
            .SetLoops(-1, LoopType.Restart);
    }

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
