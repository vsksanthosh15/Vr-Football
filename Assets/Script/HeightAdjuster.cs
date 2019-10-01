using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeightAdjuster : MonoBehaviour
{
    public GameObject Slider;
    private int i;
    private Vector3 Pos;
    // Start is called before the first frame update
    void Start()
    {
        Pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (i == 0)
            {
                i++;
                Slider.SetActive(true);
            }
            else if (i == 1)
            {
                i--;
                Slider.SetActive(false);
            }
        }
        
        Pos.y = Slider.GetComponent<Slider>().value;
        transform.position = Pos;
    }
}
