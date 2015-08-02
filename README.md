# Expresso
https://www.tech-synergy.com/transcription.php
They offer similar services to our app, but I THINK they do the transcription manually.

<!DOCTYPE html>
<!--This application demonstrates a complete custom speech recognition UI-->
<html>
<head>
    <meta charset="utf-8" />
    <title>SpeechCustomUI_JS</title>

    <!-- WinJS references -->
    <link href="//Microsoft.WinJS.2.0/css/ui-dark.css" rel="stylesheet" />
    <script src="//Microsoft.WinJS.2.0/js/base.js"></script>
    <script src="//Microsoft.WinJS.2.0/js/ui.js"></script>

    <!-- SpeechCustomUI_JS references -->
    <link href="/css/default.css" rel="stylesheet" />
    <script src="/js/default.js"></script>

    <link href="Bing.Speech/css/voiceuicontrol.css" rel="stylesheet" />
    <script src="Bing.Speech/js/voiceuicontrol.js"></script>

    <style>
        body {
            text-align: center;
        }
        .panel {
            display: none;
        }
        .instructionText {
            font-size: x-large;
        }
        .explanatory {
            font-size: large;
        }
        .spokenText {
            font-size: large;
            font-style: italic;
        }
        .bigText {
            font-size: xx-large;
        }
        .biggestText {
            font-size: xx-large;
            font-weight: bold;
        }
        .buttonDiv {
            width: 2em;
            margin: 0 auto;
            font-size: xx-large;
            width: 2em;
        }
        .subTitle {
            font-size: medium;
        }
        .listBox {
            margin: 0 auto;
            display: block;
        }

    </style>
</head>
<body onload="Body_OnLoad();" >

    <!--Panel to show at application start and after cancel.-->  
    <div id="StartPanel" class="panel">
        <p class="instructionText">
            Click the microphone and get ready to say something
        </p>
        <div>
            <!--Starts speech recognition, but may not be ready immediately. -->
            <div id="SpeakButton" onclick="SpeakButton_Click();" class="buttonDiv">
                &#xe1d6;
            </div> 
        </div>
    </div>

    <!--Panel to show while initializing the SpeechRecognizer.
        This panel may not be seen if initialization happens quickly.-->
    <div id="InitPanel" class="panel">
        <p class="instructionText">
            Ready, set...
        </p>
    </div>
    
    <!--Panel to show while listening for user speech.-->    
        <div id="ListenPanel" class="panel">
        <p class="biggestText">
            Speak!
        </p>
        <!--Shows at different opacity levels depending on speech volume.--> 
        <div id="VolumeMeter" class="bigText" style="opacity:0">
            Volume
        </div>
    
        <!--Click when done speaking, or wait for app to recognize end of 
            speech.-->
        <div>
            <div id="StopButton" onclick="StopButton_Click();" 
                 class="buttonDiv">
                &#xe15b;
            </div>
            <div class="subTitle">
                Stop
            </div>
        </div>
    </div>

    <!--Panel to show while interpreting speech input.--> 
    <div id="ThinkPanel" class="panel">
        <p class="instructionText">
            Thinking...
        </p>
    </div>

    <!--Panel to show when speech recognition complete.
        May also be shown in case of exceptions.-->
    <div id="CompletePanel" class="panel">
        <p class="instructionText">
            Done.
        </p>
        <br />
        <!--Displays confidence level of final result.-->
        <div id="ConfidenceText" class="explanatory"></div>
        <!--Displays final result text.-->
        <div id="ResultText" class="spokenText"></div>
        <br />
        <!--Displays alternate results. Copies selected text to
        FinalResult.-->
        <div id="AlternatesArea">
            <div class="explanatory">But you might have said:</div>
            <div>
                <select id="AlternatesListBox" class="spokenText listBox" 
                        onchange="AlternatesListBox_SelectionChanged();">
                </select>
            </div>
        </div id="AlternatesArea">
    </div>

    <!--Shows possible text before deciding on final interpretation.
        May flash too quickly to see for easy phrases.-->
    <div id="IntResults" class="panel">
        <div class="instructionText">You might have said...</div>
        <div id="IntermediateResults" class="spokenText"></div>
    </div>

    <!--Cancel button, to be shown in all states except for application
        start -->
    <div style="position: absolute; bottom: 0; width: 100%">
        <div id="CancelButton" onclick="CancelButton_Click();" 
             class="buttonDiv">
            &#xe10a;
            <div class="subTitle">
                Cancel
            </div>
        </div>
    </div>

</body>
</html>
