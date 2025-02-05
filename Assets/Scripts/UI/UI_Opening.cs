using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class UI_Opening : MonoBehaviour
{

    public VideoPlayer vidPly;

    public void Init() { }

    public void PlayVideo() 
    {
        Show();
        vidPly.Play();
    }

    public void Show() 
    {
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        ToEndVideo();
    }
    void ToEndVideo()
    {
        vidPly.loopPointReached += EndWithVideoPlay;
    }
    void EndWithVideoPlay(VideoPlayer thisPlay)
    {
        Debug.Log("视频播放完毕动作！");
        //StopPlay();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
