using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyMove : MonoBehaviour
{
    Vector2 point;

    Text txt;

    void Start()
    {
        txt = transform.GetComponentInChildren<Text>();

        GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        txt.text = "+ " + gm.moneyIncreaseAmount.ToString("###,###");

        Destroy(this.gameObject, 5f);
    }

    void Update()
    {
        transform = Translate(Vector2.Up * 0.1f);

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, sr.color.a - 0.007f);

        txt = transform.GetComponentInChildren<Text>();
        txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, txt.color.a - 0.007f);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(point, 0.1f);
    }
}
