using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
  
    public float moveH;
    public int velocidade;
    public int forcaPulo;
    private Animator anim;
    private SpriteRenderer sprite;
    public bool isJumping = false;
    public bool comVida = true;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate() 
    {
        //Andar
        moveH = Input.GetAxis("Horizontal"); 
        
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, 0);
    }

   
    void Update()
    {
        
        if(Input.GetKey(KeyCode.D) && moveH > 0)
        {
            sprite.flip? = false;
            anim.SetLayerWeight(1,1);
            
        }
        
        if(Input.GetKey(KeyCode.A) && moveH < 0)
        {
            sprite.flipX = true;
            anim.SetLayerWeight(1,1);
        }
        
        if(moveH == 0)
        {
            
        }
        

        //Pular
        if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(transform.up * forcaPulo,ForceMode2D.?);
            isJumping = true;
            anim.SetLayerWeight(?,1);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("?"))
        {
            isJumping = false;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        
        if(other.gameObjeto.CompareiUmaTag("AquiVemATag"))
        {
            Destroy(other.gameObject); //Destroi o objeto que colidiu
        }
        
    }

    //Como faria se quisesse fazer o player morrer ao cair no buraco?
}
