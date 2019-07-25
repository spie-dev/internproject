This is a simple test project designed for you to show off your technical skills in C# .NET MVC. The setup for this test is pretty simple. SPIE has a section of our website that displays the profiles of various SPIE and SPIE-affiliated people. This code is the initial development of that profiles section. Unfortunately, it has some bugs and missing functionality.

# Your task
Fix the bugs and add as much new functionality as you can in the given amount of time, then add it in a private github repo for us to review. You are NOT expected to get all of this done, it is instead a wide array of functionality so you can show your full array of skills. *NOTE* you CAN use any and all web/book resources, this is a test of your programming skills as if you were on the job, not a school quiz.

If you DO get all listed bug fixes/functionality done, feel free to add other functionality you think makes sense, or, if you find other bugs not listed here, fix them as well. Make sure to call out these additions, though, so we can be sure we look at them!

The bug fixes should be *production level* fixes. So things to think about:
1. Will this work with more/less data than is provided?
2. Does it do enough try/catches to prevent the website from blowing up if something goes weird?
3. Do you need to add comments or refactor code so it's clear for future devs to maintain?

# How to get this project
Pull down a zip of this by clicking the "Clone or download" link on the upper right of this repo, and select "Download Zip". Unzip into your "My Documents" folder, and open the WebApplication.sln with visual studio. Use ctrl+shift+b to build the project, then click the "IIS Express" at the top to run the website.

*NOTE* If after you press "IIS Express", the site comes up with an error that says "Could not find a part of the path C:{your path to my documents}/webapplication/bin/roslyn/csc.exe", then in visual studio's toolbar, click "Build -> Clean Solution", then "Build->Build Solution", then try clicking "IIS Express" again, and that should fix the issue.

# Bug fixes
* On the home page, the search profiles text box doesn't line up with the magnifying glass. Change it so the bottom of the text box lines up with the magnifying glass image
* When clicking on a SPIE Profile Name link, it's supposed to send you to the profile information for that particular person. It is currently always displaying Jim Bob's profile. Fix it so it displays the correct profile when you click on it.
* An individual profile can be accessed by using the following URL format: /profiles/view/{ID} There are two errors that come up:
  * If you enter a non-number as the ID, it errors out (e.g. /profiles/view/asdf). Change it to simply redirect to the home page if a profile is not found
  * Depending on how you fix the SPIE Profile Name Link error, if you enter a non-existant profile ID, it may error out (e.g. /profiles/view/123). Make sure it does not
* The first time you run the site using IIS Express, you sometimes get the error "Could not find a part of the path C:{your path to my documents}/webapplication/bin/roslyn/csc.exe", which gets fixed by a clean and rebuild. Figure out how to fix it so it no longer does this.

# Functionality Adds
* Add the ability to use the search bar, and have it display a list of profiles that have a partial match with either first or last name
** *NOTE* this should NOT do the search logic in the view itself, this isn't display logic, so it shouldn't go in the display part of the website!
* Add the ability for someone to edit a profile and have it update
** Also can move this ability to edit behind a log in, so random users can't maliciously edit someone else's profile!
* Add the ability for a profile user to log into the website


# How to submit this
1. Create a new private repo in GitHub
2. Install the Github extension for visual studio (in visual studio, click tools->"extensions and updates" and search for "Github Extension for Visual Studio")
3. Connect to GitHub and the repo with Visual studio. Use the [extension's website](https://visualstudio.github.com/) to see screenshots of how to connect
4. Update your README.md file to specify what bug fixes and functionality adds you did, as well as any new instructions for set up
5. Push your modified code to your private repo
6. Send your SPIE contact an invite to the repo
