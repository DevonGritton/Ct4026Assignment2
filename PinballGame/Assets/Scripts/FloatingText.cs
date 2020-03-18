using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    public float DestroyTime = 1.5f;
    public Vector3 Offset = new Vector3(0, 70, 0);
    public Vector3 RandomPosition = new Vector3(20, 40, 0);
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyTime);
        transform.localPosition += Offset;
        transform.localPosition += new Vector3(Random.Range(RandomPosition.x, RandomPosition.y)
            , Random.Range(RandomPosition.y, RandomPosition.y),
            Random.Range(RandomPosition.z, RandomPosition.z));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
