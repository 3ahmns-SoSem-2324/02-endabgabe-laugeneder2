# 02-endabgabe-laugeneder2
Code-Dokumentation
UML-Diagramm

UML-Diagramm:

scss

+----------------------+
|   FizzBuzzController |
+----------------------+
| - randomNumber       |
| - score              |
| - userInput          |
| - canInput           |
| - rightSoundClip     |
| - wrongSoundClip     |
| - audioSource        |
+----------------------+
| + Start()            |
| + GenerateRandomNumber() |
| + UpdateUI()         |
| + UpdateUserInputText(input: string) |
| + CheckUserInput()   |
| + PlaySound(clip: AudioClip) |
| + ChangePanelColorAfterDelay(color: Color): IEnumerator |
| + UpdateScoreText()  |
| + GenerateNewRandomNumber() |
| + Update()           |
| + GenerateNewNumberAfterDelay(): IEnumerator |
+----------------------+

Szenen-Setup

Um das Spiel richtig zu starten muss man sicherstellen dass die FizzBuzzScene geöffnet ist und die folgenden Objekte und Komponenten enthalten sind:

    TextMeshProUGUI-Objekte:
        RandomNumberText
        UserInputText
        FeedbackText
        ScoreText
        DivisibleBy3Text
        DivisibleBy5Text
    Image-Objekt:
        panel
    AudioClips:
        rightSoundClip
        wrongSoundClip
    AudioSource-Komponente:
        Stellen Sie sicher, dass das GameObject mit dem FizzBuzzController-Skript eine AudioSource-Komponente hat.
