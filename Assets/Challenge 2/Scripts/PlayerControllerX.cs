﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown;


    void Start()
    {
        cooldown = 0.0f;
    }
    // Update is called once per frame
    void Update()
    {
        if (cooldown <= 0)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                cooldown = 2.0f;
                Debug.Log(cooldown);
            }
        } else {
            cooldown -= Time.deltaTime;
        }

    }
}
