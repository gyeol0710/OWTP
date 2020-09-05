using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScienceMove : MonoBehaviour
{
    public Vector2 point;

    Text txt;

    Text sii_text;
    Image sii_image;

    void Start()
    {
        sii_text = this.GetComponent<Text>();
        sii_image = this.GetComponentInChildren<Image>();
        sii_text.text = "+ " + ((long)(GameManager.scienceIncreaseAmount * GameManager.FinalScienceBonus)).ToString("###,###");

        StartCoroutine(ScienceIncreaseInfo_Fade());
        /*
        txt = transform.GetComponentInChildren<Text>();

        GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        txt.text = "+ " + ((long)(gm.scienceIncreaseAmount * GameManager.SpaceshipScienceBonus)).ToString("###,###");

        Destroy(this.gameObject, 12f);
        */
    }

    void Update()
    {
        /*
        transform.position = Vector2.MoveTowards(transform.position, point, Time.deltaTime * 3f);

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, sr.color.a - 0.006f);

        txt = transform.GetComponentInChildren<Text>();
        txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, txt.color.a - 0.006f);
        */
    }

    IEnumerator ScienceIncreaseInfo_Fade()
    {
        int i = 0;
        int j = 0;
        while (true)
        {
            sii_text.color += new Color32(0, 0, 0, 4);
            sii_image.color += new Color32(0, 0, 0, 4);
            i++;
            if (i > 70)
            {
                sii_image.color = new Color32(255, 255, 255, 255);
                sii_text.color = new Color32(95, 161, 222, 255);

                yield return new WaitForSeconds(0.5f);

                while (true)
                {
                    if (j > 70)
                    {
                        break;
                    }
                    sii_image.color -= new Color32(0, 0, 0, 4);
                    sii_text.color -= new Color32(0, 0, 0, 4);
                    j++;

                    yield return new WaitForSeconds(0.02f);
                }
                Destroy(this.gameObject, 0.1f);

                yield break;
            }
            yield return new WaitForSeconds(0.02f);
        }
    }
}
