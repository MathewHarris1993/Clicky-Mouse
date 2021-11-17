using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //attach gameObject prefabs
    public List<GameObject> targets;


    //set spawn rate
    private float spawnRate = 1;


    // Start is called before the first frame update
    void Start()
    {
        //spawn the targets
        StartCoroutine(SpawnTarget());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //create ability to spawn targets
    IEnumerator SpawnTarget()
    {
        while(true)
        {

            //time between spawns
            yield return new WaitForSeconds(spawnRate);

            //create index to allow random object spawm
            int index = Random.Range(0, targets.Count);

            //selects random target
            Instantiate(targets[index]);

        }

    }
}
