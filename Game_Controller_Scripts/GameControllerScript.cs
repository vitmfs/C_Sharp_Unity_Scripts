using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControllerScript : MonoBehaviour
{

    public static int score;
    // CREATE THE HAZARDS
    public GameObject hazard;

    public Vector3 spawnValues;

    public int      hazardCount;
    public float    spawnWait;
    public float    startWait;
    public float    waveWait;

    private Text     scoreText;
    //public int      score;


    void Start()
    {
        score = 0;
        //UpdateScore();

        StartCoroutine( SpawnWaves() );

        scoreText = GameObject.Find("score_text").GetComponent<Text>();
    }


    // THIS FUNCTION HAS TO BECOME A CO-ROUTINE OR IT WILL PAUSE THE WHOLE GAME
    // IT HAS TO RETURN A IENUMERATOR
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds( startWait );

        while ( true )
        {
            for ( int i = 0; i < hazardCount; i++ )
            {
                Vector3 spawnPosition = new Vector3( Random.Range( -spawnValues.x, spawnValues.x ), spawnValues.y, spawnValues.z );
                Quaternion spawnRotation = Quaternion.identity;

                Instantiate(hazard, spawnPosition, spawnRotation);

                yield return new WaitForSeconds( spawnWait );
            }

            yield return new WaitForSeconds( waveWait );

        }

    }

    /*
    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }


    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();

    }
    */


}
