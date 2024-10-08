using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField]
    Transform firingPoint;

    [SerializeField]
    GameObject projectilePrefab;

    [SerializeField]
    GameObject projectilePrefab2;

    [SerializeField]
    float firingSpeed;

    [SerializeField]
    float firingSpeed2;

    public static PlayerGun Instance;

    private float lastTimeShot = 0;

    private void Awake()
    {
        Instance = GetComponent<PlayerGun>();
    }

    public void Shoot()
    {
        if (lastTimeShot + firingSpeed <= Time.time)
        {
            lastTimeShot = Time.time;
            Instantiate(projectilePrefab, firingPoint.position, firingPoint.rotation);
        }
    }

    public void Shoot2()
    {
        if (lastTimeShot + firingSpeed2 <= Time.time)
        {
            lastTimeShot = Time.time;
            Instantiate(projectilePrefab2, firingPoint.position, firingPoint.rotation);
        }
    }
}
