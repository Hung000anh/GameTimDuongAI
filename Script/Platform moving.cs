using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformmoving : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private GameObject[] waypoints;
    private int currentwaypoint = 0;

    private void Start()
    {
        
    }

    private void Update()
    {
        //distance sẽ tính khoảng cách ví du ví trí nhân vật cần tới là A9 [1] -> [0]
        if (Vector2.Distance(transform.position,waypoints[currentwaypoint].transform.position) < 0.1f)
        {
            currentwaypoint++;
            if (currentwaypoint >= waypoints.Length)
            {
                currentwaypoint = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentwaypoint].transform.position, speed * Time.deltaTime);
    }
}
