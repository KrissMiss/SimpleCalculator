using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject mainCalc;
    [SerializeField] private GameObject firstCalc;
    [SerializeField] private GameObject secondCalc;
    [SerializeField] private GameObject thirdCalc;
    [SerializeField] private GameObject fourthCalc;

    private GameObject currentCalc;

    private void Start()
    {
        mainCalc.SetActive(true);
        currentCalc = mainCalc;
    }

    public void ChangeState (GameObject state)
    {
        currentCalc.SetActive(false);
        currentCalc = state;
        currentCalc.SetActive(true);
    }
}
