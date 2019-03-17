using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour

{
    public float speed = 1f;
    public GameObject babyPrefab;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirections = 0.01f;
    public float secondsBetweenBabyDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropBaby", 2f);
    }
    void DropBaby()
    {
        GameObject baby = Instantiate<GameObject>(babyPrefab);
        baby.transform.position = transform.position;
        Invoke("DropBaby", secondsBetweenBabyDrops);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
      

    }
    void FixedUpdate()
    {
        
        if (Random.value < chanceToChangeDirections)
        {                     
            speed *= -1; // Change direction
        }
    }
    }
