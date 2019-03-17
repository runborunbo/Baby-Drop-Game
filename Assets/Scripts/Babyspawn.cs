using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Babyspawn : MonoBehaviour {
    public Camera cam;
    public GameObject baby;
    private Renderer babyRenderer;
    private float maxWidth;

    // Start is called before the first frame update
    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }
        Vector3 upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        float babyWidth = babyRenderer.bounds.extents.x; 
        maxWidth = targetWidth.x - babyWidth;
        StartCoroutine (Spawn());
    }
    IEnumerator Spawn ()
    {
        yield return new WaitForSeconds (2.0f);
        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(-maxWidth, maxWidth),
                transform.position.y,
                0.0f
                );
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(baby, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
