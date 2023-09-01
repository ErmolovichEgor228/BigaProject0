//using System.Collections;
//using System.Collections.Generic;

//using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Target : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] float spawnDelay;
    private float randomX;
    private float randomY;
    Vector2 whereToSpawn;
    float nextSpawn = 0.0f;

    /*[SerializeField] int health;
    [SerializeField] int numberOfLives;
    [SerializeField] Image[] Lives;
    [SerializeField] Sprite fullLive;
    [SerializeField] Sprite emptyLive;*/

    void Start()
    {
        
    }

    /*public void TakeDamage(int damage)
    {
        health -= damage;
        //if (health <= 0)
        //{
        //    Die();
        //}
    }*/


    void Update()
    {
        

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnDelay;
            randomX = Random.Range(-7, 8);
            randomY = Random.Range(3, -3.5f);
            whereToSpawn = new Vector2(randomX, randomY);
            GameObject Enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
            Destroy(Enemy, 1.7f);
        }

    }

    public void Shop()
    {
        
    }
}
