using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class crib_controller : MonoBehaviour
{
    public Camera cam;
  
    private float maxWidth;
    private Renderer cribRenderer;
   
    // Start is called before the first frame update
    void Start()
    {
        cribRenderer = GetComponent<Renderer>();
        if (cam == null)
        {
            cam = Camera.main;
        }
        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        float cribWidth = cribRenderer.bounds.extents.x;
        maxWidth = targetWidth.x - cribWidth;

    

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 targetPosition = new Vector3 (rawPosition.x, -3.5f, 0.0f);
        float targetWidth = Mathf.Clamp(targetPosition.x, -maxWidth, maxWidth);
        targetPosition = new Vector3 (targetWidth, targetPosition.y, targetPosition.z);
        transform.position = targetPosition;

    }
    void OnCollisionEnter(Collision coll)
    {
        // Find out what hit this basket
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "baby")
        {
            

            
        }
    }
}

