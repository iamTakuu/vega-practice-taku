using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    #region VARIABLES

    [Header("Speed Properties")]
    public float HorizontalInput = 0f;
    //public bool IsFacingRight = true;
    [SerializeField]
    private float YetiSpeed = 10;

    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private SpriteRenderer _renderer;

    private readonly Vector3 _facingRotation = new Vector3(0f, 180f, 0f);

    #endregion

    #region UNITY-METHODS

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        if (_renderer == null)
        {
            Debug.LogError("Sprite is missing a renderer");
        }
    }
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    void Update()
    // Update is called once per frame
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");

        //Flipping the sprite based on direction moving.
        if (HorizontalInput > 0f)
        {
            _renderer.flipX = false;
        }else if(HorizontalInput < 0f)
        {
            _renderer.flipX = true;
        }
    }

    private void FixedUpdate()
    {
        Move();
    }
    private void LateUpdate()
    {
        _animator.SetBool("isMoving", HorizontalInput != 0f);
    }



    #endregion

    #region METHODS
    private void Move()
    {
        _rigidbody2D.velocity = new Vector2(YetiSpeed * HorizontalInput, _rigidbody2D.velocity.y);
    }
    

    #endregion

}
