using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject bullePrefab, baudroiePrefab, baudroieDroitePrefab, medusePrefab;
    public Vector3 spawnRange;
    public int nbBulles, nbBaudroie, nbBaudroie1, nbMeduse;
    public int nbBullesMax=5, nbBaudroieMax=2, nbMeduseMax=3;
    public bool isInGame = true;
    public float waitInSeconds;
    public int score = 0;
    public TextMesh scoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generateWave());
    }


    IEnumerator generateWave() {
        while (isInGame) {
            score+=10;
            UpdateScore();
            nbBaudroie = Random.Range(0, nbBaudroieMax);
            nbBaudroie1 = Random.Range(0, nbBaudroieMax);
            nbBulles = Random.Range(0, nbBullesMax);
            nbMeduse = Random.Range(0, nbMeduseMax);
            waitInSeconds = Random.Range(0f, 5f);
            for (int i=0; i<nbBulles; i++) {
                Vector3 spawnPos = new Vector3(Random.Range(-spawnRange.x, spawnRange.x), -5.65f, 0f);
                Instantiate(bullePrefab, spawnPos, Quaternion.identity);
            }
            for (int i=0; i<nbBaudroie; i++) {
                Vector3 spawnPosBaudroie = new Vector3(-10, Random.Range(-spawnRange.y, spawnRange.y), 0f);
                Instantiate(baudroiePrefab, spawnPosBaudroie, Quaternion.identity);
            }
            for (int i=0; i<nbBaudroie1; i++) {
                Vector3 spawnPosBaudroie = new Vector3(10, Random.Range(-spawnRange.y, spawnRange.y), 0f);
                Instantiate(baudroieDroitePrefab, spawnPosBaudroie, Quaternion.identity);
            }
            for (int i=0; i<nbMeduse; i++) {
                Vector3 spawnPosMeduse = new Vector3(Random.Range(-spawnRange.x, spawnRange.x), -5.65f, 0f);
                Instantiate(medusePrefab, spawnPosMeduse, Quaternion.identity);
            }
            yield return new WaitForSeconds(waitInSeconds);
        }
    }

    void UpdateScore(){
        scoreTxt.text = "Score :"+score;

        GameObject go = GameObject.Find("background");
        go.GetComponent<background>().depth = score/10;
    }
}
