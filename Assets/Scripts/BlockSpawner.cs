using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject blockToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(blockToSpawn, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
