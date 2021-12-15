using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataGame : MonoBehaviour
{
    [System.Serializable]
    public struct CountryData
    {
        public string Name;
        public Sprite Flag;
        public bool Guessed; //whenever the country has been guessed
        public bool BeenQuestioned;
    }

    public CountryData[] WorldCountryDataSet;

    [HideInInspector]
    public CountryData[] CountrySetPerGame;
    [HideInInspector]
    public CountryData[] CountryDataSet;

    public static DataGame Instance;

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
        CountryDataSet = new CountryData[WorldCountryDataSet.Length];
        WorldCountryDataSet.CopyTo(CountryDataSet, 0);

    }
}
