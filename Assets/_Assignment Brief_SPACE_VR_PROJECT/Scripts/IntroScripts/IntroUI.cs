using System.Collections;
using TMPro;
    using UnityEngine;

    public class UIElements : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI[] texts;
        [SerializeField] AudioSource textSound;
        float displayTime=3f;
        void Start()
        {
            StartCoroutine(PlayTexts());
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        IEnumerator PlayTexts()
        {
            for(int i = 0; i < texts.Length; i++)
            {
                texts[i].gameObject.SetActive(true);
                textSound.Play();

                yield return new WaitForSeconds(displayTime);
                texts[i].gameObject.SetActive(false);
            }
        }
    }
