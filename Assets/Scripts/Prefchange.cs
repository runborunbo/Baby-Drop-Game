using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefchange : MonoBehaviour
{
    public void changemenuscene(string UI)
    {
        Application.LoadLevel(UI);
    }
}
