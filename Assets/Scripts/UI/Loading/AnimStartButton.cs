using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimStartButton : MonoBehaviour
{
    float duration = 0.3f;      //The Anim Loop.
    public Image start_0;
    public Image start_1;


    public void Init()
    {
        gameObject.SetActive(true);
        start_0.gameObject.SetActive(true);
        start_1.gameObject.SetActive(true);
        AnimShow();
    }


    public void AnimShow()
    {
        DOTween.Sequence()
            .Append(start_1.DOFade(0, 0.0001f))
            .Append(start_0.DOFade(1, 0.0001f))
            .AppendInterval(duration)
            .Append(start_1.DOFade(1, 0.0001f))
            .Append(start_0.DOFade(0, 0.0001f))
            .AppendInterval(duration)
            .SetLoops(-1, LoopType.Restart);
    }
    public void Hide() { gameObject.SetActive(false); }

}
