using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cave : MonoBehaviour
{
    public Vector2 spwanPoint;

    public SpriteRenderer inside1;
    public SpriteRenderer inside2;
    public SpriteRenderer inside3;
    public SpriteRenderer inside4;


    public void Init()
    {
        Hide();
        FadeOutGirlImages();
    }

    public void Show() { this.gameObject.SetActive(true); }
    public void Hide() { this.gameObject.SetActive(false); }

    public void FadeOutGirlImages()
    {
        var TransparentColor = new Color(1, 1, 1, 0);
        //inside1.color = TransparentColor;
        inside2.color = TransparentColor;
        inside3.color = TransparentColor;
        inside4.color = TransparentColor;

    }

    //Waiting the 
    public void AnimShowCollapseGirlStatuary()
    {
        DOTween.Sequence()
            .Append(inside1.DOFade(0, 0.5f))
            .Join(inside2.DOFade(1, 0.5f))
            .AppendInterval(0.5f)

            .Append(inside2.DOFade(0, 0.5f))
            .Join(inside3.DOFade(1, 0.5f))
            .AppendInterval(0.5f)

            .Append(inside3.DOFade(0, 0.5f))
            .Join(inside4.DOFade(1, 0.5f));
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
