using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonSpawner : MonoBehaviour
{

    [Header("Assign your Prefab object here:")]
    public GameObject PersonPrefab;

    void Start()
    {
        SpawnPeople(20);  // Spawn 20 people into the world
    }

    /// <summary>
    /// This function spawns in a bunch of objects into the world,
    /// where each represents a distinct "Person" object.
    /// </summary>
    /// <param name="numPeople">The number of spawned people.</param>
    void SpawnPeople(int numPeople)
    {
        for (int i = 0; i < numPeople; i++)
        {
            SpawnPerson();
        }
    }

    void SpawnPerson()
    {
        GameObject person = Instantiate(PersonPrefab);

        Vector3 randomPosition = new (Random.Range(-6f, 6f), Random.Range(-5f, 5f));

        person.transform.position = randomPosition;
    }

}
