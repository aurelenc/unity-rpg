using UnityEngine;

public class FightCharacter : MonoBehaviour
{
    private Health _health;
    private Effects _effects;
    private Speed _speed;
    private Turn _turn;
    
    public void OnTurn()
    {
        _turn.turnPoints -= 10;
        
        _health.currentHealth -= _effects.fireAmount * _effects.fireDamage;
        if (_health.currentHealth <= 0)
            _health.currentHealth = 0;

        _turn.turnPoints += _speed.speed;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _health = GetComponent<Health>();
        _effects = GetComponent<Effects>();
        _speed = GetComponent<Speed>();
        _turn = GetComponent<Turn>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
