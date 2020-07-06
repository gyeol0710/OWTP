using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIanimManager : MonoBehaviour
{
    public GameObject RobotUI;
    public GameObject RobotUpUI;
    public GameObject ProdUI;
    public GameObject TechUI;
    RectTransform TechUI_Pos;
    RectTransform ProdUI_Pos;


    void Awake()
    {
        TechUI_Pos = TechUI.GetComponent<RectTransform>();
        ProdUI_Pos = ProdUI.GetComponent<RectTransform>();
    }

    public void RobotUIClick()
    {

    }

    public void TechUIClick()
    {
        if (TechUI.activeSelf == false)
        {
            TechUI.SetActive(true);
            TechUI_Pos.anchoredPosition = new Vector2(1400, 0);
            StartCoroutine(ProdUIMoveOut());
            StartCoroutine(TechUIMoveIn());
        }
        else if (TechUI.activeSelf == true)
        {
            if (TechUI_Pos.anchoredPosition != new Vector2(0, 0))
            {
                StartCoroutine(TechUIMoveOut());
            }
            StartCoroutine(TechUIMoveOut());
        }
    }

    public void ProdUIClick()
    {
        if (ProdUI.activeSelf == false)
        {
            ProdUI.SetActive(true);
            ProdUI_Pos.anchoredPosition = new Vector2(-1400, 0);
            StartCoroutine(TechUIMoveOut());
            StartCoroutine(ProdUIMoveIn());
        }
        else if (ProdUI.activeSelf == true)
        {
            if (ProdUI_Pos.anchoredPosition != new Vector2(0, 0))
            {
                StartCoroutine(ProdUIMoveOut());
            }
            StartCoroutine(ProdUIMoveOut());
        }
    }

    IEnumerator TechUIMoveIn()
    {
        while(true)
        {
            if (TechUI_Pos.anchoredPosition == new Vector2(0, 0))
            {
                break;
            }
            TechUI_Pos.anchoredPosition -= new Vector2(70,0);
            yield return new WaitForSeconds(0.005f);
        }
        yield return null;
    }

    IEnumerator TechUIMoveOut()
    {
        while (true)
        {
            if (TechUI_Pos.anchoredPosition == new Vector2(1400, 0))
            {
                break;
            }
            TechUI_Pos.anchoredPosition += new Vector2(70, 0);
            yield return new WaitForSeconds(0.005f);

        }
        TechUI.SetActive(false);
        yield return null;
    }

    IEnumerator ProdUIMoveIn()
    {
        while (true)
        {
            if (ProdUI_Pos.anchoredPosition == new Vector2(0, 0))
            {
                break;
            }
            ProdUI_Pos.anchoredPosition += new Vector2(70, 0);
            yield return new WaitForSeconds(0.005f);
        }
        yield return null;
    }

    IEnumerator ProdUIMoveOut()
    {
        while (true)
        {
            if (ProdUI_Pos.anchoredPosition == new Vector2(-1400, 0))
            {
                break;
            }
            ProdUI_Pos.anchoredPosition -= new Vector2(70, 0);
            yield return new WaitForSeconds(0.005f);

        }
        ProdUI.SetActive(false);
        yield return null;
    }
}
