using UnityEngine;

public class Effects : MonoBehaviour
{
    public int fireAmount = 0;
    public int fireDamage = 0;
    private Health _health;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _health = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
