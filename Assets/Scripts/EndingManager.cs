using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManager : MonoBehaviour
{
    public Transform Cam_tr;
    //bool CameraStop;
    public SpriteRenderer Black_sr;

    void Start()
    {
        StartCoroutine(CameraMove());
    }

    void Update()
    {
        
    }

    IEnumerator CameraMove()
    {
        float a = 0.03f;
        while (true)
        {
            Cam_tr.Translate(Vector3.up * a);
            a -= 0.00005f;
            if (Cam_tr.position.y > 8.3)
            {
                //CameraStop = true;
                StartCoroutine(Black_FadeIn());
                yield break;
            }

            yield return new WaitForSeconds(0.02f);
        }
    }

    IEnumerator Black_FadeIn()
    {
        int i = 0;
        while(true)
        {
            Black_sr.color += new Color32(0, 0, 0, 2);
            i++;
            if (i == 35)
            {
                yield break;
            }    
            yield return new WaitForSeconds(0.02f);
        }
    }
}
