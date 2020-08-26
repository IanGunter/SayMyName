'Ian Gunter
'RCET0265
'Spring 2020
'Say My Name

Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()
        'Dim assigns the next work to whatever As is set as. 
        Dim Input As String
        Console.WriteLine("What Is your name")

        Input = Console.ReadLine
        Console.WriteLine("Great " & Input & "!" & " Great News!")
        Console.WriteLine("I just need to get some more information from you!")
        Console.WriteLine("Where do you live?")
        Console.ReadLine()

        Console.WriteLine("what do you like to eat?")
        Console.ReadLine()

        Console.WriteLine("GREAT! GREAT NEWS!! Lets move on shall we.")

        Console.WriteLine("Whats your favorite color?")
        Console.ReadLine()

        Console.WriteLine("Do you like cows or goats... milk?")
        Console.ReadLine()

        Console.WriteLine("Do you have brown hair? What is your Blood type?")
        Console.ReadLine()

        'If input allows for different scenerios to play depending on user feedback.
        Console.WriteLine("Are you allergic to Oats?!")
        Input = Console.ReadLine()
        If Input = "Shutup" Then Console.Beep(4000, 5000)
        If Input = "shutup" Then Console.Beep(4000, 5000)
        If Input = "Stop" Then Console.Beep(4000, 5000)
        If Input = "stop" Then Console.Beep(4000, 5000)

        Console.WriteLine("Would You like to watch a video? Yes or No?")
        Input = Console.ReadLine()
        'If input allows for different scenerios to play depending on user feedback.
        If Input = "Yes" Then Process.Start("https://youtu.be/G9FGgwCQ22w?t=107")
        If Input = "yes" Then Process.Start("https://youtu.be/G9FGgwCQ22w?t=107")
    End Sub

End Module
