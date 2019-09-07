using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public Text ScoreTxt;
    public Text Timertxt;
    public float Score;
    public bool Gamestart;
    public float FinishTime;

    //Vr ui
    public GameObject [] CountDownImages;
    public GameObject RestartButton;
    private AudioSource AudioSource;
    public GameObject GameoverImage;
    public Text VrUiScore;
    public Text VrUiTime;

    private void Awake()
    {

        //if (Instance == null)
        //{
        //    Instance = this;
        //}
        //else if (Instance != this)
        //{
        //    Destroy(gameObject);
        //}
        //DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        FindObjectOfType<BallSpawner>().enabled = false;
        FindObjectOfType<TargetSpawner>().enabled = false;
        Gamestart = false;
        RestartButton.SetActive(false);
        GameoverImage.SetActive(false);
        StartCoroutine(GameStart());
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamestart)
        {
            ScoreTxt.text = Mathf.Round(Score).ToString();
            VrUiScore.text = Mathf.Round(Score).ToString();
            FinishTime -= Time.deltaTime;
            Timertxt.text = Mathf.Round(FinishTime).ToString();
            VrUiTime.text = Mathf.Round(FinishTime).ToString();
            if (FinishTime <= 0)
            {
                GameOver();
            }
        }
    }
    void GameOver()
    {
        FindObjectOfType<BallSpawner>().enabled = false;
        FindObjectOfType<TargetSpawner>().enabled = false;
        FinishTime = 0;
        RestartButton.SetActive(true);
        GameoverImage.SetActive(true);
    }
    public IEnumerator GameStart()
    {
        yield return new WaitForSeconds(10f);
        for (int i = 0; i < CountDownImages.Length; i++)
        {
            CountDownImages[i].SetActive(true);
            yield return new WaitForSeconds(1f);
            CountDownImages[i].SetActive(false);
        }
        FindObjectOfType<BallSpawner>().enabled = true;
        FindObjectOfType<TargetSpawner>().enabled = true;
        Gamestart = true;
        AudioSource.Play();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Quitapp()
    {
        Application.Quit();
    }
}
