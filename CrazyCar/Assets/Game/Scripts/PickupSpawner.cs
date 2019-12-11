using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public int maxX = 19;
    public int maxZ = 38;
    public float timer;
    public float newSpawnTime;
    public GameObject pickUpGO;
    // Start is called before the first frame update
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > newSpawnTime)
        {
            CreateCollectable();
            timer = 0;
        }
    }

    public GameObject CreateCollectable()
    {
        GameObject aux = Instantiate(pickUpGO);
        aux.transform.position = new Vector3(Random.Range(-maxX, maxX), 40f, Random.Range(-maxZ, maxZ));
        return aux;
    }
}