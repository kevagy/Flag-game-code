using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    [System.Serializable]
    public struct CounryData
    {
        public string Name;
        public Sprite Flag;
        public bool Guessed; //whenever the country has been guessed
        public bool BeenQuestioned;
    }

    public CounryData[] WorldCountryDataSet;

    [HideInInspector]
    public CounryData[] CountrySetPerGame;
    [HideInInspector]
    public CounryData[] CountryDataSet;

    public static GameData Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
            Destroy(this);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AssignArrayOfCountry()
    {
        CountryDataSet = new CounryData[WorldCountryDataSet.Length];
        WorldCountryDataSet.CopyTo(CountryDataSet, 0);

    }
}
