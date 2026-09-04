using UnityEngine;

// Script de movimentação simples para o Player.
// Anexe este script ao GameObject do Player (que deve ter Rigidbody2D + Collider2D).
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Movimento")]
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Lê o input horizontal e vertical (WASD ou setas)
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        // Normaliza para não mover mais rápido na diagonal
        if (moveInput.sqrMagnitude > 1f)
        {
            moveInput.Normalize();
        }
    }

    private void FixedUpdate()
    {
        // Aplica a movimentação via física, no FixedUpdate
        rb.linearVelocity = moveInput * moveSpeed;
    }
}
