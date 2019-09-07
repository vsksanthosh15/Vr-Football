﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float Addscore = 30f;
    public GameObject ParcticlePrefab;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Colaide with Target");
            FindObjectOfType<TargetSpawner>().Spawn();
            FindObjectOfType<GameManager>().Score = FindObjectOfType<GameManager>().Score + Addscore;
            GameObject _Parcticle = Instantiate(ParcticlePrefab, this.gameObject.transform.position, Quaternion.identity);
            Destroy(_Parcticle, 1f);
            Destroy(this.gameObject);
        }
    }
}