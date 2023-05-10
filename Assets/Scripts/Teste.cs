using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Teste : MonoBehaviour
{

  public GameObject bulletPrefab;
  public GameObject estora;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float fireRate = 0.5f;
    private float nextFireTime = 0f;
    Animator an;
    //aula
    public Transform _transform;
    public Transform camera;
    Vector2 rotacaoMouse;
    public int sensibilidade;
    public GameObject Item_Particula;
    public GameObject Inimigo;
    public NivelControle Nivel_Controle;
 
//help
    public float playerSpeed = 10f;
    public Rigidbody playerRb;
    public float horizontalMovement;
    public float playerJump = 5f;

    public GameObject bombPrefab;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        an = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(0, 0, horizontalMovement);
        playerRb.velocity = new Vector3((horizontalMovement * playerSpeed), playerRb.velocity.y, playerRb.velocity.z);
    
        if(horizontalMovement != 0)
        {
            an.SetBool("run",true);
        }else{an.SetBool("run",false);}

    

        if(direction != Vector3.zero)
        {
            transform.LookAt(transform.position + direction);
            transform.rotation = Quaternion.LookRotation(direction);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector2.up * playerJump);
        }

        if(Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(bombPrefab, transform.position, Quaternion.identity);
        }

          if (Input.GetKeyDown(KeyCode.Z) && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            Shoot();
        }

    }
    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
    bulletRb.velocity = transform.up * bulletSpeed;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            // Carrega a próxima cena
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

private void OnTriggerEnter(Collider other) {
     if (other.gameObject.CompareTag("Jogador")) {
       Instantiate(estora, other.gameObject.transform.position, Quaternion.identity);
       Destroy(other.gameObject);
     }
   

}
 }

        

