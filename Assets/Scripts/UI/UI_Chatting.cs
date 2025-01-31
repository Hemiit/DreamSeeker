using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Chatting : MonoBehaviour
{
    public static UI_Chatting I;

    TMP_Text m_text;
    [Range(0.0001f, 0.01f)] public float duration = 0.01f;
    public TextMeshProUGUI textMeshPro;
    public Button btn;
    private bool isFinished = true;

    public void Init() 
    {
        I = this;

    }


    private void Awake()
    {
        TryGetComponent<TMP_Text>(out m_text);
    }
    private void Start()
    {
        btn.onClick.AddListener(() =>
        {
            PlayOneLineInTyping();
        });
    }

    private void PlayOneLineInTyping()
    {
        if (!isFinished) return;

        //[1].Pick up one line from the dialogue script.
        string oneLine =
            "Slice & Dice is the year¡¯s best roguelike. " +
            "It was also last year¡¯s, too, but I didn¡¯t know that then. " +
            "The game, which was released last year, ";

        //[2].Play it.
        StartCoroutine(TypeWrite(oneLine));
    }

    private IEnumerator TypeWrite(string str)
    {
        isFinished = false;

        bool isCharComplete = false;
        m_text.text = str;
        m_text.ForceMeshUpdate();
        TMP_TextInfo text_info = m_text.textInfo;
        int total = text_info.characterCount;
        int current = 0;
        while (!isCharComplete)
        {
            if (current > total)
            {
                current = total;
                yield return new WaitForSecondsRealtime(0.1f);
                isCharComplete = true;
            }
            m_text.maxVisibleCharacters = current;
            current += 1;
            yield return new WaitForSecondsRealtime(duration);
        }
        isFinished = true;
        yield return null;
    }
}

