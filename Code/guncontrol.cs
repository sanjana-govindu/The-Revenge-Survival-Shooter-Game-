/*
 * Gun Control Script
 * 
 * Manages gun shooting mechanics, animations, audio, particle effects, and score tracking.
 * Uses raycast for hit detection. Awards 5 points per enemy kill. Win at 120 points.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guncontrol : MonoBehaviour
{
    public int score;
    public Animator gunAnimator;
    public AudioSource gunaudio;
    public GameObject particle;
    
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        // Win condition - freeze game at 120 points
        if(score == 120)
        {
            Time.timeScale = 0;
        }
        
        RaycastHit raycastHit;
        
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Fire");
            
            if (!gunAnimator.isActiveAndEnabled)
            {
                gunAnimator.enabled = true;
            }
            if (!gunaudio.isPlaying)
            {
                gunaudio.Play();
            }
            particle.SetActive(true);
            
            // Raycast from camera forward, range 200 units
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out raycastHit, 200))
            {
                if (raycastHit.collider.gameObject.tag == "enemy")
                {
                    Debug.Log("Hit Enemy");
                    score = score + 5;
                    Destroy((GameObject)raycastHit.collider.gameObject);
                }
                else
                {
                    Debug.Log("Not enemy");
                }
            }
        }
        else
        {
            if (gunAnimator.isActiveAndEnabled)
            {
                gunAnimator.enabled = false;
            }
            if (gunaudio.isPlaying)
            {
                gunaudio.Stop();
            }
            particle.SetActive(false);
        }
    }
}
