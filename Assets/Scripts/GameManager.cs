using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] Text Score;
    [SerializeField] float spawnInterval;
    [SerializeField] UFO UFOPrefab;
    [SerializeField] GameObject Player;

    float lastSpawnTime;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        score = 0;
        lastSpawnTime = 0f;
        //UpdateScore();
    }

    private void UpdateScore()
    {
        Score.text = score.ToString();
    }

    public void UFODestroyed()
    {
        score++;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastSpawnTime > spawnInterval)
        {
            UFO ufo = GameObject.Instantiate(UFOPrefab);
            ufo.transform.position = UnityEngine.Random.onUnitSphere * 15f;
            ufo.transform.position += Vector3.up*15f; 
            ufo.player = Player.transform;
            lastSpawnTime = Time.time;
        }
    }
}
