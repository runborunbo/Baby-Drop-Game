using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BabyPicker : MonoBehaviour
{
    public GameObject cribPrefab;
    public int numCribs = 3;
    public float cribBottomY = -4f;
    public float cribSpacingY = 2f;
    public List<GameObject> cribList;
    // Start is called before the first frame update
    void Start()
    {
        cribList = new List<GameObject>();
        for (int i = 0; i < numCribs; i++)
        {
            
            GameObject tCribGO = Instantiate<GameObject>(cribPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = cribBottomY + (cribSpacingY * i);
            tCribGO.transform.position = pos;
            cribList.Add(tCribGO);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BabyDestroyed()
    {                                           
        // Destroy all of the falling babies
        GameObject[] tBabyArray = GameObject.FindGameObjectsWithTag("baby");
        foreach (GameObject tGO in tBabyArray)
        {
            Destroy(tGO);
           
        }
        int cribIndex = cribList.Count - 1;

        GameObject tCribGO = cribList[cribIndex];

        cribList.RemoveAt(cribIndex);
        Destroy(tCribGO);

        if (cribList.Count == 0)
        {
            SceneManager.LoadScene("Scenes/End");                              
        }

    }
}


    

