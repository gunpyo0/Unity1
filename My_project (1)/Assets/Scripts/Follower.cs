using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public float maxShotDealy;
    public float curShotDelay;
    public GameObject bulletObjA;

    void Update()
    {
        Follow();
        Fire();
        Reload();

    }

    void Follow()
    {

    }

    void Fire()
    {
        if (!Input.GetButton("Fire1"))
            return;
        if (curShotDelay < maxShotDealy)
            return;

        GameObject bullet = objectManager.MakeObj("BulletPlayerA");
        bullet.transform.position = transform.position;

        Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
        rigid.AddForce(Vector2.up * 10, ForceMode2D.Impulse);


        curShotDelay = 0;
    }
}
