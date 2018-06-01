using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public delegate void ObjectSpawnedHandler(CuttableObject obj);
    public event ObjectSpawnedHandler OnObjectSpawned;

    [Header("Targer")]
    public GameObject prefab;

    [Header("Gameplay")]
    public float interval;
    public float minimumX;
    public float maximumX;
    public float y;

    [Header("Visuals")]
    public Sprite[] sprites;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", interval, interval);
    }

    private void Spawn()
    {
        // Instantiate and position the object.
        GameObject instance = Instantiate(prefab);
        instance.transform.SetParent(transform);
        instance.transform.position = new Vector2(
            Random.Range(minimumX, maximumX),
            y
        );

        if (OnObjectSpawned != null)
        {
            OnObjectSpawned(instance.GetComponent<CuttableObject>());
        }

        // Set a random sprite.
        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        instance.GetComponent<SpriteRenderer>().sprite = randomSprite;
    }
}
