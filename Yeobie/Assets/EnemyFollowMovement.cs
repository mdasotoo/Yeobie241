using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using Lives;

public class EnemyFollowMovement : MonoBehaviour
{
    public Transform player;
    public float minX, maxX, minY, maxY;
    public float speed;
    //public int lives;
    private Lives lifecount;
    public GameObject livestext;
    //public CircleCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        lifecount = livestext.GetComponent<Lives>();
        //lives = 3;
        //rb2D = this.GetComponent<RigidBody2D>();
    }

    void OnTriggerEnter2D(Collider2D c2d) {
      if (c2d.CompareTag("Player")) {
//        SceneManager.LoadScene("LostScene");
        lifecount.LoseLife();
        Debug.Log("Life lost");
        transform.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
      //  lives--;
      /*  if (lives == 0) {
            SceneManager.LoadScene("LostScene");
        }
        */
      }
    }

    // Update is called once per frame
    void Update()
    {



      //  if (Vector2.Distance(transform.position, player.position) > 30) {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
//        }
  /*      else {
            Debug.Log("Losing condition");
            SceneManager.LoadScene("WonScene");

        }
*/

    }


}
