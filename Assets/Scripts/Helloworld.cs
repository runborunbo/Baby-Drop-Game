using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helloworld : MonoBehaviour
{
    [Range(0, 10)]
    public int playerHealth;
    public List<string> playerNames;

    private bool playerhasdied = false;

    // Start is called before the first frame update
    void Start()
    {
        playerNames.RemoveAt(0);

    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth == 0 && !playerhasdied){
            print("dead");
        playerhasdied = true;
    }

        else if (playerHealth <= 3 && playerHealth > 1)
        print ($"you have only {playerHealth} health remaining");
        playerhasdied = false;
    }
}
