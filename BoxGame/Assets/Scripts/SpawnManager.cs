using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ObstaclePrefab;
    private Vector3 nav = new Vector3(25, 0, 0);
    private float StartDelayTime = 2.0f;
    private float RepeatTime = 2.0f;
    private PlayerController playerControllerScript;
    private float LeftBound = -15;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", StartDelayTime, RepeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(ObstaclePrefab, nav, ObstaclePrefab.transform.rotation);
        }
        if(transform.position.x <LeftBound &&  gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }


    }
}
