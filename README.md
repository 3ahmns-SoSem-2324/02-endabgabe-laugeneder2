FizzBuzzController - README
Einführung und Spielbeschreibung

FizzBuzz ist ein Lernspiel, das dazu dient, das Verständnis von Teilbarkeit und logischem Denken zu fördern. Das Spiel zeigt eine zufällige Zahl zwischen 1 und 1000 an und der Spieler muss entscheiden, ob die Zahl durch 3, 5, beide teilbar oder durch keine Zahl teilbar ist. Die möglichen Antworten sind:

    "Fizz" (wenn die Zahl durch 3 teilbar ist)
    "Buzz" (wenn die Zahl durch 5 teilbar ist)
    "FizzBuzz" (wenn die Zahl sowohl durch 3 als auch durch 5 teilbar ist)
    "nicht teilbar" (wenn die Zahl weder durch 3 noch durch 5 teilbar ist)

Das Ziel des Spiels ist es, so viele richtige Antworten wie möglich zu geben und dabei eine hohe Punktzahl zu erreichen.
Spielanleitung
Schritte zum Spielen:

    Start des Spiels:
        Das Spiel beginnt automatisch beim Starten der Anwendung.

    Anzeige der zufälligen Zahl:
        Eine zufällige Zahl zwischen 1 und 1000 wird angezeigt.

    Eingabe der Antwort:
        Der Spieler gibt seine Antwort ein, indem er eine der Tasten auf der Tastatur drückt:
            Linke Pfeiltaste für "Fizz"
            Rechte Pfeiltaste für "Buzz"
            Obere Pfeiltaste für "FizzBuzz"
            Untere Pfeiltaste für "nicht teilbar"

    Überprüfung der Antwort:
        Das Spiel überprüft die Eingabe des Spielers und gibt Feedback:
            Bei richtiger Antwort: Punktzahl wird erhöht und das Panel wechselt für kurze Zeit zu grün. Ein entsprechender Soundclip wird abgespielt.
            Bei falscher Antwort: Die korrekte Antwort wird angezeigt und das Panel wechselt für kurze Zeit zu rot. Ein entsprechender Soundclip wird abgespielt.

    Nächste Runde:
        Nach einer kurzen Verzögerung wird eine neue zufällige Zahl generiert und das Spiel setzt sich fort.
        

Code-Dokumentation
UML Diagramm

mermaid

classDiagram
    note "Attributes and Methods of FizzBuzzController"
    class FizzBuzzController {
        - int randomNumber
        - int score
        - string userInput
        - bool canInput
        - AudioClip rightSoundClip
        - AudioClip wrongSoundClip
        - AudioSource audioSource
        + void Start()
        + void GenerateRandomNumber()
        + void UpdateUI()
        + void UpdateUserInputText(string input)
        + void CheckUserInput()
        + void PlaySound(AudioClip clip)
        + IEnumerator ChangePanelColorAfterDelay(Color color)
        + void UpdateScoreText()
        + void GenerateNewRandomNumber()
        + void Update()
        + IEnumerator GenerateNewNumberAfterDelay()
    }


Anmerkungen zum Code

    Start(): Initialisiert das Spiel, indem es eine neue Zufallszahl generiert und die Benutzeroberfläche aktualisiert.
    
    GenerateRandomNumber(): Generiert eine zufällige Zahl zwischen 1 und 1000.
    
    UpdateUI(): Aktualisiert die Anzeige der Zufallszahl und gibt an, ob die Zahl durch 3 oder 5 teilbar ist.
    
    UpdateUserInputText(string input): Aktualisiert den Benutzereingabetext.
    
    CheckUserInput(): Überprüft die Eingabe des Benutzers und gibt entsprechendes Feedback.
    
    PlaySound(AudioClip clip): Spielt den angegebenen Audioclip ab.
    
    ChangePanelColorAfterDelay(Color color): Ändert die Farbe des Panels nach einer kurzen Verzögerung.
    
    UpdateScoreText(): Aktualisiert die Punktzahl-Anzeige.
    
    GenerateNewRandomNumber(): Generiert eine neue Zufallszahl und setzt das Spiel zurück.
    
    Update(): Überprüft die Benutzereingaben und führt die entsprechende Aktion aus.
    
    GenerateNewNumberAfterDelay(): Generiert nach einer kurzen Verzögerung eine neue Zufallszahl.
    

Szene zum Starten

Man muss sicherstellen, dass die Szene, die den FizzBuzzController enthält, als Startszene in den Build-Einstellungen von Unity ausgewählt ist.


Nutzung von Makey Makey

Um Makey Makey zu verwenden, muss man die Klemmen an den entsprechenden Flächen für die einzelnen Tasten anbringen:

            Linke Pfeiltaste für "Fizz"
            Rechte Pfeiltaste für "Buzz"
            Obere Pfeiltaste für "FizzBuzz"
            Untere Pfeiltaste für "nicht teilbar"

Mit diesen dieser Beschreibung sollte dass Makey Makey nun funktionieren.
