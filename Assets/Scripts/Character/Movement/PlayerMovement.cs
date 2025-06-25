using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;

    private Vector2 _inputDirection;

    public void Move(InputAction.CallbackContext context)
    {
        // vector2是二维向量的意思, var 约等于auto
        _inputDirection =  context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        var position = (Vector2)transform.position;
        var targetPosition = position + _inputDirection;

        // 防止到达目标位置以后，继续调用rb.DOMove发生抖动
        if (position == targetPosition) return;

        rb.DOMove(targetPosition, speed).SetSpeedBased();
    }
}
