using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public Transform Player;
    public GameObject BallPrefab;
    public Transform SpawnPoint;
    public float WaitTime = 3f;
    private float _Time = 0;
    public float BallSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _Time)
        {
            _Time = Time.time + WaitTime;
            Debug.Log("Itz Time");
            GameObject _Ball = Instantiate(BallPrefab, SpawnPoint.position, Quaternion.identity);
            Rigidbody Rb = _Ball.GetComponent<Rigidbody>();
           // _Ball.transform.LookAt(Player);
            Rb.velocity = Vector3.back * BallSpeed;
            //_Ball.transform.Translate(Vector3.forward * BallSpeed * Time.deltaTime);
            Destroy(_Ball, 3f);
        }
        
    }
}
