using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    [SerializeField]
    private BatCubeFollowers _BatCubeFollowers;


    //spawn bat inside cube for physics
    private void SpawnBatCubeFollower()
    {
        var follower = Instantiate(_BatCubeFollowers);
        follower.transform.position = transform.position;
        follower.SetFollowTarget(this);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnBatCubeFollower();
    }

    // Update is called once per frame
    void Update()
    {
       // Vector3 _vel = OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch);
       // Debug.Log(_vel);
    }
    public void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Ball"))
        //{
        //    OVRHaptics.Channels[1].Preempt(new OVRHapticsClip());
        //}
    }
}
