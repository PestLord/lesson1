using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private GameObject _player;
    [SerializeField] private Car _car;
    
    [SerializeField] private Vector3 _offset;
    // Start is called before the first frame update
    void Start()
    {
        _car = FindObjectOfType<Car>();
    }
    
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _car.transform.position + _offset;
    }
}
