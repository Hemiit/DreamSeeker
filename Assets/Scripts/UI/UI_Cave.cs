using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Cave : MonoBehaviour
{
    public Button btn_smallBrush;
    public Button btn_bigBrush;
    public Transform itemSlots;
    public Image icon_Brush;
    public Button btn_BigScore;
    public Transform pnl_Score;


    public void Init()
    {
        Hide();

        btn_smallBrush.onClick.AddListener(() =>
        {
            GameMgr.I.cave.Anim_PickUpBrush();

        });

        btn_bigBrush.onClick.AddListener(() =>
        {
            AnimTakeBrush();
        });

        btn_BigScore.onClick.AddListener(() => 
        {
            AnimCollectScore();
        });
    }

    public void AnimTakeBrush()
    {
        DOTween.Sequence()
            .Append(btn_bigBrush.transform.DOScale(0.13f, 0.5f))
            .Join(btn_bigBrush.transform.DOLocalMove(new Vector2(-187f, -472f), 0.5f))
            .Join(btn_bigBrush.image.DOFade(0f, 0.5f))
            .InsertCallback(0.5f, () => { btn_bigBrush.gameObject.SetActive(false); })

            .Join(itemSlots.DOLocalMoveY(-481f, 0.5f))
            .Append(icon_Brush.DOFade(1, 0.2f))
            .AppendInterval(0.5f)
            .AppendCallback(() =>
            {
                btn_BigScore.gameObject.SetActive(true);
            });
    }

    public void AnimCollectScore()
    {
        DOTween.Sequence()
            .Append(btn_BigScore.transform.DOLocalMove(new Vector2(753f,490f),0.5f))
            .Join(btn_BigScore.transform.DOScale(0.1f,0.5f))
            .Join(btn_BigScore.image.DOFade(0f,0.5f))
            .InsertCallback(0.5f, ()=>{ btn_BigScore.gameObject.SetActive(false); })

            .Append(pnl_Score.DOLocalMoveY(490f, 0.5f));
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }
    public void Hide()
    {
        this.gameObject.SetActive(false);
    }

    public void ShowBigBrush()
    {
        btn_bigBrush.gameObject.SetActive(true);
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
