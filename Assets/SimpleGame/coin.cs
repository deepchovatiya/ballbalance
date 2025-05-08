using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject[] coinPrefab; // Assign a coin prefab in the Inspector

    void Start()
    {
        InvokeRepeating("Generate", 1f, 3f); // Calls Generate() every second
    }

    void Update()
    {
        //transform.Rotate(0,0, rotationSpeed * Time.deltaTime);
        transform.Rotate(0, 0, 1);
        
    }

    void Generate()
    {
        int r = Random.Range(0,coinPrefab.Length);
        Vector3 posX = new Vector3(Random.Range(-8f, 8f),transform.position.y,Random.Range(-3.8f,3.4f));
        GameObject newCoin = Instantiate(coinPrefab[r], posX, Quaternion.identity);
        newCoin.transform.Rotate(0, 0, 90);  // Spawns a new coin
    }
}



