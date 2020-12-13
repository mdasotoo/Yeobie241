using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTranslate : MonoBehaviour
{
    public Transform targetPosition;
    private Transform player;
    public float speed;
    public float minX, maxX, minY, maxY;
    private Lives lifecount;
    public GameObject livestext;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
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
        transform.position = Vector2.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, targetPosition.position) < 1.0f)
        {
            targetPosition.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        }

        if (Vector2.Distance(transform.position, player.position) < 2)
        {
            Debug.Log("Lose condition");
        }

    }
}
