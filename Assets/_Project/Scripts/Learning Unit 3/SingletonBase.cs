using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class SingletonBase<T> : MonoBehaviour where T : MonoBehaviour

{

    private static T _instance;
        


    public static T Instance

    {

        get { return _instance; }

        set => _instance = value;

    }



    public virtual void Awake()

    {

        if (_instance != null && _instance != this)

        {

            Destroy(gameObject);

            return;

        }



        DontDestroyOnLoad(gameObject);

    }

}
