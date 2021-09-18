using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPreFab;
    private bool _stopSpawning = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    IEnumerator SpawnEnemy()
    {

        while (_stopSpawning == false){

            Vector2 spawn = new Vector2(Random.Range(-4.7f, 4.7f), 5);
            Instantiate(_enemyPreFab, spawn, Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
    }
}
