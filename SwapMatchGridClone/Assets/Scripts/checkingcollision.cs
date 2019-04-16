using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkingcollision : MonoBehaviour
{
    public int type;
    private bool topMatch, leftMatch, rightMatch, bottomMatch;
    public GameObject mykids, topgem, leftgem, rightgem, bottomgem;
    public SpriteRenderer matcha;

    // Start is called before the first frame update
    void Start()
    {
        GameObject mykids = transform.parent.gameObject;
        Collider2D matcha = mykids.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Collider2D>())
        { Debug.Log("ehhh");

            Collider2D checkmatch = collision.gameObject.GetComponent<Collider2D>();
            if (checkmatch.isActiveAndEnabled)
            {
                if (gameObject.name == "topCheck")
                {
                    GameObject.FindWithTag("top");
                   
                    if (checkmatch == matcha)
                    {
                        topMatch = true;
                    }
                    else
                    {
                        topMatch = false;
                    }
                }
                else if (gameObject.name == "bottomCheck")
                {
                    GameObject.FindWithTag("bottom");
                    if (checkmatch == matcha)
                    {
                        bottomMatch = true;
                    }
                    else
                    {
                        bottomMatch = false;
                    }
                }
                else if (gameObject.name == "leftCheck")
                {
                    GameObject.FindWithTag("left");
                    if (checkmatch == matcha)
                    {
                        leftMatch = true;
                    }
                    else
                    {
                        leftMatch = false;
                    }
                }
                else if (gameObject.name == "rightCheck")
                {
                    GameObject.FindWithTag("right");
                    if (checkmatch == matcha)
                    {

                        rightMatch = true;
                    }
                    else
                    {
                        rightMatch = false;
                    }
                }

            }
        }

    }
}
