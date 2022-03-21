using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiationExample : MonoBehaviour
{

    public GameObject YetiPrefab;

    //public GameObject[] YetiPrefabs;
    public List<GameObject> YetiPrefabs = new List<GameObject>();

    public Transform YetiParent;

    public Vector2 StartPosition = new Vector2(x: 5, y: 5);

    public GameObject MyYetiClone;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Yeti Prefabs Count - {YetiPrefabs.Count}");

        for (int i = 0; i < YetiPrefabs.Count; i++)
        {
            Instantiate(YetiPrefabs[i], new Vector3(x: Random.Range(-5, 5), y: Random.Range(-5, 5)), Quaternion.identity, YetiParent);
        }
        MyYetiClone = Instantiate(YetiPrefab, StartPosition, Quaternion.identity, YetiParent);
    }

    // Update is called once per frame
    void Update()
    {
        bool spaceButtonPressed = Input.GetKeyDown(KeyCode.Space);
        if (spaceButtonPressed)
        {
            Instantiate(YetiPrefabs[Random.Range(0, YetiPrefabs.Count)], new Vector3(x:Random.Range(-5,5), y:Random.Range(-5, 5)), Quaternion.identity, YetiParent);
        }
    }
}
