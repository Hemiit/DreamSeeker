using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Loading : MonoBehaviour
{
    public Button btn_Star;

    public AnimStartButton animStartButton;

    public void Init()
    {
        Show();

        animStartButton.Init();


        btn_Star.onClick.AddListener(() =>
        {
            //animStartButton.Hide();
            Hide();
            //TODO: Play the Animation function of open the eye.

            //UIMgr.I.ui_Opening.PlayVideo();


            SceneChanger.I.ChangeScene(
                () => { Hide(); },
                () => { GameMgr.I.lvl_01.Show(); },
                0.5f,
                0.1f
                );
        });

        GameMgr.I.player.SetPosition(GameMgr.I.lvl_01.spwanPoint);
        GameMgr.I.player.gameObject.SetActive(true);
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

    }

    // Update is called once per frame
    void Update()
    {

    }
}
