
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public int health;
    [SerializeField] int numberOfLives;
    [SerializeField] Image[] Lives;
    [SerializeField] Sprite fullLive;
    [SerializeField] Sprite emptyLive;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(health > numberOfLives)
        {
            health = numberOfLives;
        }

        for (int i = 0; i < Lives.Length; i++)
        {
            if(i < health)
            {
                Lives[i].sprite = fullLive;
            }

            else
            {
                Lives[i].sprite = emptyLive;
            }

            if(i < numberOfLives)
            {
                Lives[i].enabled = true;
            }
            else
            {
                Lives[i].enabled = false;
            }
        }
    }

    public void Die()
    {
        Time.timeScale = 0;
    }

    

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
}
