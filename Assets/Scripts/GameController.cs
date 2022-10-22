using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject bullePrefab;
    public GameObject baudroiePrefab;
    public GameObject medusePrefab;
    public Vector3 spawnRange;
    public int nbBulles;
    public int nbBaudroie;
    public int nbMeduse;
    public bool isInGame = true;
    public float waitInSeconds;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generateWave());
    }


    IEnumerator generateWave() {
        while (isInGame) {
            nbBaudroie = Random.Range(0, 5);
            nbBulles = Random.Range(0, 5);
            nbMeduse = Random.Range(0, 5);
            waitInSeconds = Random.Range(0f, 5f);
            for (int i=0; i<nbBulles; i++) {
                Vector3 spawnPos = new Vector3(Random.Range(-spawnRange.x, spawnRange.x), -5.65f, 0f);
                Instantiate(bullePrefab, spawnPos, Quaternion.identity);
            }
            for (int i=0; i<nbBaudroie; i++) {
                Vector3 spawnPosBaudroie = new Vector3(-10, Random.Range(-spawnRange.y, spawnRange.y), 0f);
                Instantiate(baudroiePrefab, spawnPosBaudroie, Quaternion.identity);
            }
            for (int i=0; i<nbBaudroie; i++) {
                Vector3 spawnPosBaudroie = new Vector3(10, Random.Range(-spawnRange.y, spawnRange.y), 0f);
                Instantiate(baudroiePrefab, spawnPosBaudroie, Quaternion.identity);
            }
            for (int i=0; i<nbMeduse; i++) {
                Vector3 spawnPosMeduse = new Vector3(Random.Range(-spawnRange.x, spawnRange.x), -5.65f, 0f);
                Instantiate(medusePrefab, spawnPosMeduse, Quaternion.identity);
            }
            yield return new WaitForSeconds(waitInSeconds);
        }
    }
}
