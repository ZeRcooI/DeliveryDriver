using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.01f;
    [SerializeField] private float _steerSpeed = 1;

    void Start()
    {

    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * _steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
