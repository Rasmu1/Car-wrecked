using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 firingPoint;

    [SerializeField]
    float projectileSpeed;

    [SerializeField]
    float maxProjectileDistance;

    // Start is called before the first frame update
    void Start()
    {
        firingPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveProjectile();
    }

    void MoveProjectile()
    {
        if (Vector3.Distance(firingPoint, transform.position) > maxProjectileDistance)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.CompareTag("Enemy"))
        {
            collision.transform.gameObject.GetComponent<FollowAI>().knock();
            EnemyHit();
        }

    }
    void EnemyHit()
    {
        //Destroy(this.gameObject);
    }
}
