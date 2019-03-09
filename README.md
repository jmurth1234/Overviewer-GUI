Overviewer GUI
==============

![Screenshot](https://media.rymate.co.uk/file/lectical.png)

What is it?
-----------
The Overviewer GUI is a GUI wrapper for the Minecraft Overviewer written in C#. 
It allows you to simply specify a world directory and an output directory. It also 
allows you to specify a config file.

How do I get it?
----------------
At the bottom of this Readme there'll be a download link. Alternatively you could 
click the downloads link which is up at the top of the github page, next to "Tags."

How do I install it?
--------------------
1. Download the latest version of the Overviewer GUI [here](https://github.com/rymate1234/Overviewer-GUI/releases)
2. Extract the contents of the zip into it's own folder
3. Run the GUI - on first run the Overviewer will be downloaded.
4. That's it!

I got an error!
---------------
If its an error on the output of the Overviewer, go bug the overviewer developers at [their github page.](https://github.com/overviewer/Minecraft-Overviewer)
If its a .net error, then bug me on the forum post. :)

It doesn't work!
----------------
[Download the .NET framework 4.5 from Microsoft](https://www.microsoft.com/en-us/download/details.aspx?id=30653)

Download link?
--------------
[OverviewerGUI-1.3.1.zip][dl] (211 KB) -- 09 Feb 2017

[dl]: https://github.com/rymate1234/Overviewer-GUI/releases/download/1.3.1/Overviewer-1.3.1.zip

Changelog
---------

Version 1.3.1

- This fixes an issue with extracting the zip from the latest overviewer release

Version 1.3

-  Added the ability to download and update the Overviewer every time the GUI runs.
-  Progress is now parsed from a custom observer rather than a horrifying regex 
-  The GUI will now generate a config file rather than generate command line arguments
    - This means you can now easily migrate from simple to advanced mode by editing the
      generated config.generated.py file!
    - **Note**: don't touch the custom observer at the top of the file - this is required
      in order to provide progress to the GUI
-  Updated .NET version used to 4.5

Version 1.2

-  ini file to store last used paths!
-  A progress bar!
-  Looks more like a GUI!
-  Most bugs fixed!

Version 1.1

-  adds rendermode options to the simple render mode
-  adds error checking
-  adds a button to upload log file to pastebin

Version 1

-  initial release
