using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceAtSpawnLocation : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Transform spawnLocation;

    private void Awake()
    {
        Instantiate(player, spawnLocation.position, Quaternion.identity);
    }



}
