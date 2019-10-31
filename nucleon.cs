﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class nucleon : MonoBehaviour
{
    public float attractionForce;

    Rigidbody body;

    void Awake(){
        body = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        body.AddForce(transform.localPosition * -attractionForce);
    }



}
