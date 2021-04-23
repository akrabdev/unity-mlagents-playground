using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Instantiate(player, new Vector3(x, 1, z), Quaternion.identity);


    }

    // no need to update

}
