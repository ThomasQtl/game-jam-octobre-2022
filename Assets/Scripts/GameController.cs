using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject bullePrefab, baudroiePrefab, baudroieDroitePrefab, medusePrefab, cachalotPrefab, submarinePrefab, bulleEnPrefab;
    public Vector3 spawnRange;
    public int nbBulles, nbBaudroie, nbBaudroie1, nbMeduse, nbCachalot, nbSubmarine, nbBulleEn;
    public int nbBullesMax=7, nbBaudroieMax=1, nbMeduseMax=2, nbCachalotMax=2, nbSubmarineMax = 1, nbBulleEnMax = 0;
    public bool isInGame = true;
    public float waitInSeconds;
    public TextMesh scoreTxt;
    private int i;

    // Start is called before the first frame update
    void Start()
    {
        scoreScript.scoreValue = 0;
        StartCoroutine(generateWave());
    }


    IEnumerator generateWave() {
        while (isInGame) {
            scoreScript.scoreValue+=10;
            if (scoreScript.scoreValue >= 50) {
                nbBulleEnMax = 1;
            }
            if (scoreScript.scoreValue >= 100) {
                nbBulleEnMax = 2;
            }
            if (scoreScript.scoreValue >= 150) {
                nbBulleEnMax = 3;
            }
            if (scoreScript.scoreValue >= 200) {
                nbBulleEnMax = 4;
            }
            UpdateScore();
            nbBaudroie = Random.Range(0, nbBaudroieMax);
            nbBaudroie1 = Random.Range(0, nbBaudroieMax);
            nbBulles = Random.Range(0, nbBullesMax);
            nbBulleEn = Random.Range(1, nbBulleEnMax);
            nbMeduse = Random.Range(0, nbMeduseMax);
            nbCachalot = Random.Range(1, nbCachalotMax);
            nbSubmarine = Random.Range(0, nbSubmarineMax);
            waitInSeconds = Random.Range(1f, 3f);
            for (i=0; i<nbBulles; i++) {
                Vector3 spawnPos = new Vector3(Random.Range(-spawnRange.x, spawnRange.x), -5.65f, 0f);
                Instantiate(bullePrefab, spawnPos, Quaternion.identity);
            }
            for (i=0; i<nbBulleEn; i++) {
                Vector3 spawnPosE = new Vector3(Random.Range(-spawnRange.x, spawnRange.x), -5.65f, 0f);
                Instantiate(bulleEnPrefab, spawnPosE, Quaternion.identity);
            }
            for (i=0; i<nbBaudroie; i++) {
                Vector3 spawnPosBaudroie = new Vector3(-13, Random.Range(-spawnRange.y, spawnRange.y), 0f);
                Instantiate(baudroiePrefab, spawnPosBaudroie, Quaternion.identity);
            }
            for (i=0; i<nbBaudroie1; i++) {
                Vector3 spawnPosBaudroie = new Vector3(13, Random.Range(-spawnRange.y, spawnRange.y), 0f);
                Instantiate(baudroieDroitePrefab, spawnPosBaudroie, Quaternion.identity);
            }
            for (i=0; i<nbMeduse; i++) {
                Vector3 spawnPosMeduse = new Vector3(Random.Range(-spawnRange.x, spawnRange.x), -5.65f, 0f);
                Instantiate(medusePrefab, spawnPosMeduse, Quaternion.identity);
            };
            for (i=0; i<nbCachalot; i++) {
                Vector3 spawnPosC = new Vector3(13, Random.Range(-spawnRange.y-0.5f, spawnRange.y+0.5f), 0f);
                Instantiate(cachalotPrefab, spawnPosC, Quaternion.identity);
            }
            for (i=0; i<nbSubmarine; i++) {
                Vector3 spawnPosS = new Vector3(-13, Random.Range(-spawnRange.y, spawnRange.y), 0f);
                Instantiate(submarinePrefab, spawnPosS, Quaternion.identity);
            }
            yield return new WaitForSeconds(waitInSeconds);
        }
    }

    void UpdateScore(){
        GameObject go = GameObject.Find("background");
        go.GetComponent<background>().depth = scoreScript.scoreValue/10;
        
        GameObject pl = GameObject.Find("player");
        pl.GetComponent<player>().AddRespirationSpeed(Random.Range(0.5f,2f));
    }
}
