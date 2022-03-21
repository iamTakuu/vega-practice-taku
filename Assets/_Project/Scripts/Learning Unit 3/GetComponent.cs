using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponent : MonoBehaviour
{
    [SerializeField]
    private Transform _parentTransform;
    [SerializeField]
    private SpriteRenderer _firstChildSpriteRenderer;
    public SpriteRenderer[] ChildrenSpriteRenderers;

    //Copied Ubaid's code lmao
    private void Awake()
    {
        // Get Parent Object Transform
        _parentTransform = GetComponentInParent<Transform>();

        // Get Sprite Renderer of the First Child (Only Gets the First Childs Sprite Renderer even if there are many other children)
        _firstChildSpriteRenderer = GetComponentInChildren<SpriteRenderer>();

        // Get All the Sprite Renderers attached to each Child Object
        ChildrenSpriteRenderers = GetComponentsInChildren<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
