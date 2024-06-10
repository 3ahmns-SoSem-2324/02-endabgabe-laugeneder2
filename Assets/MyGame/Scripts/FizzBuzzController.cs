using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FizzBuzzController : MonoBehaviour
{
    public TextMeshProUGUI RandomNumberText, UserInputText, FeedbackText, ScoreText, DivisibleBy3Text, DivisibleBy5Text;
    public Image panel;
    public AudioClip rightSoundClip;
    public AudioClip wrongSoundClip;
    private AudioSource audioSource;
    private int randomNumber, score;
    private string userInput = "";
    private bool canInput = true;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        GenerateNewRandomNumber();
        UpdateUI();
    }

    private void GenerateRandomNumber()
    {
        randomNumber = Random.Range(1, 1000);
    }

    private void UpdateUI()
    {
        RandomNumberText.text = randomNumber.ToString();
        DivisibleBy3Text.text = (randomNumber % 3 == 0) ? "Teilbar durch 3" : "";
        DivisibleBy5Text.text = (randomNumber % 5 == 0) ? "Teilbar durch 5" : "";
    }

    private void UpdateUserInputText(string input)
    {
        userInput = input;
        UserInputText.text = userInput;
    }

    private void CheckUserInput()
    {
        if (userInput == "")
        {
            FeedbackText.text = "Bitte geben Sie eine Antwort ein.";
            return;
        }

        string correctAnswer = (randomNumber % 3 == 0 && randomNumber % 5 == 0) ? "FizzBuzz" :
                               (randomNumber % 3 == 0) ? "Fizz" :
                               (randomNumber % 5 == 0) ? "Buzz" : "Keine Zahl";

        if (userInput == correctAnswer)
        {
            FeedbackText.text = "Richtig!";
            score++;
            UpdateScoreText();
            StartCoroutine(ChangePanelColorAfterDelay(Color.green));
            PlaySound(rightSoundClip);
        }
        else
        {
            FeedbackText.text = "Falsch! Die richtige Antwort ist: " + correctAnswer;
            StartCoroutine(ChangePanelColorAfterDelay(Color.red));
            PlaySound(wrongSoundClip);
        }
    }

    private void PlaySound(AudioClip clip)
    {
        if (clip != null && audioSource != null)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
    }

    private IEnumerator ChangePanelColorAfterDelay(Color color)
    {
        yield return new WaitForSeconds(1f);
        panel.color = color;
    }

    private void UpdateScoreText()
    {
        ScoreText.text = "Punktzahl: " + score;
    }

    private void GenerateNewRandomNumber()
    {
        GenerateRandomNumber();
        UpdateUI();
        userInput = "";
        UserInputText.text = "";
        FeedbackText.text = "";
        canInput = true;
    }

    private void Update()
    {
        if (canInput)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                UpdateUserInputText("Fizz");
                CheckUserInput();
                canInput = false;
                StartCoroutine(GenerateNewNumberAfterDelay());
            }
            else if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.Mouse1))
            {
                UpdateUserInputText("Buzz");
                CheckUserInput();
                canInput = false;
                StartCoroutine(GenerateNewNumberAfterDelay());
            }
            else if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.H) || Input.GetKeyDown(KeyCode.W))
            {
                UpdateUserInputText("FizzBuzz");
                CheckUserInput();
                canInput = false;
                StartCoroutine(GenerateNewNumberAfterDelay());
            }
            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.I))
            {
                UpdateUserInputText("nicht teilbar");
                CheckUserInput();
                canInput = false;
                StartCoroutine(GenerateNewNumberAfterDelay());
            }
        }
    }

    private IEnumerator GenerateNewNumberAfterDelay()
    {
        yield return new WaitForSeconds(3f);
        GenerateNewRandomNumber();
        panel.color = Color.grey;
    }
}