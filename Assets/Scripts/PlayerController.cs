using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int chapter = 0;
    public bool firstTime = true;
    public int grenadeCount = 0;
    public CanvasGroup uiElement;
    public CanvasGroup uiElement2;
    public CanvasGroup uiElement3;
    public GameObject canvas;
    public GameObject canvas2;
    public GameObject canvas3;
    public int pushback = 0;
    public int trig = 0;
    public float pushSpeed = 1;
    public GameObject rain;
    public AudioSource music;
    public AudioSource buttonClick;
    public AudioSource c3p1;
    public AudioSource c3p2;

    // Start is called before the first frame update
    void Start()
    {
        music.Play();
        chapter = 1;

    }

    public void ButtonSound()
    {
        buttonClick.Play();
    }

    // Update is called once per frame
    void Update()
    {

        if (chapter == 2 && firstTime)
        {
            transform.position = new Vector3(29.6f, -0.5f, 0.5f);
            firstTime = false;
            canvas.SetActive(true);
            FadeOut();
        }

        if (chapter == 3 && firstTime)
        {
            float zNew = transform.position.z + -pushSpeed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, transform.position.y, zNew);
            if(zNew < -6  && trig == 0)
            {
                canvas2.SetActive(true);
                trig = 1;
                FadeIn2();
            }
            if (zNew < -13)
            {
                FadeOut2();
                transform.position = new Vector3(63.0f, 0.0f, -7f);
                firstTime = false;
                Invoke("C3P1", 2);
                Invoke("C3P2", 6);
            }
        }

        if (chapter == 4 && firstTime)
        {
            canvas3.SetActive(true);
            FadeIn3();
            firstTime = false;
            Invoke("Transition3", 5f);
           
        }

        if (chapter == 5 && firstTime)
        {
            transform.position = new Vector3(27.78f, 1.5f, -37.91f);

        }

        if (chapter == 6 && firstTime)
        {

            transform.position = new Vector3(0.5f, 1.5f, -72f);

        }
    }

    public void C3P1()
    {
        c3p1.Play();
    }

    public void C3P2()
    {
        c3p2.Play();
    }

    // Start is called before the first frame update
    public void FadeOut()
    {
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 0));
    }
    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float lerpTime = 5.0f)
    {

        float _timeStartedLerping = Time.time;
        float _timeSinceStarted = Time.time -_timeStartedLerping;
        float percentageComplete = _timeSinceStarted / lerpTime;

        while(true)
        {
            _timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = _timeSinceStarted / lerpTime;
            float currentValue = Mathf.Lerp(start, end, percentageComplete);
            cg.alpha = currentValue;
            if(percentageComplete >= 1) break;
            yield return new WaitForEndOfFrame();
        }

        canvas.SetActive(false);
    }

    public void PushBack()
    {
        chapter = 3;
        firstTime = true;
    }

    public void Transition2()
    {
        Invoke("PushBack", 7.0f);
    }

    public void FadeIn2()
    {
        StartCoroutine(FadeCanvasGroup2(uiElement2, uiElement2.alpha, 1));
    }

    public void FadeOut2()
    {
        StartCoroutine(FadeCanvasGroup2(uiElement2, uiElement2.alpha, 0));
    }
    public IEnumerator FadeCanvasGroup2(CanvasGroup cg, float start, float end, float lerpTime = 5.0f)
    {

        float _timeStartedLerping = Time.time;
        float _timeSinceStarted = Time.time - _timeStartedLerping;
        float percentageComplete = _timeSinceStarted / lerpTime;

        while (true)
        {
            _timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = _timeSinceStarted / lerpTime;
            float currentValue = Mathf.Lerp(start, end, percentageComplete);
            cg.alpha = currentValue;
            if (percentageComplete >= 1) break;
            yield return new WaitForEndOfFrame();
        }
    }

    public void FadeIn3()
    {
        StartCoroutine(FadeCanvasGroup3(uiElement3, uiElement3.alpha, 1));
    }

    public void FadeOut3()
    {
        StartCoroutine(FadeCanvasGroup3(uiElement3, uiElement3.alpha, 0));
    }
    public IEnumerator FadeCanvasGroup3(CanvasGroup cg, float start, float end, float lerpTime = 5.0f)
    {

        float _timeStartedLerping = Time.time;
        float _timeSinceStarted = Time.time - _timeStartedLerping;
        float percentageComplete = _timeSinceStarted / lerpTime;

        while (true)
        {
            _timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = _timeSinceStarted / lerpTime;
            float currentValue = Mathf.Lerp(start, end, percentageComplete);
            cg.alpha = currentValue;
            if (percentageComplete >= 1) break;
            yield return new WaitForEndOfFrame();
        }
    }
    public void Transition3()
    {
        transform.position = new Vector3(-2.34f, 1.5f, -37.74f);
        rain.SetActive(false);
        FadeOut3();
    }
}
