using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRenderer;


    private void Awake()
    {
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        ChangeToRandomColor();
    }

    private void ChangeToRandomColor()
    {
        _spriteRenderer.color = Random.ColorHSV();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
