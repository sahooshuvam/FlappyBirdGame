using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PipeMovement : MonoBehaviour
{
    public float speed;
    public int score;
    ScoreCalculator scoreCalculator;
    // Start is called before the first frame update
    void Start()
    {
        scoreCalculator = GameObject.Find("ScoreManager").GetComponent<ScoreCalculator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        if(transform.position.x < -4f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            scoreCalculator.ScoreManager(10);
        }
       
    }
}
