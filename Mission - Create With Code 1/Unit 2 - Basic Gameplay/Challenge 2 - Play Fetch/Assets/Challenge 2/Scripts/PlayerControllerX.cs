using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool isDogReady = true;
    private float spawnDelay = 1f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press and isDogReady is true, send dog
        if (Input.GetKeyDown(KeyCode.Space) && isDogReady)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            StartCoroutine(isSpawnActiveRoutine());
        }
    }

    IEnumerator isSpawnActiveRoutine()
    {
        isDogReady = false;
        yield return new WaitForSeconds(spawnDelay);
        isDogReady = true;
    }
}
