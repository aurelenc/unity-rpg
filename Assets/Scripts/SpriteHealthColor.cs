using UnityEngine;

public class SpriteHealthColor : MonoBehaviour
{
    private Health _health;
    public SpriteRenderer spriteRenderer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _health = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        var color = spriteRenderer.color;
        color.b = _health.currentHealth / _health.maxHealth;
        color.g = _health.currentHealth / _health.maxHealth;
        spriteRenderer.color = color;
    }
}
