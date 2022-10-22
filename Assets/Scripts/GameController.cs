using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject bullePrefab;
    public Vector3 spawnRange;
    public int nbBulles = 5;
    public bool isInGame = true;
    public float waitInSeconds;
    public int score = 0;
    public TextMesh scoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generateWave(nbBulles));
    }

    
    IEnumerator generateWave(int nbBulles) {
        while (isInGame) {
            score+=10;
            UpdateScore();
            nbBulles = Random.Range(0, 5);
            waitInSeconds = Random.Range(0f, 5f);
            for (int i=0; i<nbBulles; i++) {
                Vector3 spawnPos = new Vector3(Random.Range(-spawnRange.x, spawnRange.x), -5.65f, 0f);
                Instantiate(bullePrefab, spawnPos, Quaternion.identity);
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
