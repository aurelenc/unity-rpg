using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FightManger : MonoBehaviour
{
    public List<GameObject> characters = new();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayNextTurn()
    {
        characters.Sort((a, b) => 
            b.transform.GetComponent<Turn>().turnPoints.CompareTo(
            a.transform.GetComponent<Turn>().turnPoints));

        characters.First().GetComponent<FightCharacter>().OnTurn();
    }
}
