using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomBallRoutine());
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

    IEnumerator SpawnRandomBallRoutine()
    {
        yield return new WaitForSeconds(startDelay);
        SpawnRandomBall();

        while (true)
        {
            // Generate random spawnInterval b/w 3 and 5
            spawnInterval = Random.Range(3f, 5f);
            yield return new WaitForSeconds(spawnInterval);
            SpawnRandomBall();
        }
    }

}
