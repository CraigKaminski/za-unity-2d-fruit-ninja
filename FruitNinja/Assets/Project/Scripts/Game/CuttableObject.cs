using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttableObject : MonoBehaviour {

    public bool harmful;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cut")
        {
            Destroy(gameObject);

            if (!harmful)
            {
                GameObject.Find("ScoreText").transform.GetComponent<ScoreText>().Score += 10;
            } else
            {

            }
        }
    }
}
