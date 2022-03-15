using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLifetime : MonoBehaviour
{

    public float LifeTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(DestroyAfterLifetime), LifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DestroyAfterLifetime() 
    {
        Debug.Log(gameObject.name);
        Destroy(gameObject);
    }
}
