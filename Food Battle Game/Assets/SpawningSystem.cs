using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningSystem : MonoBehaviour
{
    public  GameObject[]    spawnPoints;
    public  GameObject      enemyPrefab;

    public  float   timer;
    public  float   timeBtwSpawn;

    public  int numberOfEnemysToSpawn;
    public  int numberOfEnemysSpawned;
    // Start is called before the first frame update
    void Start()
    {
        numberOfEnemysToSpawn = 10; //stage number * 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if(timer > timeBtwSpawn && numberOfEnemysSpawned < numberOfEnemysToSpawn){
            int randomSpot = Random.Range(0, spawnPoints.Length);
            Instantiate(enemyPrefab, new Vector3(spawnPoints[randomSpot].transform.position.x, spawnPoints[randomSpot].transform.position.y, spawnPoints[randomSpot].transform.position.z), Quaternion.identity);
            numberOfEnemysSpawned++;
            timer = 0f;
        }
        
    }
}
