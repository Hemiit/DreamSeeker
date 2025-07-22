using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StressorFloating : MonoBehaviour
{
    public float highPos_Y;
    public float lowPos_Y;
    public float duration;

    // Start is called before the first frame update
    void Start()
    {
        AnimFloating();
    }


    private void AnimFloating() 
    {
        transform.localPosition = new Vector2(transform.localPosition.x,lowPos_Y);
        DOTween.Sequence()
            .Append(transform.DOLocalMoveY(highPos_Y,duration))
            .AppendInterval(0.1f)
            .Append(transform.DOLocalMoveY(lowPos_Y,duration))
            .AppendInterval(0.1f)
            .SetLoops(-1, LoopType.Restart); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
