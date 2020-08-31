'Ian Gunter
'RCET0265
'Spring 2020
'Say My Name
'https://github.com/IanGunter/SayMyName.git

'These parameters tell VB how it should read the code.
Option Explicit On
Option Strict On
Option Compare Text

Module SayMyName

    Sub Main()

        'Dim assigns the next work to whatever As is set as. 
        Dim Input As String
        Console.WriteLine("What Is your name")

        'Input = Console.ReadLine sets the feedback typed into the console as the input string.
        Input = Console.ReadLine

        'Group of questions presented to the user
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

        'My.Computer.Audio.Play.(My.Resources.dont_touch_me, AudioPlayMode.WaitToComplete) plays a sound file uploaded into code recourses. 
        'Code references can be accessedin the project solution tab under, My Project.
        If Input = "Shutup" Then My.Computer.Audio.Play(My.Resources.dont_touch_me, AudioPlayMode.WaitToComplete)
        If Input = "Stop" Then My.Computer.Audio.Play(My.Resources.dont_touch_me, AudioPlayMode.WaitToComplete)

        Console.WriteLine("Would You like to watch a video? Yes or No?")
        Input = Console.ReadLine()
        'If input allows for different scenerios to play depending on user feedback.
        If Input = "Yes" Then Process.Start("https://youtu.be/G9FGgwCQ22w?t=107")







    End Sub

End Module
