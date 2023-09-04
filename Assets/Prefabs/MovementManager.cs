using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var position = transform.position;
        var step = speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            position.z += step;
        }

        if (Input.GetKey(KeyCode.S))
        {
            position.z -= step;
        }

        if (Input.GetKey(KeyCode.A))
        {
            position.x -= step;
        }

        if (Input.GetKey(KeyCode.D))
        {
            position.x += step;
        }

        transform.position = position;
    }
}
