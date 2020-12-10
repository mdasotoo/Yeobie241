using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero1 : MonoBehaviour
{
    public Sprite hero2;

    // Update is called once per frame
    void Update()
    {
        /*if hero = moving ;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hero2;
        */
        this.gameObject.GetComponent<SpriteRenderer>().sprite = hero2;
        transform.Translate(0f, -0.25f, 0f);
    }
}
