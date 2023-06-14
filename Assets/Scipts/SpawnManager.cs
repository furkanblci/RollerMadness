using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Objects;
    [SerializeField] private float spawnRate = 5f;
    [SerializeField] private Transform[] spawnPositions;

    private TimeManager timeManager;

    private float nextSpawnTime = 0f;
    
    void Start()
    {
        timeManager = FindObjectOfType<TimeManager>();
    }

    
    void Update()
    {
        if (Time.timeSinceLevelLoad>nextSpawnTime && timeManager.gameOver==false && timeManager.gameFinished==false)
        {
            nextSpawnTime += spawnRate;
            SpawnObject(Objects[RandomObjectNumber()], spawnPositions[RandomSpawnNumber()]);
            print("spawn");
        }


    }

    #region Ýstediðimiz objeyi vererek sahneye spawnlayabilmemize yarayan kod(OOP)
    private void SpawnObject(GameObject ObjectToSpawn,Transform newTransform)
    {
        Instantiate(ObjectToSpawn,newTransform.position,newTransform.rotation);

    }

    #endregion

    private int RandomSpawnNumber()
    {
        return Random.Range(0, spawnPositions.Length);
    }

    private int RandomObjectNumber()
    {
        return Random.Range(0, Objects.Length);

    }

}
