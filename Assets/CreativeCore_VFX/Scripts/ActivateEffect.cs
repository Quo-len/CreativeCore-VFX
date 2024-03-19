using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ActivateEffect : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.Space;

    private ParticleSystem fireParticle;
    public ParticleSystem activateParticle;
    public ParticleSystem deactivateParticle;

    bool isPlaying = true;
    // Start is called before the first frame update
    void Start()
    {
        fireParticle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if (isPlaying)
            {
                fireParticle.Stop();
                if (deactivateParticle != null)
                    deactivateParticle.Play();
                isPlaying = false;
            }
            else
            {
                fireParticle.Play();
                if (activateParticle != null)
                    activateParticle.Play();
                isPlaying = true;
            }
        }
    }
}
