using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public Sprite enemy2;
    // Update is called once per frame
    void Update()
    {
        /*if enemy = moving ;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = enemy2;
        */
        this.gameObject.GetComponent<SpriteRenderer>().sprite = enemy2;
        transform.Translate(0f, -0.25f, 0f);
    }
}
