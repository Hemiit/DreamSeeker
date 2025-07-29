using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cave : MonoBehaviour
{

    public Vector2 spwanPoint;


    public void Init()
    {
        Hide();
    }

    public void Show() { this.gameObject.SetActive(true); }
    public void Hide() { this.gameObject.SetActive(false); }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
