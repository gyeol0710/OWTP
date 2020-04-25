using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScienceMove : MonoBehaviour
{
    public Vector2 point;

    Text txt;

    void Start()
    {
        txt = transform.GetComponentInChildren<Text>();

        GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        txt.text = "+ " + gm.scienceIncreaseAmount.ToString("###,###");

        Destroy(this.gameObject, 12f);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, point, Time.deltaTime * 3f);

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, sr.color.a - 0.006f);

        txt = transform.GetComponentInChildren<Text>();
        txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, txt.color.a - 0.006f);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(point, 0.1f);
    }
}
