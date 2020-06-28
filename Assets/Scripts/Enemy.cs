﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    [SerializeField] int scorePerHit = 13;

    ScoreBoard scoreBoard;

    void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
        AddNonTriggerBoxCollider();
    }

    void OnParticleCollision(GameObject other)
    {
        GameObject explosion = Instantiate(deathFX, transform.position, Quaternion.identity);
        explosion.transform.parent = parent;

        Destroy(gameObject);

        if (null != scoreBoard)
        {
            scoreBoard.ScoreHit(scorePerHit);
        }
    }

    void AddNonTriggerBoxCollider()
    {
        Collider collider = gameObject.AddComponent<BoxCollider>();
        collider.isTrigger = false;
    }
}
