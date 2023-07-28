using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class BG : MonoBehaviour
{
    public float speed;
    public Vector3 Pos ,StartPos;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Pos = transform.position;

        transform.position += Vector3.down * speed * Time.deltaTime;   

        
    }
}
