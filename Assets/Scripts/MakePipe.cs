using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Pipe;

    public float TimeDiff;

    float timer = 0;

    void Start()
    {
        timer = TimeDiff;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > TimeDiff)
        {
            GameObject newPipe = Instantiate(Pipe);
            newPipe.transform.position = new Vector3(3.94f, Random.Range(1.76f, 6.19f), 0);
            timer = 0;
        }
        
    }
}
