using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReisenBehavior : MonoBehaviour
{
    private float _timeElapsed;
    private Transform _transform;
    public float rollTime = 0;
    private Boolean _isTouched;
    public Vector3 rollDirection;

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (_isTouched)
        {
            _timeElapsed += Time.deltaTime;
            _transform.localRotation *= Quaternion.Euler(rollDirection); 
        }

        if (_timeElapsed > rollTime)
        {
            _isTouched = false;
            _timeElapsed = 0;
            _transform.localRotation = new Quaternion(0, 180, 0, 1);
        }

    }

    private void OnMouseDown()
    {
        _isTouched = true;

    }
}
