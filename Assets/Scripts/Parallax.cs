using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    Material _material;
    float distance;
    float timeSinceLastIncrease = 0f;
    [SerializeField] float initialSpeed;
    [SerializeField] float speedIncreaseAmount = 0.01f;
    [SerializeField] float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _material = GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        //speed increase slowly
        timeSinceLastIncrease += Time.deltaTime;
        if (timeSinceLastIncrease >= 10f)
        {
            initialSpeed += speedIncreaseAmount;
            initialSpeed = Mathf.Min(initialSpeed, maxSpeed);
            timeSinceLastIncrease = 0f;
        }
        //background movement
        distance += initialSpeed * Time.deltaTime;
        _material.SetTextureOffset("_MainTex", new Vector2(distance, 0));
    }
}
