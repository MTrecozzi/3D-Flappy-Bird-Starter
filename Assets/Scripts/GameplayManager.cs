using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameplayManager : MonoBehaviour
{

    #region
    public int score = 0;

    public GameObject spawnPrefab;
    public Transform spawnPosition;

    public float spawnInterval;
    public float t = 0;

    public float resetTime;
    public bool DebugMode;

    public AudioSource coinSound;

    #endregion

    public TextMeshProUGUI scoreText;
    public PillarPool pool; // set this in inspector
    public bool paused = true;



    // Start is called before the first frame update
    void Start()
    {
    
    }

    public void AddScore()
    {
        score = score + 1;
        scoreText.text = "Score: " + score;
        coinSound.Play();
    }

    // instead calling reload, turn their reload interval into 0 seconds

    public void ResetGame()
    {

        if (DebugMode)
        {
            return;
        }

        Invoke("Reload", resetTime);

        // Manage State

        // Wait a Few Seconds

        // Reload

        // Reset the game after a few seconds
    }

    private void Reload()
    {
        SceneManager.LoadScene(0);
    }


    public void SpawnPillar()
    {
        // spawn a prefab at a certain position

        // spawns the spawnPrefab reference

        // generate a random number
        float offset = Random.Range(-2f, 2f);

        // create a new position = our referenced transform
        Vector3 finalPosition = spawnPosition.position;

        // change new positions y to have offset
        finalPosition.y = finalPosition.y + offset;


        //var newPillar = PillarManager.GetPillar(); // ask the pool for a pillar with high performance

        // new pillar to our final position

        // new Pillar = pool.GetGameObject();

        //newPillar.transform.position = set position right;

        // get a gameobject from the pool, then set its position equal to desired position
        GameObject pillarFromPool = pool.GetGameObject();
        pillarFromPool.transform.position = finalPosition;


        //Instantiate(spawnPrefab, finalPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (paused)
        {
            return;
        }

        // every so or so seconds, spawn a pillar

        t = t + Time.deltaTime;

        if (t > spawnInterval)
        {
            SpawnPillar();
            t = 0;
        }
    }
}
