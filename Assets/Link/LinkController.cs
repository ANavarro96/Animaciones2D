using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkController : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Cogemos el input
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");

        // Aplicamos la velocidad
        Vector2 velocidadFinal = new Vector2(movX,movY) * velocidad;
        rb.velocity = velocidadFinal;

        // Si nos movemos hacia la izquierda, espejo el sprite.
        if (movX < 0)
        {
            spriteRenderer.flipX = true;
        }
        // Lo pongo normal si miramos hacia la derecha
        else if (movX > 0)
        {
            spriteRenderer.flipX = false;
        }

        // TODO: ESTABLECER LAS ANIMACIONES
    }
}
