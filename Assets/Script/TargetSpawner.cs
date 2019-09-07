using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject[] TargetPrefab;
    public float MinX, MaxX, MinY, Maxy, Zpos;
    public AudioSource AudioSourc;
    public GameObject ParcticlePrefab;
    public int i;

    private void Awake()
    {
        AudioSourc = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        AudioSourc = this.GetComponent<AudioSource>();
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spawn()
    {
        if (FindObjectOfType<GameManager>().FinishTime > 75f)
        {
            Debug.Log("Spawn Large Targe");
            i = 0;
        }
        else if (FindObjectOfType<GameManager>().FinishTime > 45f  && FindObjectOfType<GameManager>().FinishTime < 75f)
        {
            Debug.Log("Spawn medium Target");
            i = 1;
        }
        else if (FindObjectOfType<GameManager>().FinishTime < 45f && FindObjectOfType<GameManager>().FinishTime > 0)
        {
            Debug.Log("Spawn Small Targe");
            i = 2;
        }
        float Xpos = Random.Range(MinX, MaxX);
        float Ypos = Random.Range(MinY, Maxy);
        GameObject _target = Instantiate(TargetPrefab[i], new Vector3(Xpos, Ypos, Zpos), Quaternion.identity);
        //_target.AddComponent<Target>();
        //FindObjectOfType<Target>().ParcticlePrefab = ParcticlePrefab;
        AudioSourc.Play();
    }
}
