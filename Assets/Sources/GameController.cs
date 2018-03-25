using System.Collections;
using System.Collections.Generic;
using Entitas;
using NUnit.Framework.Constraints;
using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour
{
    private Systems _systems;

    private Contexts _contexts;


    void Start()
    {
        _contexts = Contexts.sharedInstance;

        _systems = new Feature("Systems").Add(new TestSystem(_contexts));

        var e = _contexts.game.CreateEntity();
        e.isTest = true;
    }

    void Update()
    {
        _systems.Execute();
    }
}
