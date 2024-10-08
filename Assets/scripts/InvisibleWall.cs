using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleWall : MonoBehaviour
{
    public ScoreManager score;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.CompareTag("Enemy"))
        {
            score.AddScore(1);
            collision.transform.gameObject.GetComponent<FollowAI>().dead();
        }

        if (collision.transform.gameObject.CompareTag("Player"))
        {
            collision.transform.gameObject.GetComponent<TopDownCharacterMover>().dead();
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
