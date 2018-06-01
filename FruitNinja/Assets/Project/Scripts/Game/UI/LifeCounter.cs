using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeCounter : MonoBehaviour {

    [Header("Gameplaye")]
    public int numberOfLives;

    [Header("Visuals")]
    public GameObject lifePrefab;
    public GameObject scoreText;
    public GameObject gameOverGroup;

    private List<GameObject> lives;

	// Use this for initialization
	void Start () {
        gameOverGroup.SetActive(false);

        lives = new List<GameObject>();
        for (int i = 0; i < numberOfLives; i++)
        {
            GameObject lifeInstance = Instantiate(lifePrefab, transform);
            lives.Add(lifeInstance);
        }
	}
	
    public void LoseLife()
    {
        numberOfLives--;

        GameObject lastLife = lives[lives.Count - 1];
        lives.Remove(lastLife);

        Destroy(lastLife);

        if (numberOfLives <= 0)
        {
            gameOverGroup.SetActive(true);
            Text gameOverText = gameOverGroup.GetComponentInChildren<Text>();
            int score = GameObject.Find("ScoreText").GetComponent<ScoreText>().Score;
            gameOverText.text = string.Format(gameOverText.text, score);
            scoreText.SetActive(false);
        }
    }

    private void Update()
    {
        if (numberOfLives <= 0 && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Title");
        }
    }
}
