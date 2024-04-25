using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Aiaim : MonoBehaviour
{
    public Transform Player;

    
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);
    }
}
