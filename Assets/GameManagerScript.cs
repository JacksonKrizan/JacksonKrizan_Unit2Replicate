using UnityEngine;
using System.Collections.Generic;

public class GameManagerScript : MonoBehaviour
{
    public int score;
    public GameObject enemyPrefab;
    public Vector3 enemyPos1;
    public GameObject gemPrefab;
    public List<Vector3> gemPosList;
    public float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(enemyPrefab, enemyPos1, Quaternion.identity);
        for(int i = 0; i < gemPosList.Count; i++)
        {
            Instantiate(gemPrefab, gemPosList[i], Quaternion.identity);
        }
    }




    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

    }
}
