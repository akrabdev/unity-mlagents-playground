using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.AI;

public class PlayerSpawn : MonoBehaviour
{
    const int xmin = -20;
    const int xmax = 20;
    const int zmin = -20;
    const int zmax = 20;
    public GameObject player;
    public int x;
    public int z;

    // Start is called before the first frame update
    void Start()
    {
        
        x = Random.Range(xmin, xmax + 1);
        z = Random.Range(zmin, zmax + 1);
        Instantiate(player, new Vector3((float)x, 1.15f, (float)z), Quaternion.identity);
       


    }

    // no need to update

}
