using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(player,transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
