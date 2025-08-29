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
    public SpriteRenderer brush_Small;
    public ParticleSystem ps_Flash;

    Color TransparentColor = new Color(1, 1, 1, 0);

    public void Init()
    {
        Hide();
        FadeOutGirlStatuary();
        brush_Small.color = TransparentColor;
        brush_Small.gameObject.SetActive(false);
        ps_Flash.gameObject.SetActive(false);
    }
    public void Anim_PickUpBrush()
    {
        DOTween.Sequence()
            .Append(brush_Small.DOFade(0f,0.3f))
            .AppendCallback(() => 
            {
                brush_Small.gameObject.SetActive(false);

                UIMgr.I.ui_Cave.ShowBigBrush();
            });
            

        //TODO:shrinp the brush and shut off the particle.
    }
    public void Show()
    {
        GameMgr.I.player.transform.localPosition = spwanPoint;
        this.gameObject.SetActive(true);
    }
    public void Hide() { this.gameObject.SetActive(false); }

    public void FadeOutGirlStatuary()
    {
        //var TransparentColor = new Color(1, 1, 1, 0);
        //inside1.color = TransparentColor;
        inside2.color = TransparentColor;
        inside3.color = TransparentColor;
        inside4.color = TransparentColor;

    }

    public void AnimShowCollapseGirlStatuary()
    {
        DOTween.Sequence()
            .Append(inside1.DOFade(0, 0.5f))
            .Join(inside2.DOFade(1, 1f))
            .Join(Camera.main.DOShakePosition(1f, 0.2f, 10))
            .AppendInterval(1f)

            .Append(inside2.DOFade(0, 0.5f))
            .Join(inside3.DOFade(1, 1f))
            .Join(Camera.main.DOShakePosition(1f, 0.2f, 10))
            .AppendInterval(1f)

            .Append(inside3.DOFade(0, 0.5f))
            .Join(inside4.DOFade(1, 1f))
            .Join(Camera.main.DOShakePosition(1f, 0.2f, 10))
            .AppendCallback(() =>
            {
                ps_Flash.gameObject.SetActive(true);
                brush_Small.gameObject.SetActive(true);
                brush_Small.DOFade(1f, 0.5f);
            })
            ;
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
