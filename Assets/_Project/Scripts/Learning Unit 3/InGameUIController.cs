using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class InGameUIController : MonoBehaviour

{

    #region VARIABLES
    public static InGameUIController Instance;
    public TMP_Text ScoreText;

    #endregion



    #region UNITY METHODS



    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        //Refer instance as itself
        Instance = this;


        //Dont destroy on diff scenbese
        DontDestroyOnLoad(gameObject);
    }



    #endregion



    #region METHODS



    public void UpdateScoreText(string value)
    {
        ScoreText.SetText($"Score : {value}");
    }



    #endregion

}
