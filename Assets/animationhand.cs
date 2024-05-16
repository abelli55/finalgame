using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class animetionhand : MonoBehaviour
{
    public InputActionProperty gripanimationaction;
    public Animator handanimator;

    void Start()
    {

    }

    void Update()
    {

        float gripValue = gripanimationaction.action.ReadValue<float>();
        handanimator.SetFloat("Grip", gripValue);
    }
}
