using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public Sprite Squir1;
    public Sprite Squir2;
    public int range;

    // Update is called once per frame
    void Update()
    {
        int number = Random.Range(1,range);
        if (number % 2 ==0){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Squir1;    
        }
        else {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Squir2;
        }
    }
}
