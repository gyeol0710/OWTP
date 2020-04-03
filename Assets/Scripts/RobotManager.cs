using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RobotManager : MonoBehaviour
{
    public GameObject Robot01;
    public GameObject Robot02;
    public GameObject Robot03;
    public GameObject Robot04;
    public GameObject Robot05;
    public GameObject Robot06;
    public GameObject Robot07;
    public GameObject Robot08;
    public GameObject Robot09;
    public GameObject Robot10;

    void Start()
    {
        StartCoroutine(RobotFadeIn());
    }

    void Update()
    {
        
    }

    IEnumerator RobotFadeIn()
    {
        if (GameManager.robotTier > 1)
        {
            StopCoroutine(RobotFadeIn());
        }

        if (GameManager.robotLevel > 9)
        {
            StopCoroutine(RobotFadeIn());
        }

        while (true)
        {
            if (GameManager.robotLevel == 1)
            {
                SpriteRenderer sr = Robot01.GetComponent<SpriteRenderer>();
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 255);
            }
            if (GameManager.robotLevel == 2)
            {
                SpriteRenderer sr = Robot02.GetComponent<SpriteRenderer>();
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 255);
            }
            if (GameManager.robotLevel == 3)
            {
                SpriteRenderer sr = Robot03.GetComponent<SpriteRenderer>();
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 255);
            }
            if (GameManager.robotLevel == 4)
            {
                SpriteRenderer sr = Robot04.GetComponent<SpriteRenderer>();
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 255);
            }
            if (GameManager.robotLevel == 5)
            {
                SpriteRenderer sr = Robot05.GetComponent<SpriteRenderer>();
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 255);
            }
            if (GameManager.robotLevel == 6)
            {
                SpriteRenderer sr = Robot06.GetComponent<SpriteRenderer>();
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 255);
            }
            if (GameManager.robotLevel == 7)
            {
                SpriteRenderer sr = Robot07.GetComponent<SpriteRenderer>();
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 255);
            }
            if (GameManager.robotLevel == 8)
            {
                SpriteRenderer sr = Robot08.GetComponent<SpriteRenderer>();
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 255);
            }
            if (GameManager.robotLevel == 9)
            {
                SpriteRenderer sr = Robot09.GetComponent<SpriteRenderer>();
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 255);
            }
            if (GameManager.robotLevel == 10)
            {
                SpriteRenderer sr = Robot10.GetComponent<SpriteRenderer>();
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 255);
                break;
            }
            yield return null;
        }
        StopCoroutine(RobotFadeIn());
    }
}
