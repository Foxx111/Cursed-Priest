using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{

    float timeBetweenBulletsFire = 0.2f;
    int damageAmt = 30;
    LineRenderer lineRenderer;
    public GameObject gunBarrel;
    Light glowLight;
    AudioSource gunSoundSource;
    Ray ray;
    RaycastHit hit;
    public LayerMask enemylayer;
    public LayerMask groundLayer;
    int rayLength = 100;
    float timer;
    public ParticleSystem ps;
    Animator gunAnimator;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        gunSoundSource = GetComponent<AudioSource>();
        glowLight = GetComponent<Light>();
        ps = GetComponent<ParticleSystem>();
        gunAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
        if (timer > 0.04)
        {
            glowLight.enabled = false;
            lineRenderer.enabled = false;
        }
        if(Physics.Raycast(ray, out hit, rayLength, groundLayer))
        {
            Debug.Log(hit.distance);
            if(hit.distance < 2f)
            {
                gunAnimator.SetBool("isTouching", true);
            }
            else
            {
                gunAnimator.SetBool("isTouching", false);
            }
        }
    }

    void Shoot()
    {

        if (timer >= timeBetweenBulletsFire)
        {
            ray.origin = transform.position;
            ray.direction = transform.forward;
            lineRenderer.SetPosition(0, ray.origin);
            glowLight.enabled = true;
            lineRenderer.enabled = true;
            gunSoundSource.Play();
            if (Physics.Raycast(ray, out hit, rayLength, enemylayer))
            {
                Debug.Log("Enemy hit");
                //enemyHealthScript = hit.collider.GetComponent<EnemyHealthScript>();
                lineRenderer.SetPosition(1, hit.point);
                ps.Play();
                //enemyHealthScript.EnemyTakeDamage(damageAmt);

            }
            else
            {
                lineRenderer.SetPosition(1, ray.origin + ray.direction * 100);
            }
            timer = 0;

        }

    }






}
