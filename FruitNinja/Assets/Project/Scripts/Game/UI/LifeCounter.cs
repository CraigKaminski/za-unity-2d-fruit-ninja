using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            scoreText.SetActive(false);
            Debug.Log("Game over!");
        }
    }
}
