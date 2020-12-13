using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTransparent : MonoBehaviour
{
    public int which;

    // Update is called once per frame
    void Update()
    {
        int life= Lives.lives;

        if (life<=which){
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color (1f,1f,1f,0f); 
        }
        else{
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color (1f,1f,1f,1f);
        }
        
    }
}
