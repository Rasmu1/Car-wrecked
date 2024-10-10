using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject botsawPrefab;
    [SerializeField]
    private GameObject RobotPorcurpinePrefab;

    [SerializeField]
    private float botsawInterval = 15f;
    [SerializeField]
    private float RobotPorcurpineInterval = 10f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(botsawInterval, botsawPrefab));
        StartCoroutine(spawnEnemy(RobotPorcurpineInterval, RobotPorcurpinePrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
