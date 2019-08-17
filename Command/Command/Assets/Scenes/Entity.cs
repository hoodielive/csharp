using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputReader))]
[RequireComponent(typeof(CommandProcessor))]

public class Entity : MonoBehaviour, IEntity
{
    private InputReader _inputreader;
    private CommandProcessor _commandprocessor;

    private void Awake()
    {
        _inputreader = GetComponent<InputReader>();
        _commandprocessor = GetComponent<CommandProcessor>(); 
    }

    private void Update()
    {
        var direction = _inputreader.ReadInput(); 
        if (direction != vector3.zero)
        {
            var moveCommand = new MoveCommand(this, direction);
            _commandprocessor.ExecuteCommand(moveCommand); 
        }
    }

    void Start()
    {
        
    }

}
