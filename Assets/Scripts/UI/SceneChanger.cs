using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public static SceneChanger I;

    public Image blackCurtain;

    Color transparency = new Color(0, 0, 0, 0);

    public void Init()
    {
        I = this;

        Show();
        blackCurtain.color = transparency;
    }

    Sequence sq;

    public void ChangeScene(Action closeScene, Action open, float duration = 1.5f, float holdOn = 5f)
    {
        sq.Kill();

        blackCurtain.color = transparency;
        blackCurtain.gameObject.SetActive(true);

        sq = DOTween.Sequence()
            .Append(blackCurtain.DOFade(1, duration))
            .InsertCallback(duration + 0.1f, () => { closeScene(); })
            .InsertCallback(duration + 0.1f, () => { open(); })
            .AppendInterval(holdOn)
            .Append(blackCurtain.DOFade(0, duration))
            .AppendCallback(() => { blackCurtain.gameObject.SetActive(false); })
            ;
    }
    private void Show() { gameObject.SetActive(true); }


}
