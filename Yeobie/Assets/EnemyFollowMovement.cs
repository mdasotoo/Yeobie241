using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyFollowMovement : MonoBehaviour
{
    public Transform player;
    //private RigidBody2D rb2D;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //rb2D = this.GetComponent<RigidBody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    
        if (Vector2.Distance(transform.position, player.position) > 30) {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        } 
        else {
            Debug.Log("Losing condition");
            SceneManager.LoadScene("WonScene");
            
        }
        
    }   
}
