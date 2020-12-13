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
    private Lives lifecount;
    public GameObject livestext;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        lifecount = livestext.GetComponent<Lives>();
    }

    void OnTriggerEnter2D(Collider2D c2d) {
      if (c2d.CompareTag("Player")) {
        lifecount.LoseLife();
        Debug.Log("Life lost");
        transform.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
      }
    }

    // Update is called once per frame
    void Update()
    {
      transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);


    }


}
