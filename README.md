# TextToSpeechConverter
Simple application that uses Windows Forms

 ## Table of contents
* [About app](#about-app)
* [Languages and tools](#languages-and-tools)
* [What I learned during this project](#what-i-learned-during-this-project)


## About app
Text to speech converter allows its user to input text into a rich text box, which is later read aloud. Firstly it creates a new object of SpeechSynthesizer class and checks events for each button click. <br>
After creating the object it checks if RichTextBox is empty and if not it speaks asynchronously the text within that text box <br>
Available events allow for: <br>
- pausing current speechSynthesizer object by changing its state
- resuming the object if its been paused (based on its current state)
- stopping and disposing of current object <br>

How the application looks <br>
![DuringSpeaking](https://user-images.githubusercontent.com/103940999/167705335-fee9ada4-0487-4474-88d3-87200fdf89d4.png)

## Languages and tools
<img align="left" alt="Visual Studio" width="36px" src="https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Visual_Studio_Icon_2019.svg/2060px-Visual_Studio_Icon_2019.svg.png" />
<img align="left" alt="CSharp" width="36px" src="https://cdn.worldvectorlogo.com/logos/c--4.svg" style="padding-right:10px;" />
<img align="left" alt="Dot NET" width="36px" src="https://raw.githubusercontent.com/dotnet/brand/6afb87c4c601815acdc5d313ba15bded910ade36/logo/dotnet-logo.svg" style="padding-right:10px;" />
<img align="left" alt="GitHub" width="36px" src="https://cdn.worldvectorlogo.com/logos/github-icon-1.svg" />
 
<br>

## What I learned during this project
- usage of Windows Forms
- manipulation and usage of states
- finding documentation usefull for certain project
