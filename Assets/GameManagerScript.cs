using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class GameManagerScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector3 enemyPos1;
    public GameObject gemPrefab;
    public List<Vector3> gemPosList;
    public float timer;
    
    public int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(enemyPrefab, enemyPos1, Quaternion.identity);
        for (int i = 0; i < gemPosList.Count; i++)
        {
            Instantiate(gemPrefab, gemPosList[i], Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            Debug.Log("2 sco tim");
            timer = 0;
        }
    }
}
