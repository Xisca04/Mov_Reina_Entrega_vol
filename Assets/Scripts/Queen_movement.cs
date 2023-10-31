using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Queen_movement : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    private Direction gridMoveDirection;
    private Vector2Int gridPosition;

    private enum Direction
    {
        Left,
        Right,
        Down,
        Up
    }

    private void Update()
    {
        MoveDirection();
    }

    private void MoveDirection()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        // UP
        if (verticalInput > 0) 
        {
            if (gridMoveDirection != Direction.Down) 
            {
                gridMoveDirection = Direction.Up;
            }
        }

        // DOWN
        if (verticalInput < 0)
        {
            if (gridMoveDirection != Direction.Up)
            {
                gridMoveDirection = Direction.Down;
            }
        }

        // RIGHT
        if (horizontalInput > 0)
        {
            if (gridMoveDirection != Direction.Left)
            {
                gridMoveDirection = Direction.Right;
            }
        }

        // LEFT
        if (horizontalInput < 0)
        {
            if (gridMoveDirection != Direction.Right)
            {
                gridMoveDirection = Direction.Left;
            }
        }

        // RIGHT-UP
        // RIGHT-DOWN
        // LEFT-UP
        // LEFT-DOWN
 
    }

    private void HandleGridMovement() // Relativo al movimiento S
    {
       Vector2Int gridMoveDirectionVector;
       switch (gridMoveDirection)
        {
         default:
           case Direction.Left:
           gridMoveDirectionVector = new Vector2Int(-1, 0);
           break;
           case Direction.Right:
           gridMoveDirectionVector = new Vector2Int(1, 0);
           break;
           case Direction.Down:
           gridMoveDirectionVector = new Vector2Int(0, -1);
           break;
           case Direction.Up:
           gridMoveDirectionVector = new Vector2Int(0, 1);
           break;
            }

            gridPosition += gridMoveDirectionVector; // Mueve la posición 2D de la cabeza de la serpiente
            // gridPosition = ValidateGridPosition();

        transform.position = new Vector3(gridPosition.x, gridPosition.y, 0);
    
    }

    private void ValidateGridPosition()
    {
        
    }

}

