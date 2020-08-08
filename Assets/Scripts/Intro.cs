using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public Transform Cam_tr;
    public GameObject fall;
    Transform fall_tr;
    SpriteRenderer fall_sr;
    public SpriteRenderer Light_sr;
    public SpriteRenderer white_sr;

    void Start()
    {
        fall_tr = fall.GetComponent<Transform>();
        fall_sr = fall.GetComponent<SpriteRenderer>();

        StartCoroutine(fallMove());
        StartCoroutine(CameraMove());
    }

    void Update()
    {
        
    }

    IEnumerator fallMove()
    {
        int i = 0;

        while(true)
        {
            fall_tr.Translate(Vector3.down * 0.02f);

            if(fall_tr.position.y < 1.6)
            {
                StartCoroutine(LightOn());
                while(true)
                {
                    i++;
                    fall_sr.color -= new Color32(0, 0, 0, 20);

                    if (i > 13)
                    {
                        yield break;
                    }

                    yield return new WaitForSeconds(0.02f);
                }
            }

            yield return new WaitForSeconds(0.025f);
        }
    }

    IEnumerator LightOn()
    {
        int i = 0;
        while(true)
        {
            Light_sr.color += new Color32(0, 0, 0, 15);
            white_sr.color += new Color32(0, 0, 0, 15);
            i++;
            if(i > 20)
            {
                LoadingManager.LoadScene("MainScene");
            }
            yield return new WaitForSeconds(0.02f);
        }
    }

    IEnumerator CameraMove()
    {
        float a = 0.037f;
        while(true)
        {
            Cam_tr.Translate(Vector3.down * a);
            a -= 0.0001f;
            if (Cam_tr.position.y < 1.31)
            {
                yield break;
            }

            yield return new WaitForSeconds(0.02f);
        }
    }
}
