using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class spawnObstacle : MonoBehaviour
{
    [SerializeField] GameObject[] obstaclePrefab;
    [SerializeField] TMP_Text scoreText;
    float initialSpeed = 10f;
    float maxSpeed = 16f;
    float speedIncreaseRate = 0.1f;
    float timeElapsed = 0f;
    int score = 0;
    float scoreIncreaseRate = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObstacle());
        StartCoroutine(DelayedOperation());
    }

    IEnumerator SpawnObstacle()
    {
        while (true)
        {
            float randomDelay = Random.Range(0.6f, 3.2f);
            yield return new WaitForSeconds(randomDelay);
            int i = Random.Range(0, obstaclePrefab.Length);
            Vector3 spawnPosition = transform.position;

            if (i == 1)
            {
                spawnPosition.y += 1;
            }
            GameObject obstacle = Instantiate(obstaclePrefab[i], spawnPosition, Quaternion.identity);
            Obstacle obstacleScript = obstacle.GetComponent<Obstacle>();

            if (obstacleScript != null)
            {
                obstacleScript.SetSpeed(initialSpeed);
            }
        }
    }

    void IncreaseSpeed()
    {
        initialSpeed += speedIncreaseRate;
        if (initialSpeed > maxSpeed)
        {
            initialSpeed = maxSpeed;
        }
        scoreIncreaseRate = initialSpeed / 10f;
    }

    IEnumerator DelayedOperation()
    {
        while (true)
        {
            score += 1;
            //Debug.Log("Score: " + score);
            scoreText.text = "Score: " + score;
            yield return new WaitForSeconds(1f / scoreIncreaseRate);
        }
    }

    private void FixedUpdate()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= 5f)
        {
            timeElapsed = 0f;
            IncreaseSpeed();
        }
    }
}
