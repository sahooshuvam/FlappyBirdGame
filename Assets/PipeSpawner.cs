using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float yMin;
    public float yMax;
    public GameObject pipePrefab;
    public float time;
    BirdMovement bird;
    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.Find("Player").GetComponent<BirdMovement>();
       
            InvokeRepeating("PipeSpawners",2f,2f);       
    }
  
    private void PipeSpawners()
    {
        if (bird.isGameOver == false)
        {
            GameObject newPipe = Instantiate(pipePrefab);
            newPipe.transform.position = new Vector2(transform.position.x, UnityEngine.Random.Range(yMin, yMax));
        }
                  
    }
        
      
}
   
