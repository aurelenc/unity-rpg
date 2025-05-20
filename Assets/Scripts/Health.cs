using UnityEngine;
using UnityEngine.Serialization;

public class Health : MonoBehaviour
{
    public float maxHealth = 0.0f;
    public float currentHealth = 0.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (currentHealth <= 0)
        {
            currentHealth = maxHealth;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
