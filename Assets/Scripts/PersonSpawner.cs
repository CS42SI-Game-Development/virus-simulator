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
    public void SpawnPeople(int numPeople)
    {
        for (int i = 0; i < numPeople; i++)
        {

            // TODO: Write your code here!
            // Note that this is already inside of the for-loop, so you
            // only need to handle creating one Person object, and then
            // randomizing its position.

        }
    }

}
