﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 5f); // todo: add serialized field to customize this
    }
}