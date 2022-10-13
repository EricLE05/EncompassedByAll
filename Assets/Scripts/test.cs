using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : Task
{
    [SerializeField]
    ClickGamePanel gamePanel;

    protected override void OnStart()
    {

    }

    public override void OnInteract()
    {
        SetAsResolved();
    }
}
