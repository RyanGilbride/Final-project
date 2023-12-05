using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTank : MonoBehaviour
{
    public GameObject[] Vehicle_Military_Tank_Sand_Two;
    private float spawnRangeX = -180;
    private float spawnPosZ = -50;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTanks", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnTanks()
    {
        int animalIndex = Random.Range(0, Vehicle_Military_Tank_Sand_Two.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX-100, spawnRangeX + 100), 0, spawnPosZ);
        Debug.Log(animalIndex);
        Instantiate(Vehicle_Military_Tank_Sand_Two[animalIndex], spawnPos, Vehicle_Military_Tank_Sand_Two[animalIndex].transform.rotation);
    }

    void SpawnLeftTank()
    {
        int TankIndex = Random.Range(0, Vehicle_Military_Tank_Sand_Two.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ,
        sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(Vehicle_Military_Tank_Sand_Two[TankIndex], spawnPos, Quaternion.Euler(rotation));
    }
    void SpawnRightTank()
    {
        int TankIndex = Random.Range(0, Vehicle_Military_Tank_Sand_Two.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ,
        sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(Vehicle_Military_Tank_Sand_Two[TankIndex], spawnPos, Quaternion.Euler(rotation));
    }

}