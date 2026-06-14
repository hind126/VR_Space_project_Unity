using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeepSpace
{
    public class DSGates : MonoBehaviour
    {
        public string AnimationOpen;
        public string AnimationClose;
        public AudioSource doorSound;
        public enum StartStates
        {
            opened = 0,
            closed = 1,
        }
        public StartStates StartState = StartStates.closed;
        bool CurrentState;

        // Use this for initialization
        void Start()
        {
            if (StartState == StartStates.closed)
            {
                GetComponent<Animation>().Play(AnimationClose);
                doorSound.Play();
                CurrentState = true;
            }
            else
            {
                GetComponent<Animation>().Play(AnimationOpen);
                doorSound.Play();
                CurrentState = false;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void StartOpenClose()
        {
            if (!GetComponent<Animation>().isPlaying)
            {
                CurrentState = !CurrentState;
            }
            else
            {
                return;
            }

            if (CurrentState)
            {
                if (!GetComponent<Animation>().isPlaying)
                {
                    GetComponent<Animation>().Play(AnimationClose);
                    doorSound.Play();
                }
            }
            else
            {
                if (!GetComponent<Animation>().isPlaying)
                {
                    GetComponent<Animation>().Play(AnimationOpen);
                    doorSound.Play();
                }
            }
        }
    }
}
