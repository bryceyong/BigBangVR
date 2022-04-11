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
    public GameObject canvas;
    public GameObject canvas2;
    public int pushback = 0;
    public float pushSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        chapter = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (chapter == 2 && firstTime)
        {
            transform.position = new Vector3(30.0f, 0.0f, 0f);
            firstTime = false;
            canvas.SetActive(true);
            FadeOut();
        }

        if (chapter == 3 && firstTime)
        {
            float zNew = transform.position.z + -pushSpeed * Time.deltaTime;
            transform.position = new Vector3(30, 0.0f, zNew);
            if (zNew < -13)
            {
                FadeIn2();
                FadeOut2();
                transform.position = new Vector3(63.0f, 0.0f, -7f);
                firstTime = false;
                canvas2.SetActive(true);
                
                //FadeOut2();
            }

        }

        if (chapter == 4)
        {
            transform.position = new Vector3(0.0f, 6f, -35f);
        }



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
        StartCoroutine(FadeCanvasGroup2(uiElement2, uiElement2.alpha, 0));
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

        canvas2.SetActive(false);
    }
}
